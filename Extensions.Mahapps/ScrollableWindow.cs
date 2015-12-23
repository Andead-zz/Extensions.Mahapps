using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls;

namespace Andead.Controls.Mahapps
{
    /// <summary>
    ///     Represents a simple metro-style scrollable window with automatic scrolling depending on
    ///     <see cref="SizeToContent" /> value if the latter equals <see cref="SizeToContent.Manual" />.
    /// </summary>
    public class ScrollableWindow : MetroWindow
    {
        private bool _changingContent;

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            if (_changingContent)
                return;

            if (SizeToContent == SizeToContent.Manual)
            {
                _changingContent = true;

                Content = new ScrollViewer
                {
                    Content = newContent
                };

                _changingContent = false;
            }
        }
    }
}