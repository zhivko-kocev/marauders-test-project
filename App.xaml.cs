using Kocew.WPF.MaraudersMap.MaraudersServices;
using Microsoft.Extensions.DependencyInjection;
using TryMaraudersProject.ViewModels;
using TryMaraudersProject.ViewModels.Home;
using TryMaraudersProject.Views;
using TryMaraudersProject.Views.Home;
using HomeViewModel = TryMaraudersProject.ViewModels.Home.HomeViewModel;

namespace TryMaraudersProject;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    public static IServiceProvider Services { get; private set; } = null!;

    public App()
    {
        var services = new ServiceCollection();

        services.AddSingleton<HomeViewModel>();
        services.AddSingleton<SettingsViewModel>();
        services.AddSingleton<NestedFirstViewModel>();
        services.AddSingleton<NestedSecondViewModel>();


        services.AddSingleton<HomeView>();
        services.AddSingleton<SettingsView>();
        services.AddSingleton<NestedFirstView>();
        services.AddSingleton<NestedSecondView>();
        
        services.AddSingleton<MainWindow>();


        Services = services.BuildServiceProvider();
        NavigationProvider.Services = Services;
        
        Services.GetRequiredService<MainWindow>().Show();
    }
}