namespace Tyuiu.BrezinaYS.Sprint7.Project.V15
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonHelp_BYS = new Button();
            buttonGuide_BYS = new Button();
            panelButton_BYS = new Panel();
            buttonSave_BYS = new Button();
            buttonSearch_BYS = new Button();
            buttonOpen_BYS = new Button();
            openFileDialog1 = new OpenFileDialog();
            panelExel_BYS = new Panel();
            groupBoxEx_BYS = new GroupBox();
            dataGridViewBase_BYS = new DataGridView();
            panelChart_BYS = new Panel();
            groupBoxStatistics_BYS = new GroupBox();
            textBoxMeanStep_BYS = new TextBox();
            textBoxMean_BYS = new TextBox();
            textBoxMaxStep_BYS = new TextBox();
            textBox1 = new TextBox();
            textBoxMinStep_BYS = new TextBox();
            textBoxMin_BYS = new TextBox();
            chartSalary_BYS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            toolTipButton = new ToolTip(components);
            saveFileDialog1 = new SaveFileDialog();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            panelButton_BYS.SuspendLayout();
            panelExel_BYS.SuspendLayout();
            groupBoxEx_BYS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_BYS).BeginInit();
            panelChart_BYS.SuspendLayout();
            groupBoxStatistics_BYS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartSalary_BYS).BeginInit();
            SuspendLayout();
            // 
            // buttonHelp_BYS
            // 
            buttonHelp_BYS.BackColor = SystemColors.ButtonHighlight;
            buttonHelp_BYS.Image = (Image)resources.GetObject("buttonHelp_BYS.Image");
            buttonHelp_BYS.Location = new Point(1031, 12);
            buttonHelp_BYS.Name = "buttonHelp_BYS";
            buttonHelp_BYS.Size = new Size(87, 50);
            buttonHelp_BYS.TabIndex = 0;
            toolTipButton.SetToolTip(buttonHelp_BYS, "Данные о разработчике ");
            buttonHelp_BYS.UseVisualStyleBackColor = false;
            buttonHelp_BYS.Click += buttonHelp_BYS_Click;
            // 
            // buttonGuide_BYS
            // 
            buttonGuide_BYS.BackColor = SystemColors.ButtonHighlight;
            buttonGuide_BYS.Image = (Image)resources.GetObject("buttonGuide_BYS.Image");
            buttonGuide_BYS.Location = new Point(923, 12);
            buttonGuide_BYS.Name = "buttonGuide_BYS";
            buttonGuide_BYS.Size = new Size(95, 50);
            buttonGuide_BYS.TabIndex = 1;
            toolTipButton.SetToolTip(buttonGuide_BYS, "Руководство по использованию");
            buttonGuide_BYS.UseVisualStyleBackColor = false;
            buttonGuide_BYS.Click += buttonGuide_BYS_Click;
            // 
            // panelButton_BYS
            // 
            panelButton_BYS.Controls.Add(buttonSave_BYS);
            panelButton_BYS.Controls.Add(buttonSearch_BYS);
            panelButton_BYS.Controls.Add(buttonOpen_BYS);
            panelButton_BYS.Controls.Add(buttonHelp_BYS);
            panelButton_BYS.Controls.Add(buttonGuide_BYS);
            panelButton_BYS.Dock = DockStyle.Top;
            panelButton_BYS.Location = new Point(0, 0);
            panelButton_BYS.Name = "panelButton_BYS";
            panelButton_BYS.Size = new Size(1130, 79);
            panelButton_BYS.TabIndex = 3;
            // 
            // buttonSave_BYS
            // 
            buttonSave_BYS.BackColor = SystemColors.ButtonHighlight;
            buttonSave_BYS.Enabled = false;
            buttonSave_BYS.Image = (Image)resources.GetObject("buttonSave_BYS.Image");
            buttonSave_BYS.Location = new Point(273, 11);
            buttonSave_BYS.Name = "buttonSave_BYS";
            buttonSave_BYS.Size = new Size(94, 51);
            buttonSave_BYS.TabIndex = 8;
            toolTipButton.SetToolTip(buttonSave_BYS, "Сохранить обработанные данные в файл в формате CSV");
            buttonSave_BYS.UseVisualStyleBackColor = false;
            buttonSave_BYS.Click += buttonSave_BYS_Click;
            // 
            // buttonSearch_BYS
            // 
            buttonSearch_BYS.BackColor = SystemColors.ButtonHighlight;
            buttonSearch_BYS.Enabled = false;
            buttonSearch_BYS.Image = (Image)resources.GetObject("buttonSearch_BYS.Image");
            buttonSearch_BYS.Location = new Point(144, 11);
            buttonSearch_BYS.Name = "buttonSearch_BYS";
            buttonSearch_BYS.Size = new Size(109, 50);
            buttonSearch_BYS.TabIndex = 7;
            toolTipButton.SetToolTip(buttonSearch_BYS, "Поиск данных сотрудника по личному номеру");
            buttonSearch_BYS.UseVisualStyleBackColor = false;
            buttonSearch_BYS.Click += buttonSearch_BYS_Click;
            // 
            // buttonOpen_BYS
            // 
            buttonOpen_BYS.BackColor = SystemColors.ButtonHighlight;
            buttonOpen_BYS.Image = (Image)resources.GetObject("buttonOpen_BYS.Image");
            buttonOpen_BYS.Location = new Point(12, 12);
            buttonOpen_BYS.Name = "buttonOpen_BYS";
            buttonOpen_BYS.Size = new Size(113, 50);
            buttonOpen_BYS.TabIndex = 4;
            toolTipButton.SetToolTip(buttonOpen_BYS, "Открыть файл для обработки данных в формате CSV");
            buttonOpen_BYS.UseVisualStyleBackColor = false;
            buttonOpen_BYS.Click += buttonOpen_BYS_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelExel_BYS
            // 
            panelExel_BYS.Controls.Add(groupBoxEx_BYS);
            panelExel_BYS.Dock = DockStyle.Left;
            panelExel_BYS.Location = new Point(0, 79);
            panelExel_BYS.Name = "panelExel_BYS";
            panelExel_BYS.Size = new Size(673, 566);
            panelExel_BYS.TabIndex = 4;
            // 
            // groupBoxEx_BYS
            // 
            groupBoxEx_BYS.Controls.Add(dataGridViewBase_BYS);
            groupBoxEx_BYS.Dock = DockStyle.Fill;
            groupBoxEx_BYS.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxEx_BYS.Location = new Point(0, 0);
            groupBoxEx_BYS.Name = "groupBoxEx_BYS";
            groupBoxEx_BYS.Size = new Size(673, 566);
            groupBoxEx_BYS.TabIndex = 0;
            groupBoxEx_BYS.TabStop = false;
            groupBoxEx_BYS.Text = "База сотрудников ";
            // 
            // dataGridViewBase_BYS
            // 
            dataGridViewBase_BYS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBase_BYS.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridViewBase_BYS.Dock = DockStyle.Fill;
            dataGridViewBase_BYS.Location = new Point(3, 25);
            dataGridViewBase_BYS.Name = "dataGridViewBase_BYS";
            dataGridViewBase_BYS.RowHeadersVisible = false;
            dataGridViewBase_BYS.RowHeadersWidth = 51;
            dataGridViewBase_BYS.Size = new Size(667, 538);
            dataGridViewBase_BYS.TabIndex = 0;
            // 
            // panelChart_BYS
            // 
            panelChart_BYS.Controls.Add(groupBoxStatistics_BYS);
            panelChart_BYS.Controls.Add(chartSalary_BYS);
            panelChart_BYS.Dock = DockStyle.Right;
            panelChart_BYS.Location = new Point(673, 79);
            panelChart_BYS.Name = "panelChart_BYS";
            panelChart_BYS.Size = new Size(457, 566);
            panelChart_BYS.TabIndex = 5;
            // 
            // groupBoxStatistics_BYS
            // 
            groupBoxStatistics_BYS.Controls.Add(textBoxMeanStep_BYS);
            groupBoxStatistics_BYS.Controls.Add(textBoxMean_BYS);
            groupBoxStatistics_BYS.Controls.Add(textBoxMaxStep_BYS);
            groupBoxStatistics_BYS.Controls.Add(textBox1);
            groupBoxStatistics_BYS.Controls.Add(textBoxMinStep_BYS);
            groupBoxStatistics_BYS.Controls.Add(textBoxMin_BYS);
            groupBoxStatistics_BYS.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxStatistics_BYS.Location = new Point(6, 408);
            groupBoxStatistics_BYS.Name = "groupBoxStatistics_BYS";
            groupBoxStatistics_BYS.Size = new Size(448, 155);
            groupBoxStatistics_BYS.TabIndex = 1;
            groupBoxStatistics_BYS.TabStop = false;
            groupBoxStatistics_BYS.Text = "Статистика ";
            // 
            // textBoxMeanStep_BYS
            // 
            textBoxMeanStep_BYS.Location = new Point(34, 115);
            textBoxMeanStep_BYS.Name = "textBoxMeanStep_BYS";
            textBoxMeanStep_BYS.ReadOnly = true;
            textBoxMeanStep_BYS.Size = new Size(156, 29);
            textBoxMeanStep_BYS.TabIndex = 5;
            // 
            // textBoxMean_BYS
            // 
            textBoxMean_BYS.BackColor = SystemColors.Control;
            textBoxMean_BYS.BorderStyle = BorderStyle.None;
            textBoxMean_BYS.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxMean_BYS.Location = new Point(34, 89);
            textBoxMean_BYS.Name = "textBoxMean_BYS";
            textBoxMean_BYS.Size = new Size(234, 20);
            textBoxMean_BYS.TabIndex = 4;
            textBoxMean_BYS.Text = "Средний оклад сотрудника ";
            // 
            // textBoxMaxStep_BYS
            // 
            textBoxMaxStep_BYS.Location = new Point(244, 54);
            textBoxMaxStep_BYS.Name = "textBoxMaxStep_BYS";
            textBoxMaxStep_BYS.ReadOnly = true;
            textBoxMaxStep_BYS.Size = new Size(125, 29);
            textBoxMaxStep_BYS.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(244, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(91, 20);
            textBox1.TabIndex = 2;
            textBox1.Text = "MAX оклад";
            // 
            // textBoxMinStep_BYS
            // 
            textBoxMinStep_BYS.Location = new Point(34, 54);
            textBoxMinStep_BYS.Name = "textBoxMinStep_BYS";
            textBoxMinStep_BYS.ReadOnly = true;
            textBoxMinStep_BYS.Size = new Size(125, 29);
            textBoxMinStep_BYS.TabIndex = 1;
            // 
            // textBoxMin_BYS
            // 
            textBoxMin_BYS.BackColor = SystemColors.Control;
            textBoxMin_BYS.BorderStyle = BorderStyle.None;
            textBoxMin_BYS.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxMin_BYS.Location = new Point(34, 28);
            textBoxMin_BYS.Name = "textBoxMin_BYS";
            textBoxMin_BYS.Size = new Size(92, 20);
            textBoxMin_BYS.TabIndex = 0;
            textBoxMin_BYS.Text = "MIN оклад";
            // 
            // chartSalary_BYS
            // 
            chartArea1.Name = "ChartArea1";
            chartSalary_BYS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartSalary_BYS.Legends.Add(legend1);
            chartSalary_BYS.Location = new Point(3, 0);
            chartSalary_BYS.Name = "chartSalary_BYS";
            chartSalary_BYS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartSalary_BYS.Series.Add(series1);
            chartSalary_BYS.Size = new Size(457, 402);
            chartSalary_BYS.TabIndex = 0;
            chartSalary_BYS.Text = "chart1";
            chartSalary_BYS.Click += chartSalary_BYS_Click;
            // 
            // toolTipButton
            // 
            toolTipButton.ForeColor = SystemColors.Highlight;
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // Column1
            // 
            Column1.HeaderText = "Личный номер";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "ФИО";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Адрес";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Номер";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Должность";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Оклад";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Год ";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Срок";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 645);
            Controls.Add(panelChart_BYS);
            Controls.Add(panelExel_BYS);
            Controls.Add(panelButton_BYS);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Договорная деятельность организации";
            panelButton_BYS.ResumeLayout(false);
            panelExel_BYS.ResumeLayout(false);
            groupBoxEx_BYS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_BYS).EndInit();
            panelChart_BYS.ResumeLayout(false);
            groupBoxStatistics_BYS.ResumeLayout(false);
            groupBoxStatistics_BYS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartSalary_BYS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp_BYS;
        private Button buttonGuide_BYS;
        private Panel panelButton_BYS;
        private Button buttonOpen_BYS;
        private OpenFileDialog openFileDialog1;
        private Panel panelExel_BYS;
        private GroupBox groupBoxEx_BYS;
        private DataGridView dataGridViewBase_BYS;
        private Button buttonSearch_BYS;
        private Panel panelChart_BYS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalary_BYS;
        private Button buttonSave_BYS;
        private ToolTip toolTipButton;
        private GroupBox groupBoxStatistics_BYS;
        private TextBox textBoxMean_BYS;
        private TextBox textBoxMaxStep_BYS;
        private TextBox textBox1;
        private TextBox textBoxMinStep_BYS;
        private TextBox textBoxMin_BYS;
        private TextBox textBoxMeanStep_BYS;
        private SaveFileDialog saveFileDialog1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}
