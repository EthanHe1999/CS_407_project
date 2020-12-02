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

            //start();
            //Thread.Sleep(5000);
           
            //Thread.Sleep(5000);
            InitializeComponent();
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
                GoToLink("http://localhost:8888/notebooks/" + path3);
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
                GoToLink("http://localhost:8888/notebooks/" + path3);
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
                GoToLink("http://localhost:8888/notebooks/" + path3);
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
                GoToLink("http://localhost:8888/notebooks/" + path3);
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
                GoToLink("http://localhost:8888/notebooks/" + path3);
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
            //  start();
            string pathPython = System.AppDomain.CurrentDomain.BaseDirectory + "python" +
                "\\Scripts\\jupyter-notebook.exe";
             string FileName = Environment.CurrentDirectory + @"/python/Scripts/jupyter-notebook.exe";
            System.Diagnostics.Process.Start(pathPython);
        }
        public void start()
        {
            string pathL = Environment.CurrentDirectory + "/" + "Regressions%20with%20charts.ipynb";
            string[] sepStrings = { "\\" };
            string[] words = pathL.Split(sepStrings, System.StringSplitOptions.RemoveEmptyEntries);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            ProcessStartInfo command = new ProcessStartInfo();
            command.FileName = "cmd.exe";
            command.WorkingDirectory = @words[0] + "\\" + words[1] + "\\" + words[2];

            command.Arguments = "/C where python";
            command.UseShellExecute = false;
            command.RedirectStandardOutput = true;
            using (Process process2 = Process.Start(command))
            {
                using (StreamReader reader = process2.StandardOutput)
                {
                     result = reader.ReadToEnd();
                    if (result == "")
                    {
                        //command.Arguments = "/C install python";
                        MessageBox.Show("DownLoad");
                    }
                    else
                    {
                        MessageBox.Show(result);
                    }
                }
            }
            //command.WorkingDirectory = @"C:\Users\Owner";
            //command.Arguments = "/C jupyter notebook";
            //process.StartInfo = command;
            //process.Start();
        }
        private void run_cmd(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "cmd.exe";
            start.Arguments = string.Format("{0} {1}", cmd, args);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
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
                GoToLink("http://localhost:8888/notebooks/" + path3);
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
                GoToLink("http://localhost:8888/notebooks/" + path3);
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }
    }
}
