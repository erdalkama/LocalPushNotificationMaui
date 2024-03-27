using Plugin.LocalNotification;

namespace LocalPushNotificationMaui;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnCounterClicked(object sender, EventArgs e)
    {
        var request = new NotificationRequest
        {
            NotificationId = 1337,
            Title = "MEDIUM",
            Subtitle = "Hello! I'm Erdal",
            Description = "Local Push Notification",
            BadgeNumber = 1,

            Schedule = new NotificationRequestSchedule
            {
                NotifyTime = DateTime.Now.AddSeconds(3),
            }
        };

        LocalNotificationCenter.Current.Show(request);
    }
}


