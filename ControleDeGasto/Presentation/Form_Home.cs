using ControleDeGasto.Domain.Entities;
using ControleDeGasto.Domain.Interfaces.Services;
using ControleDeGasto.Infrastructure.Data;
using System.Data;
using System.Diagnostics;

namespace ControleDeGasto
{
    public partial class Form_Home : Form
    {

        private readonly ICategoryService _categoryService;
        private readonly ITransactionService _transactionService;
        private DataTable _transactionTable;

        public Form_Home(ICategoryService categoryService, ITransactionService transactionService)
        {
            InitializeComponent();
            _categoryService = categoryService;
            _transactionService = transactionService;
            Form_Home_Load(null, null);
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            LoadCategoryType();
            LoadCategories();
            ConfigTransactionTable();
            TransactionInTable();
        }

        private void LoadCategoryType()
        {
            CategoryType expense = new CategoryType() { Name = "Despesa", Value = "Expense" };
            CategoryType income = new CategoryType() { Name = "Receita", Value = "Income" };

            List<CategoryType> categoryTypes = new List<CategoryType> {
                expense,
                income
            };

            Cbox_Type.DisplayMember = "Name";
            Cbox_Type.ValueMember = "Value";

            Cbox_Type.DataSource = categoryTypes;

        }

        private void LoadCategories()
        {
            var categories = _categoryService.GetAllCategories();

            Cbox_CategoryType.DisplayMember = "Name";
            Cbox_CategoryType.ValueMember = "Id";

            Cbox_CategoryType.DataSource = categories;
        }

        private void ConfigTransactionTable()
        {
            _transactionTable = new DataTable();

            _transactionTable.Columns.Add("Id", typeof(int));
            _transactionTable.Columns.Add("Categoria", typeof(string));
            _transactionTable.Columns.Add("Valor", typeof(decimal));
            _transactionTable.Columns.Add("Data", typeof(string));

            Tb_Transaction.DataSource = _transactionTable;
        }

        private void TransactionInTable()
        {
            var transactions = _transactionService.GetAllTransactions();

            foreach (var transaction in transactions)
            {
                AddTransactionInTable(transaction);  
            }
        }

        private void AddTransactionInTable(Transaction transaction)
        {
            DataRow newLine = _transactionTable.NewRow();

            newLine["Id"] = transaction.Id;
            newLine["Categoria"] = transaction.CategoryId.ToString();
            newLine["Valor"] = transaction.Amount;
            newLine["Data"] = transaction.Date.ToString();

            _transactionTable.Rows.Add(newLine);
        }
        private void Btn_CreateCategory_Click(object sender, EventArgs e)
        {

            Category newCategory = new Category(Txt_CategoryName.Text, Cbox_Type.SelectedValue.ToString());
            _categoryService.AddCategory(newCategory);
            LoadCategories();
            Txt_CategoryName.Clear();
        }

        private void Btn_CreateTransaction_Click(object sender, EventArgs e)
        {
            Transaction newTransaction = new Transaction(
                decimal.Parse(Txt_TransactionAmount.Text),
                Dtp_TransactionDate.Value,
                "test transaction",
                (int)Cbox_CategoryType.SelectedValue
            );

            Transaction transactionSaved = _transactionService.AddTransaction(newTransaction);
            if (transactionSaved != null)
            {
                AddTransactionInTable(transactionSaved);
            }
            Txt_TransactionAmount.Clear();

        }
    }

    internal class CategoryType
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
