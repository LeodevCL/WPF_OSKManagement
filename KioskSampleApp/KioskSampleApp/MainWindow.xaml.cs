using System;
using System.Collections.Generic;
using System.Linq;
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

namespace KioskSampleApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region constructor

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region event handlers

        private void LaunchButton_Click(object sender, RoutedEventArgs e)
        {
            KeyboardManager.LaunchOnScreenKeyboard();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            KeyboardManager.KillOnScreenKeyboard();
        }

        #endregion
    }
}
