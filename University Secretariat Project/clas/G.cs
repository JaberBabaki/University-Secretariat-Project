using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personnelMangement.clas
{
    class G : ApplicationContext
    {
        
        public static string DIRPHOTO = Path.GetDirectoryName(Application.ExecutablePath)+@"\img";
        public static string DIRIMG=DIRPHOTO+@"\Male.png";
         
        public G(){
            Main frm1 = new Main();
            frm1.Show();
        }
    }
}
