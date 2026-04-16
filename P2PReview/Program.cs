using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using P2PReview.Client.Pages;
using P2PReview.Components;
using P2PReview.Client.Services.Interfaces;      
using P2PReview.Client.Services.Mocks;           

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();


builder.Services.AddScoped<IReviewService, MockReviewService>();
builder.Services.AddScoped<IRepositoryService, MockRepositoryService>();
builder.Services.AddScoped<IUserService, MockUserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();
app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(P2PReview.Client._Imports).Assembly);

app.Run();
