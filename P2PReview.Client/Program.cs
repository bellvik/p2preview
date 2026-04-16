using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using P2PReview;
using P2PReview.Client.Services.Interfaces;
using P2PReview.Client.Services.Mocks;
var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<IReviewService, MockReviewService>();
builder.Services.AddScoped<IRepositoryService, MockRepositoryService>();
builder.Services.AddScoped<IUserService, MockUserService>();

await builder.Build().RunAsync();
