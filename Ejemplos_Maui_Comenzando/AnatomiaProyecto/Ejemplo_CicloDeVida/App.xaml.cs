namespace Ejemplo_CicloDeVida;

//maneja el ciclo de vida de la aplicación
//inicia la ventana principal
public partial class App : Application
{

    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        //creación de la ventana principal
        return new Window(new AppShell());
    }

    protected override void OnStart()
    {
        //activación: invediatamente despues de crear la ventana principal, cuando la aplicación inicia por primera vez
        //uso: inicializaciones globales, configuraciones, inicializando servicios.
        base.OnStart();

        System.Diagnostics.Debug.WriteLine("OnStart");
    }

    protected override void OnResume()
    {
        //activación: cuando se vuelve desde otra app, vuelve a primer plano (antes en background), recupera foco
        //usos: reanudar operaciones pausadas (timers,etc), refrescar datos, o reconectar sockets.
        base.OnResume();

        System.Diagnostics.Debug.WriteLine("OnResumen");
    }

    protected override void CleanUp()
    {
        //activación: finalización de la aplicación, cierre completo
        //usos: cerrar conexiones, liberar recursos, guardar estados finales.
        base.CleanUp();

        System.Diagnostics.Debug.WriteLine("CleanUp");
    }

    protected override void OnSleep()
    {
        //activación: cambio de app, minimizado de la aplicación y pasa a segundo plano
        //usos: liberar recursos, guardar estados, pausar tareas (reanudan en onresumen)
        base.OnSleep();

        System.Diagnostics.Debug.WriteLine("OnSleep");
    }

    public override void ActivateWindow(Window window)
    {
        //activación: cuando la ventana gana foco
        //usos: reactiva ui, actualiza estado visual
        base.ActivateWindow(window);

        System.Diagnostics.Debug.WriteLine("window");
    }

    public override void CloseWindow(Window window)
    {
        //activación: Se ejecuta cuando una ventana se cierra.
        //usos: guardar estado de la ventana, liberar recursos específicos de la ventana.
        base.CloseWindow(window);

        System.Diagnostics.Debug.WriteLine("closewindow");
    }

    private async void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        //Captura excepciones no manejadas del dominio de la app.
        

    }

    private async void TaskScheduler_UnobservedTaskException(object? sender, UnobservedTaskExceptionEventArgs e)
    {
        //Captura excepciones de Tasks que nadie await-eó.
    }
}