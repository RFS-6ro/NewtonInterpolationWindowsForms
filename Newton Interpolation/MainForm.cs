using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using ZedGraph;
using System.Threading;
using System.IO;
using System.IO.Pipes;
using System.Diagnostics;

namespace Newton_Interpolation
{
    public partial class MainForm : Form
    {
        public AutoResetEvent waitRead = new AutoResetEvent(false);
        public AutoResetEvent waitSort = new AutoResetEvent(false);
        public AutoResetEvent waitBuffer = new AutoResetEvent(false);
        public AutoResetEvent waitInterpolate = new AutoResetEvent(false);

        private static Semaphore _pool;
        private static Mutex mut = new Mutex();

        public Point[] p = { };
        public int ThreadCount = 0;

        public double[] buff;
        private static int defaultFrequency = 100;
        
        public double[] points2_x = { };
        public double[] points2_y = { };

        private static string fileName = "input.txt";
        
        public void PolyBuffer()
        {
            waitSort.WaitOne();
            mut.WaitOne();
            Buffer buffer = new Buffer();
            //sort.buff += buffer.StartBuffer;
            buff = buffer.DivDifTable(p, p.Length);
            waitBuffer.Set();
            mut.ReleaseMutex();
        }

        public void SortFile()
        {
            waitRead.WaitOne();
            mut.WaitOne();
            Sort sort = new Sort();
            p = sort.HeapSort(p, p.Length);
            MessageBox.Show("Данные отсортированы", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            waitSort.Set();
            mut.ReleaseMutex();
            Thread buffer = new Thread(new ThreadStart(PolyBuffer));
            buffer.Start();
        }

        public void ReadFromFile()
        {
            mut.WaitOne();

            WorkWithFile workWithFile = new WorkWithFile();
            p = workWithFile.ReadFromFile(fileName);
            MessageBox.Show("Файл считан", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (p.Length == 0)
                return;
            построитьПолиномToolStripMenuItem.Visible = true;

            waitRead.Set();
            mut.ReleaseMutex();
            Thread sortFile = new Thread(SortFile);
            sortFile.Start();
        }

        public MainForm()
        {
            InitializeComponent();
            посчитатьКонкретноеЗначениеПолиномаToolStripMenuItem.Visible = false;
            построитьПолиномToolStripMenuItem.Visible = false;
            zedGraphControl1.GraphPane.Title.Text = "Полином Ньютона";
        }

        private void выбратьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            fileName = openFileDialog1.FileName;
            ReadFromFile();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Worker(object num)
        {
            int count = (int)num;
            _pool.WaitOne();
            Interpolator interpolator = new Interpolator();
           // buffer.CountPoly += interpolator.StartInterpolate;

            for (int i = count; i < count + 100; ++i)
            {
                points2_y[i] = interpolator.computeNewtonPoly(p, p.Length, points2_x[i], buff);
            }
            _pool.Release();
            --ThreadCount;
        }

        private void DotCounter()
        {
            mut.WaitOne();
            points2_x = new double[defaultFrequency];
            points2_y = new double[defaultFrequency];
            _pool = new Semaphore(0, 3);
            //ffffffffffffff

            for (int i = 0; i < defaultFrequency; ++i)
            {
                points2_x[i] = p[0].x + ((p[p.Length - 1].x - p[0].x) / (defaultFrequency - 1)) * i;
            }

            for (int i = 0; i < defaultFrequency; i += 100)
            {
                Thread t = new Thread(new ParameterizedThreadStart(Worker));
                
                t.Start(i);
                ++ThreadCount;      
            }

            Thread.Sleep(500);

            _pool.Release(3);

            while (ThreadCount != 0)
                Thread.Sleep(100);

            waitInterpolate.Set();
            mut.ReleaseMutex();
            //  StartDraw();
        }

        /*Функция,которая добавляет точки на график и рисует график функции,принимающая два массива x,y типа double*/
        private void DrawGraph()
        {
            waitBuffer.WaitOne();
            
            mut.WaitOne();
            int N = p.Length;
            if (N == 0)
            {
                return;
            }

            посчитатьКонкретноеЗначениеПолиномаToolStripMenuItem.Visible = true;

            /* Получим панель для рисования*/
            GraphPane pane = zedGraphControl1.GraphPane;
            /*Предварительно очищаем панель*/
            pane.CurveList.Clear();
            /*Создадим список точек*/
            PointPairList pointList1 = new PointPairList();
            /*Заполняем список точек*/

            for (int i = 0; i < N; ++i)
            {
                pointList1.Add(p[i].x, p[i].y);
            }

            while ((p[N - 1].x - p[0].x) / defaultFrequency > 0.1)
            {
                defaultFrequency *= 10;
            }

            string myString = (N - 1).ToString();
            string s1 = "Вычисляем полином ";
            string s2 = " степени";
            s1 += myString + s2;
            MessageBox.Show(s1, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LineItem myCurve1 = pane.AddCurve("Исходный график", pointList1, Color.Red, SymbolType.Diamond);
            mut.ReleaseMutex();

            DotCounter();

            mut.WaitOne();
            waitInterpolate.WaitOne();

            LineItem myCurve2 = pane.AddCurve("Полином Ньютона", points2_x, points2_y, Color.Purple, SymbolType.None);

            /* По оси Y установим автоматический подбор масштаба*/
            pane.YAxis.Scale.MinAuto = true;
            pane.YAxis.Scale.MaxAuto = true;
            /*Установим значение параметра IsBoundedRanges как true.
              Это означает, что при автоматическом подборе масштаба 
              нужно учитывать только видимый интервал графика*/
            pane.IsBoundedRanges = true;
            /*Обновляем данные об осях*/
            pane.AxisChange();
            /*Обновляем график*/
            zedGraphControl1.Invalidate();
        }

        private void построитьПолиномToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (p.Length == 0)
            {
                MessageBox.Show("Отсутствует файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DrawGraph();
        }

        private void посчитатьКонкретноеЗначениеПолиномаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread show2 = new Thread(frm2);
            show2.Start();
        }

        private void frm2()
        {
            CountForm form2 = new CountForm
            {
                buff = buff,
                p = p
            };
            form2.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        private void чтоТакоеПолиномМетодомНьютонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread show3 = new Thread(frm3);
            show3.Start();
        }

        private void frm3()
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void какПравильноОформитьИсходныйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread show4 = new Thread(frm4);
            show4.Start();
        }

        private void frm4()
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
