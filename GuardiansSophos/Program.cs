using GuardiansSophos.Entities;
using GuardiansSophos.Entities.DBSettings;
using GuardiansSophos.Repository;
using GuardiansSophos.Services;
using GuardiansSophos.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// config mongodb
builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection("MongoDB"));
builder.Services.Configure<Collections>(builder.Configuration.GetSection("Collections"));
builder.Services.AddSingleton<MongoDBContext>();

// services
builder.Services.AddScoped<ICommonService, CommonService>();
builder.Services.AddScoped<IHeroesService, HerosService>();
builder.Services.AddScoped<IVillianService, VillianService>();
builder.Services.AddScoped<IPatternsService, PatternsService>();
builder.Services.AddScoped<IDiaryService, DiaryService>();
builder.Services.AddScoped<IFightService, FightService>();

/*builder.Services.AddScoped<ICommonService, HerosService>();
builder.Services.AddScoped<ICommonService >, VillianService>();
builder.Services.AddScoped<ICommonService<Patterns>, PatternsService>();
builder.Services.AddScoped<ICommonService<Habbilities>, HabilitiesService>();
builder.Services.AddScoped<ICommonService<Diary>, DiaryService>();
builder.Services.AddScoped<ICommonService<FightsResults>, FightService>();
builder.Services.AddScoped<ICommonService<Weaknesses>, WeaknessService>();*/



// services

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
