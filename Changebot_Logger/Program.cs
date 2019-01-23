using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Changebot_Logger{
    class Program{
        static void Main(string[] args){
            
            // creates path with same name as the date
            string path = "c:\\temp\\Changebot_Files\\" + DateTime.Now.ToString("MMM-dd-yy") + "-Transactions" + ".log";
            // checks to see if the file already exists
            if (!File.Exists(path)){
                // creates the file to write to
                using (StreamWriter sw = File.CreateText(path)){
                    // writes the parameters and calls upon the previous file and writes them
                    sw.WriteLine(args[0] + " " + args[1] + " " + args[2] + " " + args[3] + " " + args[4] + " " + args[5] + " " + args[6] + "\n");
                }//end StreamWriter
            }else{
                using (StreamWriter sw = File.AppendText(path)){
                    // writes the parameters and calls upon the previous file and writes them
                    sw.WriteLine(args[0] + " " + args[1] + " " + args[2] + " " + args[3] + " " + args[4] + " " + args[5] + " " + args[6] + "\n");
                }//end StreamWriter
            }//end if(!file exists)
        }// end main
    }// end class
}// end name