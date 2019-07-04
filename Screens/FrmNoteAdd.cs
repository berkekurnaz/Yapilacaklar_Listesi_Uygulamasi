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
    public partial class FrmNoteAdd : Form
    {
        public FrmNoteAdd()
        {
            InitializeComponent();
        }

        NoteManager noteManager = new NoteManager();

        private void FrmNoteAdd_Load(object sender, EventArgs e)
        {
            txtCreatedDate.Text = DateTime.Now.ToShortDateString();
            cmbStatus.Text = "Düşük";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length > 3)
            {
                Note note = new Note();
                note.Title = txtTitle.Text;
                note.Content = txtContent.Text;
                note.CreatedDate = txtCreatedDate.Text;
                note.Status = cmbStatus.Text;

                noteManager.Add(note);
                MessageBox.Show("Not Başarıyla Eklendi");
                this.Hide();
            }
        }
    }
}
