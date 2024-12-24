using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BrezinaYS.Sprint7.Project.V15.Lib;

namespace Tyuiu.BrezinaYS.Sprint7.Project.V15
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();


        private void buttonClose_BYS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_BYS_Click(object sender, EventArgs e)
        {
            int col = 8;
            int row = ds.Row(openFilePath);
            string[,] mat = ds.BasaD(openFilePath, row, col);
            string str = textBoxIDStep_BYS.Text;

            int k = 1;
            
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j <= 0; j++)
                {
                    if (mat[i, j] == str)
                    {
                        textBoxNameStep_BYS.Text = mat[i, k];
                        k++;
                        textBoxAddressStep_BYS.Text = mat[i, k];
                        k++;
                        textBoxNumStep_BYS.Text = mat[i, k];
                        k++;
                        textBoxDolStep_BYS.Text = mat[i, k];
                        k++;
                        textBoxSalaryStep_BYS.Text = mat[i, k];
                        k++;
                        textBoxYearStep_BYS.Text = mat[i, k];
                        k++;
                        textBoxTimeStep_BYS.Text = mat[i, k];
                        k++;

                    }
                    
                }

            }
        }

        private void buttonOpen_BYS_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            buttonSearch_BYS.Enabled = true;

        }
    }
}