namespace Ejemplo_WebView.Pages;

public partial class MainPage : ContentPage
{
   

    public MainPage()
    {
        InitializeComponent();

        webView.Source = "https://hxbt1xfz-7102.brs.devtunnels.ms/";//"https://hxbt1xfz-7257.brs.devtunnels.ms/";

        //webView.Source ="https://www.google.com";
    }

    private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
    {
        //if (e.Url.Contains("foto"))
        //{
        //    e.Cancel = true;
        //}
    }

    private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
    {

    }
}
