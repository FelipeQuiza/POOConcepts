using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(year, month, day);
        }

       

        //Métodos de validación
        private int CheckMonth(int month)
        {
            if (month > 0 && month <=12)
            {
                return month;
            }
            throw new MonthException($"{month} No es un número de mes válido");
        }

        private int CheckDay(int year, int month, int day)
        {
            if (month == 2 && day ==29 && IsLeapYear(year))
            {
                return day;
            }

            int[] daysPerMonths = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonths[month])
            {
                return day;
            }
            throw new DayException("Day invalid");
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        //Sobreescritura del método toString()
        //Interpolación de strings  $"{variable}"
        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}
