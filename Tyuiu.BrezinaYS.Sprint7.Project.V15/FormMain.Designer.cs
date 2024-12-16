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
            buttonHelp_BYS = new Button();
            buttonGuide_BYS = new Button();
            buttonAdd_BYS = new Button();
            SuspendLayout();
            // 
            // buttonHelp_BYS
            // 
            buttonHelp_BYS.Location = new Point(579, 83);
            buttonHelp_BYS.Name = "buttonHelp_BYS";
            buttonHelp_BYS.Size = new Size(153, 68);
            buttonHelp_BYS.TabIndex = 0;
            buttonHelp_BYS.Text = "О программе ";
            buttonHelp_BYS.UseVisualStyleBackColor = true;
            buttonHelp_BYS.Click += buttonHelp_BYS_Click;
            // 
            // buttonGuide_BYS
            // 
            buttonGuide_BYS.Location = new Point(434, 113);
            buttonGuide_BYS.Name = "buttonGuide_BYS";
            buttonGuide_BYS.Size = new Size(129, 38);
            buttonGuide_BYS.TabIndex = 1;
            buttonGuide_BYS.Text = "Руководство ";
            buttonGuide_BYS.UseVisualStyleBackColor = true;
            buttonGuide_BYS.Click += buttonGuide_BYS_Click;
            // 
            // buttonAdd_BYS
            // 
            buttonAdd_BYS.Location = new Point(174, 73);
            buttonAdd_BYS.Name = "buttonAdd_BYS";
            buttonAdd_BYS.Size = new Size(129, 52);
            buttonAdd_BYS.TabIndex = 2;
            buttonAdd_BYS.Text = "Добавить сотрудника";
            buttonAdd_BYS.UseVisualStyleBackColor = true;
            buttonAdd_BYS.Click += buttonAdd_BYS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAdd_BYS);
            Controls.Add(buttonGuide_BYS);
            Controls.Add(buttonHelp_BYS);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp_BYS;
        private Button buttonGuide_BYS;
        private Button buttonAdd_BYS;
    }
}
