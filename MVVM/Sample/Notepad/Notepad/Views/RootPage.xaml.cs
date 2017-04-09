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
using Notepad.ViewModels;
using Notepad.Models;

namespace Notepad.Views
{
    /// <summary>
    /// Interakční logika pro RootPage.xaml
    /// </summary>
    public partial class RootPage : Page
    {
        public RootPage()
        {
            InitializeComponent();
            fsv = new FileViewModel();
            LoadData();
        }

        FileViewModel fsv;
        FileObj file;

        private void saveFileButton_Click(object sender, RoutedEventArgs e)
        {
            file = new FileObj();
            file.Data = new TextRange(notepad.Document.ContentStart, notepad.Document.ContentEnd).Text;
            DisableUIElements();
            fsv.SaveFile(file);
            EnableUIElements();
        }
        private void loadFileButton_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// Method for disabling elements in UI.
        /// </summary>
        private void DisableUIElements()
        {
            saveFileButton.IsEnabled = false;
            notepad.IsEnabled = false;
        }
        /// <summary>
        /// Method for enabling elements in UI.
        /// </summary>
        private void EnableUIElements()
        {
            saveFileButton.IsEnabled = true;
            notepad.IsEnabled = true;
        }
        /// <summary>
        /// Method for setting data in RichTextBox control.
        /// </summary>
        private void LoadData()
        {
            TextRange tr = new TextRange(notepad.Document.ContentStart, notepad.Document.ContentEnd);
            tr.Text = fsv.LoadFile().Data;
        }
        
    }
}
