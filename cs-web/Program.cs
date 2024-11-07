//var builder = WebApplication.CreateBuilder(args);
//// Add services to the container.
//builder.Services.AddRazorPages();
//var app = builder.Build();
//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}
//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();
//app.UseAuthorization();
//app.MapRazorPages();
//app.Run();

WebApplicationBuilder builder = WebApplication.CreateBuilder();
WebApplication app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.Run();

//await app.StartAsync();
//await Task.Delay(10000);
//await app.StopAsync();

app.UseWelcomePage();
app.Run();

//public delegate Task RequestDelegate(HttpContext context);