using LOP67TH2_LTUDTXD_HUCE_26_NguyenHoaiNam_0053867_LOP67TH2.View;
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
using LOP67TH2_LTUDTXD_HUCE_26_NguyenHoaiNam_0053867_LOP67TH2.View;


namespace LOP67TH2_LTUDTXD_HUCE_26_NguyenHoaiNam_0053867_LOP67TH2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFr.Content = new HomePage();
            
        }

        private void btn_DamHCN_Click(object sender, RoutedEventArgs e)
        {
            MainFr.Content = new DesignBeam();
        }

        private void btn_DamCT_Click(object sender, RoutedEventArgs e)
        {
            MainFr.Content = new DesignBeamchuT();
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainFr.Content = new HomePage();
        }

        private void btn_back2_Click(object sender, RoutedEventArgs e)
        {
            MainFr.Content = new HomePage();
        }

        private void btn_back3_Click(object sender, RoutedEventArgs e)
        {
            MainFr.Content = new HomePage();
        }

        private void btn_Nhap_Click(object sender, RoutedEventArgs e)
        {
            MainFr.Content = new information();
        }

        private void btn_Macbt_Click(object sender, RoutedEventArgs e)
        {
            MainFr.Content = new MaterialConcrete();
        }

        private void btn_Thep_Click(object sender, RoutedEventArgs e)
        {
            MainFr.Content = new MaterialSteel();
        }

        private void btn_noiluc_Click(object sender, RoutedEventArgs e)
        {
            MainFr.Content = new Internalforce();
        }

        private void btn_AS_Click(object sender, RoutedEventArgs e)
        {
            MainFr.Content = new Result();
        }
    }
}
