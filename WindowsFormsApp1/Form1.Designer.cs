
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrinter = new System.Windows.Forms.TabPage();
            this.groupBoxPrinter = new System.Windows.Forms.GroupBox();
            this.btnPrtBarcode = new System.Windows.Forms.Button();
            this.btnOpenDrawer = new System.Windows.Forms.Button();
            this.comboBarcodeType = new System.Windows.Forms.ComboBox();
            this.comboBCPosition = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSlipPrint = new System.Windows.Forms.Button();
            this.btnTransactionPrint = new System.Windows.Forms.Button();
            this.btnNomalPrint = new System.Windows.Forms.Button();
            this.btnImagePrt = new System.Windows.Forms.Button();
            this.btnImagePrint = new System.Windows.Forms.Button();
            this.btnImageLoad = new System.Windows.Forms.Button();
            this.boxBarcodeNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxDevice = new System.Windows.Forms.GroupBox();
            this.btnFullCut = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelBitmap = new System.Windows.Forms.Button();
            this.textBoxPrinterState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboDeviceName = new System.Windows.Forms.ComboBox();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.tabScanner = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.richSDBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnScannerClose = new System.Windows.Forms.Button();
            this.btnDEScanner = new System.Windows.Forms.Button();
            this.btnCDScanner = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnScannerOpen = new System.Windows.Forms.Button();
            this.comboBoxScanner = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCloseCD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDECD = new System.Windows.Forms.Button();
            this.comboBoxCD = new System.Windows.Forms.ComboBox();
            this.btnCDOpen = new System.Windows.Forms.Button();
            this.richLogBox = new System.Windows.Forms.RichTextBox();
            this.btnClearLogBox = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPrinter.SuspendLayout();
            this.groupBoxPrinter.SuspendLayout();
            this.groupBoxDevice.SuspendLayout();
            this.tabScanner.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPrinter);
            this.tabControl1.Controls.Add(this.tabScanner);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(21, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 652);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPrinter
            // 
            this.tabPrinter.Controls.Add(this.groupBoxPrinter);
            this.tabPrinter.Controls.Add(this.groupBoxDevice);
            this.tabPrinter.Location = new System.Drawing.Point(4, 28);
            this.tabPrinter.Name = "tabPrinter";
            this.tabPrinter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrinter.Size = new System.Drawing.Size(804, 620);
            this.tabPrinter.TabIndex = 0;
            this.tabPrinter.Text = "Printer";
            this.tabPrinter.UseVisualStyleBackColor = true;
            // 
            // groupBoxPrinter
            // 
            this.groupBoxPrinter.Controls.Add(this.btnPrtBarcode);
            this.groupBoxPrinter.Controls.Add(this.btnOpenDrawer);
            this.groupBoxPrinter.Controls.Add(this.comboBarcodeType);
            this.groupBoxPrinter.Controls.Add(this.comboBCPosition);
            this.groupBoxPrinter.Controls.Add(this.textBox2);
            this.groupBoxPrinter.Controls.Add(this.label4);
            this.groupBoxPrinter.Controls.Add(this.btnSlipPrint);
            this.groupBoxPrinter.Controls.Add(this.btnTransactionPrint);
            this.groupBoxPrinter.Controls.Add(this.btnNomalPrint);
            this.groupBoxPrinter.Controls.Add(this.btnImagePrt);
            this.groupBoxPrinter.Controls.Add(this.btnImagePrint);
            this.groupBoxPrinter.Controls.Add(this.btnImageLoad);
            this.groupBoxPrinter.Controls.Add(this.boxBarcodeNum);
            this.groupBoxPrinter.Controls.Add(this.label3);
            this.groupBoxPrinter.Location = new System.Drawing.Point(6, 172);
            this.groupBoxPrinter.Name = "groupBoxPrinter";
            this.groupBoxPrinter.Size = new System.Drawing.Size(792, 194);
            this.groupBoxPrinter.TabIndex = 2;
            this.groupBoxPrinter.TabStop = false;
            this.groupBoxPrinter.Text = "Printer";
            // 
            // btnPrtBarcode
            // 
            this.btnPrtBarcode.Location = new System.Drawing.Point(647, 91);
            this.btnPrtBarcode.Name = "btnPrtBarcode";
            this.btnPrtBarcode.Size = new System.Drawing.Size(139, 25);
            this.btnPrtBarcode.TabIndex = 3;
            this.btnPrtBarcode.Text = "PrtBarcode";
            this.btnPrtBarcode.UseVisualStyleBackColor = true;
            this.btnPrtBarcode.Click += new System.EventHandler(this.btnPrtBarcode_Click);
            // 
            // btnOpenDrawer
            // 
            this.btnOpenDrawer.Location = new System.Drawing.Point(597, 140);
            this.btnOpenDrawer.Name = "btnOpenDrawer";
            this.btnOpenDrawer.Size = new System.Drawing.Size(157, 33);
            this.btnOpenDrawer.TabIndex = 19;
            this.btnOpenDrawer.Text = "Open Drawer";
            this.btnOpenDrawer.UseVisualStyleBackColor = true;
            this.btnOpenDrawer.Click += new System.EventHandler(this.btnOpenDrawer_Click);
            // 
            // comboBarcodeType
            // 
            this.comboBarcodeType.FormattingEnabled = true;
            this.comboBarcodeType.Location = new System.Drawing.Point(396, 88);
            this.comboBarcodeType.Name = "comboBarcodeType";
            this.comboBarcodeType.Size = new System.Drawing.Size(162, 26);
            this.comboBarcodeType.TabIndex = 18;
            // 
            // comboBCPosition
            // 
            this.comboBCPosition.FormattingEnabled = true;
            this.comboBCPosition.Location = new System.Drawing.Point(248, 90);
            this.comboBCPosition.Name = "comboBCPosition";
            this.comboBCPosition.Size = new System.Drawing.Size(142, 26);
            this.comboBCPosition.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(652, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 28);
            this.textBox2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Item Count";
            // 
            // btnSlipPrint
            // 
            this.btnSlipPrint.Location = new System.Drawing.Point(524, 27);
            this.btnSlipPrint.Name = "btnSlipPrint";
            this.btnSlipPrint.Size = new System.Drawing.Size(122, 55);
            this.btnSlipPrint.TabIndex = 16;
            this.btnSlipPrint.Text = "Slip Print";
            this.btnSlipPrint.UseVisualStyleBackColor = true;
            // 
            // btnTransactionPrint
            // 
            this.btnTransactionPrint.Location = new System.Drawing.Point(358, 27);
            this.btnTransactionPrint.Name = "btnTransactionPrint";
            this.btnTransactionPrint.Size = new System.Drawing.Size(160, 55);
            this.btnTransactionPrint.TabIndex = 15;
            this.btnTransactionPrint.Text = "Transaction Mode Print";
            this.btnTransactionPrint.UseVisualStyleBackColor = true;
            this.btnTransactionPrint.Click += new System.EventHandler(this.btnTransactionPrint_Click);
            // 
            // btnNomalPrint
            // 
            this.btnNomalPrint.Location = new System.Drawing.Point(217, 27);
            this.btnNomalPrint.Name = "btnNomalPrint";
            this.btnNomalPrint.Size = new System.Drawing.Size(135, 55);
            this.btnNomalPrint.TabIndex = 14;
            this.btnNomalPrint.Text = "Nomal Mode Print";
            this.btnNomalPrint.UseVisualStyleBackColor = true;
            this.btnNomalPrint.Click += new System.EventHandler(this.btnNomalPrint_Click);
            // 
            // btnImagePrt
            // 
            this.btnImagePrt.Location = new System.Drawing.Point(144, 27);
            this.btnImagePrt.Name = "btnImagePrt";
            this.btnImagePrt.Size = new System.Drawing.Size(67, 55);
            this.btnImagePrt.TabIndex = 13;
            this.btnImagePrt.Text = "Image Prt";
            this.btnImagePrt.UseVisualStyleBackColor = true;
            // 
            // btnImagePrint
            // 
            this.btnImagePrint.Location = new System.Drawing.Point(80, 27);
            this.btnImagePrint.Name = "btnImagePrint";
            this.btnImagePrint.Size = new System.Drawing.Size(67, 55);
            this.btnImagePrint.TabIndex = 12;
            this.btnImagePrint.Text = "Image Print";
            this.btnImagePrint.UseVisualStyleBackColor = true;
            this.btnImagePrint.Click += new System.EventHandler(this.btnImagePrint_Click);
            // 
            // btnImageLoad
            // 
            this.btnImageLoad.Location = new System.Drawing.Point(6, 27);
            this.btnImageLoad.Name = "btnImageLoad";
            this.btnImageLoad.Size = new System.Drawing.Size(77, 55);
            this.btnImageLoad.TabIndex = 11;
            this.btnImageLoad.Text = "Image  Load";
            this.btnImageLoad.UseVisualStyleBackColor = true;
            this.btnImageLoad.Click += new System.EventHandler(this.btnImageLoad_Click);
            // 
            // boxBarcodeNum
            // 
            this.boxBarcodeNum.Location = new System.Drawing.Point(6, 88);
            this.boxBarcodeNum.Name = "boxBarcodeNum";
            this.boxBarcodeNum.Size = new System.Drawing.Size(236, 28);
            this.boxBarcodeNum.TabIndex = 10;
            this.boxBarcodeNum.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "OPOS CNT: ";
            // 
            // groupBoxDevice
            // 
            this.groupBoxDevice.Controls.Add(this.btnFullCut);
            this.groupBoxDevice.Controls.Add(this.comboBox1);
            this.groupBoxDevice.Controls.Add(this.label2);
            this.groupBoxDevice.Controls.Add(this.btnClose);
            this.groupBoxDevice.Controls.Add(this.button2);
            this.groupBoxDevice.Controls.Add(this.btnDelBitmap);
            this.groupBoxDevice.Controls.Add(this.textBoxPrinterState);
            this.groupBoxDevice.Controls.Add(this.label1);
            this.groupBoxDevice.Controls.Add(this.buttonOpen);
            this.groupBoxDevice.Controls.Add(this.comboDeviceName);
            this.groupBoxDevice.Controls.Add(this.labelDeviceName);
            this.groupBoxDevice.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDevice.Name = "groupBoxDevice";
            this.groupBoxDevice.Size = new System.Drawing.Size(792, 160);
            this.groupBoxDevice.TabIndex = 1;
            this.groupBoxDevice.TabStop = false;
            this.groupBoxDevice.Text = "Device";
            // 
            // btnFullCut
            // 
            this.btnFullCut.Location = new System.Drawing.Point(385, 120);
            this.btnFullCut.Name = "btnFullCut";
            this.btnFullCut.Size = new System.Drawing.Size(201, 30);
            this.btnFullCut.TabIndex = 10;
            this.btnFullCut.Text = "full cut";
            this.btnFullCut.UseVisualStyleBackColor = true;
            this.btnFullCut.Click += new System.EventHandler(this.btnFullCut_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 26);
            this.comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "OPOS CNT: ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(626, 64);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "Firmware   UpDate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelBitmap
            // 
            this.btnDelBitmap.Location = new System.Drawing.Point(376, 58);
            this.btnDelBitmap.Name = "btnDelBitmap";
            this.btnDelBitmap.Size = new System.Drawing.Size(102, 55);
            this.btnDelBitmap.TabIndex = 5;
            this.btnDelBitmap.Text = "Bitmap   삭제";
            this.btnDelBitmap.UseVisualStyleBackColor = true;
            this.btnDelBitmap.Click += new System.EventHandler(this.btnDelBitmap_Click);
            // 
            // textBoxPrinterState
            // 
            this.textBoxPrinterState.Location = new System.Drawing.Point(134, 64);
            this.textBoxPrinterState.Name = "textBoxPrinterState";
            this.textBoxPrinterState.Size = new System.Drawing.Size(236, 28);
            this.textBoxPrinterState.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "DeviceState: ";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(626, 21);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(160, 35);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // comboDeviceName
            // 
            this.comboDeviceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDeviceName.FormattingEnabled = true;
            this.comboDeviceName.Location = new System.Drawing.Point(134, 26);
            this.comboDeviceName.Name = "comboDeviceName";
            this.comboDeviceName.Size = new System.Drawing.Size(486, 26);
            this.comboDeviceName.TabIndex = 1;
            this.comboDeviceName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.Location = new System.Drawing.Point(17, 29);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(121, 18);
            this.labelDeviceName.TabIndex = 0;
            this.labelDeviceName.Text = "DeviceName: ";
            // 
            // tabScanner
            // 
            this.tabScanner.Controls.Add(this.groupBox2);
            this.tabScanner.Controls.Add(this.groupBox1);
            this.tabScanner.Location = new System.Drawing.Point(4, 28);
            this.tabScanner.Name = "tabScanner";
            this.tabScanner.Padding = new System.Windows.Forms.Padding(3);
            this.tabScanner.Size = new System.Drawing.Size(804, 620);
            this.tabScanner.TabIndex = 1;
            this.tabScanner.Text = "Scanner";
            this.tabScanner.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.richSDBox);
            this.groupBox2.Location = new System.Drawing.Point(16, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 330);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ScannerData";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(524, 283);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(236, 31);
            this.button6.TabIndex = 1;
            this.button6.Text = "Clear Log";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // richSDBox
            // 
            this.richSDBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.richSDBox.ForeColor = System.Drawing.SystemColors.Window;
            this.richSDBox.Location = new System.Drawing.Point(18, 27);
            this.richSDBox.Name = "richSDBox";
            this.richSDBox.Size = new System.Drawing.Size(742, 250);
            this.richSDBox.TabIndex = 0;
            this.richSDBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnScannerClose);
            this.groupBox1.Controls.Add(this.btnDEScanner);
            this.groupBox1.Controls.Add(this.btnCDScanner);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnScannerOpen);
            this.groupBox1.Controls.Add(this.comboBoxScanner);
            this.groupBox1.Location = new System.Drawing.Point(16, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // btnScannerClose
            // 
            this.btnScannerClose.Location = new System.Drawing.Point(587, 91);
            this.btnScannerClose.Name = "btnScannerClose";
            this.btnScannerClose.Size = new System.Drawing.Size(184, 35);
            this.btnScannerClose.TabIndex = 22;
            this.btnScannerClose.Text = "Close";
            this.btnScannerClose.UseVisualStyleBackColor = true;
            this.btnScannerClose.Click += new System.EventHandler(this.btnScannerClose_Click);
            // 
            // btnDEScanner
            // 
            this.btnDEScanner.Location = new System.Drawing.Point(396, 80);
            this.btnDEScanner.Name = "btnDEScanner";
            this.btnDEScanner.Size = new System.Drawing.Size(184, 46);
            this.btnDEScanner.TabIndex = 21;
            this.btnDEScanner.Text = "DeviceEnable";
            this.btnDEScanner.UseVisualStyleBackColor = true;
            this.btnDEScanner.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCDScanner
            // 
            this.btnCDScanner.Location = new System.Drawing.Point(207, 80);
            this.btnCDScanner.Name = "btnCDScanner";
            this.btnCDScanner.Size = new System.Drawing.Size(183, 46);
            this.btnCDScanner.TabIndex = 20;
            this.btnCDScanner.Text = "ClaimDevice";
            this.btnCDScanner.UseVisualStyleBackColor = true;
            this.btnCDScanner.Click += new System.EventHandler(this.btnCDScanner_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "DeviceName  :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnScannerOpen
            // 
            this.btnScannerOpen.Location = new System.Drawing.Point(587, 40);
            this.btnScannerOpen.Name = "btnScannerOpen";
            this.btnScannerOpen.Size = new System.Drawing.Size(183, 35);
            this.btnScannerOpen.TabIndex = 1;
            this.btnScannerOpen.Text = "Open";
            this.btnScannerOpen.UseVisualStyleBackColor = true;
            this.btnScannerOpen.Click += new System.EventHandler(this.btnScannerOpen_Click);
            // 
            // comboBoxScanner
            // 
            this.comboBoxScanner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScanner.FormattingEnabled = true;
            this.comboBoxScanner.Location = new System.Drawing.Point(207, 45);
            this.comboBoxScanner.Name = "comboBoxScanner";
            this.comboBoxScanner.Size = new System.Drawing.Size(364, 26);
            this.comboBoxScanner.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 620);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "CashDrawer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCloseCD);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnDECD);
            this.groupBox3.Controls.Add(this.comboBoxCD);
            this.groupBox3.Controls.Add(this.btnCDOpen);
            this.groupBox3.Location = new System.Drawing.Point(19, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 153);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Device";
            // 
            // btnCloseCD
            // 
            this.btnCloseCD.Location = new System.Drawing.Point(498, 81);
            this.btnCloseCD.Name = "btnCloseCD";
            this.btnCloseCD.Size = new System.Drawing.Size(146, 52);
            this.btnCloseCD.TabIndex = 20;
            this.btnCloseCD.Text = "Close";
            this.btnCloseCD.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "DeviceName : ";
            // 
            // btnDECD
            // 
            this.btnDECD.Location = new System.Drawing.Point(328, 81);
            this.btnDECD.Name = "btnDECD";
            this.btnDECD.Size = new System.Drawing.Size(155, 52);
            this.btnDECD.TabIndex = 4;
            this.btnDECD.Text = "DeviceEnable";
            this.btnDECD.UseVisualStyleBackColor = true;
            this.btnDECD.Click += new System.EventHandler(this.btnDECD_Click);
            // 
            // comboBoxCD
            // 
            this.comboBoxCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCD.FormattingEnabled = true;
            this.comboBoxCD.Location = new System.Drawing.Point(158, 35);
            this.comboBoxCD.Name = "comboBoxCD";
            this.comboBoxCD.Size = new System.Drawing.Size(431, 26);
            this.comboBoxCD.TabIndex = 1;
            // 
            // btnCDOpen
            // 
            this.btnCDOpen.Location = new System.Drawing.Point(608, 32);
            this.btnCDOpen.Name = "btnCDOpen";
            this.btnCDOpen.Size = new System.Drawing.Size(141, 31);
            this.btnCDOpen.TabIndex = 2;
            this.btnCDOpen.Text = "Open";
            this.btnCDOpen.UseVisualStyleBackColor = true;
            this.btnCDOpen.Click += new System.EventHandler(this.btnCDOpen_Click);
            // 
            // richLogBox
            // 
            this.richLogBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.richLogBox.ForeColor = System.Drawing.SystemColors.Window;
            this.richLogBox.Location = new System.Drawing.Point(850, 40);
            this.richLogBox.Name = "richLogBox";
            this.richLogBox.Size = new System.Drawing.Size(316, 581);
            this.richLogBox.TabIndex = 1;
            this.richLogBox.Text = "";
            this.richLogBox.TextChanged += new System.EventHandler(this.richLogBox_TextChanged_1);
            // 
            // btnClearLogBox
            // 
            this.btnClearLogBox.Location = new System.Drawing.Point(851, 631);
            this.btnClearLogBox.Name = "btnClearLogBox";
            this.btnClearLogBox.Size = new System.Drawing.Size(314, 32);
            this.btnClearLogBox.TabIndex = 19;
            this.btnClearLogBox.Text = "Clear Log";
            this.btnClearLogBox.UseVisualStyleBackColor = true;
            this.btnClearLogBox.Click += new System.EventHandler(this.btnClearLogBox_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "decodeData";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 680);
            this.Controls.Add(this.btnClearLogBox);
            this.Controls.Add(this.richLogBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPrinter.ResumeLayout(false);
            this.groupBoxPrinter.ResumeLayout(false);
            this.groupBoxPrinter.PerformLayout();
            this.groupBoxDevice.ResumeLayout(false);
            this.groupBoxDevice.PerformLayout();
            this.tabScanner.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrinter;
        private System.Windows.Forms.GroupBox groupBoxDevice;
        private System.Windows.Forms.ComboBox comboDeviceName;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.TabPage tabScanner;
        private System.Windows.Forms.RichTextBox richLogBox;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPrinter;
        private System.Windows.Forms.Button btnFullCut;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelBitmap;
        private System.Windows.Forms.TextBox textBoxPrinterState;
        private System.Windows.Forms.TextBox boxBarcodeNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImageLoad;
        private System.Windows.Forms.Button btnImagePrint;
        private System.Windows.Forms.ComboBox comboBarcodeType;
        private System.Windows.Forms.ComboBox comboBCPosition;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSlipPrint;
        private System.Windows.Forms.Button btnTransactionPrint;
        private System.Windows.Forms.Button btnNomalPrint;
        private System.Windows.Forms.Button btnImagePrt;
        private System.Windows.Forms.Button btnOpenDrawer;
        private System.Windows.Forms.Button btnPrtBarcode;
        private System.Windows.Forms.Button btnClearLogBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxScanner;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDEScanner;
        private System.Windows.Forms.Button btnCDScanner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnScannerOpen;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richSDBox;
        private System.Windows.Forms.Button btnScannerClose;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCDOpen;
        private System.Windows.Forms.ComboBox comboBoxCD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCloseCD;
        private System.Windows.Forms.Button btnDECD;
        private System.Windows.Forms.Button button1;
    }
}

