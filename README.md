# How to disable column sorting and apply fixed sort in .NET MAUI DataGrid?
This sample demonstrates how to disable column sorting in the [.NET MAUI SfDataGrid](https://help.syncfusion.com/maui/datagrid/overview) and prevent users from modifying the sort order. It also shows how to apply a fixed, programmatic sort using SortColumnDescriptions so the grid loads with a predefined order. This example helps maintain consistent data presentation while blocking user‑initiated sorting changes.

## XAML

```xml
 <ContentPage.Content>
     <syncfusion:SfDataGrid x:Name="dataGrid"
                            SortingMode="None"
                            ItemsSource="{Binding OrderInfoCollection}">
         
         <syncfusion:SfDataGrid.Columns>
             <syncfusion:DataGridNumericColumn HeaderText="Order ID" 
                                               Format="0"
                                               MappingName="OrderID" 
                                               Width="150" />
             
             <syncfusion:DataGridTextColumn  HeaderText="Customer ID"
                                             MappingName="CustomerID"
                                             Width="150" />
             
             <syncfusion:DataGridTextColumn  HeaderText="Ship Country"
                                             MappingName="ShipCountry"
                                             Width="150" />
             
             <syncfusion:DataGridTextColumn  HeaderText="Customer Name"
                                             MappingName="Customer"
                                             Width="150" />

             <syncfusion:DataGridTextColumn  HeaderText="Ship City"
                                             MappingName="ShipCity"
                                             Width="150" />
         </syncfusion:SfDataGrid.Columns>
     </syncfusion:SfDataGrid>
     
 </ContentPage.Content>
```

## C#

```csharp
private void ApplyFixedSort()
{
    dataGrid.SortColumnDescriptions.Clear();

    dataGrid.SortColumnDescriptions.Add(new SortColumnDescription
    {
        ColumnName = "CustomerID",
        SortDirection = System.ComponentModel.ListSortDirection.Ascending
    });

    dataGrid.SortColumnDescriptions.Add(new SortColumnDescription
    {
        ColumnName = "ShipCountry",
        SortDirection = System.ComponentModel.ListSortDirection.Descending
    });
}
```

Download the complete sample from [GitHub](https://github.com/SyncfusionExamples/How-to-disable-column-sorting-and-apply-fixed-sort-in-.NET-MAUI-DataGrid-SfDataGrid)