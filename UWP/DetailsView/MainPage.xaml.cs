using Windows.UI.Xaml.Controls;

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
