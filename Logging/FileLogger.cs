using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
public class FileLogger : LogBase
     {
        public string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\Log.txt";
        public override void Log(LogType logType, string message)
        {
            try
            {
                string time = DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss\t");
                string type = logType.ToString() + "\t";
                if (!File.Exists(filePath))
                {
                    using (StreamWriter streamWriter = new StreamWriter(filePath))
                    {
                        streamWriter.WriteLine(time + type + message);
                        streamWriter.Close();
                    }
                }
                else
                {
                    using (StreamWriter streamWriter = File.AppendText(filePath))
                    {
                        streamWriter.WriteLine(time + type + message);
                        streamWriter.Close();
                    }	
                }
            }
            catch { }
        }
    }
}
