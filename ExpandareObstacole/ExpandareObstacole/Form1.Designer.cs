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
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numar puncte:";
            // 
            // txtnrpct
            // 
            this.txtnrpct.Location = new System.Drawing.Point(95, 12);
            this.txtnrpct.Name = "txtnrpct";
            this.txtnrpct.Size = new System.Drawing.Size(55, 20);
            this.txtnrpct.TabIndex = 2;
            // 
            // combouniform
            // 
            this.combouniform.FormattingEnabled = true;
            this.combouniform.Items.AddRange(new object[] {
            "Uniform",
            "Neuniform"});
            this.combouniform.Location = new System.Drawing.Point(15, 52);
            this.combouniform.Name = "combouniform";
            this.combouniform.Size = new System.Drawing.Size(121, 21);
            this.combouniform.TabIndex = 3;
            this.combouniform.SelectedIndexChanged += new System.EventHandler(this.combouniform_SelectedIndexChanged);
            // 
            // comboforma
            // 
            this.comboforma.FormattingEnabled = true;
            this.comboforma.Items.AddRange(new object[] {
            "Cu pastrare forma",
            "Fara pastrare forma"});
            this.comboforma.Location = new System.Drawing.Point(12, 147);
            this.comboforma.Name = "comboforma";
            this.comboforma.Size = new System.Drawing.Size(121, 21);
            this.comboforma.TabIndex = 4;
            // 
            // btnexpand
            // 
            this.btnexpand.Location = new System.Drawing.Point(12, 318);
            this.btnexpand.Name = "btnexpand";
            this.btnexpand.Size = new System.Drawing.Size(134, 42);
            this.btnexpand.TabIndex = 5;
            this.btnexpand.Text = "Expandeaza";
            this.btnexpand.UseVisualStyleBackColor = true;
            this.btnexpand.Click += new System.EventHandler(this.btnexpand_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Distanta expandare:";
            // 
            // txtdist
            // 
            this.txtdist.Location = new System.Drawing.Point(153, 53);
            this.txtdist.Name = "txtdist";
            this.txtdist.Size = new System.Drawing.Size(99, 20);
            this.txtdist.TabIndex = 7;
            // 
            // txtdist1
            // 
            this.txtdist1.Location = new System.Drawing.Point(153, 107);
            this.txtdist1.Name = "txtdist1";
            this.txtdist1.Size = new System.Drawing.Size(55, 20);
            this.txtdist1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Distanta 1:";
            // 
            // txtdist2
            // 
            this.txtdist2.Location = new System.Drawing.Point(153, 150);
            this.txtdist2.Name = "txtdist2";
            this.txtdist2.Size = new System.Drawing.Size(55, 20);
            this.txtdist2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Distanta 2:";
            // 
            // txtdist4
            // 
            this.txtdist4.Location = new System.Drawing.Point(153, 242);
            this.txtdist4.Name = "txtdist4";
            this.txtdist4.Size = new System.Drawing.Size(55, 20);
            this.txtdist4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Distanta 4:";
            // 
            // txtdist3
            // 
            this.txtdist3.Location = new System.Drawing.Point(153, 199);
            this.txtdist3.Name = "txtdist3";
            this.txtdist3.Size = new System.Drawing.Size(55, 20);
            this.txtdist3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Distanta 3:";
            // 
            // txtdist5
            // 
            this.txtdist5.Location = new System.Drawing.Point(153, 291);
            this.txtdist5.Name = "txtdist5";
            this.txtdist5.Size = new System.Drawing.Size(55, 20);
            this.txtdist5.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Distanta 5:";
            // 
            // txtdist10
            // 
            this.txtdist10.Location = new System.Drawing.Point(229, 291);
            this.txtdist10.Name = "txtdist10";
            this.txtdist10.Size = new System.Drawing.Size(55, 20);
            this.txtdist10.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Distanta 10:";
            // 
            // txtdist9
            // 
            this.txtdist9.Location = new System.Drawing.Point(229, 242);
            this.txtdist9.Name = "txtdist9";
            this.txtdist9.Size = new System.Drawing.Size(55, 20);
            this.txtdist9.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Distanta 9:";
            // 
            // txtdist8
            // 
            this.txtdist8.Location = new System.Drawing.Point(229, 199);
            this.txtdist8.Name = "txtdist8";
            this.txtdist8.Size = new System.Drawing.Size(55, 20);
            this.txtdist8.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Distanta 8:";
            // 
            // txtdist7
            // 
            this.txtdist7.Location = new System.Drawing.Point(229, 150);
            this.txtdist7.Name = "txtdist7";
            this.txtdist7.Size = new System.Drawing.Size(55, 20);
            this.txtdist7.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Distanta 7:";
            // 
            // txtdist6
            // 
            this.txtdist6.Location = new System.Drawing.Point(229, 107);
            this.txtdist6.Name = "txtdist6";
            this.txtdist6.Size = new System.Drawing.Size(55, 20);
            this.txtdist6.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(226, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Distanta 6:";
            // 
            // combocapete
            // 
            this.combocapete.FormattingEnabled = true;
            this.combocapete.Items.AddRange(new object[] {
            "Arc de cerc",
            "Taiere"});
            this.combocapete.Location = new System.Drawing.Point(12, 196);
            this.combocapete.Name = "combocapete";
            this.combocapete.Size = new System.Drawing.Size(103, 21);
            this.combocapete.TabIndex = 28;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(822, 138);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(317, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 423);
            this.panel1.TabIndex = 30;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(163, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Coordonate:";
            // 
            // lblCoord
            // 
            this.lblCoord.AutoSize = true;
            this.lblCoord.Location = new System.Drawing.Point(163, 369);
            this.lblCoord.Name = "lblCoord";
            this.lblCoord.Size = new System.Drawing.Size(13, 13);
            this.lblCoord.TabIndex = 32;
            this.lblCoord.Text = "  ";
            // 
            // txtraza
            // 
            this.txtraza.Location = new System.Drawing.Point(12, 404);
            this.txtraza.Name = "txtraza";
            this.txtraza.Size = new System.Drawing.Size(99, 20);
            this.txtraza.TabIndex = 34;
            // 
            // lblraza
            // 
            this.lblraza.AutoSize = true;
            this.lblraza.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblraza.ForeColor = System.Drawing.Color.Brown;
            this.lblraza.Location = new System.Drawing.Point(13, 387);
            this.lblraza.Name = "lblraza";
            this.lblraza.Size = new System.Drawing.Size(91, 14);
            this.lblraza.TabIndex = 33;
            this.lblraza.Text = "Raza Cerc:";
            // 
            // BtnDeseneazaCerc
            // 
            this.BtnDeseneazaCerc.Location = new System.Drawing.Point(130, 392);
            this.BtnDeseneazaCerc.Name = "BtnDeseneazaCerc";
            this.BtnDeseneazaCerc.Size = new System.Drawing.Size(134, 42);
            this.BtnDeseneazaCerc.TabIndex = 35;
            this.BtnDeseneazaCerc.Text = "Deseneaza Cerc";
            this.BtnDeseneazaCerc.UseVisualStyleBackColor = true;
            this.BtnDeseneazaCerc.Click += new System.EventHandler(this.BtnDeseneazaCerc_Click);
            // 
            // BtnClearPanel
            // 
            this.BtnClearPanel.Location = new System.Drawing.Point(130, 452);
            this.BtnClearPanel.Name = "BtnClearPanel";
            this.BtnClearPanel.Size = new System.Drawing.Size(134, 42);
            this.BtnClearPanel.TabIndex = 36;
            this.BtnClearPanel.Text = "Clear Panel";
            this.BtnClearPanel.UseVisualStyleBackColor = true;
            this.BtnClearPanel.Click += new System.EventHandler(this.BtnClearPanel_Click);
            // 
            // BtnClearPanelData
            // 
            this.BtnClearPanelData.Location = new System.Drawing.Point(16, 452);
            this.BtnClearPanelData.Name = "BtnClearPanelData";
            this.BtnClearPanelData.Size = new System.Drawing.Size(105, 42);
            this.BtnClearPanelData.TabIndex = 37;
            this.BtnClearPanelData.Text = "Clear Panel Data";
            this.BtnClearPanelData.UseVisualStyleBackColor = true;
            this.BtnClearPanelData.Click += new System.EventHandler(this.BtnClearPanelData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 519);
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

