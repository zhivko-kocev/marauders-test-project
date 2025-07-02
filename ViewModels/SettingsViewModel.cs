using CommunityToolkit.Mvvm.ComponentModel;
using Kocew.WPF.MaraudersMap.MaraudersEntities;

namespace TryMaraudersProject.ViewModels;

public class SettingsViewModel : MaraudersAware
{
    public string Title => "Welcome to Settings View";

    public override void OnNavigatedTo(Type sender, Dictionary<string, object> content)
    {
        Console.WriteLine(
            $"OnNavigatedTo called from {GetType().Name} and the sender is {sender.Name} and it sent {content.Count} items");
    }

    public override Dictionary<string, object> OnNavigatedFrom()
    {
        Console.WriteLine($"OnNavigatedFrom called from {GetType().Name}");
        return new Dictionary<string, object> { { "test", 1 } };
    }
}