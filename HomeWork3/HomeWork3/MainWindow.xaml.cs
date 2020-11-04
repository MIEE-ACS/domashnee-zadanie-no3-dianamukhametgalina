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

namespace Homework3
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
            var st = tbText.Text;
            var split = st.Split();
            var s = "";
            foreach (var item in split)
            {
                s += Reverse(item.ToList()) + " ";
            }
            tbResult.Text = s.ToString();

        }
        private static string Reverse(List<char> word)
        {
            var list = new List<(int ind, char ch)>();
            for (int i = 0; i < word.Count; i++)
            {
                if (!char.IsLetter(word[i]))
                {
                    list.Add((i, word[i]));
                }
            }
            foreach (var item in word.ToList())
            {
                if (!char.IsLetter(item))
                {
                    word.Remove(item);
                }
            }
            word.Reverse();
            foreach (var (ind, ch) in list)
            {
                word.Insert(ind, ch);
            }
            return string.Join("", word);
        }
    }
}
