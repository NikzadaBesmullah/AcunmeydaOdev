namespace NotDefteriWebsite.Models
{
    public class ToDoListRepo
    {
        public static List<ToDoList> _Todos = new List<ToDoList>
    {
        new ToDoList { Id = 1, Title = "Unity projesine devam et", IsDone = false },
        new ToDoList { Id = 2, Title = "SQL tekrar yap", IsDone = true },
        new ToDoList { Id = 3, Title = "Fitness programı güncelle", IsDone = false },
        new ToDoList { Id = 4, Title = "30 Dakika Kitap Oku", IsDone = true},
        new ToDoList { Id = 5, Title = "Maillerini Kontrol Et", IsDone = false }
    };

        public static List<ToDoList> GetToDoList()
        {
            return _Todos;
        }
    }
}
