using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// try{
//     var options = new JsonSerializerOptions{ IncludeFields=true};
//     var projectJson = JsonSerializer.Serialize<string>(email,options);
//     string fileName=@"G:\.NetPractice\Day8\login\email.json";

//     File.WriteAllText(fileName,projectJson);

// // string jsonString= File.ReadAllText(fileName);
// // List<operations> jsonProjects = JsonSerializer.Deserialize<List<operations>>(jsonString);
// //     Console.WriteLine("\n Json: Deserializing data from json file\n\n");
// //     foreach(operations project in jsonProjects)
// //     {
// //          Console.WriteLine($"{project.pid} : {project.StartDate}");  
// //     // Console.WriteLine("${project.pid};
// //     // ${project.StarDate}:{project.EndDate}:{project.ptitle}:{project.pdesc}`);
// //     }
// }
// catch(Exception exp)
// {

// }
// finally{}
