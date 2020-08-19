using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace SlideShow
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Environment.SetEnvironmentVariable("CLOUDINARY_URL", "CLOUDINARY_URL=cloudinary://146236428816754:Obmzm_Iv5LfsEukIfNV4HB4zCDc@dpzg6mrfx", EnvironmentVariableTarget.Machine);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
