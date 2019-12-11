using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public sealed partial class MainPage : Page
    {
        List<int> numbers = new List<int>();

        public MainPage()
        {
            this.InitializeComponent();

            FontSizing();




        }

        private void FontSizing()
        {

            num0.FontSize = 40;
            num1.FontSize = 40;
            num2.FontSize = 40;
            num3.FontSize = 40;
            num4.FontSize = 40;
            num5.FontSize = 40;
            num6.FontSize = 40;
            num7.FontSize = 40;
            num8.FontSize = 40;
            num8.FontSize = 40;
            num9.FontSize = 40;
            add.FontSize = 40;
            subt.FontSize = 40;
            divide.FontSize = 40;
            equ.FontSize = 40; 
            times.FontSize = 40;
            _decimal.FontSize = 40;
            backspace.FontSize = 40;


        }

   
     

        private void display0(object sender, RoutedEventArgs e)
        {
            displayer.Items.Clear();
            int zero = 0;
            
            numbers.Add(0);

          
            displayer.FontSize =40;

            string joiner = string.Join(", ", numbers);

            displayer.Items.Add(joiner);



        }

        private void display1(object sender, RoutedEventArgs e)
        {
            numbers.Add(1);
            displayer.Items.Add("1");
        }

        private void display2(object sender, RoutedEventArgs e)
        {
            numbers.Add(2);
        }

        private void display3(object sender, RoutedEventArgs e)
        {
            numbers.Add(3);
        }

        private void display4(object sender, RoutedEventArgs e)
        {
            numbers.Add(4);
            displayer.Items.Add(4);
        }

        private void display5(object sender, RoutedEventArgs e)
        {
            numbers.Add(5);
        }


        private void display6(object sender, RoutedEventArgs e)
        {
            numbers.Add(6);
        }

        private void display7(object sender, RoutedEventArgs e)
        {
            numbers.Add(7);
        }

        private void display8(object sender, RoutedEventArgs e)
        {
            numbers.Add(8);
        }

        private void display9(object sender, RoutedEventArgs e)
        {
            numbers.Add(9);
        }

     
    }
}
