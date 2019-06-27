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
    public partial class FrmToDoWeek : Form
    {

        string toDoType;

        ToDoListWeekManager toDoListWeekManager = new ToDoListWeekManager();

        public FrmToDoWeek(string toDoType)
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

        private void FrmToDoWeek_Load(object sender, EventArgs e)
        {
            ShowData();
            lblDate.Text = "Tarih : " + DateTime.Now.ToShortDateString();
        }

        void ShowData()
        {
            if (toDoType == "Ozel")
            {
                int currentWeek = DateTime.Now.DayOfYear / 7;
                dataGridView1.DataSource = toDoListWeekManager.GetAll().Where(x => x.Week == currentWeek).ToList();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = toDoListWeekManager.GetAll();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtId.Text == null)
            {
                ToDoListWeek toDoListWeek = new ToDoListWeek();
                toDoListWeek.Id = Convert.ToInt32(txtId.Text);
                toDoListWeek.Title = txtTitle.Text;
                toDoListWeek.Completed = txtCompleted.Text;

                toDoListWeekManager.UpdateOnlyMainSections(toDoListWeek.Id, toDoListWeek);
                MessageBox.Show("Yapılacak Bilgileri Başarıyla Güncellendi.");
                ShowData();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtId.Text == null)
            {
                ToDoListWeek toDoListWeek = new ToDoListWeek();
                toDoListWeek.Id = Convert.ToInt32(txtId.Text);
                toDoListWeek.Completed = txtCompleted.Text;

                toDoListWeekManager.UpdateCompletedStatus(toDoListWeek.Id, toDoListWeek.Completed);
                MessageBox.Show("Durum Bilgisi Başarıyla Güncellendi.");
                txtCompleted.Text = toDoListWeek.Completed == "Tamamlandı" ? "Tamamlanmadı" : "Tamamlandı";
                ShowData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtId.Text == null)
            {
                var id = Convert.ToInt32(txtId.Text);
                toDoListWeekManager.Delete(id);
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
                txtCompleted.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
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
