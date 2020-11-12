using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace BMI_Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    [XmlRoot("BMI Calc", Namespace = "www.bmicalc.ninja")]
    public partial class MainWindow : Window
    {

        public string FilePath = "C:/Temp/";
        public string FileName = "yourBMI.xml";

        public class Customer
        {
            [XmlAttribute("Last Name")]
            public string lastName { get; set; }
            [XmlAttribute("First Name")]
            public string firstName { get; set; }
            [XmlAttribute("Phone Number")]
            public string phoneNumber { get; set; }
            [XmlAttribute("Height")]
            public int heightInches { get; set; }
            [XmlAttribute("Weight")]
            public int weightLbs { get; set; }
            [XmlAttribute("Customer BMI")]
            public int custBMI { get; set; }
            [XmlAttribute("Status")]
            public string statusTitle { get; set; }
        }



        public MainWindow()
        {
            InitializeComponent();
        }
        #region Part 1 of the Lab. ClearBtn & ExitBtn
        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            xPhoneBox.Text = "";
            xFirstNameBox.Text = "";
            xLastNameBox.Text = "";
            xHeightInchesBox.Text = "";
            xHeightLbsBox.Text = "";
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
    }
}
