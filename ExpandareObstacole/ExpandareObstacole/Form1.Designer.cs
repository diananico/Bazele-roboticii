namespace ExpandareObstacole
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnrpct = new System.Windows.Forms.TextBox();
            this.combouniform = new System.Windows.Forms.ComboBox();
            this.comboforma = new System.Windows.Forms.ComboBox();
            this.btnexpand = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdist = new System.Windows.Forms.TextBox();
            this.txtdist1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdist2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdist4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdist3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdist5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdist10 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdist9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdist8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdist7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdist6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.combocapete = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCoord = new System.Windows.Forms.Label();
            this.txtraza = new System.Windows.Forms.TextBox();
            this.lblraza = new System.Windows.Forms.Label();
            this.BtnDeseneazaCerc = new System.Windows.Forms.Button();
            this.BtnClearPanel = new System.Windows.Forms.Button();
            this.BtnClearPanelData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numar puncte:";
            // 
            // txtnrpct
            // 
            this.txtnrpct.Location = new System.Drawing.Point(127, 15);
            this.txtnrpct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnrpct.Name = "txtnrpct";
            this.txtnrpct.Size = new System.Drawing.Size(72, 22);
            this.txtnrpct.TabIndex = 2;
            this.txtnrpct.TextChanged += new System.EventHandler(this.txtnrpct_TextChanged);
            // 
            // combouniform
            // 
            this.combouniform.FormattingEnabled = true;
            this.combouniform.Items.AddRange(new object[] {
            "Uniform",
            "Neuniform"});
            this.combouniform.Location = new System.Drawing.Point(20, 64);
            this.combouniform.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combouniform.Name = "combouniform";
            this.combouniform.Size = new System.Drawing.Size(160, 24);
            this.combouniform.TabIndex = 3;
            this.combouniform.SelectedIndexChanged += new System.EventHandler(this.combouniform_SelectedIndexChanged);
            // 
            // comboforma
            // 
            this.comboforma.FormattingEnabled = true;
            this.comboforma.Items.AddRange(new object[] {
            "Cu pastrare forma",
            "Fara pastrare forma"});
            this.comboforma.Location = new System.Drawing.Point(16, 181);
            this.comboforma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboforma.Name = "comboforma";
            this.comboforma.Size = new System.Drawing.Size(160, 24);
            this.comboforma.TabIndex = 4;
            // 
            // btnexpand
            // 
            this.btnexpand.Location = new System.Drawing.Point(13, 475);
            this.btnexpand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexpand.Name = "btnexpand";
            this.btnexpand.Size = new System.Drawing.Size(179, 52);
            this.btnexpand.TabIndex = 5;
            this.btnexpand.Text = "Expandeaza";
            this.btnexpand.UseVisualStyleBackColor = true;
            this.btnexpand.Click += new System.EventHandler(this.btnexpand_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Distanta expandare:";
            // 
            // txtdist
            // 
            this.txtdist.Location = new System.Drawing.Point(204, 65);
            this.txtdist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdist.Name = "txtdist";
            this.txtdist.Size = new System.Drawing.Size(131, 22);
            this.txtdist.TabIndex = 7;
            // 
            // txtdist1
            // 
            this.txtdist1.Location = new System.Drawing.Point(204, 132);
            this.txtdist1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdist1.Name = "txtdist1";
            this.txtdist1.Size = new System.Drawing.Size(72, 22);
            this.txtdist1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Distanta 1:";
            // 
            // txtdist2
            // 
            this.txtdist2.Location = new System.Drawing.Point(204, 185);
            this.txtdist2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdist2.Name = "txtdist2";
            this.txtdist2.Size = new System.Drawing.Size(72, 22);
            this.txtdist2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Distanta 2:";
            // 
            // txtdist4
            // 
            this.txtdist4.Location = new System.Drawing.Point(204, 298);
            this.txtdist4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdist4.Name = "txtdist4";
            this.txtdist4.Size = new System.Drawing.Size(72, 22);
            this.txtdist4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Distanta 4:";
            // 
            // txtdist3
            // 
            this.txtdist3.Location = new System.Drawing.Point(204, 245);
            this.txtdist3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdist3.Name = "txtdist3";
            this.txtdist3.Size = new System.Drawing.Size(72, 22);
            this.txtdist3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Distanta 3:";
            // 
            // txtdist5
            // 
            this.txtdist5.Location = new System.Drawing.Point(204, 358);
            this.txtdist5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdist5.Name = "txtdist5";
            this.txtdist5.Size = new System.Drawing.Size(72, 22);
            this.txtdist5.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 338);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Distanta 5:";
            // 
            // txtdist10
            // 
            this.txtdist10.Location = new System.Drawing.Point(305, 358);
            this.txtdist10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdist10.Name = "txtdist10";
            this.txtdist10.Size = new System.Drawing.Size(72, 22);
            this.txtdist10.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 338);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Distanta 10:";
            // 
            // txtdist9
            // 
            this.txtdist9.Location = new System.Drawing.Point(305, 298);
            this.txtdist9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdist9.Name = "txtdist9";
            this.txtdist9.Size = new System.Drawing.Size(72, 22);
            this.txtdist9.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 278);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Distanta 9:";
            // 
            // txtdist8
            // 
            this.txtdist8.Location = new System.Drawing.Point(305, 245);
            this.txtdist8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdist8.Name = "txtdist8";
            this.txtdist8.Size = new System.Drawing.Size(72, 22);
            this.txtdist8.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 225);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Distanta 8:";
            // 
            // txtdist7
            // 
            this.txtdist7.Location = new System.Drawing.Point(305, 185);
            this.txtdist7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdist7.Name = "txtdist7";
            this.txtdist7.Size = new System.Drawing.Size(72, 22);
            this.txtdist7.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(301, 165);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Distanta 7:";
            // 
            // txtdist6
            // 
            this.txtdist6.Location = new System.Drawing.Point(305, 132);
            this.txtdist6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdist6.Name = "txtdist6";
            this.txtdist6.Size = new System.Drawing.Size(72, 22);
            this.txtdist6.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 112);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Distanta 6:";
            // 
            // combocapete
            // 
            this.combocapete.FormattingEnabled = true;
            this.combocapete.Items.AddRange(new object[] {
            "Arc de cerc",
            "Taiere"});
            this.combocapete.Location = new System.Drawing.Point(16, 241);
            this.combocapete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combocapete.Name = "combocapete";
            this.combocapete.Size = new System.Drawing.Size(136, 24);
            this.combocapete.TabIndex = 28;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1096, 170);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(267, 123);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(423, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 520);
            this.panel1.TabIndex = 30;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(217, 427);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "Coordonate:";
            // 
            // lblCoord
            // 
            this.lblCoord.AutoSize = true;
            this.lblCoord.Location = new System.Drawing.Point(217, 454);
            this.lblCoord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoord.Name = "lblCoord";
            this.lblCoord.Size = new System.Drawing.Size(16, 17);
            this.lblCoord.TabIndex = 32;
            this.lblCoord.Text = "  ";
            // 
            // txtraza
            // 
            this.txtraza.Location = new System.Drawing.Point(304, 10);
            this.txtraza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtraza.Name = "txtraza";
            this.txtraza.Size = new System.Drawing.Size(92, 22);
            this.txtraza.TabIndex = 34;
            // 
            // lblraza
            // 
            this.lblraza.AutoSize = true;
            this.lblraza.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblraza.ForeColor = System.Drawing.Color.Black;
            this.lblraza.Location = new System.Drawing.Point(207, 15);
            this.lblraza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblraza.Name = "lblraza";
            this.lblraza.Size = new System.Drawing.Size(78, 17);
            this.lblraza.TabIndex = 33;
            this.lblraza.Text = "Raza Cerc:";
            // 
            // BtnDeseneazaCerc
            // 
            this.BtnDeseneazaCerc.Location = new System.Drawing.Point(13, 409);
            this.BtnDeseneazaCerc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDeseneazaCerc.Name = "BtnDeseneazaCerc";
            this.BtnDeseneazaCerc.Size = new System.Drawing.Size(179, 52);
            this.BtnDeseneazaCerc.TabIndex = 35;
            this.BtnDeseneazaCerc.Text = "Obiect nou";
            this.BtnDeseneazaCerc.UseVisualStyleBackColor = true;
            this.BtnDeseneazaCerc.Click += new System.EventHandler(this.BtnDeseneazaCerc_Click);
            // 
            // BtnClearPanel
            // 
            this.BtnClearPanel.Location = new System.Drawing.Point(173, 556);
            this.BtnClearPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClearPanel.Name = "BtnClearPanel";
            this.BtnClearPanel.Size = new System.Drawing.Size(179, 52);
            this.BtnClearPanel.TabIndex = 36;
            this.BtnClearPanel.Text = "Clear Panel";
            this.BtnClearPanel.UseVisualStyleBackColor = true;
            this.BtnClearPanel.Click += new System.EventHandler(this.BtnClearPanel_Click);
            // 
            // BtnClearPanelData
            // 
            this.BtnClearPanelData.Location = new System.Drawing.Point(21, 556);
            this.BtnClearPanelData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClearPanelData.Name = "BtnClearPanelData";
            this.BtnClearPanelData.Size = new System.Drawing.Size(140, 52);
            this.BtnClearPanelData.TabIndex = 37;
            this.BtnClearPanelData.Text = "Clear Panel Data";
            this.BtnClearPanelData.UseVisualStyleBackColor = true;
            this.BtnClearPanelData.Click += new System.EventHandler(this.BtnClearPanelData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 639);
            this.Controls.Add(this.BtnClearPanelData);
            this.Controls.Add(this.BtnClearPanel);
            this.Controls.Add(this.BtnDeseneazaCerc);
            this.Controls.Add(this.txtraza);
            this.Controls.Add(this.lblraza);
            this.Controls.Add(this.lblCoord);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.combocapete);
            this.Controls.Add(this.txtdist10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdist9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdist8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdist7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtdist6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtdist5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdist4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdist3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdist2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdist1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnexpand);
            this.Controls.Add(this.comboforma);
            this.Controls.Add(this.combouniform);
            this.Controls.Add(this.txtnrpct);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnrpct;
        private System.Windows.Forms.ComboBox combouniform;
        private System.Windows.Forms.ComboBox comboforma;
        private System.Windows.Forms.Button btnexpand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdist;
        private System.Windows.Forms.TextBox txtdist1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdist2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdist4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdist3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdist5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdist10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdist9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdist8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdist7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdist6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox combocapete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCoord;
        private System.Windows.Forms.TextBox txtraza;
        private System.Windows.Forms.Label lblraza;
        private System.Windows.Forms.Button BtnDeseneazaCerc;
        private System.Windows.Forms.Button BtnClearPanel;
        private System.Windows.Forms.Button BtnClearPanelData;
    }
}

