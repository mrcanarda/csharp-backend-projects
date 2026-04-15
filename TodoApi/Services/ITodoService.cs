namespace TodoApi.Services; 

public interface ITodoService
{
    List<string> GetAll(); 
    void Add(string item); 
}