namespace NYPFinalProje
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listUrun = new System.Windows.Forms.ListBox();
            this.btnSatınAl = new System.Windows.Forms.Button();
            this.lblUrunAdetBilgi = new System.Windows.Forms.Label();
            this.txtUrunAdetBilgi = new System.Windows.Forms.TextBox();
            this.lblUrunSec = new System.Windows.Forms.Label();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.btnUrunSat = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnKarGoruntule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richHesapOzeti = new System.Windows.Forms.RichTextBox();
            this.richKar = new System.Windows.Forms.RichTextBox();
            this.ımageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.tabControl1.Location = new System.Drawing.Point(6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1046, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage2.Controls.Add(this.ımageSlider1);
            this.tabPage2.Controls.Add(this.richHesapOzeti);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listUrun);
            this.tabPage2.Controls.Add(this.btnSatınAl);
            this.tabPage2.Controls.Add(this.lblUrunAdetBilgi);
            this.tabPage2.Controls.Add(this.txtUrunAdetBilgi);
            this.tabPage2.Controls.Add(this.lblUrunSec);
            this.tabPage2.Controls.Add(this.cmbUrunler);
            this.tabPage2.Controls.Add(this.btnUrunSat);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1038, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Urun Sat";
            // 
            // listUrun
            // 
            this.listUrun.FormattingEnabled = true;
            this.listUrun.ItemHeight = 23;
            this.listUrun.Location = new System.Drawing.Point(65, 272);
            this.listUrun.Name = "listUrun";
            this.listUrun.Size = new System.Drawing.Size(436, 165);
            this.listUrun.TabIndex = 8;
            // 
            // btnSatınAl
            // 
            this.btnSatınAl.Location = new System.Drawing.Point(330, 159);
            this.btnSatınAl.Name = "btnSatınAl";
            this.btnSatınAl.Size = new System.Drawing.Size(146, 57);
            this.btnSatınAl.TabIndex = 7;
            this.btnSatınAl.Text = "Satın Al";
            this.btnSatınAl.UseVisualStyleBackColor = true;
            this.btnSatınAl.Click += new System.EventHandler(this.btnSatınAl_Click);
            // 
            // lblUrunAdetBilgi
            // 
            this.lblUrunAdetBilgi.AutoSize = true;
            this.lblUrunAdetBilgi.Location = new System.Drawing.Point(119, 72);
            this.lblUrunAdetBilgi.Name = "lblUrunAdetBilgi";
            this.lblUrunAdetBilgi.Size = new System.Drawing.Size(93, 20);
            this.lblUrunAdetBilgi.TabIndex = 4;
            this.lblUrunAdetBilgi.Text = "Urun Adet";
            // 
            // txtUrunAdetBilgi
            // 
            this.txtUrunAdetBilgi.Location = new System.Drawing.Point(305, 69);
            this.txtUrunAdetBilgi.Name = "txtUrunAdetBilgi";
            this.txtUrunAdetBilgi.Size = new System.Drawing.Size(121, 27);
            this.txtUrunAdetBilgi.TabIndex = 3;
            // 
            // lblUrunSec
            // 
            this.lblUrunSec.AutoSize = true;
            this.lblUrunSec.Location = new System.Drawing.Point(119, 31);
            this.lblUrunSec.Name = "lblUrunSec";
            this.lblUrunSec.Size = new System.Drawing.Size(87, 20);
            this.lblUrunSec.TabIndex = 2;
            this.lblUrunSec.Text = "Urun Sec";
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(305, 24);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(121, 31);
            this.cmbUrunler.TabIndex = 1;
            // 
            // btnUrunSat
            // 
            this.btnUrunSat.Location = new System.Drawing.Point(122, 159);
            this.btnUrunSat.Name = "btnUrunSat";
            this.btnUrunSat.Size = new System.Drawing.Size(137, 57);
            this.btnUrunSat.TabIndex = 0;
            this.btnUrunSat.Text = "Sepete Ekle";
            this.btnUrunSat.UseVisualStyleBackColor = true;
            this.btnUrunSat.Click += new System.EventHandler(this.btnUrunSat_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage3.Controls.Add(this.richKar);
            this.tabPage3.Controls.Add(this.btnKarGoruntule);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1038, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kâr Görüntüle";
            // 
            // btnKarGoruntule
            // 
            this.btnKarGoruntule.Location = new System.Drawing.Point(74, 64);
            this.btnKarGoruntule.Name = "btnKarGoruntule";
            this.btnKarGoruntule.Size = new System.Drawing.Size(154, 50);
            this.btnKarGoruntule.TabIndex = 0;
            this.btnKarGoruntule.Text = "Kar Görüntüle";
            this.btnKarGoruntule.UseVisualStyleBackColor = true;
            this.btnKarGoruntule.Click += new System.EventHandler(this.btnKarGoruntule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hesap Özeti";
            // 
            // richHesapOzeti
            // 
            this.richHesapOzeti.Location = new System.Drawing.Point(627, 258);
            this.richHesapOzeti.Name = "richHesapOzeti";
            this.richHesapOzeti.Size = new System.Drawing.Size(346, 178);
            this.richHesapOzeti.TabIndex = 10;
            this.richHesapOzeti.Text = "";
            // 
            // richKar
            // 
            this.richKar.Location = new System.Drawing.Point(288, 64);
            this.richKar.Name = "richKar";
            this.richKar.Size = new System.Drawing.Size(370, 141);
            this.richKar.TabIndex = 1;
            this.richKar.Text = "";
            // 
            // ımageSlider1
            // 
            this.ımageSlider1.AllowLooping = true;
            this.ımageSlider1.AnimationTime = 1000;
            this.ımageSlider1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.ımageSlider1.AutoSlideInterval = 1000;
            this.ımageSlider1.CurrentImageIndex = 0;
            this.ımageSlider1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images1"))));
            this.ımageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("ımageSlider1.Images2"))));
            this.ımageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.ımageSlider1.Location = new System.Drawing.Point(664, 24);
            this.ımageSlider1.Name = "ımageSlider1";
            this.ımageSlider1.Size = new System.Drawing.Size(260, 139);
            this.ımageSlider1.TabIndex = 11;
            this.ımageSlider1.Text = "ımageSlider1";
            this.ımageSlider1.UseDisabledStatePainter = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1050, 525);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ımageSlider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnUrunSat;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.Label lblUrunSec;
        private System.Windows.Forms.TextBox txtUrunAdetBilgi;
        private System.Windows.Forms.Label lblUrunAdetBilgi;
        private System.Windows.Forms.Button btnKarGoruntule;
        private System.Windows.Forms.Button btnSatınAl;
        private System.Windows.Forms.ListBox listUrun;
        private System.Windows.Forms.RichTextBox richHesapOzeti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richKar;
        private DevExpress.XtraEditors.Controls.ImageSlider ımageSlider1;
    }
}

