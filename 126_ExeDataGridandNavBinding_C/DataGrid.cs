using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _126_ExeDataGridandNavBinding_C
{
    public partial class DataGrid : Form
    {
        public DataGrid()
        {
            InitializeComponent();
        }

        private void DataGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;

            dataGridView1.Columns[0].HeaderText = "No. Mahasiswa";
            dataGridView1.Columns[1].HeaderText = "Nama Mahasiswa";
            dataGridView1.Columns[2].HeaderText = "Alamat Mahasiswa";
            dataGridView1.Columns[3].HeaderText = "Jenis Kelamin";
            dataGridView1.Columns[4].HeaderText = "No. Telepon";

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.SlateBlue;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.DarkCyan;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Maroon;

            dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;
            dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Green;
            dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            homepage data = new homepage();
            data.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            FormDataGrid view = new FormDataGrid();
            view.tbNim.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            view.tbNm.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            view.tbAlmt.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            view.tbJK.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            view.tbTelp.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            view.Show();
        }
    }
}
