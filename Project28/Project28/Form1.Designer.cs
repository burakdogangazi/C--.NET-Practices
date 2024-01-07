
namespace Project28
{
    partial class Dashboard
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.lnklblHelp = new System.Windows.Forms.LinkLabel();
            this.ncUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxSearchProduct = new System.Windows.Forms.TextBox();
            this.gbxProductName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(928, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxSearchProduct);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(30, 68);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(1098, 103);
            this.gbxProductName.TabIndex = 1;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Search By Product Name";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(36, 45);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(102, 17);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name:";
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(30, 204);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(1098, 418);
            this.dgwProduct.TabIndex = 4;
            // 
            // lnklblHelp
            // 
            this.lnklblHelp.AutoSize = true;
            this.lnklblHelp.LinkArea = new System.Windows.Forms.LinkArea(0, 20);
            this.lnklblHelp.Location = new System.Drawing.Point(831, 17);
            this.lnklblHelp.Name = "lnklblHelp";
            this.lnklblHelp.Size = new System.Drawing.Size(75, 20);
            this.lnklblHelp.TabIndex = 5;
            this.lnklblHelp.TabStop = true;
            this.lnklblHelp.Text = "Need Help?";
            this.lnklblHelp.UseCompatibleTextRendering = true;
            this.lnklblHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblHelp_LinkClicked);
            // 
            // ncUpDown
            // 
            this.ncUpDown.Location = new System.Drawing.Point(901, 652);
            this.ncUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ncUpDown.Name = "ncUpDown";
            this.ncUpDown.Size = new System.Drawing.Size(227, 22);
            this.ncUpDown.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(40, 713);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 10);
            this.panel1.TabIndex = 7;
            // 
            // tbxSearchProduct
            // 
            this.tbxSearchProduct.Location = new System.Drawing.Point(155, 40);
            this.tbxSearchProduct.Name = "tbxSearchProduct";
            this.tbxSearchProduct.Size = new System.Drawing.Size(222, 22);
            this.tbxSearchProduct.TabIndex = 5;
            this.tbxSearchProduct.TextChanged += new System.EventHandler(this.tbxSearchProduct_TextChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 600);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1166, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ncUpDown);
            this.Controls.Add(this.lnklblHelp);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbxProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.LinkLabel lnklblHelp;
        private System.Windows.Forms.NumericUpDown ncUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxSearchProduct;
    }
}

