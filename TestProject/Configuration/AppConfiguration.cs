using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Configuration
{
    internal static class AppConfiguration
    {
        public static string datesPath = Path.Combine(Directory.GetCurrentDirectory(), "Dates.xml");
    }
}
