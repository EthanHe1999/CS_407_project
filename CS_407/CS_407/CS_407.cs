using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace CS_407
{
    public partial class CS_407 : Form
    {        
        string result;
        string path2 = "";
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/csvFilePath.txt";
        public CS_407()
        {

           
           
           
            InitializeComponent();
        //    pythonPath();
            string pathL = Environment.CurrentDirectory;
            string[] sepStrings = { "\\" };
            string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
           
            for(int i = 0; i < words.Length - 2; i++)
            {
                    path2 += words[i];
                    path2 += "/";
            }
            if (!File.Exists(path))
            {
                TextWriter tsw = new StreamWriter(path, true);
                tsw.WriteLine(path2 + "CSV/HousePrices.csv");
                tsw.WriteLine(path2 + "CSV/Weddings.csv");
                tsw.WriteLine(path2 + "CSV/StudentGrades.csv");
                tsw.WriteLine(path2 + "CSV/InterestRate.csv");
                tsw.WriteLine(path2 + "CSV/PetrolConsumption.csv");
                tsw.WriteLine(path2 + "CSV/Insurance.csv");
                tsw.WriteLine(path2 + "CSV/pima_indians_diabetes.csv");
                tsw.WriteLine(path2 + "CSV/Weddings.csv");
                tsw.WriteLine(path2 + "CSV/titanic.csv");
                tsw.WriteLine(path2 + "CSV/PetrolConsumption.csv");
                tsw.WriteLine(path2 + "CSV/bill_authentication.csv");
                tsw.Close();
            }
            else
            {
                //File.Delete(path);
                TextWriter tsw = new StreamWriter(path, true);
                tsw.WriteLine(path2 + "CSV/HousePrices.csv");
                tsw.WriteLine(path2 + "CSV/Weddings.csv");
                tsw.WriteLine(path2 + "CSV/StudentGrades.csv");
                tsw.WriteLine(path2 + "CSV/InterestRate.csv");
                tsw.WriteLine(path2 + "CSV/PetrolConsumption.csv");
                tsw.WriteLine(path2 + "CSV/Insurance.csv");
                tsw.WriteLine(path2 + "CSV/pima_indians_diabetes.csv");
                tsw.WriteLine(path2 + "CSV/Weddings.csv");
                tsw.WriteLine(path2 + "CSV/titanic.csv");
                tsw.WriteLine(path2 + "CSV/PetrolConsumption.csv");
                tsw.WriteLine(path2 + "CSV/bill_authentication.csv");
                tsw.Close();
            }
            pythonPath();
        }
        
        private void label5_Click(object sender, EventArgs e)
        {
            
        }
  
        void GoToLink(string link)
        {
            try
            {
                Process.Start(link);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        string RemakePath(string s)
        {
            string path = "";
            for(int i = 0; i < s.Length; i++)
            {
                if(s.ElementAt(i) == '\\')
                {
                    path += "/";
                }
                else
                {
                    path += s.ElementAt(i);
                }
            }

            return path;
        }
        private void Linear_Regression(object sender, EventArgs e)
        {          
            try
            {
                string pathL = path2 + "JupyterNotebook/Regressions%20with%20charts.ipynb";
                string[] sepStrings = { "/" };                
                string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string path3 = "";
                for (int i = 3; i < words.Length; i++)
                {
                    if (i != words.Length - 1)
                    {
                        path3 += words[i];
                        path3 += "/";
                    }
                    else
                    {
                        path3 += words[i];
                    }

                }
                GoToLink("http://localhost:8888/notebooks/" + "Regressions%20with%20charts.ipynb");
            }
            catch(Exception s)
            {
                MessageBox.Show(s.Message);
            }                 
        }

        private void Logistic_Regression(object sender, EventArgs e)
        {            
            try
            {
                string pathL = path2 + "JupyterNotebook/Logistic%20Regression.ipynb";
                string[] sepStrings = { "/" };
                string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string path3 = "";
                for (int i = 3; i < words.Length; i++)
                {
                    if (i != words.Length - 1)
                    {
                        path3 += words[i];
                        path3 += "/";
                    }
                    else
                    {
                        path3 += words[i];
                    }

                }
                GoToLink("http://localhost:8888/notebooks" + "/Logistic%20Regression.ipynb");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void Baye_Classification(object sender, EventArgs e)
        {           
            try
            {
                string pathL = path2 + "JupyterNotebook/Naive%20Bayes.ipynb";
                string[] sepStrings = { "/" };
                string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string path3 = "";
                for (int i = 3; i < words.Length; i++)
                {
                    if (i != words.Length - 1)
                    {
                        path3 += words[i];
                        path3 += "/";
                    }
                    else
                    {
                        path3 += words[i];
                    }

                }
                GoToLink("http://localhost:8888/notebooks/" + "Naive%20Bayes.ipynb");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void Descision_Tree(object sender, EventArgs e)
        {
            try
            {
                string pathL = path2 + "JupyterNotebook/Decision_Tree_And_Random_Forest.ipynb";
                string[] sepStrings = { "/" };
                string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string path3 = "";
                for (int i = 3; i < words.Length; i++)
                {
                    if (i != words.Length - 1)
                    {
                        path3 += words[i];
                        path3 += "/";
                    }
                    else
                    {
                        path3 += words[i];
                    }

                }
                GoToLink("http://localhost:8888/notebooks/" + "Decision_Tree_And_Random_Forest.ipynb");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void Random_Forrest(object sender, EventArgs e)
        {
            try
            {
           
                string pathL = path2 + "JupyterNotebook/Decision_Tree_And_Random_Forest.ipynb";
                string[] sepStrings = { "/" };
                string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string path3 = "";
                for (int i = 3; i < words.Length; i++)
                {
                    if (i != words.Length - 1)
                    {
                        path3 += words[i];
                        path3 += "/";
                    }
                    else
                    {
                        path3 += words[i];
                    }

                }
                GoToLink("http://localhost:8888/notebooks/" + "Decision_Tree_And_Random_Forest.ipynb");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        public void pythonPath()

        {
           // string name = path2 + @"/Python37/Scripts/jupyter-notebook.exe";
           // string FileName = "jupyter-notebook.exe";
            try
            {
                // path2 + @"/Python37/Scripts/jupyter-kernel.exe";
                Process p = new Process();
                String newpath = path2 + @"/Python37/python.exe";
                p.StartInfo.FileName = "cmd";
               // p.StartInfo.WorkingDirectory = path2 + @"/Python37/Scripts";
               p.StartInfo.WorkingDirectory = path2 + @"/JupyterNotebook";
               
               p.StartInfo.Arguments = "/C python -m notebook";
             //   p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.RedirectStandardOutput = false;
                p.StartInfo.RedirectStandardInput = false;
                //  System.Diagnostics.Process.Start(newpath);
                p.Start();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.ReadKey();
            }
            //System.Diagnostics.Process.Start(name);
        }
       
        

        private void button1_Click(object sender, EventArgs e)
        {
            pythonPath();
        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private void Cluster(object sender, EventArgs e)
        {
            try
            {
                string pathL = path2 + "JupyterNotebook/K-Mean-Clustering-Final-WithLib.ipynb";
                string[] sepStrings = { "/" };
                string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string path3 = "";
                for (int i = 3; i < words.Length; i++)
                {
                    if (i != words.Length - 1)
                    {
                        path3 += words[i];
                        path3 += "/";
                    }
                    else
                    {
                        path3 += words[i];
                    }

                }
                GoToLink("http://localhost:8888/notebooks/" + "K-Mean-Clustering-Final-WithLib.ipynb");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void Fuzzy_Matching(object sender, EventArgs e)
        {
            try
            {
                string pathL = path2 + "JupyterNotebook/Fuzzy%20Matching%20of%20data.ipynb";
                string[] sepStrings = { "/" };
                string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string path3 = "";
                for (int i = 3; i < words.Length; i++)
                {
                    if (i != words.Length - 1)
                    {
                        path3 += words[i];
                        path3 += "/";
                    }
                    else
                    {
                        path3 += words[i];
                    }

                }
                GoToLink("http://localhost:8888/notebooks/" + "Fuzzy%20Matching%20of%20data.ipynb");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            try
            {
                string pathL = path2 + "JupyterNotebook/Linear%20Programming.ipynb";
                string[] sepStrings = { "/" };
                string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string path3 = "";
                for (int i = 3; i < words.Length; i++)
                {
                    if (i != words.Length - 1)
                    {
                        path3 += words[i];
                        path3 += "/";
                    }
                    else
                    {
                        path3 += words[i];
                    }

                }
                GoToLink("http://localhost:8888/notebooks/" + "Linear%20Programming.ipynb");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            try
            {
                string pathL = path2 + "JupyterNotebook/Spark.ipynb";
                string[] sepStrings = { "/" };
                string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string path3 = "";
                for (int i = 3; i < words.Length; i++)
                {
                    if (i != words.Length - 1)
                    {
                        path3 += words[i];
                        path3 += "/";
                    }
                    else
                    {
                        path3 += words[i];
                    }

                }
                GoToLink("http://localhost:8888/notebooks/" + "Spark.ipynb");
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
    }
}
