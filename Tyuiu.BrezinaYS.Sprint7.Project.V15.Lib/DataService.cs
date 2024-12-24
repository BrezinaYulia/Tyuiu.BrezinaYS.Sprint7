//using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Tyuiu.BrezinaYS.Sprint7.Project.V15.Lib
{
    public class DataService
    {
        public int Row(string path)
        {
            int len = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    len++;
                }
                    
            }
            return len;
        }
        public string[,] BasaD(string path, int row, int col)
        {
            string[,] mat = new string[row, col];
            int j = 0;
            String line = String.Empty;
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                String[] parts_of_line = line.Split(';');
                for (int i = 0; i < parts_of_line.Length; i++)
                {
                    parts_of_line[i] = parts_of_line[i].Trim();
                    mat[j, i] = parts_of_line[i].Trim();
                }
                j++;
            }
            return mat;
        }
        public double[] Salary(string[,] mat, int row)
        {
            double[] value = new double[row];
            for (int i = 0; i < row; i ++)
            {
                value[i] = Convert.ToDouble(mat[i, 5]);
            }
            return value;

        }
        public double Min(string[,] mat, int row)
        {
            List<double> value = new List<double>();
            for (int i = 0; i < row; i++)
            {
                value.Add(Convert.ToDouble(mat[i, 5]));

            }
            value.Sort();
            return value[0];
        }

        public double Max(string[,] mat, int row)
        {
            List<double> value = new List<double>();
            for (int i = 0; i < row; i++)
            {
                value.Add(Convert.ToDouble(mat[i, 5]));

            }
            value.Sort();
            return value[row - 1];
        }

        public double Mean(string[,] mat, int row)
        {
            double sum = 0;
            for (int i = 0; i < row; i++)
            {
                sum += Convert.ToDouble(mat[i,5]);

            }
            double res = sum / row;
            return Math.Round(res, 3);
        }

    }
}
