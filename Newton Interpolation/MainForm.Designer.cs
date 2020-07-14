namespace Newton_Interpolation
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьПолиномToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посчитатьКонкретноеЗначениеПолиномаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чтоТакоеПолиномМетодомНьютонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какПравильноОформитьИсходныйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьФайлToolStripMenuItem,
            this.построитьПолиномToolStripMenuItem,
            this.посчитатьКонкретноеЗначениеПолиномаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // выбратьФайлToolStripMenuItem
            // 
            this.выбратьФайлToolStripMenuItem.Name = "выбратьФайлToolStripMenuItem";
            this.выбратьФайлToolStripMenuItem.Size = new System.Drawing.Size(355, 24);
            this.выбратьФайлToolStripMenuItem.Text = "выбрать файл";
            this.выбратьФайлToolStripMenuItem.Click += new System.EventHandler(this.выбратьФайлToolStripMenuItem_Click);
            // 
            // построитьПолиномToolStripMenuItem
            // 
            this.построитьПолиномToolStripMenuItem.Name = "построитьПолиномToolStripMenuItem";
            this.построитьПолиномToolStripMenuItem.Size = new System.Drawing.Size(355, 24);
            this.построитьПолиномToolStripMenuItem.Text = "построить полином";
            this.построитьПолиномToolStripMenuItem.Click += new System.EventHandler(this.построитьПолиномToolStripMenuItem_Click);
            // 
            // посчитатьКонкретноеЗначениеПолиномаToolStripMenuItem
            // 
            this.посчитатьКонкретноеЗначениеПолиномаToolStripMenuItem.Name = "посчитатьКонкретноеЗначениеПолиномаToolStripMenuItem";
            this.посчитатьКонкретноеЗначениеПолиномаToolStripMenuItem.Size = new System.Drawing.Size(355, 24);
            this.посчитатьКонкретноеЗначениеПолиномаToolStripMenuItem.Text = "посчитать конкретное значение полинома";
            this.посчитатьКонкретноеЗначениеПолиномаToolStripMenuItem.Click += new System.EventHandler(this.посчитатьКонкретноеЗначениеПолиномаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(355, 24);
            this.выходToolStripMenuItem.Text = "выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.чтоТакоеПолиномМетодомНьютонаToolStripMenuItem,
            this.какПравильноОформитьИсходныйФайлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.справкаToolStripMenuItem.Text = "справка";
            // 
            // чтоТакоеПолиномМетодомНьютонаToolStripMenuItem
            // 
            this.чтоТакоеПолиномМетодомНьютонаToolStripMenuItem.Name = "чтоТакоеПолиномМетодомНьютонаToolStripMenuItem";
            this.чтоТакоеПолиномМетодомНьютонаToolStripMenuItem.Size = new System.Drawing.Size(353, 24);
            this.чтоТакоеПолиномМетодомНьютонаToolStripMenuItem.Text = "что такое полином методом Ньютона?";
            this.чтоТакоеПолиномМетодомНьютонаToolStripMenuItem.Click += new System.EventHandler(this.чтоТакоеПолиномМетодомНьютонаToolStripMenuItem_Click);
            // 
            // какПравильноОформитьИсходныйФайлToolStripMenuItem
            // 
            this.какПравильноОформитьИсходныйФайлToolStripMenuItem.Name = "какПравильноОформитьИсходныйФайлToolStripMenuItem";
            this.какПравильноОформитьИсходныйФайлToolStripMenuItem.Size = new System.Drawing.Size(353, 24);
            this.какПравильноОформитьИсходныйФайлToolStripMenuItem.Text = "Как правильно оформить исходный файл?";
            this.какПравильноОформитьИсходныйФайлToolStripMenuItem.Click += new System.EventHandler(this.какПравильноОформитьИсходныйФайлToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(353, 24);
            this.оПрограммеToolStripMenuItem.Text = "о программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 57);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1013, 554);
            this.zedGraphControl1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "степень полинома Ньютона от N точек равна N-1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Интерполяция методом Ньютона";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посчитатьКонкретноеЗначениеПолиномаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чтоТакоеПолиномМетодомНьютонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построитьПолиномToolStripMenuItem;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem какПравильноОформитьИсходныйФайлToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

