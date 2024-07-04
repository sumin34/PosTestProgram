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
    public delegate void PrinterEventHandler(object sender, PrinterEventArgs e);

    public class Printer
    {
        public event PrinterEventHandler PrinterEvent;

        protected virtual void OnPrinterEvent(string message)
        {
            PrinterEvent?.Invoke(this, new PrinterEventArgs { Message = message });
        }

        public void printerOpen(string deviceName, IOPOSPOSPrinter printer)
        {
            int nRet;
            //int bRet;
            string result;
            try
            {

                nRet = printer.Open(deviceName);
                result = Constant.getState((long)nRet);
                OnPrinterEvent($"Open: {result}");

                nRet = printer.ClaimDevice(5000);
                result = Constant.getState((long)nRet);
                OnPrinterEvent($"ClaimDevice: {result}");

                printer.DeviceEnabled = true;
                OnPrinterEvent("DeviceEnabled set to true");

            }
            catch(Exception ex)
            {
                OnPrinterEvent($"Error: {ex.Message}");
            }
        }

        public void printerClose(IOPOSPOSPrinter printer)
        {
            int nRet;

            try
            {
                printer.DeviceEnabled = false;
                printer.ReleaseDevice();

                nRet = printer.Close();

                textBoxPrinterState.Text = Constant.getState(nRet);
                richLogBox.AppendText(Constant.getState(nRet) + "\n");

            }
            catch (Exception ex)
            {
                richLogBox.AppendText("[Error]Close Failed");
            }
        }


    }
}
