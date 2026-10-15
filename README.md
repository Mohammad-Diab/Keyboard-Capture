# Keyboard Capture

A small WPF utility that shows the name of every key you press while its window is focused. Written in VB.NET with WPF on .NET Framework 4.0.

## Features

- Press any key while the window is focused and its name is added to the top of the list.
- **Clear List** empties the list.
- **about** opens the About window.

## Requirements

Windows with .NET Framework 4.0 or later. Windows 8, 10 and 11 already include it.

## Usage

Download the latest `Keyboard-Capture-v<version>.7z` from [Releases](https://github.com/Mohammad-Diab/Keyboard-Capture/releases), extract it, and run `Keyboard Capture.exe`. There is no installer.

The exe is not signed, so Windows SmartScreen may warn the first time you run it: click **More info**, then **Run anyway**.

## Building

```
git clone https://github.com/Mohammad-Diab/Keyboard-Capture.git
```

Open `Keyboard Capture.sln` in Visual Studio and build, or run:

```
MSBuild "Keyboard Capture.sln" /p:Configuration=Release
```

The exe is written to `Keyboard Capture\bin\Release`.

The project targets .NET Framework 4.0. Recent Visual Studio versions don't ship its reference assemblies; if the build stops with `MSB3644`, extract the [Microsoft.NETFramework.ReferenceAssemblies.net40](https://www.nuget.org/packages/Microsoft.NETFramework.ReferenceAssemblies.net40) NuGet package and point MSBuild at its `build` folder:

```
MSBuild "Keyboard Capture.sln" /p:Configuration=Release /p:TargetFrameworkRootPath=<package>\build
```

## Author

Mohammad Diab

## License

[Apache 2.0](LICENSE)
