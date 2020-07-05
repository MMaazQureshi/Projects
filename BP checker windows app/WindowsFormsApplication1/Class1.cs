using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Class1
    {
       public static long higher, lower;
        public string numbers_ranges(long x,long y,Label l)
{ 
        if ((x >= 0 && x <= 90 && y >= 0 && y <= 60))
            {
           return "Low Bp";
            }
        if ((x >= 90 && x <= 120 && y >= 60 && y <= 80))
            {
           return "Normal Bp";
            }
        if ((x >= 120 && x <= 140 && y >= 80 && y <=90))
           {
           return "Prehyper Bp";
          }
        if ((x >= 140 && x <= 160 && y >= 90 && y<=100))
          {
          return "Hyper 1 Bp EMERGENCY";
          
          }
        if ((x > 160 && y > 100))
        {
            return "Hyper 2 Bp EMERGENCY";
           
        }
        else
        {
            return "bp values invalid";
           
        }
        
}
    }
}
