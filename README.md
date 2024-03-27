# .NET MAUI Local Push Notification

## Overview
![Adsız tasarım (2)](https://github.com/erdalkama/LocalPushNotificationMaui/assets/34250103/2efe7498-f840-43c4-b9fa-699d1ee0d94e)
This repository contains an example .NET MAUI project demonstrating how to integrate local push notifications using the Plugin.LocalNotification package.

### Features

- **Local Push Notifications:** Utilize Plugin.LocalNotification to create and display local push notifications.
- **Customization:** Customize notification content, such as title, subtitle, description, and badge number.
- **Scheduling:** Schedule notifications to be shown at specific times using NotificationRequestSchedule.
- **Interactivity:** Add action buttons to notifications for user interaction directly from the notification.

## Getting Started

To run this project locally, follow these steps:

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or Visual Studio Code.
3. Build and run the application on your preferred platform (Android, iOS, Windows).

### Usage

The main functionality of this project revolves around the `OnCounterClicked` method in the `MainPage.xaml.cs` file. This method demonstrates how to create a local push notification using Plugin.LocalNotification.

```csharp
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
```
Feel free to explore and modify the code to suit your needs or integrate more advanced notification features.

## Dependencies

- [.NET MAUI](https://github.com/dotnet/maui)
- [Plugin.LocalNotification](https://www.nuget.org/packages/Plugin.LocalNotification)

## Contributing

Contributions are welcome! If you encounter any issues or have suggestions for improvements, please open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
