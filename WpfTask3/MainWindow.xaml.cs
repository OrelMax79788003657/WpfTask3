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

namespace WpfTask3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
                TextRange textRange = new TextRange(textBox.Selection.Start, textBox.Selection.End);
                textRange.ApplyPropertyValue(TextElement.FontSizeProperty, fontSize);

            }

        }

        private void Bold_text_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                TextRange textRange = new TextRange(textBox.Selection.Start, textBox.Selection.End);
                textRange.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
            }
        }

       
        private void Italic_text_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                TextRange textRange = new TextRange(textBox.Selection.Start, textBox.Selection.End);
                textRange.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
            }
        }

        private void Underlined_text_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                TextRange textRange = new TextRange(textBox.Selection.Start, textBox.Selection.End);
                textRange.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
            }
        }
    }
}
