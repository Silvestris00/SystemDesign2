using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProxyOnOff
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process P = new System.Diagnostics.Process();

            P.StartInfo.FileName = System.Environment.GetEnvironmentVariable("COMSPEC");
            P.StartInfo.UseShellExecute = false;
            P.StartInfo.RedirectStandardOutput = true;
            P.StartInfo.RedirectStandardInput = false;
            P.StartInfo.CreateNoWindow = true;

            Console.WriteLine("\nプロキシ設定: ONにしたい場合 1 を、OFFにしたい場合は 0 を押してください！ ");
            String Args = Console.ReadLine();
            String results, results1;
            switch (Args)
            {
                case "1":
                    Console.WriteLine("\nONにします! ");
                    System.Threading.Thread.Sleep(1000);
                    P.StartInfo.Arguments = "/c reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Connections\\DefaultConnectionSettings\" /f /v ProxyEnable /t reg_dword /d 1";
                    P.Start();
                    results = P.StandardOutput.ReadToEnd();
                    P.WaitForExit();
                    P.Close();
                    Console.WriteLine(results);
                    System.Threading.Thread.Sleep(1000);
                    break;

                case "0":
                    Console.WriteLine("\nOFFにします! ");
                    System.Threading.Thread.Sleep(1000);
                    P.StartInfo.Arguments = "/c reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Connections\\DefaultConnectionSettings\" / f /v ProxyEnable /t reg_dword /d 0";
                    P.Start();
                    results = P.StandardOutput.ReadToEnd();
                    P.WaitForExit();
                    P.Close();
                    Console.WriteLine(results);
                    System.Threading.Thread.Sleep(1000);
                    break;

                case "7":
                    Console.WriteLine("\nProxyの設定を適用します");
                    System.Threading.Thread.Sleep(1500);
                    P.StartInfo.Arguments = "/c reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Connections\\DefaultConnectionSettings\" /f /v ProxyEnable /t reg_dword /d 1";
                    P.Start();
                    P.StartInfo.Arguments = "/c reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Connections\\DefaultConnectionSettings\" /f /v ProxyServer /t reg_sz /d proxy.anan-nct.ac.jp:8080";
                    P.Start();
                    P.StartInfo.Arguments = "/c reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\Connections\\DefaultConnectionSettings\" /f /v ProxyOverride /t reg_sz /d  \"192.168.0.50;<local>\"";
                    P.Start();
                    results = P.StandardOutput.ReadToEnd();
                    Console.WriteLine(results);
                    results1 = P.StandardOutput.ReadToEnd();
                    P.WaitForExit();
                    P.Close();
                    Console.WriteLine(results1);
                    Console.ReadLine();
                    break;
            }
        }
    }
}
