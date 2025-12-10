using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DetailsView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.dataGrid.QueryDetailsViewExpanderState += DataGrid_QueryDetailsViewExpanderState;
            this.dataGrid.DetailsViewExpanding += DataGrid_DetailsViewExpanding;
        }

        private void DataGrid_DetailsViewExpanding(object sender, Syncfusion.UI.Xaml.Grid.GridDetailsViewExpandingEventArgs e)
        {
            var orderInfo = e.Record as OrderInfo;
            if (orderInfo != null)
            {
                if (orderInfo.OrderDetails.Count == 0)
                    e.Cancel = true;
            }
        }

        private void DataGrid_QueryDetailsViewExpanderState(object sender, Syncfusion.UI.Xaml.Grid.QueryDetailsViewExpanderStateEventArgs e)
        {
            var orderInfo = e.Record as OrderInfo;
            if (orderInfo != null)
            {
                if (orderInfo.OrderDetails.Count == 0)
                    e.ExpanderVisibility = false;
            }
        }
    }
}
