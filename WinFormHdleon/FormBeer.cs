using App;
using Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHdleon
{
    public partial class FormBeer : Form
    {
        private IRepository<Beer> _repository;
        private readonly IServiceProvider _serviceProvider;
        public FormBeer(IRepository<Beer> repository = null, IServiceProvider serviceProvider = null)
        {
            InitializeComponent();
            _repository = repository;
            _serviceProvider = serviceProvider;
        }

        private async Task RefreshGrid()
        {
            var cerveza = await _repository!.GetAllAsync();
            dataGridView1.DataSource = cerveza.ToList();
        }

        private async void FormBeer_Load(object sender, EventArgs e)
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

        private void BtnNuevaCerveza_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0) 
                return;

            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

            if (dataGridView1.Columns[e.ColumnIndex].Name == "EditButton")
            {

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name=="DeleteButton")
            {
                var confirmResult = MessageBox.Show("¿Estás seguro de eliminar?", "Confirm delete", MessageBoxButtons.YesNo);
            }
        }
    }
}
