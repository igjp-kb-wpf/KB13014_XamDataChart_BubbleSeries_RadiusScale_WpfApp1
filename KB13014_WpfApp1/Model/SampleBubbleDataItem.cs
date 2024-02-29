using KB13014_WpfApp1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB13014_WpfApp1.Model;
internal class SampleBubbleDataItem : ObservableObject
{
    private double _x;
    public double X
    {
        get { return _x; }
        set { _x = value; OnPropertyChanged(); }
    }

    private double _y;
    public double Y
    {
        get { return _y; }
        set { _y = value; OnPropertyChanged(); }
    }

    private double _radius;
    public double Radius
    {
        get { return _radius; }
        set { _radius = value; OnPropertyChanged(); }
    }

    public SampleBubbleDataItem()
    {
    }
}
