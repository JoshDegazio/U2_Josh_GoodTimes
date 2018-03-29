/* Josh Degazio
 * March 28th, 2018
 * User inputs time in military format, the program then outputs the time in other cities.
 * */ 
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

namespace U2_Josh_GoodTimes
{
    //Creates variables that are later used in the program.
    public static class Globals
    {
        public static string Time_Entered;
        public static string str_Ottawa;
        public static string str_Victoria;
        public static string str_Edmonton;
        public static string str_Winnipeg;
        public static string str_Toronto;
        public static string str_Halifax;
        public static string str_StJohns;
        public static int int_Ottawa = 0;
        public static int int_Victoria = 0;
        public static int int_Edmonton = 0;
        public static int int_Winnipeg = 0;
        public static int int_Toronto = 0;
        public static int int_Halifax = 0;
        public static int int_StJohns = 0;
        public static int int_OttawaDifference = 0;
        public static int int_VictoriaDifference = -300;
        public static int int_EdmontonDifference = -200;
        public static int int_WinnipegDifference = -100;
        public static int int_TorontoDifference = 0;
        public static int int_HalifaxDifference = +100;
        public static int int_StJohnsDifference = +130;
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void click_Run(object Sender, RoutedEventArgs e)
        {
            //Calls upon method.
            ResetValues();

            //Resets output textbox.
            txt_Output.Text = "";
            //Sets String "Time_Entered" to what was inputed by user.
            Globals.Time_Entered = txt_Input.Text;
            //Sets Ottawa Time to be equivalent to that of what was entered.
            int.TryParse(Globals.Time_Entered, out Globals.int_Ottawa);

            SetValues();
            GenerateLines();

        }

        private static void ResetValues()
        {
            Globals.int_Ottawa = 0;
            Globals.int_Victoria = 0;
            Globals.int_Edmonton = 0;
            Globals.int_Winnipeg = 0;
            Globals.int_Toronto = 0;
            Globals.int_Halifax = 0;
            Globals.int_StJohns = 0;
        }
        private static void SetValues()
        {
            if (Globals.int_Ottawa >= 2300)
            {
                Globals.int_Halifax = 0 + Globals.int_HalifaxDifference;
                Globals.int_StJohns = 0 + Globals.int_StJohnsDifference;
            }
            else if (Globals.int_Ottawa >= 2230)
            {
                Globals.int_Halifax = Globals.int_Ottawa + Globals.int_HalifaxDifference;
                Globals.int_StJohns = 0 + Globals.int_StJohnsDifference;
            }
            else
            {

                Globals.int_Toronto = (Globals.int_Ottawa + Globals.int_TorontoDifference);
                Globals.int_Halifax = (Globals.int_Ottawa + Globals.int_HalifaxDifference);
                Globals.int_StJohns = (Globals.int_Ottawa + Globals.int_StJohnsDifference);
            }

            if (Globals.int_Ottawa <= 100)
            {
                Globals.int_Victoria = 2400 + Globals.int_VictoriaDifference;
                Globals.int_Edmonton = 2400 + Globals.int_EdmontonDifference;
                Globals.int_Winnipeg = 2400 + Globals.int_WinnipegDifference;
            }
            else if (Globals.int_Ottawa <= 200)
            {
                Globals.int_Victoria = 2400 + Globals.int_VictoriaDifference;
                Globals.int_Edmonton = 2400 + Globals.int_EdmontonDifference;
                Globals.int_Winnipeg = Globals.int_Ottawa + Globals.int_WinnipegDifference;
            }
            else if (Globals.int_Ottawa <= 300)
            {
                Globals.int_Victoria = 2400 + Globals.int_VictoriaDifference;
                Globals.int_Edmonton = Globals.int_Ottawa + Globals.int_EdmontonDifference;
                Globals.int_Winnipeg = Globals.int_Ottawa + Globals.int_WinnipegDifference;
            }
            else
            {
                Globals.int_Toronto = (Globals.int_Ottawa + Globals.int_TorontoDifference);
                Globals.int_Victoria = (Globals.int_Ottawa + Globals.int_VictoriaDifference);
                Globals.int_Edmonton = (Globals.int_Ottawa + Globals.int_EdmontonDifference);
                Globals.int_Winnipeg = (Globals.int_Ottawa + Globals.int_WinnipegDifference);
            }
        }

        private void GenerateLines()
        {
            Globals.str_Ottawa = Globals.int_Ottawa.ToString();
            Globals.str_Victoria = Globals.int_Victoria.ToString();
            Globals.str_Edmonton = Globals.int_Edmonton.ToString();
            Globals.str_Winnipeg = Globals.int_Winnipeg.ToString();
            Globals.str_Toronto = Globals.int_Toronto.ToString();
            Globals.str_Halifax = Globals.int_Halifax.ToString();
            Globals.str_StJohns = Globals.int_StJohns.ToString();
            txt_Output.Text = "Ottawa: " + Globals.str_Ottawa;
            txt_Output.Text = txt_Output.Text + "\nVictoria: " + Globals.str_Victoria;
            txt_Output.Text = txt_Output.Text + "\nEdmonton: " + Globals.str_Edmonton;
            txt_Output.Text = txt_Output.Text + "\nWinnipeg: " + Globals.str_Winnipeg;
            txt_Output.Text = txt_Output.Text + "\nToronto: " + Globals.str_Toronto;
            txt_Output.Text = txt_Output.Text + "\nHalifax: " + Globals.str_Halifax;
            txt_Output.Text = txt_Output.Text + "\nSt.John's: " + Globals.str_StJohns;
        }
    }
}
