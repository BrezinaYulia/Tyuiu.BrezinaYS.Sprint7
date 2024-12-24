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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            buttonOK_BYS = new Button();
            textBoxG_BYS = new TextBox();
            SuspendLayout();
            // 
            // buttonOK_BYS
            // 
            buttonOK_BYS.Location = new Point(395, 184);
            buttonOK_BYS.Name = "buttonOK_BYS";
            buttonOK_BYS.Size = new Size(114, 45);
            buttonOK_BYS.TabIndex = 0;
            buttonOK_BYS.Text = "ОК";
            buttonOK_BYS.UseVisualStyleBackColor = true;
            buttonOK_BYS.Click += buttonOK_BYS_Click;
            // 
            // textBoxG_BYS
            // 
            textBoxG_BYS.BackColor = SystemColors.Control;
            textBoxG_BYS.BorderStyle = BorderStyle.None;
            textBoxG_BYS.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxG_BYS.Location = new Point(-1, 12);
            textBoxG_BYS.Multiline = true;
            textBoxG_BYS.Name = "textBoxG_BYS";
            textBoxG_BYS.Size = new Size(494, 232);
            textBoxG_BYS.TabIndex = 1;
            textBoxG_BYS.Text = resources.GetString("textBoxG_BYS.Text");
            //textBoxG_BYS.TextChanged += this.textBoxG_BYS_TextChanged;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 245);
            Controls.Add(buttonOK_BYS);
            Controls.Add(textBoxG_BYS);
            Name = "FormGuide";
            Text = "Краткое руководство ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK_BYS;
        private TextBox textBoxG_BYS;
    }
}