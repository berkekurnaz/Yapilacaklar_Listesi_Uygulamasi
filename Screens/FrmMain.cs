using KisiselYapilacaklarApp.BusinessLayer.Concrete;
using KisiselYapilacaklarApp.BusinessLayer.Utilities;
using KisiselYapilacaklarApp.DataAccessLayer.Concrete;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        NoteDal noteDal = new NoteDal();

        ToDoListTodayManager toDoListTodayManager = new ToDoListTodayManager();
        ToDoListWeekManager toDoListWeekManager = new ToDoListWeekManager();
        ToDoListMonthManager toDoListMonthManager = new ToDoListMonthManager();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ShowToDoListToday();
            ShowToDoListWeek();
            ShowToDoListMonth();

            ShowStatistics();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        public void ShowStatistics()
        {
            lblTodayCount.Text = ToDoCountService.GetToDoCountByToday(toDoListTodayManager).ToString();
            lblWeekCount.Text = ToDoCountService.GetToDoCountByWeek(toDoListWeekManager).ToString();
            lblMonthCount.Text = ToDoCountService.GetToDoCountByMonth(toDoListMonthManager).ToString();
            lblAllCount.Text = ToDoCountService.GetToDoCountAll(toDoListTodayManager, toDoListWeekManager, toDoListMonthManager).ToString();
        }

        public void ShowToDoListToday()
        {
            int currentDay = DateTime.Now.Day;
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            List<ToDoListToday> todos = toDoListTodayManager.GetAll().Where(x => x.Day == currentDay && x.Month == currentMonth && x.Year == currentYear).ToList();
            for (int i = 0; i < todos.Count; i++)
            {
                listBox1.Items.Add((i + 1).ToString() + " - " + todos[i].Title + " - " + todos[i].Completed);
            }
        }

        public void ShowToDoListWeek()
        {
            int currentWeek = DateTime.Now.DayOfYear / 7;
            int currentYear = DateTime.Now.Year;
            List<ToDoListWeek> todos = toDoListWeekManager.GetAll().Where(x => x.Week == currentWeek && x.Year == currentYear).ToList();
            for (int i = 0; i < todos.Count; i++)
            {
                listBox2.Items.Add((i + 1).ToString() + " - " + todos[i].Title + " - " + todos[i].Completed);
            }
        }

        public void ShowToDoListMonth()
        {
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            List<ToDoListMonth> todos = toDoListMonthManager.GetAll().Where(x => x.Month == currentMonth && x.Year == currentYear).ToList();
            for (int i = 0; i < todos.Count; i++)
            {
                listBox3.Items.Add((i + 1).ToString() + " - " + todos[i].Title + " - " + todos[i].Completed);
            }
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
            FrmNoteAdd frmNoteAdd = new FrmNoteAdd();
            frmNoteAdd.Show();
        }

        private void stripNotListele_Click(object sender, EventArgs e)
        {
            FrmNote frmNote = new FrmNote();
            frmNote.Show();
            this.Hide();
        }

        private void stripYapilacakAylikEkle_Click(object sender, EventArgs e)
        {
            string toDoType = "Aylik";
            FrmToDoAdd frmToDoAdd = new FrmToDoAdd(toDoType);
            frmToDoAdd.Show();
        }

        private void stripYapilacakAylikListele_Click(object sender, EventArgs e)
        {
            FrmToDoMonth frmToDoMonth = new FrmToDoMonth("Ozel");
            frmToDoMonth.Show();
            this.Hide();
        }

        private void stripYapilacakAylikHepsiniListele_Click(object sender, EventArgs e)
        {
            FrmToDoMonth frmToDoMonth = new FrmToDoMonth("Hepsi");
            frmToDoMonth.Show();
            this.Hide();
        }

        private void stripYapilacakHaftalikEkle_Click(object sender, EventArgs e)
        {
            string toDoType = "Haftalik";
            FrmToDoAdd frmToDoAdd = new FrmToDoAdd(toDoType);
            frmToDoAdd.Show();
        }

        private void stripYapilacakHaftalikListele_Click(object sender, EventArgs e)
        {
            FrmToDoWeek frmToDoWeek = new FrmToDoWeek("Ozel");
            frmToDoWeek.Show();
            this.Hide();
        }

        private void stripYapilacakHaftalikHepsiniListele_Click(object sender, EventArgs e)
        {
            FrmToDoWeek frmToDoWeek = new FrmToDoWeek("Hepsi");
            frmToDoWeek.Show();
            this.Hide();
        }

        private void stripYapilacakGunlukEkle_Click(object sender, EventArgs e)
        {
            string toDoType = "Gunluk";
            FrmToDoAdd frmToDoAdd = new FrmToDoAdd(toDoType);
            frmToDoAdd.Show();
        }

        private void stripYapilacakGunlukListele_Click(object sender, EventArgs e)
        {
            FrmToDoToday frmToDoToday = new FrmToDoToday("Ozel");
            frmToDoToday.Show();
            this.Hide();
        }

        private void stripYapilacakGunlukHepsiniListele_Click(object sender, EventArgs e)
        {
            FrmToDoToday frmToDoToday = new FrmToDoToday("Hepsi");
            frmToDoToday.Show();
            this.Hide();
        }
        /* ---------------------------- */
        /* MENU STRIP BUTTON CLICK CODE */




    }
}
