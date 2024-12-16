namespace Tyuiu.BrezinaYS.Sprint7.Project.V15
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_BYS = new Label();
            buttonOK_BYS = new Button();
            SuspendLayout();
            // 
            // label_BYS
            // 
            label_BYS.AutoSize = true;
            label_BYS.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_BYS.Location = new Point(210, 31);
            label_BYS.Name = "label_BYS";
            label_BYS.Size = new Size(324, 120);
            label_BYS.TabIndex = 0;
            label_BYS.Text = "Разработчик: Брезина Ю.С.\r\nГруппа: ИИПб-24-2\r\n\r\nОбзор технического задания \r\nПредметная область проекта: \r\nдоговорная деятельность организации";
            label_BYS.Click += label_BYS_Click;
            // 
            // buttonOK_BYS
            // 
            buttonOK_BYS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOK_BYS.Location = new Point(386, 224);
            buttonOK_BYS.Name = "buttonOK_BYS";
            buttonOK_BYS.Size = new Size(119, 46);
            buttonOK_BYS.TabIndex = 1;
            buttonOK_BYS.Text = "OK";
            buttonOK_BYS.UseVisualStyleBackColor = true;
            buttonOK_BYS.Click += buttonOK_BYS_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 300);
            Controls.Add(buttonOK_BYS);
            Controls.Add(label_BYS);
            Name = "FormAbout";
            Text = "О программе ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_BYS;
        private Button buttonOK_BYS;
    }
}