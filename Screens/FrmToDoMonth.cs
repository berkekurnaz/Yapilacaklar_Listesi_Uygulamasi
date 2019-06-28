using KisiselYapilacaklarApp.BusinessLayer.Concrete;
using KisiselYapilacaklarApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselYapilacaklarApp.Screens
{
    public partial class FrmToDoMonth : Form
    {

        string toDoType;

        ToDoListMonthManager toDoListMonthManager = new ToDoListMonthManager();

        public FrmToDoMonth(string toDoType)
        {
            InitializeComponent();
            this.toDoType = toDoType;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void FrmToDoMonth_Load(object sender, EventArgs e)
        {
            ShowData();
            lblDate.Text = "Tarih : " + DateTime.Now.ToShortDateString();
        }

        void ShowData()
        {
            if (toDoType == "Ozel")
            {
                int currentMonth = DateTime.Now.Month;
                int currentYear = DateTime.Now.Year;
                dataGridView1.DataSource = toDoListMonthManager.GetAll().Where(x => x.Month == currentMonth && x.Year == currentYear).ToList();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = toDoListMonthManager.GetAll();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtId.Text == null)
            {
                ToDoListMonth toDoListMonth = new ToDoListMonth();
                toDoListMonth.Id = Convert.ToInt32(txtId.Text);
                toDoListMonth.Title = txtTitle.Text;
                toDoListMonth.Completed = txtCompleted.Text;

                toDoListMonthManager.UpdateOnlyMainSections(toDoListMonth.Id, toDoListMonth);
                MessageBox.Show("Yapılacak Bilgileri Başarıyla Güncellendi.");
                ShowData();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtId.Text == null)
            {
                ToDoListMonth toDoListMonth = new ToDoListMonth();
                toDoListMonth.Id = Convert.ToInt32(txtId.Text);
                toDoListMonth.Completed = txtCompleted.Text;

                toDoListMonthManager.UpdateCompletedStatus(toDoListMonth.Id, toDoListMonth.Completed);
                MessageBox.Show("Durum Bilgisi Başarıyla Güncellendi.");
                txtCompleted.Text = toDoListMonth.Completed == "Tamamlandı" ? "Tamamlanmadı" : "Tamamlandı";
                ShowData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtId.Text == null)
            {
                var id = Convert.ToInt32(txtId.Text);
                toDoListMonthManager.Delete(id);
                MessageBox.Show("Yapılacak Başarıyla Silindi.");
                ShowData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
            try
            {
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCompleted.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "Tamamlandı")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "Tamamlanmadı")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}
