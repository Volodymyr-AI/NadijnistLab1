using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NadijnistLab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            a1TextBox.TextChanged += TextBox_TextChanged;
            a2TextBox.TextChanged += TextBox_TextChanged;
            a3TextBox.TextChanged += TextBox_TextChanged;
            a4TextBox.TextChanged += TextBox_TextChanged;
            deltaTextBox.TextChanged += TextBox_TextChanged;
            tTextBox.TextChanged += TextBox_TextChanged;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            if (textBox == a1TextBox)
            {
                a1 = double.Parse(text);
            }
            else if (textBox == a2TextBox)
            {
                a2 = double.Parse(text);
            }
            else if (textBox == a3TextBox)
            {
                a3 = double.Parse(text);
            }
            else if (textBox == a4TextBox)
            {
                a4 = double.Parse(text);
            }
            else if (textBox == deltaTextBox)
            {
                delta = double.Parse(text);
            }
            else if (textBox == tTextBox)
            {
                t = double.Parse(text);
            }
        }

        // Переменные для хранения значений
        private double a1, a2, a3, a4, delta, t;
    }
}