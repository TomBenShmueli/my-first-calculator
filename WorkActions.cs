using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public static class WorkActions
    {

 

        public static bool PartOrFull(RadioButton part)
        {
            return part.Checked;
        }

        public static double LocalCalculate(WorkDay workday, RadioButton part)
        {
            double sum = 0;
            try
            {
                if (workday.DateAndTime.DayOfWeek == DayOfWeek.Friday || workday.DateAndTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    var weekendBasicWage = Wage.BasicWage * 1.5;
                    var weekendOvertimeWage = Wage.Overtime * 1.5;
                    if (PartOrFull(part))
                    {

                        if (workday.Hours > 9)
                        {
                            sum += (workday.Hours - 9) * weekendOvertimeWage + 9 * weekendBasicWage;
                        }
                        else
                        {
                            sum += workday.Hours * weekendBasicWage;
                        }
                    }

                    else
                    {

                        if (workday.Hours > 8)
                        {
                            sum += (workday.Hours - 8) * weekendOvertimeWage + 8 * weekendBasicWage;
                        }
                        else
                        {
                            sum += workday.Hours * weekendBasicWage;
                        }
                    }


                }
                else
                {
                    if (PartOrFull(part))
                    {

                        if (workday.Hours > 9)
                        {
                            sum += (workday.Hours - 9) * Wage.Overtime + 9 * Wage.BasicWage;
                        }
                        else
                        {
                            sum += workday.Hours * Wage.BasicWage;
                        }
                    }

                    else
                    {

                        if (workday.Hours > 8)
                        {
                            sum += (workday.Hours - 8) * Wage.Overtime + 8 * Wage.BasicWage;
                        }
                        else
                        {
                            sum += workday.Hours * Wage.BasicWage;
                        }
                    }
                }
                return sum;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static double CalculateDay(List<WorkDay> workdays, RadioButton part, DateTime date)
        {
            double sum = 0;
            try
            {
                var filterDay = workdays.First(w => w.DateAndTime == date);
                if (filterDay.DateAndTime.DayOfWeek == DayOfWeek.Friday || filterDay.DateAndTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    double weekendBasicWage = Wage.BasicWage * 1.5;
                    double weekendOvertimeWage = Wage.Overtime * 1.5;
                    if (PartOrFull(part))
                    {

                        if (filterDay.Hours > 9)
                        {
                            sum += (filterDay.Hours - 9) * weekendOvertimeWage + 9 * weekendBasicWage;
                        }
                        else
                        {
                            sum += filterDay.Hours * weekendBasicWage;
                        }
                    }

                    else
                    {

                        if (filterDay.Hours > 8)
                        {
                            sum += (filterDay.Hours - 8) * weekendOvertimeWage + 8 * weekendBasicWage;
                        }
                        else
                        {
                            sum += filterDay.Hours * weekendBasicWage;
                        }
                    }


                }
                else
                {
                    if (PartOrFull(part))
                    {

                        if (filterDay.Hours > 9)
                        {
                            sum += (filterDay.Hours - 9) * Wage.Overtime + 9 * Wage.BasicWage;
                        }
                        else
                        {
                            sum += filterDay.Hours * Wage.BasicWage;
                        }
                    }

                    else
                    {

                        if (filterDay.Hours > 8)
                        {
                            sum += (filterDay.Hours - 8) * Wage.Overtime + 8 * Wage.BasicWage;
                        }
                        else
                        {
                            sum += filterDay.Hours * Wage.BasicWage;
                        }
                    }
                }
                return sum;
            }
            catch (Exception)
            {
                return 0;
            }
            
        }

        public static double CalculateMonth(List<WorkDay> workdays, RadioButton part, int month,int year)
        {
            double sum = 0;
            var filteredList = new List<WorkDay>();
            foreach (var day in workdays)
            {
                if (day.DateAndTime.Month == month && day.DateAndTime.Year == year)
                    filteredList.Add(day);
            }

            foreach (var day in filteredList)
            {
                if (day.DateAndTime.DayOfWeek == DayOfWeek.Friday || day.DateAndTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    double weekendBasicWage = Wage.BasicWage * 1.5;
                    double weekendOvertimeWage = Wage.Overtime * 1.5;
                    if (PartOrFull(part))
                    {

                        if (day.Hours > 9)
                        {
                            sum += (day.Hours - 9) * weekendOvertimeWage + 9 * weekendBasicWage;
                        }
                        else
                        {
                            sum += day.Hours * weekendBasicWage;
                        }
                    }

                    else
                    {

                        if (day.Hours > 8)
                        {
                            sum += (day.Hours - 8) * weekendOvertimeWage + 8 * weekendBasicWage;
                        }
                        else
                        {
                            sum += day.Hours * weekendBasicWage;
                        }
                    }


                }
                else
                {
                    if (PartOrFull(part))
                    {

                        if (day.Hours > 9)
                        {
                            sum += (day.Hours - 9) * Wage.Overtime + 9 * Wage.BasicWage;
                        }
                        else
                        {
                            sum += day.Hours * Wage.BasicWage;
                        }
                    }

                    else
                    {

                        if (day.Hours > 8)
                        {
                            sum += (day.Hours - 8) * Wage.Overtime + 8 * Wage.BasicWage;
                        }
                        else
                        {
                            sum += day.Hours * Wage.BasicWage;
                        }
                    }
                }
            }
            return sum;
        }

        public static double CalculateYear(List<WorkDay> workdays, RadioButton part, int year)
        {
            double sum = 0;
            var filteredList = new List<WorkDay>();
            foreach (var day in workdays)
            {
                if (day.DateAndTime.Year == year)
                    filteredList.Add(day);
            }

            foreach (var day in filteredList)
            {
                if (day.DateAndTime.DayOfWeek == DayOfWeek.Friday || day.DateAndTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    double weekendBasicWage = Wage.BasicWage * 1.5;
                    double weekendOvertimeWage = Wage.Overtime * 1.5;
                    if (PartOrFull(part))
                    {

                        if (day.Hours > 9)
                        {
                            sum += (day.Hours - 9) * weekendOvertimeWage + 9 * weekendBasicWage;
                        }
                        else
                        {
                            sum += day.Hours * weekendBasicWage;
                        }
                    }

                    else
                    {

                        if (day.Hours > 8)
                        {
                            sum += (day.Hours - 8) * weekendOvertimeWage + 8 * weekendBasicWage;
                        }
                        else
                        {
                            sum += day.Hours * weekendBasicWage;
                        }
                    }


                }
                else
                {
                    if (PartOrFull(part))
                    {

                        if (day.Hours > 9)
                        {
                            sum += (day.Hours - 9) * Wage.Overtime + 9 * Wage.BasicWage;
                        }
                        else
                        {
                            sum += day.Hours * Wage.BasicWage;
                        }
                    }

                    else
                    {

                        if (day.Hours > 8)
                        {
                            sum += (day.Hours - 8) * Wage.Overtime + 8 * Wage.BasicWage;
                        }
                        else
                        {
                            sum += day.Hours * Wage.BasicWage;
                        }
                    }
                }
            }
            return sum;
        }
    }
}


