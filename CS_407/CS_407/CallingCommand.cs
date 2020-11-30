﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace CS_407
{
   
    class CallingCommand: IDisposable
    {
        private Process _cmdProcess;
        private StreamWriter _streamWriter;
        private AutoResetEvent _outputWaitHandle;
        private string _cmdOutput;
        
        public CallingCommand(string cmdPath)
        {
            _cmdProcess = new Process();
            _outputWaitHandle = new AutoResetEvent(false);
            _cmdOutput = String.Empty;

            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = cmdPath;
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.CreateNoWindow = true;

            _cmdProcess.OutputDataReceived += _cmdProcess_OutputDataReceived;

            _cmdProcess.StartInfo = processStartInfo;
            _cmdProcess.Start();

            _streamWriter = _cmdProcess.StandardInput;
            _cmdProcess.BeginOutputReadLine();
        }
        public string ExecuteCommand(string command)
        {
            _cmdOutput = String.Empty;

            _streamWriter.WriteLine(command);
            _streamWriter.WriteLine("echo end");
            _outputWaitHandle.WaitOne();
            return _cmdOutput;
        }

        private void _cmdProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null || e.Data == "end")
                _outputWaitHandle.Set();
            else
                _cmdOutput += e.Data + Environment.NewLine;
        }

        public void Dispose()
        {
            _cmdProcess.Close();
            _cmdProcess.Dispose();
            _streamWriter.Close();
            _streamWriter.Dispose();
        }
    }
}
