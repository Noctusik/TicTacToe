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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isPlayerTurn;
        private int moveCounter;
        public MainWindow()
        {
            InitializeComponent();
            SetUp();
        }

        private void SetUp()
        {
            isPlayerTurn = false;
            moveCounter = 0;

            button_0_0.Content = String.Empty;
            button_1_0.Content = String.Empty;
            button_2_0.Content = String.Empty;

            button_0_1.Content = String.Empty;
            button_1_1.Content = String.Empty;
            button_2_1.Content = String.Empty;

            button_0_2.Content = String.Empty;
            button_1_2.Content = String.Empty;
            button_2_2.Content = String.Empty;

            button_0_0.Background = Brushes.WhiteSmoke;
            button_1_0.Background = Brushes.WhiteSmoke;
            button_2_0.Background = Brushes.WhiteSmoke;
                                    
            button_0_1.Background = Brushes.WhiteSmoke;
            button_1_1.Background = Brushes.WhiteSmoke;
            button_2_1.Background = Brushes.WhiteSmoke;
                                    
            button_0_2.Background = Brushes.WhiteSmoke;
            button_1_2.Background = Brushes.WhiteSmoke;
            button_2_2.Background = Brushes.WhiteSmoke;
        }


        private void ButtonOnClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            
            if (moveCounter >= 9)
            {
                SetUp();
                return;
            }
            if (button.Content == string.Empty && moveCounter < 9)
            {
                moveCounter++;
                button.Content = isPlayerTurn ? "O" : "X";

                isPlayerTurn ^= true;
            }
            else
                return;
            WinnerChecker();
            
        }

        private void WinnerChecker()
        {
            if(button_0_0.Content != String.Empty && button_0_0.Content == button_0_1.Content && button_0_1.Content == button_0_2.Content)
            {
                moveCounter = 9;
                button_0_0.Background = Brushes.SpringGreen;
                button_0_1.Background = Brushes.SpringGreen;
                button_0_2.Background = Brushes.SpringGreen;
            }
            if (button_1_0.Content != String.Empty && button_1_0.Content == button_1_1.Content && button_1_1.Content == button_1_2.Content)
            {
                moveCounter = 9;
                button_1_0.Background = Brushes.SpringGreen;
                button_1_1.Background = Brushes.SpringGreen;
                button_1_2.Background = Brushes.SpringGreen;
            }
            if (button_2_0.Content != String.Empty && button_2_0.Content == button_2_1.Content && button_2_1.Content == button_2_2.Content)
            {
                moveCounter = 9;
                button_2_0.Background = Brushes.SpringGreen;
                button_2_1.Background = Brushes.SpringGreen;
                button_2_2.Background = Brushes.SpringGreen;
            }


            if (button_0_0.Content != String.Empty && button_0_0.Content == button_1_0.Content && button_1_0.Content == button_2_0.Content)
            {
                moveCounter = 9;
                button_0_0.Background = Brushes.SpringGreen;
                button_1_0.Background = Brushes.SpringGreen;
                button_2_0.Background = Brushes.SpringGreen;
            }
            if (button_0_1.Content != String.Empty && button_0_1.Content == button_1_1.Content && button_1_1.Content == button_2_1.Content)
            {
                moveCounter = 9;
                button_0_1.Background = Brushes.SpringGreen;
                button_1_1.Background = Brushes.SpringGreen;
                button_2_1.Background = Brushes.SpringGreen;
            }
            if (button_0_2.Content != String.Empty && button_0_2.Content == button_1_2.Content && button_1_2.Content == button_2_2.Content)
            {
                moveCounter = 9;
                button_0_2.Background = Brushes.SpringGreen;
                button_1_2.Background = Brushes.SpringGreen;
                button_2_2.Background = Brushes.SpringGreen;
            }

            if (button_0_0.Content != String.Empty && button_0_0.Content == button_1_1.Content && button_1_1.Content == button_2_2.Content)
            {
                moveCounter = 9;
                button_0_0.Background = Brushes.SpringGreen;
                button_1_1.Background = Brushes.SpringGreen;
                button_2_2.Background = Brushes.SpringGreen;
            }
            if (button_0_2.Content != String.Empty && button_0_2.Content == button_1_1.Content && button_1_1.Content == button_2_0.Content)
            {
                moveCounter = 9;
                button_0_2.Background = Brushes.SpringGreen;
                button_1_1.Background = Brushes.SpringGreen;
                button_2_0.Background = Brushes.SpringGreen;
            }
        }
    }
}
