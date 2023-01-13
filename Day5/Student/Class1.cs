namespace User;
using System.ComponentModel.DataAnnotations;

[Serializable]
public class Student
{
    
    public int Id{get;set;}
    public string? Name{get;set;}
    public string? City{get;set;}
    public string? Course{get;set;}

   public Student():this(12,"raju","pune","PG-DAC"){

   } 

   public Student(int id,string name,string city,string course){
    this.Id=id;
    this.Name=name;
    this.City=city;
    this.Course=course;
   }

    public override string ToString()
    {
        return "[ Id: "+Id+" Name:"+Name+" City:"+City+" Course:"+Course+" ]";

    }

}
