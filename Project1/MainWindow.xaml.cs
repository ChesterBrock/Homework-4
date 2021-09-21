/// Chapter No. 4		Exercise No. 1
/// File Name: MainWindow.xaml.cs
/// @author: Chester Brock 
/// Date:  Sep 20, 2021
///
/// Problem Statement: Write a GUI program that reads in the amount of a monthly mortgage payment and the outstanding balance  
/// 
/// 
/// Overall Plan:
/// 1) Create a constant for the yearly interest tax rate
/// 2) Prompt user to enter outstanding balance and monthly payments 
/// 3) get the monthly interest rate by dividing by 12 (6.39 * outstanding balance) / 12)
/// 4) Calculate the amount that goes into interest 
/// 5) Find the principal amount 
/// 6) find new balance 
/// 7) Display all the results 
///

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

namespace Project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
