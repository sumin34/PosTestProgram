using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    class File
    {
        static string fileName=null;
        static public void OpenImageFile()
        {

            using (OpenFileDialog open = new OpenFileDialog())
            {
                try
                {
                    open.Filter = "Image Files|*.bmp";
                    if(open.ShowDialog() == DialogResult.OK)
                    {
                        
                    }
                }
                finally
                {
                    if (open != null)
                        open.Dispose();
                }
            }

        }

        static public void OpenFirwareFile()
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                try
                {
                    open.Filter = "Firmware Files|*.bin;*.hex;*.mot;*.img;*.upd;*.fw;*.rom;*.exe;*.dfu;*.prg;*.ebn;*.rsc;*.pkg;*.pof;*.mcs;*.jic;*.elf;*.uf2";
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        fileName = open.FileName;
                    }
                }
                finally
                {
                    if (open != null)
                        open.Dispose();
                }
            }
        }



    }
}
