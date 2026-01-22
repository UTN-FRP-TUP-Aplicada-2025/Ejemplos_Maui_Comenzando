##instalar la primera vez 

7zip
https://sourceforge.net/projects/sevenzip/


## 📱 Versiones de iOS, SDK, macOS, Xcode y .NET compatible

| Versión de iOS | Fecha de Lanzamiento     | iOS SDK    | Xcode Asociado | iOS SDK Requerido por Xcode    | Versión mínima de macOS compatible | Versión de .NET para iOS compatible | Estado en tu Proyecto |
|----------------|--------------------------|------------|----------------|--------------------------------|------------------------------------|------------------------------------|------------------------|
| iOS 11.0		 | 19 de septiembre de 2017 | SDK 11.0   | Xcode 9.0      | iOS SDK 11.0                   | macOS 10.12.6 Sierra               | .NET 6+ (soporte inicial MAUI)      | ✓ Soportado |
| iOS 12.0		 | 17 de septiembre de 2018 | SDK 12.0   | Xcode 10.0     | iOS SDK 12.0                   | macOS 10.13.6 High Sierra          | .NET 6+                             | ✓ Soportado |
| iOS 13.0		 | 19 de septiembre de 2019 | SDK 13.0   | Xcode 11.0     | iOS SDK 13.0                   | macOS 10.14.4 Mojave               | .NET 6+                             | ✓ Soportado |
| iOS 14.0		 | 16 de septiembre de 2020 | SDK 14.0   | Xcode 12.0     | iOS SDK 14.0                   | macOS 10.15.4 Catalina             | .NET 6+                             | ✓ Soportado |
| iOS 15.0		 | 20 de septiembre de 2021 | SDK 15.0   | Xcode 13.0     | iOS SDK 15.0                   | macOS 11.3 Big Sur                 | .NET 7+                             | ✓ Soportado |
| iOS 16.0		 | 12 de septiembre de 2022 | SDK 16.0   | Xcode 14.0     | iOS SDK 16.0                   | macOS 12.4 Monterey                | .NET 8+                             | ✓ Soportado |
| iOS 17.0       | 18 de septiembre de 2023 | SDK 17.0   | Xcode 15.0     | iOS SDK 17.0                   | macOS 13.5 Ventura                 | .NET 8+                             | ✓ Soportado |
| iOS 18.0       | 16 de septiembre de 2024 | SDK 18.0   | Xcode 16.0     | iOS SDK 18.0                   | macOS 14.5 Sonoma                  | .NET 9+ (soporte estable)           | ✓ Soportado |
| iOS 18.0       | 16 de septiembre de 2024 | SDK 18.0   | Xcode 16.1     | iOS SDK 18.0                   | macOS 14.5 Sonoma                  | .NET 9+                             | ✓ Soportado |
| iOS 18.0       | 16 de septiembre de 2024 | SDK 18.0   | Xcode 16.2     | iOS SDK 18.0                   | macOS 14.5 Sonoma                  | .NET 9+                             | ✓ Soportado |
| iOS 18.0       | 16 de septiembre de 2024 | SDK 18.0   | Xcode 16.3     | iOS SDK 18.0                   | macOS 14.5 Sonoma                  | .NET 9+                             | ✓ Soportado |
| iOS 18.0       | 16 de septiembre de 2024 | SDK 18.0   | Xcode 16.4     | iOS SDK 18.0                   | macOS 14.5 Sonoma                  | .NET 9+                             | ✓ Soportado |
| iOS 18.x       | Desde septiembre de 2024 | SDK 18.x   | Xcode 26.0 ⚠️  | iOS SDK 26.0 ✅               | macOS 14.5 Sonoma                  | .NET 10.0+ (compatible con 26.0)    | 🚀 **RECOMENDADO** |
| iOS 18.x       | Desde septiembre de 2024 | SDK 18.x   | Xcode 26.1 ⚠️  | iOS SDK 26.1 ✅               | macOS 14.5 Sonoma                  | .NET 10.0+ (compatible con 26.1)    | ✓ Soportado |
| iOS 18.x       | Desde septiembre de 2024 | SDK 18.x   | Xcode 26.2     | iOS SDK 26.2 ❌ NO DISPONIBLE  | macOS 14.5 Sonoma                  | .NET 10.0+                          | ❌ No disponible en runner |

---

### 📌 **Tu Configuración Actual**

```
✅ .NET SDK: 10.0.101
✅ Xcode instalados en runner: 26.0.1, 26.1.1, 16.x (anteriores)
✅ iOS SDK compatible: 26.0 (especificado en global.json)
✅ Target Framework: net10.0-ios
✅ SupportedOSPlatformVersion: 15.0 (iOS 15.0+)
```

---

### ⚠️ **Notas Críticas - Mapeo de Versiones**

**IMPORTANTE: Cambio en esquema de versiones de Apple**

| Rango | Esquema Tradicional | Esquema Nuevo (2024+) |
|-------|-------------------|----------------------|
| iOS 16.x | Xcode 14.x → iOS SDK 14.x | — |
| iOS 17.x | Xcode 15.x → iOS SDK 15.x | — |
| iOS 18.x | Xcode 16.x → iOS SDK 16.x | **Xcode 26 = iOS SDK 26** ⚠️ |

**Apple cambió el esquema en Xcode 26.x:**
- Antes: Xcode 14 = iOS SDK 14
- Ahora: **Xcode 26 = iOS SDK 26** (salto de numeración)

---

### 🔧 **Matriz de Compatibilidad Strict**

| Tu Xcode | iOS SDK Requerido | Disponible en Runner | Estado |
|----------|-------------------|----------------------|--------|
| Xcode 26.0.1 | iOS SDK 26.0 | ✅ SÍ (en global.json) | 🚀 **USA ESTE** |
| Xcode 26.1.1 | iOS SDK 26.1 | ✅ SÍ (disponible) | ✓ Alternativa válida |
| Xcode 26.2.x | iOS SDK 26.2 | ❌ NO | ❌ No disponible |

---

### 🔧 **Configuración Recomendada para tu Proyecto**

**En `cd-ios.yml`:**
```yaml
XCODE_VERSION: '26.0.1'        # ← Mantener esta
XCODE_VERSION_SHORT: '26.0'
```

**En `global.json`:**
```json
{
  "sdk": {
    "version": "10.0.101",
    "rollForward": "latestFeature",
    "allowPrerelease": false
  },
  "msbuild-sdks": {
    "Microsoft.iOS.Sdk": "26.0"  // ← CRÍTICO: iOS SDK 26.0 para Xcode 26.0.1
  }
}
```

---

# Compatibilidad de Android con .NET MAUI

| Versión de Android | Nombre en Clave        | Fecha de Lanzamiento | API Level | Versión de .NET compatible            | API Mínima por .NET (minSdk) | Target/Compile SDK | API Mínima OS (targetSdk) |
| ------------------ | ---------------------- | -------------------- | --------- | ------------------------------------- | ---------------------------- | ------------------ | ------------------------- |
| 1.0 a 3.2          | (Varios)               | 2008 - 2011          | 1 - 13    | — (No soportado)                      | —                            | —                  | —                         |
| 4.0 – 4.0.4        | Ice Cream Sandwich     | 18 oct 2011          | 14-15     | Xamarin.Android (MonoAndroid 2.x)     | API 14                       | API 14-15          | API 14                    |
| 4.1 – 4.3.1        | Jelly Bean             | 9 jul 2012           | 16-18     | Xamarin.Android (MonoAndroid 4.x)     | API 16                       | API 16-18          | API 16                    |
| 4.4 – 4.4.4        | KitKat                 | 31 oct 2013          | 19-20     | Xamarin.Android (MonoAndroid 5.x)     | API 19                       | API 19-20          | API 19                    |
| 5.0 – 5.1.1        | Lollipop               | 12 nov 2014          | 21-22     | Xamarin.Android (MonoAndroid 6.x)     | API 21                       | API 21-22          | API 21                    |
| 6.0 – 6.0.1        | Marshmallow            | 5 oct 2015           | 23        | Xamarin.Android (MonoAndroid 6.x)     | API 23                       | API 23             | API 23                    |
| 7.0 – 7.1.2        | Nougat                 | 22 ago 2016          | 24-25     | Xamarin.Android (MonoAndroid 7.x)     | API 24                       | API 24-25          | API 24                    |
| 8.0 – 8.1          | Oreo                   | 21 ago 2017          | 26-27     | Xamarin.Android (MonoAndroid 8.x)     | API 26                       | API 26-27          | API 26                    |
| 9.0                | Pie                    | 6 ago 2018           | 28        | Xamarin.Android (MonoAndroid 9.0)     | API 28                       | API 28             | API 28                    |
| 10                 | Android 10             | 3 sep 2019           | 29        | Xamarin.Android / .NET 6 Preview      | API 29                       | API 29             | Sin restricción OS        |
| 11                 | Android 11             | 8 sep 2020           | 30        | .NET 6 (Soporte unificado)            | API 21                       | API 30             | Sin restricción OS        |
| 12                 | Android 12             | 4 oct 2021           | 31        | .NET 6                                | API 21                       | API 31             | Sin restricción OS        |
| 12L                | Android 12L            | 7 mar 2022           | 32        | .NET 6                                | API 21                       | API 32             | Sin restricción OS        |
| 13                 | Android 13             | 15 ago 2022          | 33        | .NET 7                                | API 21                       | API 33             | Sin restricción OS        |
| 14                 | Android 14             | 4 oct 2023           | 34        | .NET 8                                | API 21                       | API 34             | **API 23                  |
| 15                 | Android 15             | 2 oct 2024           | 35        | .NET 9                                | API 21                       | API 35             | **API 24                  |
| 16                 | Android 16             | 10 jun 2025          | 36        | .NET 10.0+                            | API 24 (Proyectada)          | API 36             | **API 25   (Proyectada)   |

## Notas 

### Diferencia entre las tres configuraciones de API

1. **API Mínima por .NET (minSdkVersion)**: Define la versión **mínima** de Android que puede ejecutar 
la aplicación desde el punto de vista de .NET. Los usuarios con versiones anteriores no podrán instalar la app.
Ejemplo. Compilo con .NET9 la versión mínima API 21, por lo que usuarios con Android 5.0+ (API 21) podrán instalarla.

2. **Target/Compile SDK (targetSdkVersion)**: Define la versión de Android contra la cual compilas. 
Google Play requiere mantener este valor actualizado.

3. **API Mínima del OS (Minimum installable targetSdk)**: Desde Android 14, el sistema operativo
**bloquea la instalación** de apps cuyo `targetSdkVersion` sea demasiado antiguo, independientemente del `minSdkVersion`.
Ejemplo. Compilo con .NET9 con targetSdk 35 (Android 15), por lo que los usuarios con Android 7 (API 24) podrán instalarla.
 
### Ejemplo configuraciones proyecto proyecto.

``` 
<TargetFramework>net9.0-android35.0</TargetFramework>
<SupportedOSPlatformVersion Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'android'">24.0</SupportedOSPlatformVersion>
```

Compilará la aplicación contra API 35 (Android 15) y permitirá instalarla en dispositivos con Android 7.0+ (API 24+).

