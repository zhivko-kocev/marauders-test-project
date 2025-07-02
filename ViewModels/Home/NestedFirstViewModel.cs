using CommunityToolkit.Mvvm.ComponentModel;
using Kocew.WPF.MaraudersMap.MaraudersEntities;

namespace TryMaraudersProject.ViewModels.Home;

public class NestedFirstViewModel:MaraudersAware
{
    public string Title => "Welcome to First Nested View!";

    public override void OnNavigatedTo(Type sender, Dictionary<string, object> content)
    {
        Console.WriteLine(
            $"OnNavigatedTo called from {GetType().Name} and the sender is {sender.Name} and it sent {content.Count} items");
    }

    public override Dictionary<string, object> OnNavigatedFrom()
    {
        Console.WriteLine($"OnNavigatedFrom called from {GetType().Name}");
        return [];
    }
}