namespace ControleDeGasto
{
    partial class Form_Home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            Gbox_Category = new GroupBox();
            Btn_CreateCategory = new Button();
            Cbox_Type = new ComboBox();
            Lbl_CategoryType = new Label();
            Txt_CategoryName = new TextBox();
            Lbl_CategoryName = new Label();
            Gbox_Transaction = new GroupBox();
            Lbl_TransactionDate = new Label();
            Dtp_TransactionDate = new DateTimePicker();
            Txt_TransactionAmount = new TextBox();
            Lbl_TransactionAmount = new Label();
            Btn_CreateTransaction = new Button();
            Cbox_CategoryType = new ComboBox();
            Lbl_CategoriaType = new Label();
            Tb_Transaction = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Chart_Transactions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Gbox_Category.SuspendLayout();
            Gbox_Transaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tb_Transaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Chart_Transactions).BeginInit();
            SuspendLayout();
            // 
            // Gbox_Category
            // 
            Gbox_Category.Controls.Add(Btn_CreateCategory);
            Gbox_Category.Controls.Add(Cbox_Type);
            Gbox_Category.Controls.Add(Lbl_CategoryType);
            Gbox_Category.Controls.Add(Txt_CategoryName);
            Gbox_Category.Controls.Add(Lbl_CategoryName);
            Gbox_Category.Location = new Point(12, 12);
            Gbox_Category.Name = "Gbox_Category";
            Gbox_Category.Size = new Size(631, 141);
            Gbox_Category.TabIndex = 0;
            Gbox_Category.TabStop = false;
            Gbox_Category.Text = "Categoria";
            // 
            // Btn_CreateCategory
            // 
            Btn_CreateCategory.Location = new Point(263, 106);
            Btn_CreateCategory.Name = "Btn_CreateCategory";
            Btn_CreateCategory.Size = new Size(122, 29);
            Btn_CreateCategory.TabIndex = 4;
            Btn_CreateCategory.Text = "Criar Categoria";
            Btn_CreateCategory.UseVisualStyleBackColor = true;
            Btn_CreateCategory.Click += Btn_CreateCategory_Click;
            // 
            // Cbox_Type
            // 
            Cbox_Type.FormattingEnabled = true;
            Cbox_Type.Items.AddRange(new object[] { "Receita", "Despesa" });
            Cbox_Type.Location = new Point(426, 36);
            Cbox_Type.Name = "Cbox_Type";
            Cbox_Type.Size = new Size(151, 28);
            Cbox_Type.TabIndex = 3;
            // 
            // Lbl_CategoryType
            // 
            Lbl_CategoryType.AutoSize = true;
            Lbl_CategoryType.Location = new Point(378, 39);
            Lbl_CategoryType.Name = "Lbl_CategoryType";
            Lbl_CategoryType.Size = new Size(42, 20);
            Lbl_CategoryType.TabIndex = 2;
            Lbl_CategoryType.Text = "Tipo:";
            // 
            // Txt_CategoryName
            // 
            Txt_CategoryName.Location = new Point(89, 39);
            Txt_CategoryName.Name = "Txt_CategoryName";
            Txt_CategoryName.Size = new Size(202, 27);
            Txt_CategoryName.TabIndex = 1;
            // 
            // Lbl_CategoryName
            // 
            Lbl_CategoryName.AutoSize = true;
            Lbl_CategoryName.Location = new Point(30, 39);
            Lbl_CategoryName.Name = "Lbl_CategoryName";
            Lbl_CategoryName.Size = new Size(53, 20);
            Lbl_CategoryName.TabIndex = 0;
            Lbl_CategoryName.Text = "Nome:";
            // 
            // Gbox_Transaction
            // 
            Gbox_Transaction.Controls.Add(Lbl_TransactionDate);
            Gbox_Transaction.Controls.Add(Dtp_TransactionDate);
            Gbox_Transaction.Controls.Add(Txt_TransactionAmount);
            Gbox_Transaction.Controls.Add(Lbl_TransactionAmount);
            Gbox_Transaction.Controls.Add(Btn_CreateTransaction);
            Gbox_Transaction.Controls.Add(Cbox_CategoryType);
            Gbox_Transaction.Controls.Add(Lbl_CategoriaType);
            Gbox_Transaction.Location = new Point(12, 159);
            Gbox_Transaction.Name = "Gbox_Transaction";
            Gbox_Transaction.Size = new Size(878, 141);
            Gbox_Transaction.TabIndex = 1;
            Gbox_Transaction.TabStop = false;
            Gbox_Transaction.Text = "Transação";
            // 
            // Lbl_TransactionDate
            // 
            Lbl_TransactionDate.AutoSize = true;
            Lbl_TransactionDate.Location = new Point(587, 44);
            Lbl_TransactionDate.Name = "Lbl_TransactionDate";
            Lbl_TransactionDate.Size = new Size(44, 20);
            Lbl_TransactionDate.TabIndex = 8;
            Lbl_TransactionDate.Text = "Data:";
            // 
            // Dtp_TransactionDate
            // 
            Dtp_TransactionDate.Format = DateTimePickerFormat.Short;
            Dtp_TransactionDate.Location = new Point(641, 41);
            Dtp_TransactionDate.Name = "Dtp_TransactionDate";
            Dtp_TransactionDate.Size = new Size(121, 27);
            Dtp_TransactionDate.TabIndex = 7;
            // 
            // Txt_TransactionAmount
            // 
            Txt_TransactionAmount.Location = new Point(378, 43);
            Txt_TransactionAmount.Name = "Txt_TransactionAmount";
            Txt_TransactionAmount.Size = new Size(166, 27);
            Txt_TransactionAmount.TabIndex = 6;
            // 
            // Lbl_TransactionAmount
            // 
            Lbl_TransactionAmount.AutoSize = true;
            Lbl_TransactionAmount.Location = new Point(326, 44);
            Lbl_TransactionAmount.Name = "Lbl_TransactionAmount";
            Lbl_TransactionAmount.Size = new Size(46, 20);
            Lbl_TransactionAmount.TabIndex = 5;
            Lbl_TransactionAmount.Text = "Valor:";
            // 
            // Btn_CreateTransaction
            // 
            Btn_CreateTransaction.Location = new Point(378, 106);
            Btn_CreateTransaction.Name = "Btn_CreateTransaction";
            Btn_CreateTransaction.Size = new Size(122, 29);
            Btn_CreateTransaction.TabIndex = 4;
            Btn_CreateTransaction.Text = "Criar Transação";
            Btn_CreateTransaction.UseVisualStyleBackColor = true;
            Btn_CreateTransaction.Click += Btn_CreateTransaction_Click;
            // 
            // Cbox_CategoryType
            // 
            Cbox_CategoryType.FormattingEnabled = true;
            Cbox_CategoryType.Items.AddRange(new object[] { "Receita", "Despesa" });
            Cbox_CategoryType.Location = new Point(113, 44);
            Cbox_CategoryType.Name = "Cbox_CategoryType";
            Cbox_CategoryType.Size = new Size(151, 28);
            Cbox_CategoryType.TabIndex = 3;
            // 
            // Lbl_CategoriaType
            // 
            Lbl_CategoriaType.AutoSize = true;
            Lbl_CategoriaType.Location = new Point(30, 44);
            Lbl_CategoriaType.Name = "Lbl_CategoriaType";
            Lbl_CategoriaType.Size = new Size(77, 20);
            Lbl_CategoriaType.TabIndex = 2;
            Lbl_CategoriaType.Text = "Categoria:";
            // 
            // Tb_Transaction
            // 
            Tb_Transaction.AllowUserToAddRows = false;
            Tb_Transaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tb_Transaction.Location = new Point(12, 306);
            Tb_Transaction.Name = "Tb_Transaction";
            Tb_Transaction.ReadOnly = true;
            Tb_Transaction.RowHeadersWidth = 51;
            Tb_Transaction.Size = new Size(803, 262);
            Tb_Transaction.TabIndex = 2;
            // 
            // Chart_Transactions
            // 
            chartArea2.Name = "ChartArea1";
            Chart_Transactions.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            Chart_Transactions.Legends.Add(legend2);
            Chart_Transactions.Location = new Point(959, 68);
            Chart_Transactions.Name = "Chart_Transactions";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            Chart_Transactions.Series.Add(series2);
            Chart_Transactions.Size = new Size(435, 428);
            Chart_Transactions.TabIndex = 3;
            Chart_Transactions.Text = "chart1";
            // 
            // Form_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 574);
            Controls.Add(Chart_Transactions);
            Controls.Add(Tb_Transaction);
            Controls.Add(Gbox_Transaction);
            Controls.Add(Gbox_Category);
            Name = "Form_Home";
            Text = "Form1";
            Gbox_Category.ResumeLayout(false);
            Gbox_Category.PerformLayout();
            Gbox_Transaction.ResumeLayout(false);
            Gbox_Transaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Tb_Transaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)Chart_Transactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Gbox_Category;
        private ComboBox Cbox_Type;
        private Label Lbl_CategoryType;
        private TextBox Txt_CategoryName;
        private Label Lbl_CategoryName;
        private Button Btn_CreateCategory;
        private GroupBox Gbox_Transaction;
        private Label Lbl_TransactionAmount;
        private Button Btn_CreateTransaction;
        private ComboBox Cbox_CategoryType;
        private Label Lbl_CategoriaType;
        private TextBox Txt_TransactionAmount;
        private DataGridView Tb_Transaction;
        private DateTimePicker Dtp_TransactionDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label Lbl_TransactionDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Transactions;
    }
}
