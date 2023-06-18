
namespace PiggyBank
{
    partial class KumbaraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KumbaraForm));
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.pnlDolu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalla = new System.Windows.Forms.Button();
            this.btnParaAt = new System.Windows.Forms.Button();
            this.btnKir = new System.Windows.Forms.Button();
            this.cmbKagitPara = new System.Windows.Forms.ComboBox();
            this.lblBozukPara = new System.Windows.Forms.Label();
            this.cmbBozukPara = new System.Windows.Forms.ComboBox();
            this.btnKatla = new System.Windows.Forms.Button();
            this.lblParaHacmi = new System.Windows.Forms.Label();
            this.lblFazladan = new System.Windows.Forms.Label();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTotal.Controls.Add(this.pnlDolu);
            this.pnlTotal.Location = new System.Drawing.Point(550, 64);
            this.pnlTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(360, 307);
            this.pnlTotal.TabIndex = 8;
            this.pnlTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTotal_Paint);
            // 
            // pnlDolu
            // 
            this.pnlDolu.BackColor = System.Drawing.Color.DarkGray;
            this.pnlDolu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDolu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDolu.Location = new System.Drawing.Point(0, 198);
            this.pnlDolu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDolu.Name = "pnlDolu";
            this.pnlDolu.Size = new System.Drawing.Size(356, 105);
            this.pnlDolu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(610, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "BANKNOTE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSalla
            // 
            this.btnSalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalla.BackColor = System.Drawing.Color.Transparent;
            this.btnSalla.ForeColor = System.Drawing.Color.Black;
            this.btnSalla.Location = new System.Drawing.Point(34, 466);
            this.btnSalla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(87, 28);
            this.btnSalla.TabIndex = 16;
            this.btnSalla.Text = "SHAKE İT!!";
            this.btnSalla.UseVisualStyleBackColor = false;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // btnParaAt
            // 
            this.btnParaAt.BackColor = System.Drawing.Color.Transparent;
            this.btnParaAt.ForeColor = System.Drawing.Color.Black;
            this.btnParaAt.Location = new System.Drawing.Point(499, 457);
            this.btnParaAt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnParaAt.Name = "btnParaAt";
            this.btnParaAt.Size = new System.Drawing.Size(87, 46);
            this.btnParaAt.TabIndex = 15;
            this.btnParaAt.Text = "Throw Money!";
            this.btnParaAt.UseVisualStyleBackColor = false;
            this.btnParaAt.Click += new System.EventHandler(this.btnParaAt_Click);
            // 
            // btnKir
            // 
            this.btnKir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKir.BackColor = System.Drawing.Color.Transparent;
            this.btnKir.ForeColor = System.Drawing.Color.Black;
            this.btnKir.Location = new System.Drawing.Point(206, 466);
            this.btnKir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKir.Name = "btnKir";
            this.btnKir.Size = new System.Drawing.Size(87, 28);
            this.btnKir.TabIndex = 14;
            this.btnKir.Text = "BREAK!";
            this.btnKir.UseVisualStyleBackColor = false;
            this.btnKir.Click += new System.EventHandler(this.btnKir_Click);
            // 
            // cmbKagitPara
            // 
            this.cmbKagitPara.ForeColor = System.Drawing.Color.Black;
            this.cmbKagitPara.FormattingEnabled = true;
            this.cmbKagitPara.Location = new System.Drawing.Point(614, 470);
            this.cmbKagitPara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbKagitPara.Name = "cmbKagitPara";
            this.cmbKagitPara.Size = new System.Drawing.Size(140, 24);
            this.cmbKagitPara.TabIndex = 12;
            this.cmbKagitPara.SelectedIndexChanged += new System.EventHandler(this.cmbKagitPara_SelectedIndexChanged);
            // 
            // lblBozukPara
            // 
            this.lblBozukPara.AutoSize = true;
            this.lblBozukPara.ForeColor = System.Drawing.Color.White;
            this.lblBozukPara.Location = new System.Drawing.Point(321, 450);
            this.lblBozukPara.Name = "lblBozukPara";
            this.lblBozukPara.Size = new System.Drawing.Size(37, 16);
            this.lblBozukPara.TabIndex = 20;
            this.lblBozukPara.Text = "COIN";
            this.lblBozukPara.Click += new System.EventHandler(this.lblBozukPara_Click);
            // 
            // cmbBozukPara
            // 
            this.cmbBozukPara.ForeColor = System.Drawing.Color.Black;
            this.cmbBozukPara.FormattingEnabled = true;
            this.cmbBozukPara.Location = new System.Drawing.Point(324, 470);
            this.cmbBozukPara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBozukPara.Name = "cmbBozukPara";
            this.cmbBozukPara.Size = new System.Drawing.Size(140, 24);
            this.cmbBozukPara.TabIndex = 19;
            this.cmbBozukPara.SelectedIndexChanged += new System.EventHandler(this.cmbBozukPara_SelectedIndexChanged);
            // 
            // btnKatla
            // 
            this.btnKatla.BackColor = System.Drawing.Color.Transparent;
            this.btnKatla.ForeColor = System.Drawing.Color.Black;
            this.btnKatla.Location = new System.Drawing.Point(786, 467);
            this.btnKatla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKatla.Name = "btnKatla";
            this.btnKatla.Size = new System.Drawing.Size(87, 28);
            this.btnKatla.TabIndex = 21;
            this.btnKatla.Text = "Fold It!";
            this.btnKatla.UseVisualStyleBackColor = false;
            this.btnKatla.Visible = false;
            this.btnKatla.Click += new System.EventHandler(this.btnKatla_Click);
            // 
            // lblParaHacmi
            // 
            this.lblParaHacmi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblParaHacmi.AutoSize = true;
            this.lblParaHacmi.ForeColor = System.Drawing.Color.White;
            this.lblParaHacmi.Location = new System.Drawing.Point(670, 9);
            this.lblParaHacmi.Name = "lblParaHacmi";
            this.lblParaHacmi.Size = new System.Drawing.Size(111, 16);
            this.lblParaHacmi.TabIndex = 22;
            this.lblParaHacmi.Text = "Volume Of Coins: 0";
            this.lblParaHacmi.Click += new System.EventHandler(this.lblParaHacmi_Click);
            // 
            // lblFazladan
            // 
            this.lblFazladan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFazladan.AutoSize = true;
            this.lblFazladan.ForeColor = System.Drawing.Color.White;
            this.lblFazladan.Location = new System.Drawing.Point(670, 36);
            this.lblFazladan.Name = "lblFazladan";
            this.lblFazladan.Size = new System.Drawing.Size(203, 16);
            this.lblFazladan.TabIndex = 23;
            this.lblFazladan.Text = "Extra Volume Occupied By Coins :  0";
            this.lblFazladan.Click += new System.EventHandler(this.lblFazladan_Click);
            // 
            // KumbaraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(922, 529);
            this.Controls.Add(this.lblFazladan);
            this.Controls.Add(this.lblParaHacmi);
            this.Controls.Add(this.btnKatla);
            this.Controls.Add(this.lblBozukPara);
            this.Controls.Add(this.cmbBozukPara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalla);
            this.Controls.Add(this.btnParaAt);
            this.Controls.Add(this.btnKir);
            this.Controls.Add(this.cmbKagitPara);
            this.Controls.Add(this.pnlTotal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KumbaraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piggy Bank";
            this.pnlTotal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel pnlDolu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalla;
        private System.Windows.Forms.Button btnParaAt;
        private System.Windows.Forms.Button btnKir;
        private System.Windows.Forms.ComboBox cmbKagitPara;
        private System.Windows.Forms.Label lblBozukPara;
        private System.Windows.Forms.ComboBox cmbBozukPara;
        private System.Windows.Forms.Button btnKatla;
        private System.Windows.Forms.Label lblParaHacmi;
        private System.Windows.Forms.Label lblFazladan;
    }
}

