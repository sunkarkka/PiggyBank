
namespace PiggyBank
{
    partial class KırıkKumbaraForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KırıkKumbaraForm));
            this.dgvAtilanKagitParalar = new System.Windows.Forms.DataGridView();
            this.dgvAtilanBozukParalar = new System.Windows.Forms.DataGridView();
            this.lblKagitParalar = new System.Windows.Forms.Label();
            this.lblBozukParalar = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtilanKagitParalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtilanBozukParalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAtilanKagitParalar
            // 
            this.dgvAtilanKagitParalar.AllowUserToAddRows = false;
            this.dgvAtilanKagitParalar.AllowUserToDeleteRows = false;
            this.dgvAtilanKagitParalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtilanKagitParalar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAtilanKagitParalar.BackgroundColor = System.Drawing.Color.HotPink;
            this.dgvAtilanKagitParalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAtilanKagitParalar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAtilanKagitParalar.Location = new System.Drawing.Point(338, 46);
            this.dgvAtilanKagitParalar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAtilanKagitParalar.MultiSelect = false;
            this.dgvAtilanKagitParalar.Name = "dgvAtilanKagitParalar";
            this.dgvAtilanKagitParalar.ReadOnly = true;
            this.dgvAtilanKagitParalar.RowHeadersVisible = false;
            this.dgvAtilanKagitParalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtilanKagitParalar.Size = new System.Drawing.Size(219, 391);
            this.dgvAtilanKagitParalar.TabIndex = 0;
            this.dgvAtilanKagitParalar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtilanKagitParalar_CellContentClick);
            // 
            // dgvAtilanBozukParalar
            // 
            this.dgvAtilanBozukParalar.AllowUserToAddRows = false;
            this.dgvAtilanBozukParalar.AllowUserToDeleteRows = false;
            this.dgvAtilanBozukParalar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAtilanBozukParalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtilanBozukParalar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAtilanBozukParalar.BackgroundColor = System.Drawing.Color.Violet;
            this.dgvAtilanBozukParalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAtilanBozukParalar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAtilanBozukParalar.Location = new System.Drawing.Point(563, 46);
            this.dgvAtilanBozukParalar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAtilanBozukParalar.MultiSelect = false;
            this.dgvAtilanBozukParalar.Name = "dgvAtilanBozukParalar";
            this.dgvAtilanBozukParalar.ReadOnly = true;
            this.dgvAtilanBozukParalar.RowHeadersVisible = false;
            this.dgvAtilanBozukParalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtilanBozukParalar.Size = new System.Drawing.Size(219, 391);
            this.dgvAtilanBozukParalar.TabIndex = 1;
            // 
            // lblKagitParalar
            // 
            this.lblKagitParalar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKagitParalar.AutoSize = true;
            this.lblKagitParalar.BackColor = System.Drawing.Color.HotPink;
            this.lblKagitParalar.ForeColor = System.Drawing.Color.White;
            this.lblKagitParalar.Location = new System.Drawing.Point(361, 26);
            this.lblKagitParalar.Name = "lblKagitParalar";
            this.lblKagitParalar.Size = new System.Drawing.Size(180, 16);
            this.lblKagitParalar.TabIndex = 2;
            this.lblKagitParalar.Text = "Paper Money İn The Piggy Bank";
            this.lblKagitParalar.Click += new System.EventHandler(this.lblKagitParalar_Click_1);
            // 
            // lblBozukParalar
            // 
            this.lblBozukParalar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBozukParalar.AutoSize = true;
            this.lblBozukParalar.BackColor = System.Drawing.Color.HotPink;
            this.lblBozukParalar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBozukParalar.ForeColor = System.Drawing.Color.White;
            this.lblBozukParalar.Location = new System.Drawing.Point(602, 26);
            this.lblBozukParalar.Name = "lblBozukParalar";
            this.lblBozukParalar.Size = new System.Drawing.Size(138, 16);
            this.lblBozukParalar.TabIndex = 3;
            this.lblBozukParalar.Text = "Coins İn The Piggy Bank";
            // 
            // lblMiktar
            // 
            this.lblMiktar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.BackColor = System.Drawing.Color.HotPink;
            this.lblMiktar.ForeColor = System.Drawing.Color.White;
            this.lblMiktar.Location = new System.Drawing.Point(479, 441);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(165, 16);
            this.lblMiktar.TabIndex = 5;
            this.lblMiktar.Text = "Amount Of Money Saved: 0₺";
            // 
            // KırıkKumbaraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(796, 487);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblBozukParalar);
            this.Controls.Add(this.lblKagitParalar);
            this.Controls.Add(this.dgvAtilanBozukParalar);
            this.Controls.Add(this.dgvAtilanKagitParalar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KırıkKumbaraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Broken Piggy Bank";
            this.TransparencyKey = System.Drawing.Color.DarkTurquoise;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtilanKagitParalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtilanBozukParalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAtilanKagitParalar;
        private System.Windows.Forms.DataGridView dgvAtilanBozukParalar;
        private System.Windows.Forms.Label lblKagitParalar;
        private System.Windows.Forms.Label lblBozukParalar;
        private System.Windows.Forms.Label lblMiktar;
    }
}