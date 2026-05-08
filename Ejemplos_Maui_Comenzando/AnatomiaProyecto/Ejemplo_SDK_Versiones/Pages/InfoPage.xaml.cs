using System.Reflection;

namespace Ejemplo_SDK_Versiones.Pages;

public partial class InfoPage : ContentPage
{
    public InfoPage()
    {
        InitializeComponent();
    }

    private void OnVerInfoClicked(object sender, EventArgs e)
    {
        // Runtime de .NET en el dispositivo
        string dotnetVersion = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
        
        // OS del teléfono y arquitectura (debería decir ARM o X86)
        string osVersion = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
        string arch = System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString();
        var mauiVersion = typeof(MauiApp).Assembly.GetName().Version?.ToString() ?? "Desconocida";
        string appVersion = AppInfo.Current.VersionString; // Ej: 1.0
        string buildNumber = AppInfo.Current.BuildString;   // Ej: 1

        var maui = typeof(MauiApp).Assembly.GetName().Version?.ToString() ?? "N/A";
        string appV = AppInfo.Current.VersionString;

        var infoVersion = Assembly.GetAssembly(typeof(MauiApp))
                ?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                ?.InformationalVersion;

        LbInfo.Text += $"\n[SDK Detalle]: {infoVersion}";

        var targetSdk = "";
        var osVersionName = "" ;
#if ANDROID
        targetSdk = Android.OS.Build.VERSION.SdkInt.ToString();
        osVersionName = Android.OS.Build.VERSION.Release;
#endif

        LbInfo.Text = $@"[.NET Version]: {dotnetVersion}
[OS]: {osVersion}
[Arch]: {arch}
[maui]: {maui}
[infoVersion]: {infoVersion}
[appVersion]: {appV}
[targetSdk ]: {targetSdk}
[osVersionName]: {osVersionName}
";
    }

    async private void OnVolverClicked(object sender, EventArgs e)
    {
        //volver hacia atras
        //await Shell.Current.GoToAsync("../");
        await Navigation.PopAsync();
    }
}