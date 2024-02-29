using Infragistics.Controls.Charts;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KB13014_WpfApp1;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var vm = (MainWindowViewModel)DataContext;

        var scale1 = new SizeScale()
        {
            IsLogarithmic = false,
            MinimumValue = vm.SampleBubbleDataItems1.Min(dataItem => dataItem.Radius),
            MaximumValue = vm.SampleBubbleDataItems1.Max(dataItem => dataItem.Radius)
        };
        bubbleSeries1.RadiusScale = scale1;

        var scale2 = new SizeScale()
        {
            IsLogarithmic = false,
            MinimumValue = vm.SampleBubbleDataItems2.Min(dataItem => dataItem.Radius),
            MaximumValue = vm.SampleBubbleDataItems2.Max(dataItem => dataItem.Radius)
        };
        bubbleSeries2.RadiusScale = scale2;
    }
}