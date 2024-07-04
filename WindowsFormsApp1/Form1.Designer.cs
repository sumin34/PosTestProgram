
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
            this.btnOpenDrawer = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSlipPrint = new System.Windows.Forms.Button();
            this.btnTransactionPrint = new System.Windows.Forms.Button();
            this.btnNomalPrint = new System.Windows.Forms.Button();
            this.btnImagePrt = new System.Windows.Forms.Button();
            this.btnImagePrint = new System.Windows.Forms.Button();
            this.btnImageLoad = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richLogBox = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPrinter.SuspendLayout();
            this.groupBoxPrinter.SuspendLayout();
            this.groupBoxDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPrinter);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.groupBoxPrinter.Controls.Add(this.btnOpenDrawer);
            this.groupBoxPrinter.Controls.Add(this.comboBox3);
            this.groupBoxPrinter.Controls.Add(this.comboBox2);
            this.groupBoxPrinter.Controls.Add(this.textBox2);
            this.groupBoxPrinter.Controls.Add(this.label4);
            this.groupBoxPrinter.Controls.Add(this.btnSlipPrint);
            this.groupBoxPrinter.Controls.Add(this.btnTransactionPrint);
            this.groupBoxPrinter.Controls.Add(this.btnNomalPrint);
            this.groupBoxPrinter.Controls.Add(this.btnImagePrt);
            this.groupBoxPrinter.Controls.Add(this.btnImagePrint);
            this.groupBoxPrinter.Controls.Add(this.btnImageLoad);
            this.groupBoxPrinter.Controls.Add(this.textBox1);
            this.groupBoxPrinter.Controls.Add(this.label3);
            this.groupBoxPrinter.Location = new System.Drawing.Point(6, 172);
            this.groupBoxPrinter.Name = "groupBoxPrinter";
            this.groupBoxPrinter.Size = new System.Drawing.Size(792, 194);
            this.groupBoxPrinter.TabIndex = 2;
            this.groupBoxPrinter.TabStop = false;
            this.groupBoxPrinter.Text = "Printer";
            // 
            // btnOpenDrawer
            // 
            this.btnOpenDrawer.Location = new System.Drawing.Point(597, 140);
            this.btnOpenDrawer.Name = "btnOpenDrawer";
            this.btnOpenDrawer.Size = new System.Drawing.Size(157, 33);
            this.btnOpenDrawer.TabIndex = 19;
            this.btnOpenDrawer.Text = "Open Drawer";
            this.btnOpenDrawer.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(396, 88);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(162, 26);
            this.comboBox3.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(248, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(142, 26);
            this.comboBox2.TabIndex = 11;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 28);
            this.textBox1.TabIndex = 10;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richLogBox
            // 
            this.richLogBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.richLogBox.ForeColor = System.Drawing.SystemColors.Window;
            this.richLogBox.Location = new System.Drawing.Point(850, 23);
            this.richLogBox.Name = "richLogBox";
            this.richLogBox.Size = new System.Drawing.Size(316, 636);
            this.richLogBox.TabIndex = 1;
            this.richLogBox.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(759, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 28);
            this.button3.TabIndex = 18;
            this.button3.Text = "???";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 676);
            this.Controls.Add(this.button3);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrinter;
        private System.Windows.Forms.GroupBox groupBoxDevice;
        private System.Windows.Forms.ComboBox comboDeviceName;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImageLoad;
        private System.Windows.Forms.Button btnImagePrint;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSlipPrint;
        private System.Windows.Forms.Button btnTransactionPrint;
        private System.Windows.Forms.Button btnNomalPrint;
        private System.Windows.Forms.Button btnImagePrt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnOpenDrawer;
    }
}

