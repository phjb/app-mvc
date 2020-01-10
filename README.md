
![](screenshots/phjb.png)

# Introdução

Esse projeto é um exemplo prático de como desenvolver `do zero` uma aplicação **MVC** **`M`** -> *`Model (Modelo)`* **`V`** -> *`View (Visão)`*  **`C`** -> *`Controller (Controlador)`*  utilizando o [asp.net core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1).

### Tecnologia
* SDK do .NET Core
```
 Version:   3.1.100
 Commit:    cd82f021f4
```
## 

### Editor de Código
* [Visual Studio Code](https://code.visualstudio.com/)



### Um pouco de *Command Line Interface*
Usando um **terminal** que pode ser `cmd`, `PowerShell`, `Git Bash` ou outro da sua escolha, a primeira coisa a se fazer é escolher o nosso *template*, o **dotnet** nos disponibiliza vários modelos. Para visualizar esses modelos bastar digitar no terminal
```{ps}
dotnet new
```
Como resultado teremos obteremos:
```
Templates                                         Short Name               Language          Tags
----------------------------------------------------------------------------------------------------------------------------------
Console Application                               console                  [C#], F#, VB      Common/Console
Class library                                     classlib                 [C#], F#, VB      Common/Library
WPF Application                                   wpf                      [C#]              Common/WPF
WPF Class library                                 wpflib                   [C#]              Common/WPF
WPF Custom Control Library                        wpfcustomcontrollib      [C#]              Common/WPF
WPF User Control Library                          wpfusercontrollib        [C#]              Common/WPF
Windows Forms (WinForms) Application              winforms                 [C#]              Common/WinForms
Windows Forms (WinForms) Class library            winformslib              [C#]              Common/WinForms
Worker Service                                    worker                   [C#]              Common/Worker/Web
Unit Test Project                                 mstest                   [C#], F#, VB      Test/MSTest
NUnit 3 Test Project                              nunit                    [C#], F#, VB      Test/NUnit
NUnit 3 Test Item                                 nunit-test               [C#], F#, VB      Test/NUnit
xUnit Test Project                                xunit                    [C#], F#, VB      Test/xUnit
Razor Component                                   razorcomponent           [C#]              Web/ASP.NET
Razor Page                                        page                     [C#]              Web/ASP.NET
MVC ViewImports                                   viewimports              [C#]              Web/ASP.NET
MVC ViewStart                                     viewstart                [C#]              Web/ASP.NET
Blazor Server App                                 blazorserver             [C#]              Web/Blazor
ASP.NET Core Empty                                web                      [C#], F#          Web/Empty
ASP.NET Core Web App (Model-View-Controller)      mvc                      [C#], F#          Web/MVC
ASP.NET Core Web App                              webapp                   [C#]              Web/MVC/Razor Pages
ASP.NET Core with Angular                         angular                  [C#]              Web/MVC/SPA
ASP.NET Core with React.js                        react                    [C#]              Web/MVC/SPA
ASP.NET Core with React.js and Redux              reactredux               [C#]              Web/MVC/SPA
Razor Class Library                               razorclasslib            [C#]              Web/Razor/Library/Razor Class Library
ASP.NET Core Web API                              webapi                   [C#], F#          Web/WebAPI
ASP.NET Core gRPC Service                         grpc                     [C#]              Web/gRPC
dotnet gitignore file                             gitignore                                  Config
global.json file                                  globaljson                                 Config
NuGet Config                                      nugetconfig                                Config
Dotnet local tool manifest file                   tool-manifest                              Config
Web Config                                        webconfig                                  Config
Solution File                                     sln                                        Solution
Protocol Buffer File                              proto                                      Web/gRPC
```
Como mencionado vamos desenvolver `do zero`, para isso precisaremos de um *template* vazio, então vamos utilizar o modelo `ASP.NET Core Empty` que tem como *short name* `web`.

Novamente no **terminal** vamos digitar
```
dotnet new web -o app-mvc
```
> ***-o app-mvc*** indica a pasta do nosso projeto!

Agora vamos abrir o nosso projeto no **Visual Studio Code**. Basta digitar no terminal
```
code .
```

## Mão no *Visual Studio Code*