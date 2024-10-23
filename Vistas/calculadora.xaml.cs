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
using System.Windows.Shapes;

namespace calculadora2.Vistas
{
    public partial class Window1 : Window
    {
        private string input = "";
        private string operatorUsed = "";
        private double firstNumber, secondNumber;

        public Window1()
        {
            InitializeComponent();
        }

        // Botón de número
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            input += button.Content.ToString();
            Pantalla.Text = input;  // Accediendo al TextBox Pantalla
        }

        // Operador
        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            operatorUsed = button.Content.ToString();
            firstNumber = double.Parse(input);
            input = "";
        }

        // Botón "C"
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            input = "";
            operatorUsed = "";
            firstNumber = 0;
            secondNumber = 0;
            Pantalla.Text = "0";
        }

        // Botón "="
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            secondNumber = double.Parse(input);
            double result = 0;

            switch (operatorUsed)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "X":
                    result = firstNumber * secondNumber;
                    break;
                case "÷":
                    result = firstNumber / secondNumber;
                    break;
            }

            Pantalla.Text = result.ToString();
            input = result.ToString();
        }
    }
}
