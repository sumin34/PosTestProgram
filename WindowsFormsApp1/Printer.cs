using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OposPOSPrinter_CCO;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public class PrinterEventArgs : EventArgs
    {
        public string Message { get; set; }

    }
    public class PrinterCoverEventArgs : EventArgs
    {
        public bool IsOpen { get; set; }

    }
    public delegate void PrinterEventHandler(object sender, PrinterEventArgs e);
    public delegate void PrinterCoverEventHandler(object sender, PrinterCoverEventArgs e);
    public class Printer
    {
        public event PrinterCoverEventHandler PrinterCoverEvent;
        public event EventHandler<PrinterEventArgs> PrinterEvent;

        protected virtual void OnPrinterCoverEvnet(bool isOpen)
        {
            PrinterCoverEvent?.Invoke(this, new PrinterCoverEventArgs { IsOpen = isOpen });
        }
        protected virtual void OnPrinterEvent(string message)
        {
            PrinterEvent?.Invoke(this, new PrinterEventArgs { Message = message });
        }

        private void CheckPrintCoverStatus(IOPOSPOSPrinter printer)
        {
            try
            {
                // Implement logic to check if printer cover is open
                bool isOpen = printer.CapCoverSensor; // Example: Assuming there is a property like PrinterCoverOpen
                OnPrinterCoverEvnet(isOpen);
            }
            catch 
            {
            }
        }

        public void printerOpen(string deviceName, IOPOSPOSPrinter printer)
        {
            try
            {

                int nRet = printer.Open(deviceName);
                string result = Constant.getState((long)nRet);
                if (nRet != 0)
                    throw new Exception($"[Open Error] : {result}");
                OnPrinterEvent($"Open: {result}");

                nRet = printer.ClaimDevice(5000);
                result = Constant.getState((long)nRet);
                if (nRet != 0)
                    throw new Exception($"[Claim Error] : {result}");


                OnPrinterEvent($"ClaimDevice: {result}");

                
                printer.DeviceEnabled = true;
                OnPrinterEvent("DeviceEnabled set to true");

            }
            catch(Exception ex)
            {
                HandleError(ex);
            }
        }

        public void printerClose(IOPOSPOSPrinter printer)
        {
            try
            {
                printer.DeviceEnabled = false;
                printer.ReleaseDevice();

                int nRet = printer.Close();

                OnPrinterEvent($"[Close] : {Constant.getState(nRet)}");

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
                OnPrinterEvent($"Cut paper command sent (percent: {percent})");
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        private void HandleError(Exception ex)
        {
            OnPrinterEvent("failed");
        }

        public void printBitmap(OPOSPOSPrinter printer,int bitmapNumber,int station, string fileName,int width,int alignment)
        {
            try
            {

                printer.SetBitmap(bitmapNumber, station, fileName, width, alignment);
            }
            catch (Exception ex)
            {

            }
        }

    }
}
