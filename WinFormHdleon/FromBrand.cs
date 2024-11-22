using App;
using Entities;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormHdleon
{
    public partial class FromBrand : Form
    {
        private IRepository<Brand>? _repository;
        private readonly IServiceProvider _serviceProvider;


        public FromBrand(IRepository<Brand>? repository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _repository = repository;
            _serviceProvider = serviceProvider;
        }

        private async Task RefreshGrid()
        {
            var brands = await _repository!.GetAllAsync();
            dataGridView1.DataSource = brands.ToList();
        }

        private async void FromBrand_Load(object sender, EventArgs e)
        {
            await RefreshGrid();
            AddColumns();
        }

        private void AddColumns()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "EditButton";
            editButtonColumn.HeaderText = string.Empty;
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.Text = "Editar";
            editButtonColumn.DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Columns.Add(editButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.HeaderText = string.Empty;
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.Columns.Add(deleteButtonColumn);


        }

        private async void BtnNuevaMarca_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<FormNewEditBrand>();

            frm.ShowDialog();
            await RefreshGrid();
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

            if (dataGridView1.Columns[e.ColumnIndex].Name=="EditButton")
            {
                var frm = _serviceProvider.GetRequiredService<FormNewEditBrand>();
                var brand = await _repository!.GetByIdAsync(id);
                frm.SetInfo(brand);
                frm.ShowDialog();
                await RefreshGrid();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name =="DeleteButton")
            {
                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar?","Confirm delete",MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes) 
                {
                    await _repository!.DeleteAsyn(id);
                    await RefreshGrid();
                }
            }
        }
    }
}
