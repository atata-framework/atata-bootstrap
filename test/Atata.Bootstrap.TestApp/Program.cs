var builder = WebApplication.CreateBuilder(new WebApplicationOptions { Args = args });

builder.Services.AddRazorPages();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

app.Run();
