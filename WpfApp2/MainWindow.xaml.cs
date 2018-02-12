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

namespace WpfApp2
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string firstNumber;
        string secondNumber;
        char typeOfActivity = ' ';

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            Operation('0');
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            Operation('1');
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            Operation('2');
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            Operation('3');
        }
        private void b4_Click(object sender, RoutedEventArgs e)
        {
            Operation('4');
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            Operation('5');
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            Operation('6');
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            Operation('7');
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            Operation('8');
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            Operation('9');
        }

        private void bOff_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bC_Click(object sender, RoutedEventArgs e)
        {
            tbResult.Text = "";
            typeOfActivity = ' ';
            firstNumber = null;
            secondNumber = null;
        }

        private void bCE_Click(object sender, RoutedEventArgs e)
        {
            tbResult.Text = "";
            typeOfActivity = ' ';
            secondNumber = null;
        }

        private void bDivision_Click(object sender, RoutedEventArgs e)
        {
            if (checker(secondNumber) == true)
            {
                Resolution(typeOfActivity);
            }
            else
            {
                tbResult.Text = "";
            }
            typeOfActivity = '/';

        }
        private void bMultiplication_Click(object sender, RoutedEventArgs e)
        {
            if (checker(secondNumber) == true)
            {
                Resolution(typeOfActivity);
            }
            else
            {
                tbResult.Text = "";
            }
            typeOfActivity = '*';
        }

        private void bSubtraction_Click(object sender, RoutedEventArgs e)
        {
            if (checker(secondNumber)==true)
            {
                Resolution(typeOfActivity);
            }
            else
            {
                tbResult.Text = "";
            }

            typeOfActivity = '-';

        }


        private void bAddition_Click(object sender, RoutedEventArgs e)
        {
            if (checker(secondNumber) == true)
                {
                Resolution(typeOfActivity);
            }
            else
            {
                tbResult.Text = "";
            }

            typeOfActivity = '+';


        }



        private void bDot_Click(object sender, RoutedEventArgs e)
        {
            Operation(',');
        }

        private void bResult_Click(object sender, RoutedEventArgs e)
        {
            Resolution(typeOfActivity);
        }

        private void Operation(char number)
        {
            if (typeOfActivity == ' ')
            {
                firstNumber += number;
                tbResult.Text = firstNumber;
            }
            else
            {
                secondNumber += number;
                tbResult.Text = secondNumber;
            }
        }

        public void Resolution(char typeofActivity)
        {

            switch (typeOfActivity)
            {
                case ('+'):
                    if (checker(secondNumber) == true)
                    {
                        firstNumber = (double.Parse(firstNumber) + double.Parse(secondNumber)).ToString();
                        secondNumber = "";
                    }
                    tbResult.Text = firstNumber;
                    break;
                case ('-'):
                    if (checker(secondNumber) == true)
                    {
                        firstNumber = (double.Parse(firstNumber) - double.Parse(secondNumber)).ToString();
                        secondNumber = "";
                    }
                    tbResult.Text = firstNumber;
                    break;
                case ('/'):
                    if (checker(secondNumber) == true)
                    {
                        firstNumber = (double.Parse(firstNumber) / double.Parse(secondNumber)).ToString();
                        secondNumber = "";
                    }
                    tbResult.Text = firstNumber;
                    break;
                case ('*'):
                    if (checker(secondNumber) == true)
                    {
                        firstNumber = (double.Parse(firstNumber) * double.Parse(secondNumber)).ToString();
                        secondNumber = "";
                    }
                    tbResult.Text = firstNumber;
                    break;

            }
        }

        private bool checker(string secondNumber)
        {
            if (secondNumber != "" && secondNumber != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
