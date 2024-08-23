using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OposPOSPrinter_CCO;
using OposCashDrawer_CCO;
using OposScanner_CCO;
using Constants;
using Printer;
using Drawer;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        const int PTR_S_RECEIPT = 2;

        const int PTR_TP_TRANSACTION = 11;
        const int PTR_TP_NORMAL = 12;

        
        //OPOSPOSPrinter printer = new OPOSPOSPrinter();
        OPOSPOSPrinter printer = new OPOSPOSPrinter();
        OPOSCashDrawer drawer = new OPOSCashDrawer();
        //private Printer _printer;
        PrinterCtr _printer = new PrinterCtr();
        Scanner.Scanner _scanner;
        Drawer.Drawer _drawer = new Drawer.Drawer();
        
        String deviceName;
        const string printerRegPath = @"SOFTWARE\oleforretail\ServiceOPOS\POSPrinter";
        const string scannerRegPath = @"SOFTWARE\WOW6432Node\oleforretail\ServiceOPOS\Scanner";
        const string cdRegPath = @"SOFTWARE\WOW6432Node\oleforretail\ServiceOPOS\CashDrawer";

        private Bitmap imageToPrint;
        string imagePath;
        bool bRet = false;
        public Form1()
        {
            InitializeComponent();
            _scanner = new Scanner.Scanner(this);
            //_printer = Printer.PrinterCtr;
            //Printer.PrinterCtr.PrinterEvent() += OnPrinterEvent;
            //////////////////////////////////////////////////////////////////////////////////
            ///gpt 이벤트 구독
            _scanner.DataReceived += OnScannerDataReceived;
            //////////////////////////////////////////////////////////////////////////////////////
            updateComboboxRegList("DefaultPOSPrinter", printerRegPath,comboDeviceName);
            updateComboboxRegList("DefaultScanner", scannerRegPath, comboBoxScanner);
            updateComboboxRegList("DefaultCashDrawer", cdRegPath, comboBoxCD);
        }

        /// <summary>
        /// gpt////////////////////////////////////////////////////////////////////////////
        /// 
        /// </summary>
        /// 

        private void OnScannerDataReceived(string decodedData)
        {
            // Ensure this is called on the UI thread
            if (InvokeRequired)
            {
                Invoke(new Action<string>(OnScannerDataReceived), decodedData);
            }
            else
            {
                richSDBox.AppendText(decodedData);
            }
        }
        
    /// <summary>
    /// ///////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    private void InitializePrinter()
        {

        }

        private void OnPrinterEvent(object sender)
        {
            if (richLogBox.InvokeRequired)
            {
               // richLogBox.Invoke(new Action<string>(AppendToRichTextBox), e.Message);
            }
            else
            {
                //AppendToRichTextBox(e.Message);
            }
        }

        public void AppendToRichTextBox(string message)
        {
            richLogBox.AppendText(message + Environment.NewLine);
        }

        public void AppendToSDRichTextBox(string message)
        {
            richSDBox.AppendText(message + Environment.NewLine);
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            bool bRet;
            deviceName = comboDeviceName.Text;
            
            bRet = _printer.printerOpen(deviceName, printer);
            
            if (bRet)
                InitializePrinter();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboDeviceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void richLogBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            deviceName = comboDeviceName.Text;
            _printer.printerClose(printer);
            

        }

        private void btnDelBitmap_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFullCut_Click(object sender, EventArgs e)
        {
            try
            {
                _printer.printCut(printer,100);
            }
            catch (Exception)
            {

            }
        }

        private void btnImageLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                try
                {
                    open.Filter = "Image Files|*.bmp";
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        printer.SetBitmap(1, PTR_S_RECEIPT, open.FileName,512,(int)Constant.PTR_BC_CENTER);
                    }
                }
                finally
                {
                    if (open != null)
                        open.Dispose();
                }
            }
            printer.SetBitmap(1, 0, "", 512, 0);
            printer.PrintNormal(0, "");


            printer.PrintBitmap(0, "", 512, 0);

            /*using (OpenFileDialog open = new OpenFileDialog())
            {
                open.
            }*/
            File.OpenImageFile();

        }

        public Bitmap LoadBitmapFromDisk(string filePath)
        {
            Bitmap bitmap = null;
            try
            {
                bitmap = new Bitmap(filePath);
            }
            catch (Exception ex)
            {
                richLogBox.AppendText($"Failed to load bitmap from {filePath}: {ex.Message}");
            }
            return bitmap;
        }



        private void btnNomalPrint_Click(object sender, EventArgs e)
        {
            try
            {
                //printer.TransactionPrint(PTR_S_RECEIPT,PTR_TP_TRANSACTION);
                printer.PrintNormal(PTR_S_RECEIPT, "test");
                printer.PrintNormal(PTR_S_RECEIPT, "12345678901234567890123456789012345678901234567890");
                //printer.TransactionPrint(PTR_S_RECEIPT,PTR_TP_NORMAL);
                printer.CutPaper(95);

            }
            catch
            {
                AppendToRichTextBox("\n프린트 실패");
            }
        }

        

        public bool PrinterOpen(OPOSPOSPrinter OposPrinter)
        {
            int nRet;
            string devicename = comboDeviceName.Text;
            try
            {
                nRet = printer.Open(devicename);
                if (nRet != 0)
                {
                    MessageBox.Show("Printer Open Error");
                    return bRet;
                }
                nRet = printer.ClaimDevice(5000);
                if (nRet != 0)
                {
                    MessageBox.Show("Printer Claim Error");
                    return bRet;
                }
                printer.DeviceEnabled = true;
                nRet = printer.ResultCode;
                if (nRet != 0)
                {
                    MessageBox.Show("Printer DeviceEnable Error");
                    return bRet;
                }

                bRet = true;
                return bRet;
            }
            catch (Exception ex)
            {
                return bRet;
                AppendToRichTextBox("[Exception]Open failed");
            }
        }
        public bool PrinterClose(OPOSPOSPrinter OposPrinter)
        {
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOpenDrawer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnImagePrint_Click(object sender, EventArgs e)
        {
            try
            {
                int bitmapNumber = 1;
                _printer.printBitmap(printer, bitmapNumber, PTR_S_RECEIPT, imagePath, (int)Constant.PTR_BM_ASIS, (int)Constant.PTR_BM_CENTER);
            }
            catch (Exception ex)
            {

            }
        }

        private void Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrtBarcode_Click(object sender, EventArgs e)
        {
            try
            {
                /*int textPosition = comboBCPosition.Text;
                printer.PrintBarCode(PTR_S_RECEIPT, boxBarcodeNum.Text, ,textPosition);*/
            }
            catch (Exception ex)
            {

            }
        }

        private void btnTransactionPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printer.TransactionPrint(PTR_S_RECEIPT,PTR_TP_TRANSACTION);
                printer.PrintNormal(PTR_S_RECEIPT, "test");
                printer.PrintNormal(PTR_S_RECEIPT, "12345678901234567890123456789012345678901234567890");
                printer.TransactionPrint(PTR_S_RECEIPT,PTR_TP_NORMAL);
                printer.CutPaper(95);
            }
            catch
            {
                AppendToRichTextBox("\n프린트 실패");
            }
        }

        private void btnClearLogBox_Click(object sender, EventArgs e)
        {
            try
            {
                richLogBox.Clear();
            }
            catch (Exception)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void richLogBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendToRichTextBox(_scanner.scannerDE());
        }


        private void btnCDOpen_Click(object sender, EventArgs e)
        {
            
        }

        private void updateComboboxRegList(string defaultName, string regPath,ComboBox comboBox)
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regPath))
            {
                comboBox.Items.Add(defaultName);
                comboBox.SelectedIndex = 0;
                if (key != null)
                {
                    foreach (string name in key.GetSubKeyNames())
                        comboBox.Items.Add(name);
                }
                else
                {
                    AppendToRichTextBox("Registry key not found");
                    Console.WriteLine("Registry key not found");
                }
            }
        }

        private void btnDECD_Click(object sender, EventArgs e)
        {
            try
            {

            } catch (Exception ex) {
                     
            }
        }

        private void btnScannerOpen_Click(object sender, EventArgs e)
        {
            int nRet;
            string sRet;
            deviceName = comboBoxScanner.Text;
           
            sRet = _scanner.scannerOpen(deviceName);
            AppendToRichTextBox(sRet);
        }

        private void btnCDScanner_Click(object sender, EventArgs e)
        {
            int nRet;
            deviceName = comboBoxScanner.Text;
            AppendToRichTextBox(_scanner.scannerClaim());
        }

        private void btnScannerClose_Click(object sender, EventArgs e)
        {
            _scanner.scannerClose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int test = 111;

            _scanner.Scanner_DataEvent(test);
            
        }
    }
}
