using FileManager.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace FileManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Manager Manager;
        public MainWindow()
        {
            InitializeComponent();

            Manager = new Manager();
            Manager.OnFilesMoved += Manager_OnFilesMoved;

            RefreshPath();
        }

        private void RefreshPath()
        {
            var dir = Settings.Default.UserDirectory;

            if (dir == "NULL")
            {
                TextBlockFolder.Text = Manager.GetDefaultPath();
            }
            else
            {
                TextBlockFolder.Text = Settings.Default.UserDirectory;
            }
        }

        private void Manager_OnFilesMoved(object? sender, bool success)
        {
            if(success)
            {
                TextBlockNotification.Visibility = Visibility.Visible;
                TextBlockNotification.Text = "Files were moved!";

            }
            else
            {
                TextBlockNotification.Visibility = Visibility.Visible;
                TextBlockNotification.Text = "No files moved!";
            }
        }

        private void ButtonOpenFolder_Click(object sender, RoutedEventArgs e)
        {
            TextBlockNotification.Visibility = Visibility.Hidden;

            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {
                System.Windows.Forms.DialogResult result = dialog.ShowDialog();
                
                if(result == System.Windows.Forms.DialogResult.OK)
                {
                    TextBlockFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void ButtonOrganize_Click(object sender, RoutedEventArgs e)
        {
            Manager.Update(TextBlockFolder.Text);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Settings.Default.UserDirectory = TextBlockFolder.Text;
            Settings.Default.Save();
        }
    }
}
