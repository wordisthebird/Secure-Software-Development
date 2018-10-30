using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Shapes;

namespace Secure_Software_Development
{
    /// <summary>
    /// Interaction logic for ReadPage.xaml
    /// </summary>
    public partial class ReadPage : Window
    {
        string str;
        public ReadPage()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Text_File_Contents.Clear();


            OpenFileDialog ofd = new OpenFileDialog();

            ofd.DefaultExt = ".txt";



            if (ofd.ShowDialog() == true)
            {

                str = ofd.FileName;

                Text_File_Contents.Text = File.ReadAllText(str);
            }

            MessageBox.Show("Here is the file's contents");


        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

            StreamWriter SW = new StreamWriter(str);

            SW.WriteLine(Text_File_Contents.Text);
            SW.Close();
            MessageBox.Show("File Updated");

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this file?",
                                          "Confirmation",
                                          MessageBoxButton.YesNo,
                                          MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                File.Delete(@str);
                Text_File_Contents.Clear();
                MessageBox.Show("File deleted");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();

            mw.Show();

            this.Close();
        }
    }
}
