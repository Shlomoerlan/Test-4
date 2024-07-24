using System.Windows.Forms;
using System.Xml.Linq;
using TestProject.Model;
using TestProject.Service;
using static TestProject.Configuration.AppConfiguration;
using static TestProject.Model.DatesModel;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // DatesModel datesModel = new("ראשון", "2", "iu", @"תשפ""ו");
            DatesService.CreateXmlIfNotExist();
            
        }

        private DatesModel CreateModel()
        {
            DatesModel datesModel = new(

                Day: DayComboBox.Text,
                DayMonth: DatMonthComboBox.Text,
                Month: MonthComboBox.Text,
                Year: YearComboBox.Text
            );
            return datesModel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatesModel datesModel = CreateModel();
            string day = DatesService.CalculateDay(datesModel);
            string dayMonth = DatesService.CalculateDayMonth(datesModel);
            string x = "לירח";
            string month = MonthComboBox.Text;
            string year = DatesService.CalculateYear(datesModel);
          
            string res = day + " " + dayMonth + " " + x + " " + month + " " + year;

                
            XElement element = DatesService.ConvertToElement(datesModel, res);
            MessageBox.Show($"{element}");
            DatesService.AddQuery(element);
        }
        
    }
}
