﻿using System.Reflection;
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
using System;

namespace krestiki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] buttons;
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            buttons = new Button[] {_1, _2, _3, _4, _5, _6, _7, _8, _9};
            _1.IsEnabled = false;
            _2.IsEnabled = false;
            _3.IsEnabled = false;
            _4.IsEnabled = false;
            _5.IsEnabled = false;
            _6.IsEnabled = false;
            _7.IsEnabled = false;
            _8.IsEnabled = false;
            _9.IsEnabled = false;
        }
        private void prosto_click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            if (nichaya())
            {
                shtyka.Text = "Ничья";
                ebanina();
                return;
            }
            int knopka = random.Next(0, 9);
            while (buttons[knopka].IsEnabled == false)
            {
                knopka = random.Next(0, 9);
            }
            buttons[knopka].Content = "O";
            buttons[knopka].IsEnabled = false;
            pobeda(sender);
            nichaya();
        }

        private void start_click(object sender, RoutedEventArgs e)
        {
            _1.IsEnabled = true;
            _2.IsEnabled = true;
            _3.IsEnabled = true;
            _4.IsEnabled = true;
            _5.IsEnabled = true;
            _6.IsEnabled = true;
            _7.IsEnabled = true;
            _8.IsEnabled = true;
            _9.IsEnabled = true;
            start.IsEnabled = false;
        }
        private void pobeda(object sender)
        {
            if (buttons[0].Content == buttons[1].Content && buttons[1].Content == buttons[2].Content)
            {
                if (buttons[0].Content == "X" && buttons[1].Content == "X" && buttons[2].Content == "X")
                {
                    shtyka.Text = "Pobeda X";
                    ebanina();
                }
            }
            if (buttons[0].Content == buttons[1].Content && buttons[1].Content == buttons[2].Content)
            {
                if (buttons[0].Content == "O" && buttons[1].Content == "O" && buttons[2].Content == "O")
                {
                    shtyka.Text = "Pobeda O";
                    ebanina();
                }
            }
            if (buttons[0].Content == buttons[3].Content && buttons[3].Content == buttons[6].Content)
            {
                if (buttons[0].Content == "X" && buttons[3].Content == "X" && buttons[6].Content == "X")
                {
                    shtyka.Text = "Pobeda X";
                    ebanina();
                }
            }
            if (buttons[0].Content == buttons[3].Content && buttons[3].Content == buttons[6].Content)
            {
                if (buttons[0].Content == "O" && buttons[3].Content == "O" && buttons[6].Content == "O")
                {
                    shtyka.Text = "Pobeda O";
                    ebanina();
                }
            }
            if (buttons[0].Content == buttons[4].Content && buttons[4].Content == buttons[8].Content)
            {
                if (buttons[0].Content == "X" && buttons[4].Content == "X" && buttons[8].Content == "X")
                {
                    shtyka.Text = "Pobeda X";
                    ebanina();
                }
            }
            if (buttons[0].Content == buttons[4].Content && buttons[4].Content == buttons[8].Content)
            {
                if (buttons[0].Content == "O" && buttons[4].Content == "O" && buttons[8].Content == "O")
                {
                    shtyka.Text = "Pobeda O";
                    ebanina();
                }
            }
            if (buttons[2].Content == buttons[4].Content && buttons[4].Content == buttons[6].Content)
            {
                if (buttons[2].Content == "X" && buttons[4].Content == "X" && buttons[6].Content == "X")
                {
                    shtyka.Text = "Pobeda X";
                    ebanina();
                }
            }
            if (buttons[2].Content == buttons[4].Content && buttons[4].Content == buttons[6].Content)
            {
                if (buttons[2].Content == "O" && buttons[4].Content == "O" && buttons[6].Content == "O")
                {
                    shtyka.Text = "Pobeda O";
                    ebanina();
                }
            }
            if (buttons[3].Content == buttons[4].Content && buttons[4].Content == buttons[5].Content)
            {
                if (buttons[3].Content == "X" && buttons[4].Content == "X" && buttons[5].Content == "X")
                {
                    shtyka.Text = "Pobeda X";
                    ebanina();
                }
            }
            if (buttons[3].Content == buttons[4].Content && buttons[4].Content == buttons[5].Content)
            {
                if (buttons[3].Content == "O" && buttons[4].Content == "O" && buttons[5].Content == "O")
                {
                    shtyka.Text = "Pobeda O";
                    ebanina();
                }
            }
            if (buttons[6].Content == buttons[7].Content && buttons[7].Content == buttons[8].Content)
            {
                if (buttons[6].Content == "X" && buttons[7].Content == "X" && buttons[8].Content == "X")
                {
                    shtyka.Text = "Pobeda X";
                    ebanina();
                }
            }
            if (buttons[6].Content == buttons[7].Content && buttons[7].Content == buttons[8].Content)
            {
                if (buttons[6].Content == "O" && buttons[7].Content == "O" && buttons[8].Content == "O")
                {
                    shtyka.Text = "Pobeda O";
                    ebanina();
                }
            }
            if (buttons[1].Content == buttons[4].Content && buttons[4].Content == buttons[7].Content)
            {
                if (buttons[1].Content == "X" && buttons[4].Content == "X" && buttons[7].Content == "X")
                {
                    shtyka.Text = "Pobeda X";
                    ebanina();
                }
            }
            if (buttons[1].Content == buttons[4].Content && buttons[4].Content == buttons[7].Content)
            {
                if (buttons[1].Content == "O" && buttons[4].Content == "O" && buttons[7].Content == "O")
                {
                    shtyka.Text = "Pobeda O";
                    ebanina();
                }
            }
            if (buttons[2].Content == buttons[5].Content && buttons[5].Content == buttons[8].Content)
            {
                if (buttons[2].Content == "X" && buttons[5].Content == "X" && buttons[8].Content == "X")
                {
                    shtyka.Text = "Pobeda X";
                    ebanina();
                }
            }
            if (buttons[2].Content == buttons[5].Content && buttons[5].Content == buttons[8].Content)
            {
                if (buttons[2].Content == "O" && buttons[5].Content == "O" && buttons[8].Content == "O")
                {
                    shtyka.Text = "Pobeda O";
                    ebanina();
                }
            }
        }
        private void ebanina()
        {
            _1.Content = null;
            _2.Content = null;
            _3.Content = null;
            _4.Content = null;
            _5.Content = null;
            _6.Content = null;
            _7.Content = null;
            _8.Content = null;
            _9.Content = null;
            _1.IsEnabled = false;
            _2.IsEnabled = false;
            _3.IsEnabled = false;
            _4.IsEnabled = false;
            _5.IsEnabled = false;
            _6.IsEnabled = false;
            _7.IsEnabled = false;
            _8.IsEnabled = false;
            _9.IsEnabled = false;
            start.IsEnabled = true;
        }
        private bool nichaya()
        {
            foreach (Button button in buttons)
            {
                if (button.IsEnabled)
                {
                    return false;
                }
            }
            return true;
        }
    }
}