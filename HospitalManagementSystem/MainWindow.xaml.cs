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

namespace HospitalManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            combobox.Items.Add("Adminstrator");
            combobox.Items.Add("Doctor");
            combobox.Items.Add("Staff");
        }

        /*private void bbtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (combobox.SelectedItem == null)
            {
                MessageBox.Show("Please choose an option");
            }
        }  Click="btnLogin*/

        private void Login_click(object sender, RoutedEventArgs e)
        {
            if (combobox.SelectedItem == null)
            {
                MessageBox.Show("Select an option to proceed");
            }

            else if (combobox.SelectedItem.Equals("Adminstrator"))
            {
                MessageBox.Show("Selected admin");
            }

            else if (combobox.SelectedItem.Equals("Doctor"))
            {
                MessageBox.Show("Selected doctor");
            }

            else if (combobox.SelectedItem.Equals("Staff"))
            {
                //MessageBox.Show("Selected staff");
                Staff objStaffWindow = new Staff();
                //objStaffWindow.Show();
                this.Close();

            }
        }
    }
}
