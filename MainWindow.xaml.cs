using Syncfusion.UI.Xaml.Grid.Converter;
using Syncfusion.XlsIO;
using System.Diagnostics;
using System.Windows;

namespace SfDataGridDemo
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

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            var file_name = "Sample.xlsx";
            var options = new ExcelExportingOptions
            {
                ExcelVersion = ExcelVersion.Excel2016,
            };

            //get the columns in SfDataGrid
            foreach (var column in dataGrid.Columns)
            {
                //check the columns is Hidden or not
                if (column.IsHidden)
                    //While exporting Hidden column stop by Add the MappingName of hidden column in ExcludeColumns in ExcelExportingOptions
                    options.ExcludeColumns.Add(column.MappingName);
            }

            var excelEngine = dataGrid.ExportToExcel(dataGrid.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];
            workBook.SaveAs(file_name);
            _ = Process.Start(file_name);
        }
    }
}
