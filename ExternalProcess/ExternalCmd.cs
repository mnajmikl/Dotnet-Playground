using System.Diagnostics;

namespace ExternalProcess
{
    public class ExternalCmd : Process
    {
        public ExternalCmd()
        {
            StartInfo.RedirectStandardOutput = false;
            StartInfo.RedirectStandardError = false;
            StartInfo.CreateNoWindow = false;
            StartInfo.ErrorDialog = false;
            StartInfo.UseShellExecute = false;
            StartInfo.ErrorDialog = true;
            StartInfo.WorkingDirectory = System.Environment.GetEnvironmentVariable("windir");
        }
    }
}
