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

namespace HomeWork3
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

        private void btnReverse_Click(object sender, RoutedEventArgs e)
        {
            string data = tbText.Text;
            char[]charc= data.ToCharArray();
            Array.Reverse(charc);
            int i;
            string empytstr = string.Empty;
            for (i = 0; i < charc.Length; i++)
            {
                empytstr += charc[i];
            }
            tbResult.Text = empytstr.ToString();
        }
    }
}
