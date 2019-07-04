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
    public partial class FrmNote : Form
    {
        public FrmNote()
        {
            InitializeComponent();
        }

        NoteManager noteManager = new NoteManager();

        private void FrmNote_Load(object sender, EventArgs e)
        {
            ShowAllData();
        }

        private void FrmNote_Activated(object sender, EventArgs e)
        {
            ShowAllData();
        }

        public void ShowAllData()
        {
            dataGridView1.DataSource = noteManager.GetAll();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            lblDate.Text = "Tarih : " + DateTime.Now.ToShortDateString();
        }

        public void ClearComponents()
        {
            txtId.Text = "";
            txtTitle.Text = "";
            txtContent.Text = "";
            txtCreatedDate.Text = "";
            cmbStatus.Text = "Düşük";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
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
                txtContent.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCreatedDate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch 
            {

            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "Düşük")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "Orta")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "Yüksek")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtId.Text == null)
            {
                Note note = new Note();
                note.Id = Convert.ToInt32(txtId.Text);
                note.Title = txtTitle.Text;
                note.Content = txtContent.Text;
                note.CreatedDate = txtCreatedDate.Text;
                note.Status = cmbStatus.Text;

                noteManager.Update(note.Id, note);
                MessageBox.Show("Not Bilgileri Başarıyla Güncellendi.");
                ShowAllData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtId.Text == null)
            {
                var id = Convert.ToInt32(txtId.Text);
                noteManager.Delete(id);
                MessageBox.Show("Not Başarıyla Silindi.");
                ShowAllData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmNoteAdd frmNoteAdd = new FrmNoteAdd();
            frmNoteAdd.Show();
        }

    }
}
