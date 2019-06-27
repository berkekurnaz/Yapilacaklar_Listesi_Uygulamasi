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
    public partial class FrmToDoAdd : Form
    {

        string toDoType;

        public FrmToDoAdd(string toDoType)
        {
            InitializeComponent();
            this.toDoType = toDoType;
        }



        ToDoListTodayManager toDoListTodayManager = new ToDoListTodayManager();
        ToDoListWeekManager toDoListWeekManager = new ToDoListWeekManager();
        ToDoListMonthManager toDoListMonthManager = new ToDoListMonthManager();



        private void FrmToDoAdd_Load(object sender, EventArgs e)
        {

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length > 2)
            {
                if (toDoType == "Gunluk")
                {
                    ToDoListToday toDoListToday = new ToDoListToday();
                    toDoListToday.Title = txtTitle.Text;
                    toDoListToday.Day = dtpCreatedDate.Value.Day;
                    toDoListToday.Week = dtpCreatedDate.Value.DayOfYear / 7;
                    toDoListToday.Month = dtpCreatedDate.Value.Month;
                    toDoListToday.Year = dtpCreatedDate.Value.Year;
                    toDoListToday.Completed = "Tamamlanmadı";

                    toDoListTodayManager.Add(toDoListToday);
                    MessageBox.Show("Başarıyla Eklendi.");
                    this.Hide();
                }
                else if(toDoType == "Haftalik")
                {
                    ToDoListWeek toDoListWeek = new ToDoListWeek();
                    toDoListWeek.Title = txtTitle.Text;
                    toDoListWeek.Week = dtpCreatedDate.Value.DayOfYear / 7;
                    toDoListWeek.Month = dtpCreatedDate.Value.Month;
                    toDoListWeek.Year = dtpCreatedDate.Value.Year;
                    toDoListWeek.Completed = "Tamamlanmadı";

                    toDoListWeekManager.Add(toDoListWeek);
                    MessageBox.Show("Başarıyla Eklendi.");
                    this.Hide();
                }
                else if(toDoType == "Aylik")
                {
                    ToDoListMonth toDoListMonth= new ToDoListMonth();
                    toDoListMonth.Title = txtTitle.Text;
                    toDoListMonth.Month = dtpCreatedDate.Value.Month;
                    toDoListMonth.Year = dtpCreatedDate.Value.Year;
                    toDoListMonth.Completed = "Tamamlanmadı";

                    toDoListMonthManager.Add(toDoListMonth);
                    MessageBox.Show("Başarıyla Eklendi.");
                    this.Hide();
                }
            }
        }



    }
}
