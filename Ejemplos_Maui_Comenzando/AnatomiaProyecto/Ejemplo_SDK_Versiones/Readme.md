
# Definiciones

## SDK (Software Development Kit): 
Es la "Caja de Herramientas". Contiene todo lo necesario 
para crear aplicaciones: el compilador (csc.exe), los comandos de terminal (dotnet build, 
dotnet restore) y los Workloads.

Comandos asociados:
```
C:\Users\fernando>dotnet --list-sdks
8.0.406 [C:\Program Files\dotnet\sdk]
9.0.308 [C:\Program Files\dotnet\sdk]
10.0.102 [C:\Program Files\dotnet\sdk]
```

## Runtime (Entorno de Ejecución): 
Es el "Motor". Es lo mínimo necesario para que una aplicación ya compilada pueda correr 
en una computadora.

Comando: lista de motores para ejecutar la herramienta
```
C:\Users\fernando>dotnet --list-runtimes
Microsoft.AspNetCore.App 8.0.13 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.AspNetCore.App 8.0.22 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.AspNetCore.App 8.0.23 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.AspNetCore.App 9.0.11 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.AspNetCore.App 9.0.12 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.AspNetCore.App 10.0.2 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.NETCore.App 8.0.13 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.NETCore.App 8.0.22 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.NETCore.App 8.0.23 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.NETCore.App 9.0.11 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.NETCore.App 9.0.12 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.NETCore.App 10.0.2 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.WindowsDesktop.App 8.0.13 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
Microsoft.WindowsDesktop.App 8.0.22 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
Microsoft.WindowsDesktop.App 8.0.23 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
Microsoft.WindowsDesktop.App 9.0.11 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
Microsoft.WindowsDesktop.App 9.0.12 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
Microsoft.WindowsDesktop.App 10.0.2 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
```

## Workload - Carga de trabajo

Los Workloads (cargas de trabajo) son componentes modulares y opcionales del SDK de .NET.
A partir de .NET 6, el SDK se volvió "pesado" porque incluía soporte para todo (Android,
iOS, WebAssembly, etc.). Para solucionar esto, Microsoft creó los Workloads: en lugar
de instalar un SDK gigante de varios gigabytes, instalas solo la base de .NET y
luego se agrega por separado los paquetes específicos que se necesiten para el desarrollo

Comandos asociados:
- Muestra qué módulos tienes instalados actualmente.
```
C:\Users\fernando>dotnet workload list

Versión de carga de trabajo: 10.0.102

Id. de carga de trabajo instalada      Versión del manifiesto      Origen de la instalación
--------------------------------------------------------------------------------------------------------------------
android                                36.1.12/10.0.100            SDK 10.0.100, VS 18.2.11408.102, VS 17.14.36811.4
ios                                    26.2.10191/10.0.100         SDK 10.0.100, VS 18.2.11408.102, VS 17.14.36811.4
maccatalyst                            26.2.10191/10.0.100         SDK 10.0.100, VS 18.2.11408.102, VS 17.14.36811.4
maui-android                           10.0.1/10.0.100             SDK 10.0.100
maui-windows                           10.0.1/10.0.100             SDK 10.0.100, VS 18.2.11408.102, VS 17.14.36811.4
wasm-tools                             10.0.102/10.0.100           SDK 10.0.100, VS 17.14.36811.4

Use "dotnet workload search" para buscar cargas de trabajo adicionales para instalar.
```

- Instala un módulo (ej. dotnet workload install maui).
```dotnet workload install [nombre]```

- Actualiza todos los módulos instalados a su última versión disponible.
```dotnet workload update``` 

- Reinstala los módulos si algo está fallando (útil para tu error de paquetes faltantes).
```dotnet workload repair```

## Rid - Runtime Identifier

Un RID (Runtime Identifier) es un identificador que utiliza .NET para saber 
exactamente en qué sistema operativo y arquitectura de procesador se va a 
ejecutar tu aplicación. Se relaciona con el tipo de paquete que va a tomar 
de los repositorios de NuGet.

Ejemplos de RID: win-x64, linux-arm64, osx-x64, android-arm64


# Analizando versiones

tengo esto

```
C:\Users\fernando>dotnet workload list

Versión de carga de trabajo: 10.0.102

Id. de carga de      Versión             Origen de la instalación
trabajo instalada    del manifiesto
------------------------------------------------------------------------------------------
android             36.1.12/10.0.100     SDK 10.0.100, VS 18.2.11408.102, VS 17.14.36811.4
...

```

y

```
C:\Users\fernando>dotnet --list-sdks
9.0.308 [C:\Program Files\dotnet\sdk]
10.0.102 [C:\Program Files\dotnet\sdk]
```

Segun esas salidas tengo el sdk 10.0.102, pero en dotnet workload list me dice que el 
workload instalado es: 
( android  | 36.1.12/10.0.100  |  SDK 10.0.100, VS 18.2.11408.102, VS 17.14.36811.4 )
parece que como esa extensión es del sdk 10.0.100, pero mi sdk instalado es el 10.0.102


El error ocurre porque cuando ejecutas dotnet restore usando el SDK 10.0.102, el sistema 
busca los paquetes de carga de trabajo (workloads) que correspondan exactamente a esa banda 
del SDK. Como el workload de Android que tienes está "atado" a la versión 10.0.100, el SDK 
más nuevo no lo reconoce como una instalación válida para sí mismo y sale a buscar los 
paquetes a internet (NuGet), fallando porque los RIDs de .NET 10 aún están en una etapa
muy temprana o no coinciden.

Algunas soluciones
```
dotnet workload repair
```



# Administración de lo Workloads o cargas de trabajo

## Listar los workloads instalados
dotnet workload list

## Buscar todos los workloads disponibles
dotnet workload search
```
C:\Users\fernando>dotnet workload search

Id. de carga de trabajo         Descripción
----------------------------------------------------------------------------------------
android                         .NET SDK Workload for building Android applications.
ios                             .NET SDK Workload for building iOS applications.
maccatalyst                     .NET SDK Workload for building MacCatalyst applications.
macos                           .NET SDK Workload for building macOS applications.
maui                            .NET MAUI SDK for all platforms
maui-android                    .NET MAUI SDK for Android
maui-desktop                    .NET MAUI SDK for Desktop
maui-ios                        .NET MAUI SDK for iOS
maui-maccatalyst                .NET MAUI SDK for Mac Catalyst
maui-mobile                     .NET MAUI SDK for Mobile
maui-tizen                      .NET MAUI SDK for Tizen
maui-windows                    .NET MAUI SDK for Windows
mobile-librarybuilder           workloads/mobile-librarybuilder/description
mobile-librarybuilder-net9      workloads/mobile-librarybuilder-net9/description
tvos                            .NET SDK Workload for building tvOS applications.
wasi-experimental               workloads/wasi-experimental/description
wasi-experimental-net8          workloads/wasi-experimental-net8/description
wasi-experimental-net9          workloads/wasi-experimental-net9/description
wasm-experimental               Herramientas experimentales .NET WebAssembly
wasm-experimental-net7          workloads/wasm-experimental-net7/description
wasm-experimental-net8          workloads/wasm-experimental-net8/description
wasm-experimental-net9          Herramientas experimentales .NET 9.0 WebAssembly
wasm-tools                      Herramientas de compilación de WebAssembly de .NET
wasm-tools-net6                 Herramientas de compilación de WebAssembly de .NET
wasm-tools-net7                 Herramientas de compilación de WebAssembly de .NET
wasm-tools-net8                 Herramientas de compilación de WebAssembly de .NET 8.0
wasm-tools-net9                 Herramientas de compilación de WebAssembly de .NET 9.0
```


```
C:\Users\fernando>dotnet --list-runtimes
Microsoft.AspNetCore.App 8.0.13 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.AspNetCore.App 8.0.22 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.AspNetCore.App 8.0.23 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.AspNetCore.App 9.0.11 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.AspNetCore.App 9.0.12 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.AspNetCore.App 10.0.2 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
Microsoft.NETCore.App 8.0.13 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.NETCore.App 8.0.22 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.NETCore.App 8.0.23 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.NETCore.App 9.0.11 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.NETCore.App 9.0.12 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.NETCore.App 10.0.2 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
Microsoft.WindowsDesktop.App 8.0.13 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
Microsoft.WindowsDesktop.App 8.0.22 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
Microsoft.WindowsDesktop.App 8.0.23 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
Microsoft.WindowsDesktop.App 9.0.11 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
Microsoft.WindowsDesktop.App 9.0.12 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
Microsoft.WindowsDesktop.App 10.0.2 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
```





# Mensaje por incompatibilidad de CPU y plataforma.

configuración en el fichero manifest:
```
<uses-sdk android:minSdkVersion="25" android:targetSdkVersion="36" />
```

Mensaje al hacer el build
```
ADB0020: Mono.AndroidTools.IncompatibleCpuAbiException: The package does 
not support the CPU architecture of this device. ...

```

Comando de restauración para completar el soporte de 32bits.
```
dotnet restore --runtime android-arm
```

Mensaje de error al ejecutar el comando de restauración
```
 E:\repos\tup\aplicada\2025\utn\Ejemplos_Maui_Comenzando\Ejemplos_Maui_Comenzando\
 Ejemplo_SDK_Versiones> dotnet restore --runtime android-arm
    E:\repos\tup\aplicada\2025\utn\Ejemplos_Maui_Comenzando\Ejemplos_Maui_Comenzando\
    Ejemplo_SDK_Versiones\Ejemplo_SDK_Versiones.csproj : error NU1101: No se encuentra 
    el paquete Microsoft.NETCore.App.Runtime.linux-bionic-arm. No existe ningún paquete 
    con este id. en los orígenes: C:\Program Files\dotnet\library-packs, Microsoft Visual 
    Studio Offline Packages, nuget.or
```
El error ocurre porque el comando dotnet restore --runtime android-arm está buscando un identificador de plataforma (RID)

## La solución

Es ejecutar
```
dotnet workload install maui-android
```
luego restaurar el proyecto con
```
dotnet workload repair
dotnet restore -t:net10.0-android
```
Ajustar el proyecto con 
```
<TargetFrameworks>net10.0-android;net10.0-ios;net10.0-maccatalyst</TargetFrameworks>
```

https://youtu.be/fkL2tU_qmiA