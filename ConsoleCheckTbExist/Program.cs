using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCheckTbExist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Waiting for response...");

            string ctid = "CT3290354"; //MapsView CTID
            int status = checkToolbarExists(ctid);
            Console.WriteLine(status);
            Console.ReadKey(); //Use this to keep console open while utility is running
        }

        public static int checkToolbarExists(string ctid)
        {
            Process conduit_check = new Process();
            conduit_check.StartInfo.FileName = Directory.GetCurrentDirectory() + "//mchecktbexist.exe"; //place mchecktbexist.exe in the debug folder
            conduit_check.StartInfo.Arguments = " " + string.Format("-ctid={0} -any", ctid);
            conduit_check.Start();
            while(!conduit_check.HasExited);
            return conduit_check.ExitCode;
        }
    }
}
