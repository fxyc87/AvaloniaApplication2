using System;

using Avalonia.Controls;
using Avalonia.Interactivity;

using AvaloniaApplication2.ViewModels;

namespace AvaloniaApplication2.Views
{
    public partial class MainWindow : Window
    {
        public int Count2 = 0;
        MainWindowViewModel model = new();
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, RoutedEventArgs e)
        {
            button1.Content = $"Click Me! {Count2++}";
            text1.Text = $"{model.Greeting} {model.Count++}";
        }

        private void MainWindow_Loaded(object? sender, RoutedEventArgs e)
        {

        }
    }
}