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
using System.Drawing;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        const int PTR_S_RECEIPT = 2;

        const int PTR_TP_TRANSACTION = 11;
        const int PTR_TP_NORMAL = 12;



        //OPOSPOSPrinter printer = new OPOSPOSPrinter();
        OPOSPOSPrinter printer = new OPOSPOSPrinter();
        private Printer _printer;
        String deviceName;
        const string registryPath = @"SOFTWARE\oleforretail\ServiceOPOS\POSPrinter";
        private Bitmap imageToPrint;
        string imagePath;
        bool bRet = false;

        public Form1()
        {
            InitializeComponent();
            LoadDeviceNames();
            _printer = new Printer();
            _printer.PrinterEvent += OnPrinterEvent;
        }

        private void OnPrinterEvent(object sender, PrinterEventArgs e)
        {
            if (richLogBox.InvokeRequired)
            {
                richLogBox.Invoke(new Action<string>(AppendToRichTextBox), e.Message);
            }
            else
            {
                AppendToRichTextBox(e.Message);
            }
        }

        private void AppendToRichTextBox(string message)
        {
            richLogBox.AppendText(message + Environment.NewLine);
        }


        private void LoadDeviceNames()
        {
            deviceName = "DefaultPOSPrinter";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath))
            {
                comboDeviceName.Items.Add(deviceName);
                comboDeviceName.SelectedIndex = 0;
                if (key != null)
                {
                    foreach (string name in key.GetSubKeyNames())
                        comboDeviceName.Items.Add(name);
                }
                else
                {
                    Console.WriteLine("Registry key not found");
                }
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            deviceName = comboDeviceName.Text;
            _printer.printerOpen(deviceName, printer);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
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
                        imagePath = open.FileName;
                        //하드에 저장

                        Bitmap bitmap = LoadBitmapFromDisk(imagePath);

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
                printer.TransactionPrint(PTR_S_RECEIPT,PTR_TP_TRANSACTION);
                printer.PrintNormal(PTR_S_RECEIPT, "test");
                printer.PrintNormal(PTR_S_RECEIPT, "12345678901234567890123456789012345678901234567890");
                printer.TransactionPrint(PTR_S_RECEIPT,PTR_TP_NORMAL);
            }
            catch
            {
                richLogBox.AppendText("\n프린트 실패");
            }
        }

        

        public bool PrinterOpen(OPOSPOSPrinter OposPrinter)
        {
            int nRet;
            string devicename = comboDeviceName.Text;
            try
            {
                nRet = printer.Open(devicename);
                textBoxPrinterState.Text = Constant.getState(nRet);
                if (nRet != 0)
                {
                    MessageBox.Show("Printer Open Error");
                    return bRet;
                }
                nRet = printer.ClaimDevice(5000);
                textBoxPrinterState.Text = Constant.getState(nRet);
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
                richLogBox.AppendText("[Exception]Open failed");
            }
        }
        public bool PrinterClose(OPOSPOSPrinter OposPrinter)
        {
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
