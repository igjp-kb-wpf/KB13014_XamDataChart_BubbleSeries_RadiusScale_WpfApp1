using KB13014_WpfApp1.Infrastructure;
using KB13014_WpfApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB13014_WpfApp1;
internal class MainWindowViewModel : ObservableObject
{
	private ObservableCollection<SampleBubbleDataItem> _sampleBubbleDataItems1;
	public ObservableCollection<SampleBubbleDataItem> SampleBubbleDataItems1
	{
		get { return _sampleBubbleDataItems1; }
		set { _sampleBubbleDataItems1 = value; OnPropertyChanged(); }
	}

    private ObservableCollection<SampleBubbleDataItem> _sampleBubbleDataItems2;
    public ObservableCollection<SampleBubbleDataItem> SampleBubbleDataItems2
    {
        get { return _sampleBubbleDataItems2; }
        set { _sampleBubbleDataItems2 = value; OnPropertyChanged(); }
    }

    public MainWindowViewModel()
    {
		_sampleBubbleDataItems1 = new()
		{
			new () { X = 14.62120165, Y = 24.4225263, Radius = 10 },
			new () { X = 67.39662402, Y = 75.53715618, Radius = 30 },
			new () { X = 49.40682044, Y = 57.5293363, Radius = 50 },
		};

		_sampleBubbleDataItems2 = new()
		{
			new () { X = 38.84576134, Y = 62.22608273, Radius = 30 },
			new () { X = 85.94647829, Y = 14.35851323, Radius = 50 },
        };
    }
}
