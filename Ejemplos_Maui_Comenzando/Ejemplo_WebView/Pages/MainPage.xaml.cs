using System;

namespace Ejemplo_WebView.Pages;

public partial class MainPage : ContentPage
{
   

    public MainPage()
    {
        InitializeComponent();

        //webView.Source = "https://hxbt1xfz-7102.brs.devtunnels.ms/";//"https://hxbt1xfz-7257.brs.devtunnels.ms/";
        webView.Source = "https://geometriafernando.somee.com/";

//var request = new HttpRequestMessage(HttpMethod.Get, "https://hxbt1xfz-7102.brs.devtunnels.ms/");

//request.Headers.Add("X-Tunnel-Skip-AntiPhishing-Page", "true");

//webView.Source = new UrlWebViewSource
//{
//    Url = "https://hxbt1xfz-7102.brs.devtunnels.ms/"
//};

//var webViewSource = new UrlWebViewSource
//{
//    Url = "https://hxbt1xfz-7102.brs.devtunnels.ms/"
//};

//#if ANDROID
//    var nativeWebView = webView.Handler?.PlatformView as Android.Webkit.WebView;
//    if (nativeWebView != null)
//    {
//        Dictionary<string, string> headers = new Dictionary<string, string>
//        {
//            { "X-Tunnel-Skip-AntiPhishing-Page", "true" }
//        };
//        nativeWebView.LoadUrl("https://geometriafernando.somee.com/", headers);
//    }
//# endif
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
