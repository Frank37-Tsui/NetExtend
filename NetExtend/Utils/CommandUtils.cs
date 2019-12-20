using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExtend.Utils
{
    public class CommandUtils
    {
        public static void ExecuteCommandSync(object command)
        {
            try
            {                
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command);                
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;                
                procStartInfo.CreateNoWindow = true;                
                Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();                
                string result = proc.StandardOutput.ReadToEnd();                
                Console.WriteLine(result);
            }
            catch
            {
                throw;
            }
        }
    }
}
