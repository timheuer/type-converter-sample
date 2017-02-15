using Windows.UI.Xaml.Controls;

namespace CustomControlWithType
{
    public class MyMap : Control
    {
        public MyMap()
        {
            this.DefaultStyleKey = typeof(MyMap);
        }

        public string MapTitle { get; set; }
        public Location CenterPoint { get; set; }
    }
}
