using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;
using Microsoft.Office.Interop.Excel;
using System.Data.Common;
using xl = Microsoft.Office.Interop.Excel;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.IO;



namespace Selenium
{
    internal class LogFile
    {
        FileStream ostrm;
        StreamWriter writer;
        TextWriter oldOut = Console.Out;
        public LogFile()
        {
            ostrm = new FileStream("C:/Users/Dilan/Desktop/test/Selenium/Selenium/LogFile.txt", FileMode.OpenOrCreate, FileAccess.Write);
            writer = new StreamWriter(ostrm);

            Console.SetOut(writer);
        }
        public void Stop()
        {
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
        }
    }
}
