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
        public ReadPage()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //open the file explorer on click
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = @"C:\Users\S00151977\Desktop\Secure Software Development\Secure Software Development\bin\Debug";
            process.Start();




            Text_File_Contents.Text = File.ReadAllText("C:/Users/S00151977/Desktop/Secure Software Development/Secure Software Development/bin/Debug/meh.txt");



        }
    }
}
