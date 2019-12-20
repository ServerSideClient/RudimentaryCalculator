using System.Windows;
using System.Windows.Controls;
using System.Linq;
using System.Text.RegularExpressions;

namespace RudimentaryCalculator
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

        private void WriteToDisplay(object sender, RoutedEventArgs e)
        {
            string buttonLabel = (sender as Button).Content.ToString();
            int clickedNumber = int.Parse(buttonLabel);
            calculatorDisplay.Text += buttonLabel;
        }

        private void OperandClickHandler(object sender, RoutedEventArgs e)
        {

        }

        private void CalculateSolution(object sender, RoutedEventArgs e)
        {
            string problem = calculatorDisplay.Text;

            int result = 0;

            string[] sections = problem.Split(' ');
            bool firstEntry = true;
            int tempResult = 0;
            string savedOperand = string.Empty;
            foreach (string section in sections)
            {
                int number;
                bool isNumber = int.TryParse(section, out number);
                if (isNumber)
                {
                    if (firstEntry)
                    {
                        result += number;
                        firstEntry = false;
                    }
                    else if (string.IsNullOrEmpty(savedOperand) == false)
                    {
                        switch (savedOperand)
                        {
                            case ("X"):
                                break;
                            case ("/"):
                                break;
                        }
                        savedOperand = "";
                    }
                }
                else
                {
                    savedOperand = section;
                }

                

            }
        }

    }
}
