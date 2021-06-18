# How to exclude the Hidden Columns while exporting in WPF DataGrid (SfDataGrid)?

## About the sample
This example illustrates how to exclude the Hidden Columns while exporting in [WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid)?

[WPF DataGrid](https://www.syncfusion.com/wpf-controls/datagrid) (SfDataGrid) does not provide the direct support to exclude the hidden columns while exporting. You can exclude the hidden columns while exporting by using [ExcludeColumns](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.Converter.ExcelExportingOptions.html#Syncfusion_UI_Xaml_Grid_Converter_ExcelExportingOptions_ExcludeColumns) field in [ExcelExportingOptions](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Grid.Converter.ExcelExportingOptions.html).

```C#

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

```

![Shows the exclude the hidden column while exporting in SfDataGrid](ExcludeHiddenColumn.gif)

Take a moment to peruse the [WPF DataGrid - Export To Excel](https://help.syncfusion.com/wpf/datagrid/export-to-excel) documentation, where you can find about export to excel with code examples.

## Requirements to run the demo
Visual Studio 2015 and above versions
