using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class BarCodeReader
    {
        String IDnum = "";
        String barcode = "";
        DateTime lastKeystroke = new DateTime(0);
        public String codeReader(char e)
        {
            TimeSpan passed = (DateTime.Now - lastKeystroke);
            if (passed.TotalMilliseconds > 100)
            {
                barcode = "";
                IDnum = "";
            }
            barcode = barcode + e.ToString();
            lastKeystroke = DateTime.Now;
            //showing the barcode
            if (barcode.Length == 14)
            {
                char[] n = barcode.ToCharArray();
                for (int i = 4; i < barcode.Length - 1; i++)
                {
                    if (i < 6)
                    {
                        IDnum = IDnum + "0";
                    }
                    else
                        IDnum = IDnum + n[i].ToString();
                }
                return IDnum;
            }
            else return null;
        }
        
    }
    
}
　
　
　

