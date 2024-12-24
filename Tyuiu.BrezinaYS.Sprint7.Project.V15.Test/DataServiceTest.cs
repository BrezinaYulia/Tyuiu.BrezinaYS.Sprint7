using Tyuiu.BrezinaYS.Sprint7.Project.V15.Lib;
namespace Tyuiu.BrezinaYS.Sprint7.Project.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]

        
        public void TestMetod1()
        {
            
            string path = @"C:\DataSprint6\Test.txt";
            int res = ds.Row(path);
            Assert.AreEqual(3, res);

        }
        public void TestMin()
        {
            string[,] mat = { { "jdj", "ooi", "iid", "111", "loh", "100" }, { "hjhh", "ldld", "999", "kjk", "kk", "500" } };
            int row = 2;
            double res = ds.Min(mat, row);
            double wait = 100;
            Assert.AreEqual(wait, res);
        }

        public void TestMax()
        {
            string[,] mat = { { "jdj", "ooi", "iid", "111", "loh", "100" }, { "hjhh", "ldld", "999", "kjk", "kk", "500" } };
            int row = 2;
            double res = ds.Max(mat, row);
            double wait = 500;
            Assert.AreEqual(wait, res);
        }

        public void TestMean()
        {
            string[,] mat = { { "jdj", "ooi", "iid", "111", "loh", "100" }, { "hjhh", "ldld", "999", "kjk", "kk", "500" } };
            int row = 2;
            double res = ds.Mean(mat, row);
            double wait = 350;
            Assert.AreEqual(wait, res);
        }

    }
}