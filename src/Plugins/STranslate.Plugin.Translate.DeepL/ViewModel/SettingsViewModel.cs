using CommunityToolkit.Mvvm.ComponentModel;

namespace STranslate.Plugin.Translate.DeepL.ViewModel;

public partial class SettingsViewModel(IPluginContext context, Settings settings) : ObservableObject
{
    [ObservableProperty] public partial string ApiKey { get; set; } = settings.ApiKey;
    [ObservableProperty] public partial bool UseProApi { get; set; } = settings.UseProApi;

    partial void OnApiKeyChanged(string value)
    {
        settings.ApiKey = value;
        context.SaveSettingStorage<Settings>();
    }

    partial void OnUseProApiChanged(bool value)
    {
        settings.UseProApi = value;
        context.SaveSettingStorage<Settings>();
    }
}