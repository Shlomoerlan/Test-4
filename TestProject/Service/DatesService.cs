using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TestProject.Model;
using static TestProject.Configuration.AppConfiguration;
using static TestProject.Model.DatesModel;

namespace TestProject.Service
{
    internal static class DatesService
    {
        public static void CreateXmlIfNotExist()
        {
            if (!File.Exists(datesPath))
            {
                XDocument document = new();
                XElement queries = new("queries");
                document.Add(queries);
                document.Save(datesPath);
            }
        }

        public static XElement ConvertToElement(DatesModel dates, string res)
        {
               return new("query",
                new XElement("Day", dates.Day),
                new XElement("DayMonth", dates.DayMonth),
                new XElement("Month", dates.Month),
                new XElement("Year", dates.Year),
                new XElement("result", res)
                );
        }

        public static void AddQuery(XElement query)
        {
            XDocument document = XDocument.Load(datesPath);
            XElement element = new(query);
            XElement? queries = document.Descendants("queries").FirstOrDefault();
            if (queries == null) { return; }
            queries.Add(element);
            document.Save(datesPath);
        }

        

        public static string CalculateDay(DatesModel dates)
        {
            string res = dates.Day switch
            {
                "ראשון" => "באחד בשבת",
                "שני" => "בשני בשבת",
                "שלישי" => "בשלישי בשבת",
                "רביעי" => "ברביעי בשבת",
                "חמישי" => "בחמישי בשבת",
                "ששי" => "בששי בשבת",
            };
            return res;
        }

        public static string CalculateDayMonth(DatesModel dates)
        {
            string rh = GetMonthDay30(dates);
            string res = dates.DayMonth switch
            {
                "1" => "יום אחד ",
                "2" => " שני ימים ",
                "3" => "שלשה ימים ",
                "4" => "ארבעה ימים ",
                "5" => "חמשה ימים ",
                "6" => "ששה ימים ",
                "7" => "שבעה ימים ",
                "8" => "שמנה ימים ",
                "9" => "תשעה ימים",
                "10" => "עשרה ימים",
                "11" => "אחד עשר יום",
                "12" => "שנים עשר יום",
                "13" => "שלשה עשר יום",
                "14" => "ארבעה עשר יום",
                "15" => " חמשה עשר יום",
                "16" => "ששה עשר יום",
                "17" => "שבעה עשר יום",
                "18" => "שמנה עשר יום",
                "19" => "תשעה עשר יום",
                "20" => "עשרים יום",
                "21" => "אחד ועשרים יום",
                "22" => "שנים ועשרים יום",
                "23" => "שלשה ועשרים יום",
                "24" => "ארבעה ועשרים יום",
                "25" => "חמשה ועשרים יום",
                "26" => "ששה ועשרים יום",
                "27" => "שבעה ועשרים יום",
                "28" => "שמנה ועשרים יום",
                "29" => "תשעה ועשרים יום",
                "30" => $"יום שלשים שהוא ראש חודש {rh}",
            };
            return res;
        }

        public static string CalculateYear(DatesModel dates)
        {
            MessageBox.Show(dates.Year);
            string res = dates.Year switch
            {
                @"תשפ""ד" => "שנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם",
                @"תשפ""ה" => "שנת חמשת אלפים ושבע מאות ושמנים וחמש לבריאת העולם",
                @"תשפ""ו" => "שנת חמשת אלפים ושבע מאות ושמנים ושש לבריאת העולם",
                @"תשפ""ז" => "שנת חמשת אלפים ושבע מאות ושמנים ושבע לבריאת העולם",
                @"תשפ""ח" => "שנת חמשת אלפים ושבע מאות ושמנים ושמנה לבריאת העולם",
                @"תשפ""ט" => "שנת חמשת אלפים ושבע מאות ושמנים ותשע לבריאת העולם",
                @"תש""צ" => "שנת חמשת אלפים ושבע מאות ותשעים לבריאת העולם",
                @"תשצ""א" => "שנת חמשת אלפים ושבע מאות ותשעים ואחת לבריאת העולם",
                @"תשצ""ב" => "שנת חמשת אלפים ושבע מאות ותשעים ושתים לבריאת העולם",
                @"תשצ""ג" => "שנת חמשת אלפים ושבע מאות ותשעים ןשלש לבריאת העולם",
            };
            return res;
        }

        public static string GetMonthDay30(DatesModel dates)
        {
            string res = dates.Month switch
            {
                "תשרי" => "מרחשון",
                "מרחשון" => "כסלו",
                "כסלו" => "טבת",
                "טבת" => "שבט",
                "שבט" => "אדר",
                "אדר" => "ניסן",
                "אדר הראשון" => "אדר השני",
                "אדר השני" => "ניסן",
                "ניסן" => "אייר",
                "אייר" => "סיון",
                "סיון" => "תמוז",
                "תמוז" => "אב",
                "אב" => "אלול",
                "אלול" => "תשרי"
            };
            return res;
        }
    }
}
