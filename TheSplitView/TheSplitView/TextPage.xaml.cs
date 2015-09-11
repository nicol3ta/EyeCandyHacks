using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TheSplitView
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet werden kann oder auf die innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class TextPage : Page
    {
        public TextPage()
        {
            this.InitializeComponent();

            textContainer.Height = Window.Current.Bounds.Height;
            Window.Current.SizeChanged += (s, e) =>
            {
                if (overflowContainer.HasOverflowContent && (overflowContainer.Visibility == Visibility.Collapsed))
                {
                    textContainer.OverflowContentTarget = null;
                }
                else
                {
                    textContainer.OverflowContentTarget = overflowContainer;
                }
            };
        }

    }
}
