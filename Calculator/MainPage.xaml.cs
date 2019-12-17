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
        List<String> numbers = new List<String>();
        String currentVal;
        string joiner;
        int[] numholder;



        public MainPage()
        {
            this.InitializeComponent();
            displayer.FontSize = 40;
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


        }

   
     

        private void display0(object sender, RoutedEventArgs e)
        {
            displayer.Items.Clear();
          
            numbers.Add("0");
           joiner = string.Join("", numbers);
           displayer.Items.Add(joiner);



        }

        private void display1(object sender, RoutedEventArgs e)
        {
            displayer.Items.Clear();
            numbers.Add("1");
            joiner = string.Join("", numbers);
            displayer.Items.Add(joiner);

        }

        private void display2(object sender, RoutedEventArgs e)
        {
            displayer.Items.Clear();
            numbers.Add("2");
            joiner = string.Join("", numbers);
            displayer.Items.Add(joiner);
        }

        private void display3(object sender, RoutedEventArgs e)
        {
            displayer.Items.Clear();
            numbers.Add("3");
            joiner = string.Join("", numbers);
            displayer.Items.Add(joiner);
        }

        private void display4(object sender, RoutedEventArgs e)
        {
            displayer.Items.Clear();
            numbers.Add("4");
            joiner = string.Join("", numbers);
            displayer.Items.Add(joiner);
        }

        private void display5(object sender, RoutedEventArgs e)
        {
            displayer.Items.Clear();
            numbers.Add("5");
            joiner = string.Join("", numbers);
            displayer.Items.Add(joiner);
        }


        private void display6(object sender, RoutedEventArgs e)
        {
            displayer.Items.Clear();
            numbers.Add("6");
            joiner = string.Join("", numbers);
            displayer.Items.Add(joiner);
        }

        private void display7(object sender, RoutedEventArgs e)
        {
            displayer.Items.Clear();
            numbers.Add("7");
            joiner = string.Join("", numbers);
            displayer.Items.Add(joiner);
        }

        private void display8(object sender, RoutedEventArgs e)
        {
            displayer.Items.Clear();
            numbers.Add("8");
            joiner = string.Join("", numbers);
            displayer.Items.Add(joiner);
        }

        private void display9(object sender, RoutedEventArgs e)
        {
            displayer.Items.Clear();
            numbers.Add("9");
            joiner = string.Join("", numbers);
            displayer.Items.Add(joiner);
        }

      


        private void addNum(object sender, RoutedEventArgs e)
        {
           

            displayer.Items.Clear();
            numbers.Add("+");
            joiner = string.Join("",numbers);
            displayer.Items.Add(joiner);
           
            

        }
    }
}
