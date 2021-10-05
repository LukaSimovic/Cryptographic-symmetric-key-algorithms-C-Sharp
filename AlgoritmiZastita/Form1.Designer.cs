
namespace AlgoritmiZastita
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRT = new System.Windows.Forms.CheckBox();
            this.cbRF = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHill = new System.Windows.Forms.CheckBox();
            this.cbAutokey = new System.Windows.Forms.CheckBox();
            this.cbVigenere = new System.Windows.Forms.CheckBox();
            this.cbPlayfair = new System.Windows.Forms.CheckBox();
            this.cbGauss = new System.Windows.Forms.CheckBox();
            this.cbMono = new System.Windows.Forms.CheckBox();
            this.cbCaesar = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbRT = new System.Windows.Forms.TextBox();
            this.tbHill = new System.Windows.Forms.TextBox();
            this.tbRF = new System.Windows.Forms.TextBox();
            this.tbAutokey = new System.Windows.Forms.TextBox();
            this.tbVigenere = new System.Windows.Forms.TextBox();
            this.tbPlayfair = new System.Windows.Forms.TextBox();
            this.tbGauss = new System.Windows.Forms.TextBox();
            this.tbMono = new System.Windows.Forms.TextBox();
            this.tbCaesar = new System.Windows.Forms.TextBox();
            this.tbPor1 = new System.Windows.Forms.TextBox();
            this.buttonIzab = new System.Windows.Forms.Button();
            this.buttonWorkSif = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSif1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPonovi = new System.Windows.Forms.Button();
            this.buttonDesif = new System.Windows.Forms.Button();
            this.buttonIzlaz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.šifrovanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dešifrovanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSif2 = new System.Windows.Forms.TextBox();
            this.tbPor2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonResetujIzb = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRT);
            this.groupBox1.Controls.Add(this.cbRF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbHill);
            this.groupBox1.Controls.Add(this.cbAutokey);
            this.groupBox1.Controls.Add(this.cbVigenere);
            this.groupBox1.Controls.Add(this.cbPlayfair);
            this.groupBox1.Controls.Add(this.cbGauss);
            this.groupBox1.Controls.Add(this.cbMono);
            this.groupBox1.Controls.Add(this.cbCaesar);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 367);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algoritam";
            // 
            // cbRT
            // 
            this.cbRT.AutoSize = true;
            this.cbRT.Location = new System.Drawing.Point(9, 325);
            this.cbRT.Name = "cbRT";
            this.cbRT.Size = new System.Drawing.Size(120, 21);
            this.cbRT.TabIndex = 7;
            this.cbRT.Text = "Row transpos.";
            this.cbRT.UseVisualStyleBackColor = true;
            this.cbRT.CheckedChanged += new System.EventHandler(this.cbRT_CheckedChanged);
            // 
            // cbRF
            // 
            this.cbRF.AutoSize = true;
            this.cbRF.Location = new System.Drawing.Point(9, 298);
            this.cbRF.Name = "cbRF";
            this.cbRF.Size = new System.Drawing.Size(93, 21);
            this.cbRF.TabIndex = 8;
            this.cbRF.Text = "Rail fence";
            this.cbRF.UseVisualStyleBackColor = true;
            this.cbRF.CheckedChanged += new System.EventHandler(this.cbRF_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Transpozicioni:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Supstitucioni:";
            // 
            // cbHill
            // 
            this.cbHill.AutoSize = true;
            this.cbHill.Location = new System.Drawing.Point(6, 226);
            this.cbHill.Name = "cbHill";
            this.cbHill.Size = new System.Drawing.Size(49, 21);
            this.cbHill.TabIndex = 6;
            this.cbHill.Text = "Hill";
            this.cbHill.UseVisualStyleBackColor = true;
            this.cbHill.CheckedChanged += new System.EventHandler(this.cbHill_CheckedChanged);
            // 
            // cbAutokey
            // 
            this.cbAutokey.AutoSize = true;
            this.cbAutokey.Location = new System.Drawing.Point(6, 199);
            this.cbAutokey.Name = "cbAutokey";
            this.cbAutokey.Size = new System.Drawing.Size(81, 21);
            this.cbAutokey.TabIndex = 5;
            this.cbAutokey.Text = "Autokey";
            this.cbAutokey.UseVisualStyleBackColor = true;
            this.cbAutokey.CheckedChanged += new System.EventHandler(this.cbAutokey_CheckedChanged);
            // 
            // cbVigenere
            // 
            this.cbVigenere.AutoSize = true;
            this.cbVigenere.Location = new System.Drawing.Point(6, 172);
            this.cbVigenere.Name = "cbVigenere";
            this.cbVigenere.Size = new System.Drawing.Size(87, 21);
            this.cbVigenere.TabIndex = 4;
            this.cbVigenere.Text = "Vigenère";
            this.cbVigenere.UseVisualStyleBackColor = true;
            this.cbVigenere.CheckedChanged += new System.EventHandler(this.cbVigenere_CheckedChanged);
            // 
            // cbPlayfair
            // 
            this.cbPlayfair.AutoSize = true;
            this.cbPlayfair.Location = new System.Drawing.Point(6, 145);
            this.cbPlayfair.Name = "cbPlayfair";
            this.cbPlayfair.Size = new System.Drawing.Size(77, 21);
            this.cbPlayfair.TabIndex = 3;
            this.cbPlayfair.Text = "Playfair";
            this.cbPlayfair.UseVisualStyleBackColor = true;
            this.cbPlayfair.CheckedChanged += new System.EventHandler(this.cbPlayfair_CheckedChanged);
            // 
            // cbGauss
            // 
            this.cbGauss.AutoSize = true;
            this.cbGauss.Location = new System.Drawing.Point(6, 118);
            this.cbGauss.Name = "cbGauss";
            this.cbGauss.Size = new System.Drawing.Size(71, 21);
            this.cbGauss.TabIndex = 2;
            this.cbGauss.Text = "Gauss";
            this.cbGauss.UseVisualStyleBackColor = true;
            this.cbGauss.CheckedChanged += new System.EventHandler(this.cbGauss_CheckedChanged);
            // 
            // cbMono
            // 
            this.cbMono.AutoSize = true;
            this.cbMono.Location = new System.Drawing.Point(6, 91);
            this.cbMono.Name = "cbMono";
            this.cbMono.Size = new System.Drawing.Size(120, 21);
            this.cbMono.TabIndex = 1;
            this.cbMono.Text = "Monoalphabet";
            this.cbMono.UseVisualStyleBackColor = true;
            this.cbMono.CheckedChanged += new System.EventHandler(this.cbMono_CheckedChanged);
            // 
            // cbCaesar
            // 
            this.cbCaesar.AutoSize = true;
            this.cbCaesar.Location = new System.Drawing.Point(6, 64);
            this.cbCaesar.Name = "cbCaesar";
            this.cbCaesar.Size = new System.Drawing.Size(75, 21);
            this.cbCaesar.TabIndex = 0;
            this.cbCaesar.Text = "Caesar";
            this.cbCaesar.UseVisualStyleBackColor = true;
            this.cbCaesar.CheckedChanged += new System.EventHandler(this.cbCaesar_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbRT);
            this.groupBox2.Controls.Add(this.tbHill);
            this.groupBox2.Controls.Add(this.tbRF);
            this.groupBox2.Controls.Add(this.tbAutokey);
            this.groupBox2.Controls.Add(this.tbVigenere);
            this.groupBox2.Controls.Add(this.tbPlayfair);
            this.groupBox2.Controls.Add(this.tbGauss);
            this.groupBox2.Controls.Add(this.tbMono);
            this.groupBox2.Controls.Add(this.tbCaesar);
            this.groupBox2.Location = new System.Drawing.Point(146, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 367);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ključ";
            // 
            // tbRT
            // 
            this.tbRT.Location = new System.Drawing.Point(6, 323);
            this.tbRT.Name = "tbRT";
            this.tbRT.Size = new System.Drawing.Size(268, 22);
            this.tbRT.TabIndex = 8;
            // 
            // tbHill
            // 
            this.tbHill.Location = new System.Drawing.Point(6, 224);
            this.tbHill.Name = "tbHill";
            this.tbHill.Size = new System.Drawing.Size(268, 22);
            this.tbHill.TabIndex = 7;
            this.tbHill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            this.tbHill.MouseHover += new System.EventHandler(this.tbHill_MouseHover);
            // 
            // tbRF
            // 
            this.tbRF.Location = new System.Drawing.Point(6, 296);
            this.tbRF.Name = "tbRF";
            this.tbRF.Size = new System.Drawing.Size(268, 22);
            this.tbRF.TabIndex = 6;
            // 
            // tbAutokey
            // 
            this.tbAutokey.Location = new System.Drawing.Point(6, 197);
            this.tbAutokey.Name = "tbAutokey";
            this.tbAutokey.Size = new System.Drawing.Size(268, 22);
            this.tbAutokey.TabIndex = 5;
            this.tbAutokey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            // 
            // tbVigenere
            // 
            this.tbVigenere.Location = new System.Drawing.Point(6, 168);
            this.tbVigenere.Name = "tbVigenere";
            this.tbVigenere.Size = new System.Drawing.Size(268, 22);
            this.tbVigenere.TabIndex = 4;
            this.tbVigenere.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            // 
            // tbPlayfair
            // 
            this.tbPlayfair.Location = new System.Drawing.Point(6, 141);
            this.tbPlayfair.Name = "tbPlayfair";
            this.tbPlayfair.Size = new System.Drawing.Size(268, 22);
            this.tbPlayfair.TabIndex = 3;
            this.tbPlayfair.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            // 
            // tbGauss
            // 
            this.tbGauss.Location = new System.Drawing.Point(6, 116);
            this.tbGauss.Name = "tbGauss";
            this.tbGauss.Size = new System.Drawing.Size(268, 22);
            this.tbGauss.TabIndex = 2;
            this.tbGauss.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            this.tbGauss.MouseHover += new System.EventHandler(this.tbGauss_MouseHover);
            // 
            // tbMono
            // 
            this.tbMono.Location = new System.Drawing.Point(6, 89);
            this.tbMono.Name = "tbMono";
            this.tbMono.Size = new System.Drawing.Size(268, 22);
            this.tbMono.TabIndex = 1;
            this.tbMono.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            this.tbMono.TextChanged += new System.EventHandler(this.tbMono_TextChanged);
            this.tbMono.MouseHover += new System.EventHandler(this.tbMono_MouseHover);
            // 
            // tbCaesar
            // 
            this.tbCaesar.Location = new System.Drawing.Point(6, 62);
            this.tbCaesar.Name = "tbCaesar";
            this.tbCaesar.Size = new System.Drawing.Size(268, 22);
            this.tbCaesar.TabIndex = 0;
            this.tbCaesar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseClick);
            this.tbCaesar.MouseHover += new System.EventHandler(this.tbCaesar_MouseHover);
            // 
            // tbPor1
            // 
            this.tbPor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPor1.Location = new System.Drawing.Point(499, 124);
            this.tbPor1.Name = "tbPor1";
            this.tbPor1.Size = new System.Drawing.Size(357, 22);
            this.tbPor1.TabIndex = 3;
            this.tbPor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPor1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ponudiTekst);
            // 
            // buttonIzab
            // 
            this.buttonIzab.Location = new System.Drawing.Point(39, 430);
            this.buttonIzab.Name = "buttonIzab";
            this.buttonIzab.Size = new System.Drawing.Size(75, 36);
            this.buttonIzab.TabIndex = 4;
            this.buttonIzab.Text = "Izaberi";
            this.buttonIzab.UseVisualStyleBackColor = true;
            this.buttonIzab.Click += new System.EventHandler(this.buttonIzab_Click);
            // 
            // buttonWorkSif
            // 
            this.buttonWorkSif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWorkSif.Location = new System.Drawing.Point(479, 243);
            this.buttonWorkSif.Name = "buttonWorkSif";
            this.buttonWorkSif.Size = new System.Drawing.Size(100, 61);
            this.buttonWorkSif.TabIndex = 5;
            this.buttonWorkSif.Text = "Šifruj";
            this.buttonWorkSif.UseVisualStyleBackColor = true;
            this.buttonWorkSif.Click += new System.EventHandler(this.buttonWorkSif_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(431, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Poruka:";
            // 
            // tbSif1
            // 
            this.tbSif1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSif1.Location = new System.Drawing.Point(499, 385);
            this.tbSif1.Name = "tbSif1";
            this.tbSif1.ReadOnly = true;
            this.tbSif1.Size = new System.Drawing.Size(355, 22);
            this.tbSif1.TabIndex = 10;
            this.tbSif1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(448, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Šifra:";
            // 
            // buttonPonovi
            // 
            this.buttonPonovi.Location = new System.Drawing.Point(226, 460);
            this.buttonPonovi.Name = "buttonPonovi";
            this.buttonPonovi.Size = new System.Drawing.Size(69, 43);
            this.buttonPonovi.TabIndex = 12;
            this.buttonPonovi.Text = "Ponovo";
            this.buttonPonovi.UseVisualStyleBackColor = true;
            this.buttonPonovi.Click += new System.EventHandler(this.buttonPonovi_Click);
            // 
            // buttonDesif
            // 
            this.buttonDesif.Location = new System.Drawing.Point(297, 460);
            this.buttonDesif.Name = "buttonDesif";
            this.buttonDesif.Size = new System.Drawing.Size(112, 43);
            this.buttonDesif.TabIndex = 13;
            this.buttonDesif.Text = "Dešifrovanje";
            this.buttonDesif.UseVisualStyleBackColor = true;
            this.buttonDesif.Click += new System.EventHandler(this.buttonDesif_Click);
            // 
            // buttonIzlaz
            // 
            this.buttonIzlaz.Location = new System.Drawing.Point(411, 460);
            this.buttonIzlaz.Name = "buttonIzlaz";
            this.buttonIzlaz.Size = new System.Drawing.Size(63, 43);
            this.buttonIzlaz.TabIndex = 14;
            this.buttonIzlaz.Text = "Izlaz";
            this.buttonIzlaz.UseVisualStyleBackColor = true;
            this.buttonIzlaz.Click += new System.EventHandler(this.buttonIzlaz_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(638, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 69);
            this.label6.TabIndex = 16;
            this.label6.Text = "...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcijeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcijeToolStripMenuItem
            // 
            this.opcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.šifrovanjeToolStripMenuItem,
            this.dešifrovanjeToolStripMenuItem});
            this.opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            this.opcijeToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.opcijeToolStripMenuItem.Text = "Opcije";
            // 
            // šifrovanjeToolStripMenuItem
            // 
            this.šifrovanjeToolStripMenuItem.Name = "šifrovanjeToolStripMenuItem";
            this.šifrovanjeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.šifrovanjeToolStripMenuItem.Text = "Šifrovanje";
            this.šifrovanjeToolStripMenuItem.Click += new System.EventHandler(this.šifrovanjeToolStripMenuItem_Click);
            // 
            // dešifrovanjeToolStripMenuItem
            // 
            this.dešifrovanjeToolStripMenuItem.Name = "dešifrovanjeToolStripMenuItem";
            this.dešifrovanjeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dešifrovanjeToolStripMenuItem.Text = "Dešifrovanje";
            this.dešifrovanjeToolStripMenuItem.Click += new System.EventHandler(this.dešifrovanjeToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(639, -9);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.label5.Size = new System.Drawing.Size(112, 158);
            this.label5.TabIndex = 21;
            this.label5.Text = "...";
            // 
            // tbSif2
            // 
            this.tbSif2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSif2.Location = new System.Drawing.Point(499, 75);
            this.tbSif2.Name = "tbSif2";
            this.tbSif2.Size = new System.Drawing.Size(355, 22);
            this.tbSif2.TabIndex = 22;
            this.tbSif2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSif2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ponudiTekst);
            this.tbSif2.TextChanged += new System.EventHandler(this.ponudiTekst);
            // 
            // tbPor2
            // 
            this.tbPor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPor2.Location = new System.Drawing.Point(499, 382);
            this.tbPor2.Name = "tbPor2";
            this.tbPor2.ReadOnly = true;
            this.tbPor2.Size = new System.Drawing.Size(355, 22);
            this.tbPor2.TabIndex = 23;
            this.tbPor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(431, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Poruka:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(448, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Šifra:";
            // 
            // buttonResetujIzb
            // 
            this.buttonResetujIzb.Location = new System.Drawing.Point(19, 472);
            this.buttonResetujIzb.Name = "buttonResetujIzb";
            this.buttonResetujIzb.Size = new System.Drawing.Size(117, 25);
            this.buttonResetujIzb.TabIndex = 28;
            this.buttonResetujIzb.Text = "Resetuj izbor";
            this.buttonResetujIzb.UseVisualStyleBackColor = true;
            this.buttonResetujIzb.Click += new System.EventHandler(this.buttonResetujIzb_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(810, 410);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(69, 43);
            this.buttonCopy.TabIndex = 29;
            this.buttonCopy.Text = "Kopiraj";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            this.buttonCopy.MouseEnter += new System.EventHandler(this.buttonCopy_MouseEnter);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::AlgoritmiZastita.Properties.Resources.arr2;
            this.pictureBox6.Location = new System.Drawing.Point(631, 343);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(89, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AlgoritmiZastita.Properties.Resources.arrow1;
            this.pictureBox5.Location = new System.Drawing.Point(644, 52);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 140);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AlgoritmiZastita.Properties.Resources.avatar1;
            this.pictureBox4.Location = new System.Drawing.Point(622, 419);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(107, 81);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AlgoritmiZastita.Properties.Resources.avatar1;
            this.pictureBox3.Location = new System.Drawing.Point(622, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(107, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AlgoritmiZastita.Properties.Resources.arr2;
            this.pictureBox2.Location = new System.Drawing.Point(631, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AlgoritmiZastita.Properties.Resources.arrow1;
            this.pictureBox1.Location = new System.Drawing.Point(644, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // image1
            // 
            this.image1.Image = global::AlgoritmiZastita.Properties.Resources.box2;
            this.image1.Location = new System.Drawing.Point(600, 192);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(164, 147);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image1.TabIndex = 7;
            this.image1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 514);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonResetujIzb);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPor2);
            this.Controls.Add(this.tbSif2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonIzlaz);
            this.Controls.Add(this.buttonDesif);
            this.Controls.Add(this.buttonPonovi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSif1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonWorkSif);
            this.Controls.Add(this.buttonIzab);
            this.Controls.Add(this.tbPor1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Zaštita podataka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbHill;
        private System.Windows.Forms.CheckBox cbAutokey;
        private System.Windows.Forms.CheckBox cbVigenere;
        private System.Windows.Forms.CheckBox cbPlayfair;
        private System.Windows.Forms.CheckBox cbGauss;
        private System.Windows.Forms.CheckBox cbMono;
        private System.Windows.Forms.CheckBox cbCaesar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPor1;
        private System.Windows.Forms.TextBox tbRF;
        private System.Windows.Forms.TextBox tbAutokey;
        private System.Windows.Forms.TextBox tbVigenere;
        private System.Windows.Forms.TextBox tbPlayfair;
        private System.Windows.Forms.TextBox tbGauss;
        private System.Windows.Forms.TextBox tbMono;
        private System.Windows.Forms.TextBox tbCaesar;
        private System.Windows.Forms.CheckBox cbRT;
        private System.Windows.Forms.CheckBox cbRF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRT;
        private System.Windows.Forms.TextBox tbHill;
        private System.Windows.Forms.Button buttonIzab;
        private System.Windows.Forms.Button buttonWorkSif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbSif1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPonovi;
        private System.Windows.Forms.Button buttonDesif;
        private System.Windows.Forms.Button buttonIzlaz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem šifrovanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dešifrovanjeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSif2;
        private System.Windows.Forms.TextBox tbPor2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button buttonResetujIzb;
        private System.Windows.Forms.Button buttonCopy;
    }
}

