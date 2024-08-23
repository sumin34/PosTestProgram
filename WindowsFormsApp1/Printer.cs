using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OposPOSPrinter_CCO;
using System.Windows.Forms;
using Constants;
namespace Printer
{
   
    public class PrinterCtr
    {
        public delegate void statusUpdateEvent(int data);

        statusUpdateEvent StatusUpdateEvent = null;


        OPOSPOSPrinter printer = new OPOSPOSPrinter();

        public PrinterCtr()
        {
            //StatusUpdateEvent += new 
        }
        

        public bool printerOpen(string deviceName, OPOSPOSPrinter printer)
        {
            

            try
            {

                int nRet = printer.Open(deviceName);

               
                if (nRet != 0)
                    //throw new Exception($"[Open Error] : {result}");

                nRet = printer.ClaimDevice(5000);
                if (nRet != 0)
                    //throw new Exception($"[Claim Error] : {result}");

                
                printer.DeviceEnabled = true;


                return true;
            }
            catch(Exception ex)
            {
                
                HandleError(ex);
                return false;
            }
        }
        

        public void printerClose(IOPOSPOSPrinter printer)
        {
            try
            {
                printer.DeviceEnabled = false;
                printer.ReleaseDevice();

                int nRet = printer.Close();


            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        public void printCut(IOPOSPOSPrinter printer,int percent)
        {
            try
            {
                printer.CutPaper(percent);
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        private void HandleError(Exception ex)
        {

        }

        public void printBitmap(OPOSPOSPrinter printer,int bitmapNumber,int station, string fileName,int width,int alignment)
        {
            try
            {

                
            }
            catch (Exception ex)
            {

            }
        }

        
    }
}
