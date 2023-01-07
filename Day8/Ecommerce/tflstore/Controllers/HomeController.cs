using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tflstore.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tflstore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult Login()
    {
        return View();
    }
    public IActionResult Validate(string email, string password)
    {
        if(email =="abc123@gmail.com" && password=="seed")
        {
          return Redirect("/home/Welcome");
        }
       
        try{
    var options = new JsonSerializerOptions{ IncludeFields=true};
    var projectJson = JsonSerializer.Serialize<string>(email,options);
    string fileName=@"G:\.NetPractice\Day8\login\email.json";

    System.IO.File.WriteAllText(fileName,projectJson);

// string jsonString= File.ReadAllText(fileName);
// List<operations> jsonProjects = JsonSerializer.Deserialize<List<operations>>(jsonString);
//     Console.WriteLine("\n Json: Deserializing data from json file\n\n");
//     foreach(operations project in jsonProjects)
//     {
//          Console.WriteLine($"{project.pid} : {project.StartDate}");  
//     // Console.WriteLine("${project.pid};
//     // ${project.StarDate}:{project.EndDate}:{project.ptitle}:{project.pdesc}`);
//     }
}
catch(Exception exp)
{

}
finally{}

 return View();

    }  
    public IActionResult Welcome()
    {
        return View();
    }
    public IActionResult Register()
    {
        return View();
    }
  

}

