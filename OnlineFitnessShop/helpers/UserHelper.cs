using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nexmo.Api;
using Microsoft.AspNetCore.Http;
using System.Web;


namespace OnlineFitnessShop.helpers
{
    public static class UserHelper
    {
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
                new SelectListItem {Text = "2030", Value = "2030"},
                new SelectListItem {Text = "2029", Value = "2029"},
                new SelectListItem {Text = "2028", Value = "2028"},
                new SelectListItem {Text = "2027", Value = "2027"},
                new SelectListItem {Text = "2026", Value = "2026"},
                new SelectListItem {Text = "2025", Value = "2025"},
                new SelectListItem {Text = "2024", Value = "2024"},
                new SelectListItem {Text = "2023", Value = "2023"},
                new SelectListItem {Text = "2022", Value = "2022"},
                new SelectListItem {Text = "2021", Value = "2021"},
                new SelectListItem {Text = "2020", Value = "2020"}
            };


            return godine;
        }

        public static List<SelectListItem> getNazivKartica()
        {
            List<SelectListItem> kartice = new List<SelectListItem>
            {
                new SelectListItem {Text = "MasterCard", Value = "MasterCard"},
                new SelectListItem {Text = "Visa", Value = "Visa"}
            };

            return kartice;

        }

        public static List<SelectListItem> getSpolList()
        {
            List<SelectListItem> spol = new List<SelectListItem>
            {
                new SelectListItem {Text = "Muški", Value = "Muški"},
                new SelectListItem {Text = "Ženski", Value = "Ženski"}
            };
            return spol;
        }

        public static void SendSMS(string datumVrijeme, string _to = "38761764809")
        {
            var client = new Client(creds: new Nexmo.Api.Request.Credentials
            {
                ApiKey = "6514a503",
                ApiSecret = "hc8cuBehibrCTcBN"
            });
            var results = client.SMS.Send(request: new SMS.SMSRequest
            {
                from = "SeminarskiRS1",
                to = _to,
                text = "Postovani, imate novu narudzbu na cekanju.Datum i vrijeme narucivanja: " + datumVrijeme
            });
        }

    }
}
