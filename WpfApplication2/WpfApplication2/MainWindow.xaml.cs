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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isLocked = false;
        bool isVisible = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isVisible)
            {
                developLabel.Visibility = Visibility.Collapsed;
                LockButton.Visibility = Visibility.Collapsed;
                PresetsTab.Visibility = Visibility.Collapsed;
                clarityLbel.Visibility = Visibility.Collapsed;
                ClaritySlider.Visibility = Visibility.Collapsed;
                clarityTextBox.Visibility = Visibility.Collapsed;
                filtersLabel.Visibility = Visibility.Collapsed;
                FilterAmountSlider.Visibility = Visibility.Collapsed;
                filtersAmountTextBox.Visibility = Visibility.Collapsed;
                isVisible = false;
            }
            else
            {
                developLabel.Visibility = Visibility.Visible;
                LockButton.Visibility = Visibility.Visible;
                PresetsTab.Visibility = Visibility.Visible;
                clarityLbel.Visibility = Visibility.Visible;
                ClaritySlider.Visibility = Visibility.Visible;
                clarityTextBox.Visibility = Visibility.Visible;
                filtersLabel.Visibility = Visibility.Visible;
                FilterAmountSlider.Visibility = Visibility.Visible;
                filtersAmountTextBox.Visibility = Visibility.Visible;
                isVisible = true;
            }
        }

        private void LockButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isLocked)
            {  
                TemperatureSlider.IsEnabled = false;
                TintSlider.IsEnabled = false;
                ExposureSlider.IsEnabled = false;
                ContrastSlider.IsEnabled = false;
                HighlightSlider.IsEnabled = false;
                ShadowsSlider.IsEnabled = false;
                WhitesSlider.IsEnabled = false;
                BlacksSlider.IsEnabled = false;
                ClaritySlider.IsEnabled = false;
                FilterAmountSlider.IsEnabled = false;
                isLocked = true;
            }
            else
            {
                TemperatureSlider.IsEnabled = true;
                TintSlider.IsEnabled = true;
                ExposureSlider.IsEnabled = true;
                ContrastSlider.IsEnabled = true;
                HighlightSlider.IsEnabled = true;
                ShadowsSlider.IsEnabled = true;
                WhitesSlider.IsEnabled = true;
                BlacksSlider.IsEnabled = true;
                ClaritySlider.IsEnabled = true;
                FilterAmountSlider.IsEnabled = true;
                isLocked = false;
            }
        }
    }
}
