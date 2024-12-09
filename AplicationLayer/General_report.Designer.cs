namespace AplicationLayer
{
    partial class General_report
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchsapcode = new System.Windows.Forms.TextBox();
            this.txtbatchno = new System.Windows.Forms.TextBox();
            this.txtrheo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmooney = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnrefesh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1900, 802);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchsapcode
            // 
            this.searchsapcode.Location = new System.Drawing.Point(110, 71);
            this.searchsapcode.Name = "searchsapcode";
            this.searchsapcode.Size = new System.Drawing.Size(157, 26);
            this.searchsapcode.TabIndex = 1;
            this.searchsapcode.TextChanged += new System.EventHandler(this.searchsapcode_TextChanged);
            // 
            // txtbatchno
            // 
            this.txtbatchno.Location = new System.Drawing.Point(298, 71);
            this.txtbatchno.Name = "txtbatchno";
            this.txtbatchno.Size = new System.Drawing.Size(157, 26);
            this.txtbatchno.TabIndex = 2;
            this.txtbatchno.TextChanged += new System.EventHandler(this.txtbatchno_TextChanged);
            // 
            // txtrheo
            // 
            this.txtrheo.Location = new System.Drawing.Point(492, 71);
            this.txtrheo.Name = "txtrheo";
            this.txtrheo.Size = new System.Drawing.Size(157, 26);
            this.txtrheo.TabIndex = 3;
            this.txtrheo.TextChanged += new System.EventHandler(this.txtrheo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sapcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Batch_No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rheo_Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(687, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mooney_Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(881, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status";
            // 
            // txtmooney
            // 
            this.txtmooney.Location = new System.Drawing.Point(681, 71);
            this.txtmooney.Name = "txtmooney";
            this.txtmooney.Size = new System.Drawing.Size(157, 26);
            this.txtmooney.TabIndex = 9;
            this.txtmooney.TextChanged += new System.EventHandler(this.txtmooney_TextChanged);
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(865, 71);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(157, 26);
            this.txtstatus.TabIndex = 10;
            this.txtstatus.TextChanged += new System.EventHandler(this.txtstatus_TextChanged);
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnexport.Location = new System.Drawing.Point(158, 934);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(126, 45);
            this.btnexport.TabIndex = 11;
            this.btnexport.Text = "Export Data";
            this.btnexport.UseVisualStyleBackColor = false;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btnrefesh
            // 
            this.btnrefesh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnrefesh.Location = new System.Drawing.Point(329, 934);
            this.btnrefesh.Name = "btnrefesh";
            this.btnrefesh.Size = new System.Drawing.Size(126, 45);
            this.btnrefesh.TabIndex = 12;
            this.btnrefesh.Text = "Refresh";
            this.btnrefesh.UseVisualStyleBackColor = false;
            this.btnrefesh.Click += new System.EventHandler(this.btnrefesh_Click);
            // 
            // General_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1244, 991);
            this.Controls.Add(this.btnrefesh);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtmooney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrheo);
            this.Controls.Add(this.txtbatchno);
            this.Controls.Add(this.searchsapcode);
            this.Controls.Add(this.dataGridView1);
            this.Name = "General_report";
            this.Text = "General_report";
            this.Load += new System.EventHandler(this.General_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchsapcode;
        private System.Windows.Forms.TextBox txtbatchno;
        private System.Windows.Forms.TextBox txtrheo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmooney;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnrefesh;
    }
}