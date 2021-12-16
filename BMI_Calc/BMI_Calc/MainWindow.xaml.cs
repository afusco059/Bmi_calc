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

namespace BMI_Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Exit_btn(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Clear_btn(object sender, RoutedEventArgs e)
        {
            First_Name.Text = "";
            Last_Name.Text = "";
            Phone_num.Text = "";
            Height.Text = "";
            Weight.Text = "";
        }
    }
}
