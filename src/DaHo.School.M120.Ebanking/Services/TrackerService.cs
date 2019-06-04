using System.Windows;
using System.Windows.Forms;
using Jot;

namespace DaHo.School.M120.Ebanking.Services
{
    public static class TrackerService
    {
        public static Tracker JotTracker = new Tracker();

        static TrackerService()
        {
            JotTracker.Configure<Window>()
                .Id(w => w.ToString(), SystemInformation.VirtualScreen.Size)
                .Properties(w => new {w.Height, w.Width, w.Left, w.Top, w.WindowState})
                .PersistOn(nameof(Window.Closing))
                .StopTrackingOn(nameof(Window.Closing));
        }
    }
}
