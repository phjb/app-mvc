
![](screenshots/phjb_2020.png)

# Introdução

Esse projeto é um exemplo prático de como desenvolver uma aplicação *`step by step`* utilizando o padrão **MVC** *`Model (Modelo)`* *`View (Visão)`* *`Controller (Controlador)`*  com o [asp.net core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1).

### Tecnologia
* SDK do .NET Core
```
 Version:   3.1.100
 Commit:    cd82f021f4
```
## 

### Editor de Código
* [Visual Studio Code](https://code.visualstudio.com/)

## 

### Extensões
As extensões do VS Code permitem adicionar idiomas, depuradores e ferramentas à sua instalação para dar suporte ao seu fluxo de trabalho de desenvolvimento. O rico modelo de extensibilidade do VS Code permite que os autores de extensões se conectem diretamente à interface do usuário do VS Code e contribuam com a funcionalidade por meio das mesmas APIs usadas pelo VS Code. [Veja mais aqui](https://code.visualstudio.com/docs/editor/extension-gallery/).

### 

![](screenshots/my-extensions-to-vscode.png)



### Um pouco de *Command Line Interface*
Usando um **terminal** que pode ser `cmd`, `PowerShell`, `Git Bash` ou outro da sua escolha, a primeira coisa a se fazer é escolher o nosso *template*, o **dotnet** nos disponibiliza vários modelos. Para visualizar esses modelos bastar digitar no terminal
```bash
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
```bash
dotnet new web -o app-mvc
```
> ***-o app-mvc*** indica a pasta do nosso projeto!

Agora vamos abrir o nosso projeto no **Visual Studio Code**. Basta digitar no terminal
```bash
code .
```

## Mãos no *Visual Studio Code*

Com o VS Code aberto vamos criar os 3 pastas do **MVC** `Models` `Views` `Controllers`. Por conversão criamos as pastas no *`Plural`*, aconselho a seguirmos essa conversão. 

![](screenshots/ss_1.png)

Agora vamos criar primeiro *Controller* chamado `HomeController.cs` que ficará dentro da pasta ***Controllers*** que acabamos de criar.
> A classe ***HomeController*** herda da classe base `Controller`. Para que funcione devemos a *diretiva* *`using Microsoft.AspNetCore.Mvc;`*

Com isso nossa **`HomeController`** deverá ter o seguinte código

```c#
using Microsoft.AspNetCore.Mvc;

namespace app_mvc.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
```
Agora chegou a vez de criarmos nossa *View* e se chamará `Index.cshtml` e ficará dentra da pasta ***Views > Home***.

Vamos adicionar uns códigos
```html
@{
    ViewData["Title"] = "Index";
}

<h1>Nossa Primeira View</h1>
```
Chegou a hora de vermos os resultados no navegador :rocket:. Esperamos que apareça a frase
"**Nossa Primeira View**".


 Para que isso aconteça vamos rodar a aplicação, no **terminal** vamos digitar
```bash
dotnet run
```
> O ***dotnet*** nos disponibilizou a seguinte *Url*: [`http://localhost:5000/`](http://localhost:5000/).

![](screenshots/ss_2.png)

*what this is???* :scream:

### Configurando as rotas

Nossa execução não funcionou porque não configuramos as rota da aplicação.

Então vamos configurar. 

Abra o arquivo chamado ***Startup.cs*** e no método *ConfigureServices* vamos adicionar o serviço do ***`MVC`***. O método deverá ficar assim 
```c#
 public void ConfigureServices(IServiceCollection services)
  {
    services.AddControllersWithViews();
  }
```

Vamos adicionar a rota, método *Configure* vamos trocar 
```c#
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context =>
    {
      await context.Response.WriteAsync("Hello World!");
    });
}); 
```
Por 
```c#
app.UseEndpoints(endpoints =>
 {
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
  });
```
Com isso nosso arquivo ***Startup.cs*** ficará com código abaixo:

```c#
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace app_mvc
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}

```



