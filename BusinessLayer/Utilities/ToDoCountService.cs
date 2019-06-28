using KisiselYapilacaklarApp.BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselYapilacaklarApp.BusinessLayer.Utilities
{
    public class ToDoCountService
    {

        public static int GetToDoCountByToday(ToDoListTodayManager toDoListTodayManager)
        {
            int currentDay = DateTime.Now.Day;
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            return toDoListTodayManager.GetAll().Where(x => x.Day == currentDay && x.Month == currentMonth &&x.Year == currentYear).ToList().Count;
        }

        public static int GetToDoCountByWeek(ToDoListWeekManager toDoListWeekManager)
        {
            int currentWeek = DateTime.Now.DayOfYear / 7;
            int currentYear = DateTime.Now.Year;
            return toDoListWeekManager.GetAll().Where(x => x.Week == currentWeek && x.Year == currentYear).ToList().Count;
        }

        public static int GetToDoCountByMonth(ToDoListMonthManager toDoListMonthManager)
        {
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            return toDoListMonthManager.GetAll().Where(x => x.Month == currentMonth && x.Year == currentYear).ToList().Count;
        }

        public static int GetToDoCountAll(ToDoListTodayManager today, ToDoListWeekManager week, ToDoListMonthManager month)
        {
            int countToday = today.GetAll().Count;
            int countWeek = week.GetAll().Count;
            int countMonth = month.GetAll().Count;
            int result = countToday + countWeek + countMonth;
            return result;
        }

    }
}
