using User;
using System;
using System.Collections.Generic;
using System.Text.Json;
bool exit=false;
List<Student> list=new List<Student>();

while(!exit){
    Console.WriteLine("1.Restore data 2.Add Student  3.Update 4.remove student 5.Search By Id 6.Getall 7.Save 8.Exit Application");
int choice=int.Parse(Console.ReadLine());
switch(choice){
    case 1:
        string filename=@"D:\Cdac Notes\.NET\Assignment\Day5\student.json";
        string jsonString=File.ReadAllText(filename);
        list=JsonSerializer.Deserialize<List<Student>>(jsonString);
        Console.WriteLine("File Restored");
        break;

    case 2:
        Console.WriteLine("Enter details as  id, name, city, course");
        list.Add(new Student(int.Parse(Console.ReadLine()),Console.ReadLine(),Console.ReadLine(),Console.ReadLine()));
        break;

    case 3:
     Console.WriteLine("Enter id");
       int id= int.Parse(Console.ReadLine()); 

       Student st= list.Find((e)=>e.Id==id);
       Console.WriteLine("Enter New Name");
       st.Name=Console.ReadLine();
       Console.WriteLine("Enter New City");
       st.City=Console.ReadLine();
       Console.WriteLine("Enter New Course");
       st.Course=Console.ReadLine();
       break;


    case 4:
        Console.WriteLine("Enter id");
        id= int.Parse(Console.ReadLine()); 
       list.RemoveAll(s=>s.Id==id);
       break;


    case 5:
        Console.WriteLine("Enter id");
        id=int.Parse(Console.ReadLine());   
        list.ForEach(e=>{
            if(e.Id==id){
                Console.WriteLine(e);
            }
        });      
       break;


    case 6:
        foreach(Student s in list){
            Console.WriteLine(s);
        }
        break;

    case 7:
        var options=new JsonSerializerOptions{IncludeFields=true};
        var studentsJson=JsonSerializer.Serialize<List<Student>>(list,options);
         filename=@"D:\Cdac Notes\.NET\Assignment\Day5\student.json";
        //serialize
        File.WriteAllText(filename,studentsJson);
        Console.WriteLine("Stored successfully");
        break;

    case 10:
        exit=true;
        break;

}

}

