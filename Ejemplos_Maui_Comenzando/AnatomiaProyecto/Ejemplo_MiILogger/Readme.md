

# Guía de Logging en .NET MAUI

Este documento resume las estrategias de registro de eventos (Logging) para .NET MAUI, desde el uso básico hasta la creación de proveedores personalizados.

## 1. System.Diagnostics.Debug

Es la herramienta más sencilla para desarrollo. Envía texto directamente al depurador del IDE.

* **Uso:** `Debug.WriteLine("Mensaje de prueba");`
* **Pros:** No requiere configuración.
* **Contras:** El compilador elimina estas líneas en modo **Release**. No permite niveles ni categorías.

---

## 2. Infraestructura de Logging (.NET)

Basada en el sistema oficial de Microsoft. Se divide en dos partes:

### A. Registro del Servicio (`AddLogging`)

Habilita la **Inyección de Dependencias**. MAUI lo suele incluir por defecto.

```csharp
// En MauiProgram.cs
builder.Services.AddLogging(); 

```

### B. Registro del Destino (`AddDebug`)

Define **a dónde** van los mensajes. `AddDebug` los envía a la ventana de salida de Visual Studio.

```csharp
// En MauiProgram.cs
builder.Logging.AddDebug();

```

### C. Uso por Inyección

Se pide en el constructor de la clase (Páginas o ViewModels).

```csharp
public MainPage(ILogger<MainPage> logger) {
    logger.LogInformation("Página cargada");
    logger.LogError("Error detectado");
}

```

---

## 3. Captura de Logcat (Android Nativo)

Permite leer el buffer interno de Android desde la propia aplicación. Útil para diagnósticos en dispositivos físicos.

```csharp
// Obtener el ID del proceso actual
int pid = Android.OS.Process.MyPid();

// Ejecutar comando nativo filtrando por nuestro PID
var proceso = Java.Lang.Runtime.GetRuntime().Exec($"logcat -d --pid {pid} -v time");
// ... leer el InputStream del proceso ...

```

---

## 4. Proveedor de Log Personalizado (Escritura en Archivo)

Para persistir logs en un archivo físico (`.txt`) y consultarlos más tarde, se debe implementar un `ILoggerProvider`.

### Paso 1: El Logger (Escritor)

```csharp
public class SimpleFileLogger : ILogger {
    private readonly string _path;
    public SimpleFileLogger(string path) => _path = path;

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? ex, Func<TState, Exception?, string> formatter) {
        var linea = $"[{DateTime.Now}] [{logLevel}] {formatter(state, ex)}";
        File.AppendAllText(_path, linea + Environment.NewLine);
    }
    // ... implementar BeginScope e IsEnabled ...
}

```

### Paso 2: El Provider

```csharp
public class FileLoggerProvider : ILoggerProvider {
    private readonly string _path;
    public FileLoggerProvider(string path) => _path = path;
    public ILogger CreateLogger(string category) => new SimpleFileLogger(_path);
    public void Dispose() { }
}

```

### Paso 3: Registro en MauiProgram

```csharp
string ruta = Path.Combine(FileSystem.AppDataDirectory, "app.log");
builder.Logging.AddProvider(new FileLoggerProvider(ruta));

```

---

## Tabla Comparativa Final

| Método | Persistente | Disponible en Release | Filtrable |
| --- | --- | --- | --- |
| **Debug.WriteLine** | No | No | No |
| **ILogger + AddDebug** | No | Sí (pero sin salida visual) | Sí |
| **Logcat Nativo** | Parcial (buffer) | Sí | Sí (vía PID) |
| **Custom File Provider** | Sí | Sí | Sí |

---

¿Te gustaría que te ayude a crear una interfaz gráfica simple en MAUI para mostrar este archivo de log con colores según el nivel de error?