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
using Data.Database;
using WpfAppPostgre.Domain;
using System.Windows.Threading;

namespace WpfAppPostgre
{
    /// <summary>
    /// SelectTest.xaml の相互作用ロジック
    /// </summary>
    public partial class SelectTest : UserControl
    {
        public SelectTest()
        {
            InitializeComponent();

            DataContext = new SelectTestViewModel();

        }

        private void DataGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //列幅調節処理
            Dispatcher.BeginInvoke(new Action(() =>
            {
                var dataGrid = (DataGrid)e.Source;
                var difference = (dataGrid.ActualWidth - dataGrid.Columns
                    .Sum(x => x.ActualWidth) - 20) / dataGrid.Columns.Count;
                foreach (var col in dataGrid.Columns)
                {
                    col.Width = new DataGridLength(col.ActualWidth + difference);
                };

            })
            , DispatcherPriority.Loaded);
        }
    }
}
