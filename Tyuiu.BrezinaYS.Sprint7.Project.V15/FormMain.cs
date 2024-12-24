using System.Windows.Forms;
using Tyuiu.BrezinaYS.Sprint7.Project.V15.Lib;
namespace Tyuiu.BrezinaYS.Sprint7.Project.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        public string openFilePath;

        DataService ds = new DataService();

        private void buttonHelp_BYS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonGuide_BYS_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }



        private void buttonOpen_BYS_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            int col = 8;
            int row = ds.Row(openFilePath);
            dataGridViewBase_BYS.RowCount = row;
            dataGridViewBase_BYS.ColumnCount = col;
            string[,] mat = new string[row, col];
            mat = ds.BasaD(openFilePath, row, col);
            int c = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridViewBase_BYS.Rows[c].Cells[j].Value = mat[i, j];
                }
                c++;
            }

            this.chartSalary_BYS.ChartAreas[0].AxisX.Title = "Человек";
            this.chartSalary_BYS.ChartAreas[0].AxisY.Title = "Зарплата";
            double[] value;
            value = new double[row];
            value = ds.Salary(mat, row);
            int st = 1;
            chartSalary_BYS.Series[0].Points.Clear();
            for (int i = 0; i <= value.Length - 1; i++)
            {
                this.chartSalary_BYS.Series[0].Points.AddXY(st, value[i]);
                st++;
            }

            textBoxMinStep_BYS.Text = Convert.ToString(ds.Min(mat, row));
            textBoxMaxStep_BYS.Text = Convert.ToString(ds.Max(mat, row));
            textBoxMeanStep_BYS.Text = Convert.ToString(ds.Mean(mat, row));

            buttonSearch_BYS.Enabled = true;
            buttonSave_BYS.Enabled = true;

        }

        private void buttonSearch_BYS_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch();
            formSearch.ShowDialog();


        }

        private void chartSalary_BYS_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_BYS_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutFileTask7.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                File.Delete(path);
            }
            int rows = dataGridViewBase_BYS.RowCount;
            int columns = dataGridViewBase_BYS.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewBase_BYS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewBase_BYS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
