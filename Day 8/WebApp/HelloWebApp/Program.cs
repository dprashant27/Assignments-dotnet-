var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var emp=new {Id=45,Name="Vishal",City="Ghughus"};
var employees=new List<object>();
employees.Add(new {Id=45,Name="Vishal",City="Ghughus"});
employees.Add(new {Id=40,Name="Rupesh",City="Nagpur"});
employees.Add(new {Id=5,Name="Chaitu",City="Chandrapur"});
employees.Add(new {Id=52,Name="kunal",City="nashik"});
   

app.MapGet("/", () => "<h1>Hello World!</h1>");
app.MapGet("/list",() =>{
    var str="";
    foreach(var s in employees){
        str+="@ Employee :"+s+"\n";
    }
    return str;
});

app.Run();
