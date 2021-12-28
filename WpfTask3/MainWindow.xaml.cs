using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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

namespace WpfTask3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int isBold = 0;
        int isItalic = 0;
        int isUnderline = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox!=null)
            { 
            textBox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = double.Parse(((sender as ComboBox).SelectedItem as TextBlock).Text);
            
            if (textBox != null)
            {
                textBox.FontSize = fontSize;

            }

        }


        private void Button_bold_text_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                isBold += 1;
                if (isBold == 1)
                {
                    textBox.FontWeight = FontWeights.Bold;
                }
                else if (isBold == 2)
                {
                    isBold = 0;
                    textBox.FontWeight = FontWeights.Normal;
                }
            }
        }

        private void Button_italic_text_Click(object sender, RoutedEventArgs e)
//            Чтобы не хранить дополнительные переменные, можно было сразу проверять текущее значение, например

//if (textBox.FontStyle == FontStyles.Italic)
        {
            if (textBox != null)
            {
                isItalic += 1;
                if (isItalic == 1)
                {
                    textBox.FontStyle = FontStyles.Italic;
                }
                else if (isItalic == 2)
                {
                    isItalic = 0;
                    textBox.FontStyle = FontStyles.Normal;
                }
            }
        }

        private void Button_underlined_text_Click(object sender, RoutedEventArgs e)
        {

            if (textBox != null)
            {
                isUnderline += 1;
                if (isUnderline == 1)
                {
                    textBox.TextDecorations = TextDecorations.Underline;
                }
                else if (isUnderline == 2)
                {
                    isUnderline = 0;
                    textBox.TextDecorations = null;
                }
            }
        }

        private void Radio_button_black_checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void Radio_button_red_checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }
        }

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void OpenExecute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Документ открыт");
        }

        private void SaveExecute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Документ coxpaнен");
        }
    }
}
