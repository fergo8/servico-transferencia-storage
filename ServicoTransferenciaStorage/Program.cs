using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;

namespace ServicoTransferenciaStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            string gcpAuth = "/c \"" + ConfigurationSettings.AppSettings["gcpAuth"].ToString() + " " +
                                    ConfigurationSettings.AppSettings["gcpAuthPath"].ToString() +
                                    ConfigurationSettings.AppSettings["gcpAuthFile"].ToString() + "\"";
            
            int authRetorno = ProcessarComCMD(gcpAuth);

            if (authRetorno == 0)
            {
                string gcpCopyFiles = "/c \"gsutil cp " + ConfigurationSettings.AppSettings["localPath"].ToString() + 
                                        "*.txt " + ConfigurationSettings.AppSettings["gcpStoragePath"].ToString() + "\"";

                int Retorno = ProcessarComCMD(gcpCopyFiles);
            }
        }

        static int ProcessarComCMD(string gcpArguments)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = gcpArguments
            };

            process.StartInfo = startInfo;
            process.Start();

            process.WaitForExit();

            return process.ExitCode;
        }
    }
}
