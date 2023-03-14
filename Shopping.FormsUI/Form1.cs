using Shopping.Business.Abstract;
using Shopping.Business.DependencyResolvers.Ninject;
using Shopping.Entities.Concrete;

namespace Shopping.FormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private IProductService _productService;
        private ICategoryService _categoryService;



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategorySearch.DataSource = _categoryService.GetAll();
            cbxCategorySearch.DisplayMember = "CategoryName";
            cbxCategorySearch.ValueMember = "CategoryId";

            cbxCategoryUpd.DataSource = _categoryService.GetAll();
            cbxCategoryUpd.DisplayMember = "CategoryName";
            cbxCategoryUpd.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategorySearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategory.SelectedValue),
                    ProductName = tbxProductName.Text,
                    UnitPrice = Convert.ToDecimal(tbxProductPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxProductStock.Text)
                });
                MessageBox.Show("Ürün eklendi!");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxProductNameUpd.Text,
                CategoryId = Convert.ToInt32(cbxCategoryUpd.SelectedValue),
                UnitsInStock = Convert.ToInt16(tbxProductStockUpd.Text),
                UnitPrice = Convert.ToDecimal(tbxProductPriceUpd.Text)
            });
            MessageBox.Show("Ürün güncellendi!");
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxProductNameUpd.Text = row.Cells[1].Value.ToString();
            cbxCategoryUpd.SelectedValue = row.Cells[2].Value;
            tbxProductPriceUpd.Text = row.Cells[3].Value.ToString();
            tbxProductStock.Text = row.Cells[4].Value.ToString();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün silindi!");
                    LoadProducts();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}