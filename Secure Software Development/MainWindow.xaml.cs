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
using System.IO;

namespace Secure_Software_Development
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

        private void Add_to_text_file_Click(object sender, RoutedEventArgs e)
        {
            string x = EnterTextBox.Text;

            StreamWriter SW = new StreamWriter(x+".txt");

            SW.WriteLine("BOOOMM");



            SW.Close();


        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            ReadPage rp = new ReadPage();

            rp.Show();

            this.Close();
        }
    }
}
