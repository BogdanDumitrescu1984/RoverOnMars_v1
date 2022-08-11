using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.IO;

namespace RoverOnMars_v1
{
    internal class Logger
    {
        public string GetCurrentDirectory()
        {
            string startupPath = Environment.CurrentDirectory;
            string filePath = startupPath + "\\RoverOnMars.txt";

            return filePath;
        }

        public void CreateTxtFile(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            sw.Close();
        }

        public void WriteToFile(string fileName, string userAction, string UserEffect, string direction)
        {

            using (StreamWriter streamWriter = new StreamWriter(fileName, true))
            {
                DateTime now = DateTime.Now;

                string elemToBeLogged = userAction + ", " + UserEffect + ", " + direction;

                streamWriter.WriteLine(now + "; "+ elemToBeLogged);
                streamWriter.Close();
            }
        }
    }
}
