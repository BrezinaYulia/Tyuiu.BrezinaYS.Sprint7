namespace Tyuiu.BrezinaYS.Sprint7.Project.V15
{
    partial class FormGuide
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
            buttonOK_BYS = new Button();
            SuspendLayout();
            // 
            // buttonOK_BYS
            // 
            buttonOK_BYS.Location = new Point(535, 263);
            buttonOK_BYS.Name = "buttonOK_BYS";
            buttonOK_BYS.Size = new Size(114, 45);
            buttonOK_BYS.TabIndex = 0;
            buttonOK_BYS.Text = "ОК";
            buttonOK_BYS.UseVisualStyleBackColor = true;
            buttonOK_BYS.Click += buttonOK_BYS_Click;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 359);
            Controls.Add(buttonOK_BYS);
            Name = "FormGuide";
            Text = "Краткое руководство ";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOK_BYS;
    }
}