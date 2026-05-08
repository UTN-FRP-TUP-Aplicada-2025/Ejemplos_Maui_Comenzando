

```
ADB0020: Mono.AndroidTools.IncompatibleCpuAbiException: The package does not support the CPU 
architecture of this device. ...
```

```
<PropertyGroup Condition="$([MSBuild]::GetTargetPlatformIdentifier('$(TargetFramework)')) == 'android'">
	<RuntimeIdentifiers>android-arm;android-arm64;android-x86;android-x64</RuntimeIdentifiers>
</PropertyGroup>
```