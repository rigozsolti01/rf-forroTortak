namespace rf_kliensapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddProduct = new Button();
            txtProductName = new TextBox();
            btnDeleteProduct = new Button();
            productsListView = new ListBox();
            txtProductPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            currentProductName = new TextBox();
            currentProductPrice = new TextBox();
            updateProductPrice = new TextBox();
            updateProductName = new TextBox();
            buttonUpdateProduct = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(232, 134);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(127, 52);
            buttonAddProduct.TabIndex = 0;
            buttonAddProduct.Text = "Add Product";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(113, 134);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 1;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.White;
            btnDeleteProduct.Location = new Point(496, 384);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(272, 38);
            btnDeleteProduct.TabIndex = 4;
            btnDeleteProduct.Text = "Please Choose a Product to Delete";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // productsListView
            // 
            productsListView.FormattingEnabled = true;
            productsListView.ItemHeight = 15;
            productsListView.Location = new Point(496, 134);
            productsListView.Name = "productsListView";
            productsListView.Size = new Size(272, 244);
            productsListView.TabIndex = 6;
            productsListView.SelectedIndexChanged += productsListView_SelectedIndexChanged;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(113, 163);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(100, 23);
            txtProductPrice.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 137);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 9;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 166);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 10;
            label2.Text = "Product Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 60);
            label3.Name = "label3";
            label3.Size = new Size(232, 51);
            label3.TabIndex = 11;
            label3.Text = "Add Product";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(496, 60);
            label4.Name = "label4";
            label4.Size = new Size(272, 51);
            label4.TabIndex = 12;
            label4.Text = "Delete Product";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(903, 60);
            label5.Name = "label5";
            label5.Size = new Size(285, 51);
            label5.TabIndex = 13;
            label5.Text = "Update Product";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(863, 171);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 14;
            label6.Text = "Product Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(863, 200);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 15;
            label7.Text = "Product Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(989, 134);
            label8.Name = "label8";
            label8.Size = new Size(78, 27);
            label8.TabIndex = 16;
            label8.Text = "Current";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1169, 134);
            label9.Name = "label9";
            label9.Size = new Size(97, 27);
            label9.TabIndex = 17;
            label9.Text = "Update to";
            // 
            // currentProductName
            // 
            currentProductName.Location = new Point(953, 168);
            currentProductName.Name = "currentProductName";
            currentProductName.ReadOnly = true;
            currentProductName.Size = new Size(145, 23);
            currentProductName.TabIndex = 18;
            // 
            // currentProductPrice
            // 
            currentProductPrice.Location = new Point(953, 197);
            currentProductPrice.Name = "currentProductPrice";
            currentProductPrice.ReadOnly = true;
            currentProductPrice.Size = new Size(145, 23);
            currentProductPrice.TabIndex = 19;
            // 
            // updateProductPrice
            // 
            updateProductPrice.Location = new Point(1145, 197);
            updateProductPrice.Name = "updateProductPrice";
            updateProductPrice.Size = new Size(145, 23);
            updateProductPrice.TabIndex = 20;
            // 
            // updateProductName
            // 
            updateProductName.Location = new Point(1145, 166);
            updateProductName.Name = "updateProductName";
            updateProductName.Size = new Size(145, 23);
            updateProductName.TabIndex = 21;
            // 
            // buttonUpdateProduct
            // 
            buttonUpdateProduct.BackColor = Color.White;
            buttonUpdateProduct.Location = new Point(1145, 226);
            buttonUpdateProduct.Name = "buttonUpdateProduct";
            buttonUpdateProduct.Size = new Size(145, 39);
            buttonUpdateProduct.TabIndex = 22;
            buttonUpdateProduct.Text = "Update";
            buttonUpdateProduct.UseVisualStyleBackColor = false;
            buttonUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(868, 290);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(422, 291);
            richTextBox1.TabIndex = 23;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(1326, 290);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(422, 291);
            richTextBox2.TabIndex = 24;
            richTextBox2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1967, 725);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(buttonUpdateProduct);
            Controls.Add(updateProductName);
            Controls.Add(updateProductPrice);
            Controls.Add(currentProductPrice);
            Controls.Add(currentProductName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProductPrice);
            Controls.Add(productsListView);
            Controls.Add(btnDeleteProduct);
            Controls.Add(txtProductName);
            Controls.Add(buttonAddProduct);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddProduct;
        private TextBox txtProductName;
        private Button btnDeleteProduct;
        private ListBox productsListView;
        private TextBox txtProductPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox currentProductName;
        private TextBox currentProductPrice;
        private TextBox updateProductPrice;
        private TextBox updateProductName;
        private Button buttonUpdateProduct;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
    }
}