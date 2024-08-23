using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OposScanner_CCO;
using Constants;
using WindowsFormsApp1;

namespace Scanner
{
    class Scanner
    {
        OPOSScanner scanner = new OPOSScanner();
        //public delegate void Scanner_DataEvent(int Data);
        //public delegate void Scanner_State(int Data);
        /// <summary>
        /// gpt event 처리//////////////////////////////////////////////////////////////
        /// </summary>
        public delegate void ScannerEventHandler(string decodedData);


        public event ScannerEventHandler DataReceived;

        private Form1 form;
        public Scanner(Form1 form)
        {
            this.form = form;
        }

        public void Scanner_DataEvent(int data)
        {
            // Decode data here
            string decodedData = DecodeData(data);

            //대충 logbox에 나오는 줄
            form.AppendToSDRichTextBox("12341234");
        }

        public string decodeDate()
        {
            string data = scanner.ScanData;
            return data;
        }

        private string DecodeData(int data)
        {
            // Implement your data decoding logic here
            return data.ToString(); // Placeholder for actual decoding
        }

        ///////////////////////////////////////////////////////////////////////////////////
        ///
        //public event Scanner_DataEvent Data_event= null;
        //public event Scanner_State State_event = null;
        int nRet;

        public Scanner()
        {
            scanner.DataEvent += scanner_dataEvent;

        }

        private void scanner_dataEvent(int status)
        {
            try
            {
                string data;
                //scanner.FreezeEvents = false;
                scanner.DecodeData = true;
                data = scanner.ScanData;
                MessageBox.Show(data);
                //scanner.FreezeEvents = true;
            }
            catch
            {
                MessageBox.Show("event failed");
            }
        }

        public string scannerOpen(string deviceName)
        {
            try
            {
                if (scanner == null)
                {
                    return "Scanner object is not initialized.";
                }

                nRet = scanner.Open(deviceName);
                
                return "[" + nRet + "] " + Constant.GetErrorCodeName(nRet);
            }
            catch(Exception ex)
            {
                return $"Scanner Open failed: {ex.Message}";
            }
        }

        public string scannerDE()
        {
            try
            {
                scanner.DeviceEnabled = true;
                
                return "DeviceEnable set true";
            }
            catch (Exception e)
            {
                return "DeviceEnable set failed";
            }
        }

        public string scannerClaim()
        {
            try
            {
                nRet = scanner.ClaimDevice(5000);
                return "[" + nRet + "] "+ Constant.GetErrorCodeName(nRet);
            }
            catch (Exception e)
            {
                return "claimDevice Failed";
            }
        }

        public string scannerClose()
        {
            try
            {
                scanner.DeviceEnabled = false;
                scanner.ReleaseDevice();
                nRet = scanner.Close();
                
                return "scanner close";
            }
            catch (Exception e)
            {
                return "scanner close failed";
            }
        }



    }
}
