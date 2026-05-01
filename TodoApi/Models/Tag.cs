namespace TodoApi.Models; 

public class Tag
{
    public int Id {get; set;}
    public string Name {get; set;}
    public List<TodoItem> Todos{get; set;} = new(); 
}