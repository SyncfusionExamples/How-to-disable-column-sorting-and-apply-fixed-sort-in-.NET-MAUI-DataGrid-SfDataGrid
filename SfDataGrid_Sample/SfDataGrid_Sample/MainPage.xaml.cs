using Syncfusion.Maui.DataGrid;

namespace SfDataGrid_Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ApplyFixedSort();
        }

        private void ApplyFixedSort()
        {
            dataGrid.SortColumnDescriptions.Clear();

            dataGrid.SortColumnDescriptions.Add(new SortColumnDescription
            {
                ColumnName = "ShipCountry",
                SortDirection = System.ComponentModel.ListSortDirection.Descending
            });

            dataGrid.SortColumnDescriptions.Add(new SortColumnDescription
            {
                ColumnName = "CustomerID",
                SortDirection = System.ComponentModel.ListSortDirection.Ascending
            });
        }
    }
}
