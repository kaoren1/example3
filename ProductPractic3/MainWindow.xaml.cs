using ProductPractic3.PractisDataSetTableAdapters;
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

namespace ProductPractic3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PractisEntities pr = new PractisEntities();

        WorkReportTableAdapter workReportTableAdapter = new WorkReportTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EF_Click(object sender, RoutedEventArgs e)
        {
            EFWindow ef = new EFWindow();
            ef.Show();
            ef.EFTable.ItemsSource = pr.Info.ToList();
        }

        private void DataSet_Click(object sender, RoutedEventArgs e)
        {
            DataSetWindow dataSetWindow = new DataSetWindow();
            dataSetWindow.Show();
            dataSetWindow.DataSetTable.ItemsSource = workReportTableAdapter.GetDataBy();
        }
    }
}
