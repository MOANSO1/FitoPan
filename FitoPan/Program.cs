using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitoPan
{
    internal static class Program{
        [STAThread]
        static void Main(){
            FitoPan.getInstance().startProgram();
        }
    }
}
