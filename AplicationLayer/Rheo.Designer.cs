namespace AplicationLayer
{
    partial class Rheo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rheo));
            this.comborheo = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.concheck = new System.Windows.Forms.CheckBox();
            this.lblcon_max = new System.Windows.Forms.Label();
            this.txtcon_max = new System.Windows.Forms.TextBox();
            this.txtcon_min = new System.Windows.Forms.TextBox();
            this.lblcon_min = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtgrt_max = new System.Windows.Forms.TextBox();
            this.txtgrt_min = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txthrd_max = new System.Windows.Forms.TextBox();
            this.txthrd_min = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label26 = new System.Windows.Forms.Label();
            this.lbledit = new System.Windows.Forms.Label();
            this.txttc90_max = new System.Windows.Forms.TextBox();
            this.txttc90_min = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txttc50_max = new System.Windows.Forms.TextBox();
            this.txttc50_min = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtts2_max = new System.Windows.Forms.TextBox();
            this.txtts2_min = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtmh_max = new System.Windows.Forms.TextBox();
            this.txtmh_min = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtml_max = new System.Windows.Forms.TextBox();
            this.txtml_min = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcompcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsacode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conpane = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.conpane.SuspendLayout();
            this.SuspendLayout();
            // 
            // comborheo
            // 
            this.comborheo.FormattingEnabled = true;
            this.comborheo.Location = new System.Drawing.Point(34, 36);
            this.comborheo.Name = "comborheo";
            this.comborheo.Size = new System.Drawing.Size(202, 28);
            this.comborheo.TabIndex = 6;
            this.comborheo.SelectedIndexChanged += new System.EventHandler(this.comborheo_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(646, 517);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(294, 49);
            this.btnEdit.TabIndex = 131;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.Location = new System.Drawing.Point(131, 517);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(294, 49);
            this.btnsave.TabIndex = 130;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // concheck
            // 
            this.concheck.AutoSize = true;
            this.concheck.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concheck.Location = new System.Drawing.Point(667, 328);
            this.concheck.Name = "concheck";
            this.concheck.Size = new System.Drawing.Size(143, 27);
            this.concheck.TabIndex = 129;
            this.concheck.Text = "Conductivity";
            this.concheck.UseVisualStyleBackColor = true;
            this.concheck.CheckedChanged += new System.EventHandler(this.concheck_CheckedChanged_1);
            // 
            // lblcon_max
            // 
            this.lblcon_max.AutoSize = true;
            this.lblcon_max.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcon_max.Location = new System.Drawing.Point(19, 62);
            this.lblcon_max.Name = "lblcon_max";
            this.lblcon_max.Size = new System.Drawing.Size(55, 22);
            this.lblcon_max.TabIndex = 128;
            this.lblcon_max.Text = "MAX";
            this.lblcon_max.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtcon_max
            // 
            this.txtcon_max.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcon_max.Location = new System.Drawing.Point(74, 55);
            this.txtcon_max.Multiline = true;
            this.txtcon_max.Name = "txtcon_max";
            this.txtcon_max.Size = new System.Drawing.Size(104, 38);
            this.txtcon_max.TabIndex = 127;
            // 
            // txtcon_min
            // 
            this.txtcon_min.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcon_min.Location = new System.Drawing.Point(74, 11);
            this.txtcon_min.Multiline = true;
            this.txtcon_min.Name = "txtcon_min";
            this.txtcon_min.Size = new System.Drawing.Size(104, 38);
            this.txtcon_min.TabIndex = 126;
            // 
            // lblcon_min
            // 
            this.lblcon_min.AutoSize = true;
            this.lblcon_min.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcon_min.Location = new System.Drawing.Point(19, 18);
            this.lblcon_min.Name = "lblcon_min";
            this.lblcon_min.Size = new System.Drawing.Size(47, 22);
            this.lblcon_min.TabIndex = 125;
            this.lblcon_min.Text = "MIN";
            this.lblcon_min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(455, 445);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(55, 22);
            this.label33.TabIndex = 124;
            this.label33.Text = "MAX";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtgrt_max
            // 
            this.txtgrt_max.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrt_max.Location = new System.Drawing.Point(510, 438);
            this.txtgrt_max.Multiline = true;
            this.txtgrt_max.Name = "txtgrt_max";
            this.txtgrt_max.Size = new System.Drawing.Size(104, 38);
            this.txtgrt_max.TabIndex = 123;
            // 
            // txtgrt_min
            // 
            this.txtgrt_min.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrt_min.Location = new System.Drawing.Point(510, 394);
            this.txtgrt_min.Multiline = true;
            this.txtgrt_min.Name = "txtgrt_min";
            this.txtgrt_min.Size = new System.Drawing.Size(104, 38);
            this.txtgrt_min.TabIndex = 122;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(455, 401);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(47, 22);
            this.label34.TabIndex = 121;
            this.label34.Text = "MIN";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(500, 368);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(98, 23);
            this.label35.TabIndex = 120;
            this.label35.Text = "GRAVITY";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(243, 445);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(55, 22);
            this.label30.TabIndex = 119;
            this.label30.Text = "MAX";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txthrd_max
            // 
            this.txthrd_max.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthrd_max.Location = new System.Drawing.Point(298, 438);
            this.txthrd_max.Multiline = true;
            this.txthrd_max.Name = "txthrd_max";
            this.txthrd_max.Size = new System.Drawing.Size(104, 38);
            this.txthrd_max.TabIndex = 118;
            // 
            // txthrd_min
            // 
            this.txthrd_min.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthrd_min.Location = new System.Drawing.Point(298, 394);
            this.txthrd_min.Multiline = true;
            this.txthrd_min.Name = "txthrd_min";
            this.txthrd_min.Size = new System.Drawing.Size(104, 38);
            this.txthrd_min.TabIndex = 117;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(243, 401);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(47, 22);
            this.label31.TabIndex = 116;
            this.label31.Text = "MIN";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(272, 368);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(116, 23);
            this.label32.TabIndex = 115;
            this.label32.Text = "HARDNESS";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(27, 387);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(128, 66);
            this.label29.TabIndex = 114;
            this.label29.Text = "Physical\r\nProperties";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(1066, 276);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 22);
            this.label26.TabIndex = 113;
            this.label26.Text = "MAX";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbledit
            // 
            this.lbledit.AutoSize = true;
            this.lbledit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledit.Location = new System.Drawing.Point(85, 0);
            this.lbledit.Name = "lbledit";
            this.lbledit.Size = new System.Drawing.Size(54, 22);
            this.lbledit.TabIndex = 5;
            this.lbledit.Text = "EDIT";
            // 
            // txttc90_max
            // 
            this.txttc90_max.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttc90_max.Location = new System.Drawing.Point(1121, 269);
            this.txttc90_max.Multiline = true;
            this.txttc90_max.Name = "txttc90_max";
            this.txttc90_max.Size = new System.Drawing.Size(104, 38);
            this.txttc90_max.TabIndex = 112;
            // 
            // txttc90_min
            // 
            this.txttc90_min.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttc90_min.Location = new System.Drawing.Point(1121, 225);
            this.txttc90_min.Multiline = true;
            this.txttc90_min.Name = "txttc90_min";
            this.txttc90_min.Size = new System.Drawing.Size(104, 38);
            this.txttc90_min.TabIndex = 111;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(1066, 232);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 22);
            this.label27.TabIndex = 110;
            this.label27.Text = "MIN";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(1117, 191);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(78, 23);
            this.label28.TabIndex = 109;
            this.label28.Text = "R-TC90";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(865, 276);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 22);
            this.label23.TabIndex = 108;
            this.label23.Text = "MAX";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txttc50_max
            // 
            this.txttc50_max.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttc50_max.Location = new System.Drawing.Point(920, 269);
            this.txttc50_max.Multiline = true;
            this.txttc50_max.Name = "txttc50_max";
            this.txttc50_max.Size = new System.Drawing.Size(104, 38);
            this.txttc50_max.TabIndex = 107;
            // 
            // txttc50_min
            // 
            this.txttc50_min.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttc50_min.Location = new System.Drawing.Point(920, 225);
            this.txttc50_min.Multiline = true;
            this.txttc50_min.Name = "txttc50_min";
            this.txttc50_min.Size = new System.Drawing.Size(104, 38);
            this.txttc50_min.TabIndex = 106;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(865, 232);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 22);
            this.label24.TabIndex = 105;
            this.label24.Text = "MIN";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(916, 191);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 23);
            this.label25.TabIndex = 104;
            this.label25.Text = "R-TC50";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(663, 276);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 22);
            this.label20.TabIndex = 103;
            this.label20.Text = "MAX";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtts2_max
            // 
            this.txtts2_max.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtts2_max.Location = new System.Drawing.Point(718, 269);
            this.txtts2_max.Multiline = true;
            this.txtts2_max.Name = "txtts2_max";
            this.txtts2_max.Size = new System.Drawing.Size(104, 38);
            this.txtts2_max.TabIndex = 102;
            // 
            // txtts2_min
            // 
            this.txtts2_min.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtts2_min.Location = new System.Drawing.Point(718, 225);
            this.txtts2_min.Multiline = true;
            this.txtts2_min.Name = "txtts2_min";
            this.txtts2_min.Size = new System.Drawing.Size(104, 38);
            this.txtts2_min.TabIndex = 101;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(663, 232);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 22);
            this.label21.TabIndex = 100;
            this.label21.Text = "MIN";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(714, 191);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 23);
            this.label22.TabIndex = 99;
            this.label22.Text = "R-TS2";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(455, 276);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 22);
            this.label17.TabIndex = 98;
            this.label17.Text = "MAX";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtmh_max
            // 
            this.txtmh_max.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmh_max.Location = new System.Drawing.Point(510, 269);
            this.txtmh_max.Multiline = true;
            this.txtmh_max.Name = "txtmh_max";
            this.txtmh_max.Size = new System.Drawing.Size(104, 38);
            this.txtmh_max.TabIndex = 97;
            // 
            // txtmh_min
            // 
            this.txtmh_min.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmh_min.Location = new System.Drawing.Point(510, 225);
            this.txtmh_min.Multiline = true;
            this.txtmh_min.Name = "txtmh_min";
            this.txtmh_min.Size = new System.Drawing.Size(104, 38);
            this.txtmh_min.TabIndex = 96;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(455, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 22);
            this.label18.TabIndex = 95;
            this.label18.Text = "MIN";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(506, 191);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 23);
            this.label19.TabIndex = 94;
            this.label19.Text = "R-MH";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(243, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 22);
            this.label14.TabIndex = 93;
            this.label14.Text = "MAX";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtml_max
            // 
            this.txtml_max.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtml_max.Location = new System.Drawing.Point(298, 269);
            this.txtml_max.Multiline = true;
            this.txtml_max.Name = "txtml_max";
            this.txtml_max.Size = new System.Drawing.Size(104, 38);
            this.txtml_max.TabIndex = 92;
            // 
            // txtml_min
            // 
            this.txtml_min.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtml_min.Location = new System.Drawing.Point(298, 225);
            this.txtml_min.Multiline = true;
            this.txtml_min.Name = "txtml_min";
            this.txtml_min.Size = new System.Drawing.Size(104, 38);
            this.txtml_min.TabIndex = 91;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(243, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 22);
            this.label15.TabIndex = 90;
            this.label15.Text = "MIN";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(294, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 23);
            this.label16.TabIndex = 89;
            this.label16.Text = "R-ML";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 66);
            this.label13.TabIndex = 88;
            this.label13.Text = "Rheometer \r\nProperties";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.comborheo);
            this.panel1.Controls.Add(this.lbledit);
            this.panel1.Location = new System.Drawing.Point(1043, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 78);
            this.panel1.TabIndex = 71;
            // 
            // txtcompcode
            // 
            this.txtcompcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompcode.Location = new System.Drawing.Point(755, 35);
            this.txtcompcode.Multiline = true;
            this.txtcompcode.Name = "txtcompcode";
            this.txtcompcode.Size = new System.Drawing.Size(236, 46);
            this.txtcompcode.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 33);
            this.label2.TabIndex = 69;
            this.label2.Text = "COMPOUND-CODE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtsacode
            // 
            this.txtsacode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsacode.Location = new System.Drawing.Point(204, 35);
            this.txtsacode.Multiline = true;
            this.txtsacode.Name = "txtsacode";
            this.txtsacode.Size = new System.Drawing.Size(236, 46);
            this.txtsacode.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 33);
            this.label1.TabIndex = 67;
            this.label1.Text = "SAPCODE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // conpane
            // 
            this.conpane.Controls.Add(this.lblcon_min);
            this.conpane.Controls.Add(this.txtcon_min);
            this.conpane.Controls.Add(this.txtcon_max);
            this.conpane.Controls.Add(this.lblcon_max);
            this.conpane.Location = new System.Drawing.Point(655, 376);
            this.conpane.Name = "conpane";
            this.conpane.Size = new System.Drawing.Size(200, 100);
            this.conpane.TabIndex = 132;
            // 
            // Rheo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 634);
            this.Controls.Add(this.conpane);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.concheck);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtgrt_max);
            this.Controls.Add(this.txtgrt_min);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txthrd_max);
            this.Controls.Add(this.txthrd_min);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txttc90_max);
            this.Controls.Add(this.txttc90_min);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txttc50_max);
            this.Controls.Add(this.txttc50_min);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtts2_max);
            this.Controls.Add(this.txtts2_min);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtmh_max);
            this.Controls.Add(this.txtmh_min);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtml_max);
            this.Controls.Add(this.txtml_min);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtcompcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsacode);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Rheo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rheo";
            this.Load += new System.EventHandler(this.Rheo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.conpane.ResumeLayout(false);
            this.conpane.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comborheo;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.CheckBox concheck;
        private System.Windows.Forms.Label lblcon_max;
        private System.Windows.Forms.TextBox txtcon_max;
        private System.Windows.Forms.TextBox txtcon_min;
        private System.Windows.Forms.Label lblcon_min;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtgrt_max;
        private System.Windows.Forms.TextBox txtgrt_min;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txthrd_max;
        private System.Windows.Forms.TextBox txthrd_min;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label29;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbledit;
        private System.Windows.Forms.TextBox txttc90_max;
        private System.Windows.Forms.TextBox txttc90_min;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txttc50_max;
        private System.Windows.Forms.TextBox txttc50_min;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtts2_max;
        private System.Windows.Forms.TextBox txtts2_min;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtmh_max;
        private System.Windows.Forms.TextBox txtmh_min;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtml_max;
        private System.Windows.Forms.TextBox txtml_min;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcompcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsacode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel conpane;
    }
}