namespace Shopping.FormUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.tbxProductSearch = new System.Windows.Forms.TextBox();
            this.cbxCategorySearch = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxProductNameUpd = new System.Windows.Forms.TextBox();
            this.tbxProductPriceUpd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxProductStockUpd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxCategoryUpd = new System.Windows.Forms.ComboBox();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxProductStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxProductPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 12);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(573, 426);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // tbxProductSearch
            // 
            this.tbxProductSearch.Location = new System.Drawing.Point(737, 45);
            this.tbxProductSearch.Name = "tbxProductSearch";
            this.tbxProductSearch.Size = new System.Drawing.Size(130, 20);
            this.tbxProductSearch.TabIndex = 1;
            this.tbxProductSearch.TextChanged += new System.EventHandler(this.tbxProductSearch_TextChanged);
            // 
            // cbxCategorySearch
            // 
            this.cbxCategorySearch.FormattingEnabled = true;
            this.cbxCategorySearch.Location = new System.Drawing.Point(594, 45);
            this.cbxCategorySearch.Name = "cbxCategorySearch";
            this.cbxCategorySearch.Size = new System.Drawing.Size(137, 21);
            this.cbxCategorySearch.TabIndex = 2;
            this.cbxCategorySearch.SelectedIndexChanged += new System.EventHandler(this.cbxCategorySearch_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProductUpdate);
            this.groupBox1.Controls.Add(this.cbxCategoryUpd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbxProductStockUpd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbxProductPriceUpd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxProductNameUpd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(594, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 243);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünü Düzenle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kategori Seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ürün Ara:";
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(696, 95);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProductDelete.TabIndex = 8;
            this.btnProductDelete.Text = "Ürünü Sil";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ürün Adı:";
            // 
            // tbxProductNameUpd
            // 
            this.tbxProductNameUpd.Location = new System.Drawing.Point(6, 46);
            this.tbxProductNameUpd.Name = "tbxProductNameUpd";
            this.tbxProductNameUpd.Size = new System.Drawing.Size(125, 20);
            this.tbxProductNameUpd.TabIndex = 9;
            // 
            // tbxProductPriceUpd
            // 
            this.tbxProductPriceUpd.Location = new System.Drawing.Point(6, 87);
            this.tbxProductPriceUpd.Name = "tbxProductPriceUpd";
            this.tbxProductPriceUpd.Size = new System.Drawing.Size(125, 20);
            this.tbxProductPriceUpd.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ürün Fiyatı:";
            // 
            // tbxProductStockUpd
            // 
            this.tbxProductStockUpd.Location = new System.Drawing.Point(6, 129);
            this.tbxProductStockUpd.Name = "tbxProductStockUpd";
            this.tbxProductStockUpd.Size = new System.Drawing.Size(125, 20);
            this.tbxProductStockUpd.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stok:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kategori:";
            // 
            // cbxCategoryUpd
            // 
            this.cbxCategoryUpd.FormattingEnabled = true;
            this.cbxCategoryUpd.Location = new System.Drawing.Point(6, 168);
            this.cbxCategoryUpd.Name = "cbxCategoryUpd";
            this.cbxCategoryUpd.Size = new System.Drawing.Size(125, 21);
            this.cbxCategoryUpd.TabIndex = 9;
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(6, 204);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(125, 23);
            this.btnProductUpdate.TabIndex = 9;
            this.btnProductUpdate.Text = "Düzenle";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProductAdd);
            this.groupBox2.Controls.Add(this.cbxCategory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbxProductStock);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbxProductPrice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbxProductName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(737, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 243);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Ürün Ekle";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(6, 204);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(125, 23);
            this.btnProductAdd.TabIndex = 9;
            this.btnProductAdd.Text = "Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(6, 168);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(125, 21);
            this.cbxCategory.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kategori:";
            // 
            // tbxProductStock
            // 
            this.tbxProductStock.Location = new System.Drawing.Point(6, 129);
            this.tbxProductStock.Name = "tbxProductStock";
            this.tbxProductStock.Size = new System.Drawing.Size(125, 20);
            this.tbxProductStock.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Stok:";
            // 
            // tbxProductPrice
            // 
            this.tbxProductPrice.Location = new System.Drawing.Point(6, 87);
            this.tbxProductPrice.Name = "tbxProductPrice";
            this.tbxProductPrice.Size = new System.Drawing.Size(125, 20);
            this.tbxProductPrice.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ürün Fiyatı:";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(6, 46);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(125, 20);
            this.tbxProductName.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ürün Adı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCategorySearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxProductSearch);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.TextBox tbxProductSearch;
        private System.Windows.Forms.ComboBox cbxCategorySearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryUpd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxProductStockUpd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxProductPriceUpd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxProductNameUpd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxProductStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxProductPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label label10;
    }
}

