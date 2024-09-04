var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();




static void ConfigureServices(IServiceCollection services)
{
    // Add services to the container.
    services.AddControllersWithViews(); // Adds support for controllers and views
}

app.MapGet("/", () => "Hello World!");

app.Run();

builder.Services.AddControllersWithViews();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// Enable the use of static files from the wwwroot folder
// wwwroot klasöründe bulunan statik dosyalarýn kullanýlmasýný saðlayacak konfigürasyonlarý ekleyiniz.
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Define the endpoints for routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();

//Controller - Action - Model -  View - Razor - RazorView -
//wwwroot kavramlarýnýn ve builder.Build() - app.Run() metotlarýnýn ne iþe yaradýklarýný,
//hangi amaçla kullanýldýklarýný
//Program.cs'in en alt kýsmýnda yorum satýrý olarak açýklayýnýz.

//Controller: It handles user input, processes requests and interacts with the model to perform 
//operations and send data to the view for rendering.

// Action: It is a method defined within a controller that handles incoming HTTP requests and generates
// a response to be sent back to the client.

//Model: represents the data, business logic, and rules of the application.

// View: View is responsible for presenting data to the user.
// It represents the user interface (UI) of the application, typically displaying information from the
// model in a structured and visually appealing way. 

//Razor:  It allows developers to embed C# code directly within HTML,
//making it easier to generate dynamic content and interact with data.

//Razor View: Razor Pages used to create dynamic web pages by combining HTML
//markup with C# code. Razor views are defined using the .cshtml file extension and are a core part of the MVC (Model-View-Controller) pattern,
//where they are responsible for rendering the user interface and presenting data to the user.

//WWwRoot: wwwroot folder is a special directory used to serve static
//files. This folder is the web root of your application and is typically
//where you place files that should be accessible directly by the web browser.

//buýlder.Buýld(): is a method used in the configuration of the application's host.
//It creates an instance of the IHost or IWebHost that represents the running application. This method is part of the host-building process, which sets up the application environment,
//configuration, services, and request processing pipeline.

//app.Run(): is a method used to configure the application to handle HTTP requests. It is part of the IApplicationBuilder interface,
//which allows you to define how the application should respond to HTTP requests.
//It is typically used to set up a final handler or endpoint that processes HTTP requests.