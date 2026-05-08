

# Captura de Logs Nativos en .NET MAUI (Android)

Este módulo permite extraer los registros del sistema (**Logcat**) directamente
desde la aplicación, filtrando la información para obtener solo lo relevante al proceso actual.

## Implementación Rápida

Para leer los logs internos de la aplicación en Android, se utiliza la ejecución de comandos de shell a través de `Java.Lang.Runtime`.

### Código de Extracción

```csharp
#if ANDROID
    // 1. Obtener el ID del proceso actual (PID) para no leer basura del sistema
    int pid = Android.OS.Process.MyPid();

    // 2. Ejecutar logcat: 
    // -d: Vuelca el buffer actual y finaliza
    // --pid: Filtra solo los mensajes de nuestra App
    // -v time: Incluye marcas de tiempo
    var proceso = Java.Lang.Runtime.GetRuntime().Exec($"logcat -d --pid {pid} -v time");
    
    using var reader = new Java.IO.BufferedReader(new Java.IO.InputStreamReader(proceso.InputStream));
    var sb = new System.Text.StringBuilder();
    string? linea;

    while ((linea = reader.ReadLine()) != null)
    {
        sb.AppendLine(linea);
    }

    string miLogcat = sb.ToString();
#endif

```

## 🛠️ Comandos de Filtrado (Logcat)

Dependiendo de lo que necesites ver, puedes modificar el string del comando `.Exec()`:

| Comando | Resultado |
| --- | --- |
| `logcat -d --pid {pid}` | Solo lo que genera tu app (Recomendado). |
| `logcat -d *:E` | Muestra solo los **Errores** (propios y del sistema). |
| `logcat -d *:W` | Muestra **Advertencias** y Errores. |
| `logcat -c` | **Limpia** el historial de logs (útil antes de iniciar un proceso). |

## ⚠️ Notas Importantes

1. **Directivas de Compilación:** El código debe estar envuelto en `#if ANDROID` ya que utiliza librerías de Java nativas que no existen en iOS o Windows.
2. **Permisos:** Desde Android 4.1, las aplicaciones **solo pueden leer sus propios logs**. No verás mensajes de otras apps por seguridad.
3. **Release vs Debug:**
* Si usas `System.Diagnostics.Debug`, los mensajes **no aparecerán** en el Logcat si compilas en modo **Release**.
* Si usas `Android.Util.Log.Info("TAG", "Mensaje")`, los mensajes persistirán incluso en la versión final de la tienda.



---

## obtener el valor pid del proceso

#if ANDROID
    int pid = Android.OS.Process.MyPid();
#endif