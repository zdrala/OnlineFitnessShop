﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFitnessShop.helpers
{
    public static class AdministratorHelper
    {
        public static List<SelectListItem> GenerateDaysList()
        {
            List<SelectListItem> dani = new List<SelectListItem>
            {

                new SelectListItem {Text = "1", Value = "1"},
                new SelectListItem {Text = "2", Value = "2"},
                new SelectListItem {Text = "3", Value = "3"},
                new SelectListItem {Text = "4", Value = "4"},
                new SelectListItem {Text = "5", Value = "5"},
                new SelectListItem {Text = "6", Value = "6"},
                new SelectListItem {Text = "7", Value = "7"},
                new SelectListItem {Text = "8", Value = "8"},
                new SelectListItem {Text = "9", Value = "9"},
                new SelectListItem {Text = "10", Value = "10"},
                new SelectListItem {Text = "11", Value = "11"},
                new SelectListItem {Text = "12", Value = "12"},
                new SelectListItem {Text = "13", Value = "13"},
                new SelectListItem {Text = "14", Value = "14"},
                new SelectListItem {Text = "15", Value = "15"},
                new SelectListItem {Text = "16", Value = "16"},
                new SelectListItem {Text = "17", Value = "17"},
                new SelectListItem {Text = "18", Value = "18"},
                new SelectListItem {Text = "19", Value = "19"},
                new SelectListItem {Text = "20", Value = "20"},
                new SelectListItem {Text = "21", Value = "21"},
                new SelectListItem {Text = "22", Value = "22"},
                new SelectListItem {Text = "23", Value = "23"},
                new SelectListItem {Text = "24", Value = "24"},
                new SelectListItem {Text = "25", Value = "25"},
                new SelectListItem {Text = "26", Value = "26"},
                new SelectListItem {Text = "27", Value = "27"},
                new SelectListItem {Text = "28", Value = "28"},
                new SelectListItem {Text = "29", Value = "29"},
                new SelectListItem {Text = "30", Value = "30"},
                new SelectListItem {Text = "31", Value = "31"}

            };
            

            return dani;
        }
        public static List<SelectListItem> GenerateMonthsList()
        {
            List<SelectListItem> mjeseci = new List<SelectListItem>
            {

                new SelectListItem {Text = "1", Value = "1"},
                new SelectListItem {Text = "2", Value = "2"},
                new SelectListItem {Text = "3", Value = "3"},
                new SelectListItem {Text = "4", Value = "4"},
                new SelectListItem {Text = "5", Value = "5"},
                new SelectListItem {Text = "6", Value = "6"},
                new SelectListItem {Text = "7", Value = "7"},
                new SelectListItem {Text = "8", Value = "8"},
                new SelectListItem {Text = "9", Value = "9"},
                new SelectListItem {Text = "10", Value = "10"},
                new SelectListItem {Text = "11", Value = "11"},
                new SelectListItem {Text = "12", Value = "12"},
                
            };


            return mjeseci;
        }

        public static List<SelectListItem> GenerateYearsList()
        {
            List<SelectListItem> godine = new List<SelectListItem>
            {

                new SelectListItem {Text = "2001", Value = "2001"},
                new SelectListItem {Text = "2000", Value = "2000"},
                new SelectListItem {Text = "1999", Value = "1999"},
                new SelectListItem {Text = "1998", Value = "1998"},
                new SelectListItem {Text = "1997", Value = "1997"},
                new SelectListItem {Text = "1996", Value = "1996"},
                new SelectListItem {Text = "1995", Value = "1995"},
                new SelectListItem {Text = "1994", Value = "1994"},
                new SelectListItem {Text = "1993", Value = "1993"},
                new SelectListItem {Text = "1992", Value = "1992"},
                new SelectListItem {Text = "1991", Value = "1991"},
                new SelectListItem {Text = "1990", Value = "1990"},
                new SelectListItem {Text = "1989", Value = "1989"},
                new SelectListItem {Text = "1988", Value = "1988"},
                new SelectListItem {Text = "1987", Value = "1987"},
                new SelectListItem {Text = "1986", Value = "1986"},
                new SelectListItem {Text = "1985", Value = "1985"},
                new SelectListItem {Text = "1984", Value = "1984"},
                new SelectListItem {Text = "1983", Value = "1983"},
                new SelectListItem {Text = "1982", Value = "1982"},
                new SelectListItem {Text = "1981", Value = "1981"},
                new SelectListItem {Text = "1980", Value = "1980"},
            };


            return godine;
        }

        public static List<SelectListItem> getTipoveDodataka()
        {
            List<SelectListItem> dodatci = new List<SelectListItem>
            {

                new SelectListItem {Text = "Pojasevi", Value = "Pojasevi"},
                new SelectListItem {Text = "Šejkeri", Value = "Šejkeri"},
                new SelectListItem {Text = "Steznici", Value = "Steznici"},
                new SelectListItem {Text = "Torbe", Value = "Torbe"}
            };

            return dodatci;

        }
    }
}
