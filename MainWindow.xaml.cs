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

namespace Toller_Taschenrechner
{
    public partial class MainWindow : Window
    {
        // Initalisierung der Anwendung:
        public MainWindow()
        {
            InitializeComponent();
            rechnung.Text = "0";
        }

        // Standart Definitionen:

        string op = "";
        double number1 = 0;
        double number2 = 0;

        // Was geschehen soll, wenn der Knopf "%" gedrückt wird:
        private void percent_Click(object sender, RoutedEventArgs e)
        {
            op = "%";
            ergebnis.Text = number1 + "%" + " " + "von";
            rechnung.Text = "0";
        }

        // Was geschehen soll, wenn der Knopf "CE" gedrückt wird:
        private void ce_Click(object sender, RoutedEventArgs e)
        {
            if(op == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
                ergebnis.Text = number1 + " " + op;
            }

            rechnung.Text = "0";
        }

        // Was geschehen soll, wenn der Knopf "C" gedrückt wird:
        private void c_Click(object sender, RoutedEventArgs e)
        {
            op = "";
            number1 = 0;
            number2 = 0;
            rechnung.Text = "0";
            ergebnis.Text = "";
        }

        // Was geschehen soll, wenn der Knopf "⇚" gedrückt wird:
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                if (rechnung.Text.Length > 2)
                {
                    rechnung.Text = rechnung.Text.Remove(rechnung.Text.Length - 1);
                }
                else
                {
                    rechnung.Text = "0";
                }

                number1 = Convert.ToDouble(rechnung.Text);
            }
            else
            {
                if (rechnung.Text.Length > 2)
                {
                    rechnung.Text = rechnung.Text.Remove(rechnung.Text.Length - 1);
                }
                else
                {
                    rechnung.Text = "0";
                }

                number2 = Convert.ToDouble(rechnung.Text);
            }
        }

        // Was geschehen soll, wenn der Knopf "1/x" gedrückt wird:
        private void durchEins_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case "":
                    ergebnis.Text = "1" + " " + "/" + " " + number1 + " " + "=";
                    rechnung.Text = (1 / number1).ToString();
                    number1 = 1 / number1;
                    break;
                case "÷":
                    number1 = number1 / number2;
                    ergebnis.Text = "1" + " " + "/" + " " + number1 + " " + "=";
                    rechnung.Text = (1 / number1).ToString();
                    number1 = 1 / number1;
                    number2 = 0;
                    op = "";
                    break;
                case "x":
                    number1 = number1 * number2;
                    ergebnis.Text = "1" + " " + "/" + " " + number1 + " " + "=";
                    rechnung.Text = (1 / number1).ToString();
                    number1 = 1 / number1;
                    number2 = 0;
                    op = "";
                    break;
                case "-":
                    number1 = number1 - number2;
                    ergebnis.Text = "1" + " " + "/" + " " + number1 + " " + "=";
                    rechnung.Text = (1 / number1).ToString();
                    number1 = 1 / number1;
                    number2 = 0;
                    op = "";
                    break;
                case "+":
                    number1 = number1 + number2;
                    ergebnis.Text = "1" + " " + "/" + " " + number1 + " " + "=";
                    rechnung.Text = (1 / number1).ToString();
                    number1 = 1 / number1;
                    number2 = 0;
                    op = "";
                    break;
                case "%":
                    number1 = number1 / 100 * number2;
                    ergebnis.Text = "1" + " " + "/" + " " + number1 + " " + "=";
                    rechnung.Text = (1 / number1).ToString();
                    number1 = 1 / number1;
                    number2 = 0;
                    op = "";
                    break;
            }
        }

        // Was geschehen soll, wenn der Knopf "x²" gedrückt wird:
        private void square_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case "":
                    ergebnis.Text = number1 + "²" + " " + "=";
                    rechnung.Text = (number1 * number1).ToString();
                    number1 = number1 * number1;
                    break;
                case "÷":
                    number1 = number1 / number2;
                    ergebnis.Text = number1 + "²" + " " + "=";
                    rechnung.Text = (number1 * number1).ToString();
                    number1 = number1 * number1;
                    number2 = 0;
                    op = "";
                    break;
                case "x":
                    number1 = number1 * number2;
                    ergebnis.Text = number1 + "²" + " " + "=";
                    rechnung.Text = (number1 * number1).ToString();
                    number1 = number1 * number1;
                    number2 = 0;
                    op = "";
                    break;
                case "-":
                    number1 = number1 - number2;
                    ergebnis.Text = number1 + "²" + " " + "=";
                    rechnung.Text = (number1 * number1).ToString();
                    number1 = number1 * number1;
                    number2 = 0;
                    op = "";
                    break;
                case "+":
                    number1 = number1 + number2;
                    ergebnis.Text = number1 + "²" + " " + "=";
                    rechnung.Text = (number1 * number1).ToString();
                    number1 = number1 * number1;
                    number2 = 0;
                    op = "";
                    break;
                case "%":
                    number1 = number1 / 100 * number2;
                    ergebnis.Text = number1 + "²" + " " + "=";
                    rechnung.Text = (number1 * number1).ToString();
                    number1 = number1 * number1;
                    number2 = 0;
                    op = "";
                    break;
            }
        }

        // Was geschehen soll, wenn der Knopf "√" gedrückt wird:
        private void squareroot_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case "":
                    ergebnis.Text = "√" + number1 + " " + "=";
                    number1 = Math.Sqrt(number1);
                    rechnung.Text = number1.ToString();
                    break;
                case "÷":
                    number1 = number1 / number2;
                    ergebnis.Text = "√" + number1 + " " + "=";
                    number1 = Math.Sqrt(number1);
                    rechnung.Text = number1.ToString();
                    number2 = 0;
                    op = "";
                    break;
                case "x":
                    number1 = number1 * number2;
                    ergebnis.Text = "√" + number1 + " " + "=";
                    number1 = Math.Sqrt(number1);
                    rechnung.Text = number1.ToString();
                    number2 = 0;
                    op = "";
                    break;
                case "-":
                    number1 = number1 - number2;
                    ergebnis.Text = "√" + number1 + " " + "=";
                    number1 = Math.Sqrt(number1);
                    rechnung.Text = number1.ToString();
                    number2 = 0;
                    op = "";
                    break;
                case "+":
                    number1 = number1 + number2;
                    ergebnis.Text = "√" + number1 + " " + "=";
                    number1 = Math.Sqrt(number1);
                    rechnung.Text = number1.ToString();
                    number2 = 0;
                    op = "";
                    break;
                case "%":
                    number1 = number1 / 100 * number2;
                    ergebnis.Text = "√" + number1 + " " + "=";
                    number1 = Math.Sqrt(number1);
                    rechnung.Text = number1.ToString();
                    number2 = 0;
                    op = "";
                    break;
            }
        }

        // Was geschehen soll, wenn der Knopf "÷" gedrückt wird:
        private void division_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                op = "÷";
                ergebnis.Text = number1 + " " + op.ToString();
                rechnung.Text = "0";
            }
            else
            {
                ergebnis.Text = number1 / number2 + " " + op;
                rechnung.Text = "0";
                number1 = number1 / number2;
                number2 = 0;
            }
        }

        // Was geschehen soll, wenn der Knopf "7" gedrückt wird:
        private void seven_Click(object sender, RoutedEventArgs e)
        {
            while(rechnung.Text == "0")
            {
                rechnung.Text = "";
            }

            if (op == "")
            {
                rechnung.Text = rechnung.Text + "7";
                number1 = Convert.ToDouble(rechnung.Text);
            }
            else
            {
                rechnung.Text = rechnung.Text + "7";
                number2 = Convert.ToDouble(rechnung.Text);
            }
        }

        // Was geschehen soll, wenn der Knopf "8" gedrückt wird:
        private void eight_Click(object sender, RoutedEventArgs e)
        {
            while (rechnung.Text == "0")
            {
                rechnung.Text = "";
            }

            if (op == "")
            {
                rechnung.Text = rechnung.Text + "8";
                number1 = Convert.ToDouble(rechnung.Text);
            }
            else
            {
                rechnung.Text = rechnung.Text + "8";
                number2 = Convert.ToDouble(rechnung.Text);
            }
        }

        // Was geschehen soll, wenn der Knopf "9" gedrückt wird:
        private void nine_Click(object sender, RoutedEventArgs e)
        {
            while (rechnung.Text == "0")
            {
                rechnung.Text = "";
            }

            if (op == "")
            {
                rechnung.Text = rechnung.Text + "9";
                number1 = Convert.ToDouble(rechnung.Text);
            }
            else
            {
                rechnung.Text = rechnung.Text + "9";
                number2 = Convert.ToDouble(rechnung.Text);
            }
        }

        // Was geschehen soll, wenn der Knopf "x" gedrückt wird:
        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                op = "x";
                ergebnis.Text = number1 + " " + op.ToString();
                rechnung.Text = "0";
            }
            else
            {
                ergebnis.Text = number1 * number2 + " " + op;
                rechnung.Text = "0";
                number1 = number1 * number2;
                number2 = 0;
            }
        }

        // Was geschehen soll, wenn der Knopf "4" gedrückt wird:
        private void four_Click(object sender, RoutedEventArgs e)
        {
            while (rechnung.Text == "0")
            {
                rechnung.Text = "";
            }

            if (op == "")
            {
                rechnung.Text = rechnung.Text + "4";
                number1 = Convert.ToDouble(rechnung.Text);
            }
            else
            {
                rechnung.Text = rechnung.Text + "4";
                number2 = Convert.ToDouble(rechnung.Text);
            }
        }

        // Was geschehen soll, wenn der Knopf "5" gedrückt wird:
        private void five_Click(object sender, RoutedEventArgs e)
        {
            while (rechnung.Text == "0")
            {
                rechnung.Text = "";
            }

            if (op == "")
            {
                rechnung.Text = rechnung.Text + "5";
                number1 = Convert.ToDouble(rechnung.Text);
            }
            else
            {
                rechnung.Text = rechnung.Text + "5";
                number2 = Convert.ToDouble(rechnung.Text);
            }
        }

        // Was geschehen soll, wenn der Knopf "6" gedrückt wird:
        private void six_Click(object sender, RoutedEventArgs e)
        {
            while (rechnung.Text == "0")
            {
                rechnung.Text = "";
            }

            if (op == "")
            {
                rechnung.Text = rechnung.Text + "6";
                number1 = Convert.ToDouble(rechnung.Text);
            }
            else
            {
                rechnung.Text = rechnung.Text + "6";
                number2 = Convert.ToDouble(rechnung.Text);
            }
        }

        // Was geschehen soll, wenn der Knopf "-" gedrückt wird:
        private void subtraction_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                op = "-";
                ergebnis.Text = number1 + " " + op.ToString();
                rechnung.Text = "0";
            }
            else
            {
                ergebnis.Text = number1 - number2 + " " + op;
                rechnung.Text = "0";
                number1 = number1 - number2;
                number2 = 0;
            }
        }

        // Was geschehen soll, wenn der Knopf "1" gedrückt wird:
        private void one_Click(object sender, RoutedEventArgs e)
        {
            while (rechnung.Text == "0")
            {
                rechnung.Text = "";
            }

            if (op == "")
            {
                rechnung.Text = rechnung.Text + "1";
                number1 = Convert.ToDouble(rechnung.Text);
            }
            else
            {
                rechnung.Text = rechnung.Text + "1";
                number2 = Convert.ToDouble(rechnung.Text);
            }
        }

        // Was geschehen soll, wenn der Knopf "2" gedrückt wird:
        private void two_Click(object sender, RoutedEventArgs e)
        {
            while (rechnung.Text == "0")
            {
                rechnung.Text = "";
            }

            if (op == "")
            {
                rechnung.Text = rechnung.Text + "2";
                number1 = Convert.ToDouble(rechnung.Text);
            }
            else
            {
                rechnung.Text = rechnung.Text + "2";
                number2 = Convert.ToDouble(rechnung.Text);
            }
        }

        // Was geschehen soll, wenn der Knopf "3" gedrückt wird:
        private void three_Click(object sender, RoutedEventArgs e)
        {
            while (rechnung.Text == "0")
            {
                rechnung.Text = "";
            }

            if (op == "")
            {
                rechnung.Text = rechnung.Text + "3";
                number1 = Convert.ToDouble(rechnung.Text);
            }
            else
            {
                rechnung.Text = rechnung.Text + "3";
                number2 = Convert.ToDouble(rechnung.Text);
            }
        }

        // Was geschehen soll, wenn der Knopf "+" gedrückt wird:
        private void addition_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                op = "+";
                ergebnis.Text = number1 + " " + op.ToString();
                rechnung.Text = "0";
            }
            else
            {
                ergebnis.Text = number1 + number2 + " " + op;
                rechnung.Text = "0";
                number1 = number1 + number2;
                number2 = 0;
            }
        }

        // Was geschehen soll, wenn der Knopf "+/-" gedrückt wird:
        private void plusminus_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                number1 = number1 * -1;
                rechnung.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * -1;
                rechnung.Text = number2.ToString();
            }
        }

        // Was geschehen soll, wenn der Knopf "0" gedrückt wird:
        private void zero_Click(object sender, RoutedEventArgs e)
        {
            while (rechnung.Text == "0")
            {
                rechnung.Text = "";
            }

            if (op == "")
            {
                rechnung.Text = rechnung.Text + "0";
                number1 = Convert.ToDouble(rechnung.Text);
            }
            else
            {
                rechnung.Text = rechnung.Text + "0";
                number2 = Convert.ToDouble(rechnung.Text);
            }
        }

        // Was geschehen soll, wenn der Knopf "," gedrückt wird:
        private void komma_Click(object sender, RoutedEventArgs e)
        {
            rechnung.Text = rechnung.Text + ",";
        }

        // Was geschehen soll, wenn der Knopf "=" gedrückt wird:
        private void result_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case "÷":
                    ergebnis.Text = number1 + " " + op + " " + number2 + " " + "=";
                    rechnung.Text = (number1 / number2).ToString();
                    number1 = number1 / number2;
                    number2 = 0;
                    op = "";
                    break;
                case "x":
                    ergebnis.Text = number1 + " " + op + " " + number2 + " " + "=";
                    rechnung.Text = (number1 * number2).ToString();
                    number1 = number1 * number2;
                    number2 = 0;
                    op = "";
                    break;
                case "-":
                    ergebnis.Text = number1 + " " + op + " " + number2 + " " + "=";
                    rechnung.Text = (number1 - number2).ToString();
                    number1 = number1 - number2;
                    number2 = 0;
                    op = "";
                    break;
                case "+":
                    ergebnis.Text = number1 + " " + op + " " + number2 + " " + "=";
                    rechnung.Text = (number1 + number2).ToString();
                    number1 = number1 + number2;
                    number2 = 0;
                    op = "";
                    break;
                case "%":
                    ergebnis.Text = number1 + "%" + " " + "von" + " " + number2 + " " + "=";
                    rechnung.Text = (number1 / 100 * number2).ToString();
                    number1 = number1 / 100 * number2;
                    number2 = 0;
                    op = "";
                    break;
            }
        }
    }
}
