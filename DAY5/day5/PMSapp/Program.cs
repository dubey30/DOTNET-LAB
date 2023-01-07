using Projectmanagement;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

operations op = new operations( 1,new DateTime(2023-01-01),new DateTime(2023-01-01),
"school","schoolmanagement");
operations op1 = new operations( 2,new DateTime(2023-01-01),new DateTime(2023-01-01),"bank","bankmanagement");
operations op2 = new operations( 3,new DateTime(2023-01-01),new DateTime(2023-01-01),"college","collegemanagement");
operations op3 = new operations( 4,new DateTime(2023-01-01),new DateTime(2023-01-01),"pollution","pollutionmanagement");
List<operations> projects = new List<operations>();
projects.Add(op);
projects.Add(op1);
projects.Add(op2);
projects.Add(op3);

try{
    var options = new JsonSerializerOptions{ IncludeFields=true};
    var projectJson = JsonSerializer.Serialize<List<operations>>(projects,options);string fileName=@"G:\.NetPractice\DAY5\day5\file\projects.json";

    File.WriteAllText(fileName,projectJson);

string jsonString= File.ReadAllText(fileName);
List<operations> jsonProjects = JsonSerializer.Deserialize<List<operations>>(jsonString);
    Console.WriteLine("\n Json: Deserializing data from json file\n\n");
    foreach(operations project in jsonProjects)
    {
         Console.WriteLine($"{project.pid} : {project.StartDate}");  
    // Console.WriteLine("${project.pid};
    // ${project.StarDate}:{project.EndDate}:{project.ptitle}:{project.pdesc}`);
    }
}
catch(Exception exp)
{

}
finally{}