using KisiselYapilacaklarApp.DataAccessLayer.Concrete;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        NoteDal noteDal = new NoteDal();

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }



        /* MENU STRIP BUTTON CLICK CODE */
        /* ---------------------------- */
        private void stripCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stripAyarlar_Click(object sender, EventArgs e)
        {

        }

        private void stripNotEkle_Click(object sender, EventArgs e)
        {

        }

        private void stripNotListele_Click(object sender, EventArgs e)
        {
            FrmNote frmNote = new FrmNote();
            frmNote.Show();
            this.Hide();
        }

        private void stripYapilacakAylikEkle_Click(object sender, EventArgs e)
        {

        }

        private void stripYapilacakAylikListele_Click(object sender, EventArgs e)
        {
            FrmToDoMonth frmToDoMonth = new FrmToDoMonth();
            frmToDoMonth.Show();
            this.Hide();
        }

        private void stripYapilacakAylikHepsiniListele_Click(object sender, EventArgs e)
        {
            FrmToDoMonth frmToDoMonth = new FrmToDoMonth();
            frmToDoMonth.Show();
            this.Hide();
        }

        private void stripYapilacakHaftalikEkle_Click(object sender, EventArgs e)
        {

        }

        private void stripYapilacakHaftalikListele_Click(object sender, EventArgs e)
        {
            FrmToDoWeek frmToDoWeek = new FrmToDoWeek();
            frmToDoWeek.Show();
            this.Hide();
        }

        private void stripYapilacakHaftalikHepsiniListele_Click(object sender, EventArgs e)
        {
            FrmToDoWeek frmToDoWeek = new FrmToDoWeek();
            frmToDoWeek.Show();
            this.Hide();
        }

        private void stripYapilacakGunlukEkle_Click(object sender, EventArgs e)
        {

        }

        private void stripYapilacakGunlukListele_Click(object sender, EventArgs e)
        {
            FrmToDoToday frmToDoToday = new FrmToDoToday();
            frmToDoToday.Show();
            this.Hide();
        }

        private void stripYapilacakGunlukHepsiniListele_Click(object sender, EventArgs e)
        {
            FrmToDoToday frmToDoToday = new FrmToDoToday();
            frmToDoToday.Show();
            this.Hide();
        }
        /* ---------------------------- */
        /* MENU STRIP BUTTON CLICK CODE */



    }
}
