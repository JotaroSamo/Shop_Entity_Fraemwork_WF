
namespace Cars
{
    partial class Pay
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
            this.components = new System.ComponentModel.Container();
            this.TablePr = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_detals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Params = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDetal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Tablbasket = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Film_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablePr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablbasket)).BeginInit();
            this.SuspendLayout();
            // 
            // TablePr
            // 
            this.TablePr.AllowUserToAddRows = false;
            this.TablePr.AllowUserToDeleteRows = false;
            this.TablePr.AutoGenerateColumns = false;
            this.TablePr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablePr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Name_detals,
            this.Params,
            this.amount,
            this.PriceDetal});
            this.TablePr.DataSource = this.priceBindingSource;
            this.TablePr.Location = new System.Drawing.Point(12, 1);
            this.TablePr.Name = "TablePr";
            this.TablePr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablePr.Size = new System.Drawing.Size(451, 511);
            this.TablePr.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // Name_detals
            // 
            this.Name_detals.DataPropertyName = "Name_detals";
            this.Name_detals.HeaderText = "Товар";
            this.Name_detals.Name = "Name_detals";
            // 
            // Params
            // 
            this.Params.DataPropertyName = "Params";
            this.Params.HeaderText = "Параметры";
            this.Params.Name = "Params";
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "Осталось";
            this.amount.Name = "amount";
            // 
            // PriceDetal
            // 
            this.PriceDetal.DataPropertyName = "PriceDetal";
            this.PriceDetal.HeaderText = "Цена";
            this.PriceDetal.Name = "PriceDetal";
            // 
            // priceBindingSource
            // 
            this.priceBindingSource.DataSource = typeof(Cars.Price);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "Купить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tablbasket
            // 
            this.Tablbasket.AllowUserToAddRows = false;
            this.Tablbasket.AllowUserToDeleteRows = false;
            this.Tablbasket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tablbasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablbasket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Film_Name,
            this.Date,
            this.Price});
            this.Tablbasket.Location = new System.Drawing.Point(589, 1);
            this.Tablbasket.Name = "Tablbasket";
            this.Tablbasket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tablbasket.Size = new System.Drawing.Size(430, 511);
            this.Tablbasket.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "Номер";
            this.ID.Name = "ID";
            // 
            // Film_Name
            // 
            this.Film_Name.HeaderText = "Товар";
            this.Film_Name.Name = "Film_Name";
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата покупки";
            this.Date.Name = "Date";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 92);
            this.button2.TabIndex = 3;
            this.button2.Text = "Вернуть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Tablbasket);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TablePr);
            this.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            this.Load += new System.EventHandler(this.Pay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablePr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tablbasket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView TablePr;
        private System.Windows.Forms.BindingSource priceBindingSource;
        private System.Windows.Forms.Button button1;
        protected internal System.Windows.Forms.DataGridView Tablbasket;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn namefilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountcopyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceFilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_detals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Params;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceDetal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Film_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}