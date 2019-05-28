using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args!=null && args.Length>0)
            {
                if (args[0].ToLower().EndsWith(".pdf"))
                {
                    Application.Run(new Form1(args[0],Type.PDF));
                }
                else if (args[0].ToLower().EndsWith(".epub"))
                {
                    Application.Run(new Form1(args[0],Type.EPUB));
                }
                
            }
            else
            {
                Application.Run(new Form1());
            }
        }
    }
}
