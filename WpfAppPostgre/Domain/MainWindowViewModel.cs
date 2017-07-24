using System.Windows.Controls;

namespace WpfAppPostgre
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            ListItems = new[]
            {
                new ListItem("Home", new Home())
                    {
                        VerticalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto,
                        //HorizontalScrollBarVisibilityRequirement = ScrollBarVisibility.Auto
                    },
                new ListItem("Select", new SelectTest())
            };
        }

        public ListItem[] ListItems { get; }
    }
}