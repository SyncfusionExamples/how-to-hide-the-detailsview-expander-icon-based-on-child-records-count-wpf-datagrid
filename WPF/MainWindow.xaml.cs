#region Copyright Syncfusion Inc. 2001 - 2019
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Shared;

namespace MasterDetailsViewDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ChromelessWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.dataGrid.QueryDetailsViewExpanderState += DataGrid_QueryDetailsViewExpanderState;
        }

        private void DataGrid_QueryDetailsViewExpanderState(object sender, Syncfusion.UI.Xaml.Grid.QueryDetailsViewExpanderStateEventArgs e)
        {
            var orderInfo = e.Record as OrderInfo;
            if (orderInfo != null)
            {
                if (orderInfo.OrderDetails.Count == 0)
                {
                    e.ExpanderVisibility = false;
                }
            }
        }
    }
}
