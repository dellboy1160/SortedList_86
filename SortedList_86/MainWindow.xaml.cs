using System;
using System.Collections;
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

namespace SortedList_86
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void Button_add(object sender, RoutedEventArgs e)
        {
            sortedList.Add(int.Parse (txt_key.Text),(txt_value.Text));
                
            ICollection collection = sortedList.Keys;
            string data = "";

            foreach (int key in collection)
            {

                data = data +"\n"+ sortedList[key].ToString();
 
            }
            MessageBox.Show("Key : "+collection.Count+ " = " + txt_value.Text+data);
            txt_key.Clear();
            txt_value.Clear();
              

        }

        private void txt_key_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
