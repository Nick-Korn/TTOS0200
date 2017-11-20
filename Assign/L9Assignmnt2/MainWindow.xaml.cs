﻿using System;
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

namespace L9Assignmnt2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Player> players;
        public MainWindow()
        {
            InitializeComponent();
            players = Player.GetPlayers();
        }

        private void dgPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Object obj = dgPlayers.SelectedItem;
            if (obj != null)
            {
                Player chosen = (Player)obj;
            }
        }

        private void getplayersBtn_Click(object sender, RoutedEventArgs e)
        {
            dgPlayers.ItemsSource = players;
        }
    }
}
