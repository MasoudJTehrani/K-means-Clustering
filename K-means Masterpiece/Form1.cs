using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace K_means_Masterpiece
{
    public partial class Form1 : Form
    {
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        public static int R = 2;
        public static int C, tmp1, tmp2;
        public static int P = 2;
        public static int K = 1;
        public static int Maxp = 100000000;
        public static double[,] datas = new double[0, 0];
        public static double[,,] cluster;
        public static double[,,] clusterprev;
        public static double[,] centroid;
        public static readonly Random random = new Random();
        public double distance(double[] x, double[] y, int p)
        {
            double result = 0;
            for (int i = 0; i < C; i++)
            {
                result += Math.Pow(Math.Abs(x[i] - y[i]), p);
            }
            double sqrt = (double)1 / p;
            result = Math.Pow(result, sqrt);
            return result;
        }
        public bool ismoved(double[,,] c, double[,,] cp)
        {
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < R; j++)
                {
                    for (int z = 0; z < C; z++)
                    {
                        if (c[i, j, z] != cp[i, j, z])
                            return true;
                    }
                }
            }
            return false;
        }
        public int emptyclust(double[,,] clust, int ind)
        {
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (clust[ind, i, j] == 0.0)
                        return i;
                }
            }
            return 100000;
        }
        public double[,] newcentroid(double[,,] clust)
        {
            double[,] newcent = new double[K, C];
            int count = 0;
            double sum = 0;
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    for (int z = 0; z < R; z++)
                    {
                        if (clust[i, z, j] != 0.0)
                        {
                            count++;
                            sum += clust[i, z, j];
                        }
                    }
                    newcent[i, j] = sum / count;
                    count = 0;
                    sum = 0;
                }
            }
            return newcent;
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog datafile = new OpenFileDialog();
            datafile.Filter = "Excel File|*.xlsx;*.xls";
            if (datafile.ShowDialog() == DialogResult.OK)
            {
                if (datafile.FileName.Trim() != "")
                {
                    xlApp = new Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Open(datafile.FileName);
                    xlWorkSheet = xlWorkBook.Worksheets.get_Item(1);
                    C = 1;
                    R = 1;
                    while (xlWorkSheet.Cells[R, 1].value != null)
                    {
                        R++;
                    }
                    while (xlWorkSheet.Cells[1, C].value != null)
                    {
                        C++;
                    }
                    R--;
                    C--;
                    datas = new double[R, C];
                    for (int i = 0; i < R; i++)
                    {
                        for (int j = 0; j < C; j++)
                        {
                            if (xlWorkSheet.Cells[i + 1, j + 1].value != null)
                            {
                                datas[i, j] = xlWorkSheet.Cells[i + 1, j + 1].value;
                            }
                        }
                    }
                    xlWorkBook.Close();   
                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);
                    xlApp.Quit();
                }
                done.Text = "Excel File uploaded successfully";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            C = Decimal.ToInt32(dimension.Value);
            R = Decimal.ToInt32(number.Value);
            int Min = Decimal.ToInt32(min.Value);
            int Max = Decimal.ToInt32(max.Value);
            datas = new double[R, C];
            if (Max > Min)
            {
                for (int i = 0; i < R; i++)
                {
                    for (int j = 0; j < C; j++)
                    {
                        datas[i, j] = random.NextDouble()*(Max - Min) + Min;
                    }
                }
                done.Text = "Random numbers between " + Min + " and " + Max + " generated successfully";
            }
            else
            {
                MessageBox.Show("Max value must be bigger than Min value");
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Custom K
            if (radioButton2.Checked == true)
            {
                k.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Best K
            if (radioButton1.Checked == true)
            {
                k.Visible = false;
                K = 1;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //Minkowski Distance
            if (radioButton5.Checked == true)
            {
                label8.Visible = true;
                p.Visible = true;
                maxp.Visible = false;
                maxpl.Visible = false;
                to.Visible = false;
                minp.Visible = false;
                P = decimal.ToInt32(p.Value);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Euclidean Distance
            P = 2;
            if (radioButton3.Checked == true)
            {
                label8.Visible = false;
                p.Visible = false;
                maxp.Visible = false;
                maxpl.Visible = false;
                to.Visible = false;
                minp.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //Manhattan Distance
            P = 1;
            if (radioButton4.Checked == true)
            {
                label8.Visible = false;
                p.Visible = false;
                maxp.Visible = false;
                maxpl.Visible = false;
                to.Visible = false;
                minp.Visible = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            //Best Distance
            if (radioButton6.Checked == true)
            {
                label8.Visible = false;
                p.Visible = false;
                maxp.Visible = true;
                maxpl.Visible = true;
                to.Visible = true;
                minp.Visible = true;
                P = decimal.ToInt32(minp.Value);
                Maxp = decimal.ToInt32(maxp.Value);
            }
        }

        private void k_ValueChanged(object sender, EventArgs e)
        {
            K = decimal.ToInt32(k.Value);
        }

        private void minp_ValueChanged(object sender, EventArgs e)
        {
            P = decimal.ToInt32(minp.Value);
        }

        private void maxp_ValueChanged(object sender, EventArgs e)
        {
            Maxp = decimal.ToInt32(maxp.Value);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private void p_ValueChanged(object sender, EventArgs e)
        {
            P = decimal.ToInt32(p.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Maxp > P && datas.Length != 0 && K <= R)
            {
                cluster = new double[K, R, C];   //Declare a 3D array for clusters
                clusterprev = new double[K, R, C];      //Declare another 3D array to check if a data move to another cluster in order to finish the calculation
                double[,] d = new double[R, K];
                double[] x = new double[C];
                double[] y = new double[C];
                int[] rand = new int[K];            //Declare an array to select random data from datas in order to initial K means
                centroid = new double[K, C];            //Declare an array to save centroids
                int rcheck = 0;
                while (rcheck < K)
                {
                    rand[rcheck] = random.Next(1, R);
                    if (rcheck != 0)
                    {
                        if (rand[rcheck] == rand[rcheck - 1])
                        {
                            //nothing
                        }
                        else
                        {
                            rcheck++;
                        }
                    }
                    else
                    {
                        rcheck++;
                    }
                }
                for (int i = 0; i < K; i++)
                {
                    int aaa = rand[i];
                    for (int j = 0; j < C; j++)
                    {
                        centroid[i, j] = datas[aaa, j]; //initial K is now set on a data
                    }
                }
                do
                {
                    clusterprev = cluster;
                    cluster = new double[K, R, C];
                    //measure distance
                    for (int i = 0; i < K; i++)
                    {
                        for (int j = 0; j < R; j++)
                        {
                            for (int z = 0; z < C; z++)
                            {
                                x[z] = centroid[i, z];
                                y[z] = datas[j, z];
                            }
                            d[j, i] = distance(x, y, P);
                        }
                    }
                    //add datas to clusters
                    for (int i = 0; i < R; i++)
                    {
                        tmp1 = i;
                        tmp2 = 0;
                        for (int j = 0; j < K; j++)
                        {
                            for (int z = 0; z < K; z++)
                            {
                                if (d[i, j] <= d[i, z] && d[i,j] <= d[tmp1,tmp2])
                                {
                                    tmp1 = i;
                                    tmp2 = j;
                                }
                            }
                        }
                        int index = emptyclust(cluster, tmp2);
                        for (int j = 0; j < C; j++)
                        {
                            cluster[tmp2, index, j] = datas[tmp1, j];
                        }
                    }
                    // calculate new center of each cluster
                    centroid = newcentroid(cluster);
                    // MessageBox.Show("where the fuck i am");
                }
                while (ismoved(cluster, clusterprev));

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add();
                Excel.Worksheet xlsheet;
                xlWorkBook.Worksheets.Add(Type.Missing,Type.Missing,K,Type.Missing);
                for (int i = 0; i < K; i++)
                {
                    xlsheet = xlWorkBook.Worksheets.get_Item(i + 1);
                    xlsheet.Name = "K" + i;
                    for (int j = 0; j < R; j++)
                    {
                        for (int z = 0; z < C; z++)
                        {
                            if (cluster[i, j, z] != 0.0)
                            {
                                xlsheet.Cells[j + 1, z + 1].value = cluster[i, j, z];
                            }
                        }
                    }
                }
                xlsheet = xlWorkBook.Worksheets["sheet1"];
                xlsheet.Delete();
                xlApp.Visible = true;                   
            }
            else if (Maxp < P)
            {
                MessageBox.Show("!Please check the range of P value .Max p must be more than Min p");
            }
            else if (datas.Length == 0)
            {
                MessageBox.Show("!Please insert datas first or generate random datas");
            }
            else if (K > R)
            {
                MessageBox.Show("!K value must be less or equal to number of datas");
            }
        }
    }
}