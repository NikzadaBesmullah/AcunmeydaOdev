namespace NotDefteriWebsite.Models
{
    public class Repository
    {
        private static readonly List<Note> _notes = new List<Note>();

        public static List<Note> _Not
        {
            get { return _notes; }
        }

        static Repository()
        {
            _notes = new List<Note>()
            {
                            new Note() { Noteid = 2, NoteTitle = "İnglizce", NoteContent = "audience=seyirci" , NoteAddTime= new DateTime(2025,03,14), NoteCategory="Dil" } ,
            new Note() { Noteid = 3, NoteTitle = "Acunmedya", NoteContent = "Shared Klasouru ortak Kullanılan klasördür" , NoteAddTime= new DateTime(2025,1,05),NoteCategory="Staj"} ,
            new Note() { Noteid = 4, NoteTitle = "Ağ Temelleri", NoteContent = "Switchler 2.katman cihazlarıdır" , NoteAddTime=DateTime.Now,NoteCategory="okul"} ,
            new Note() { Noteid = 5, NoteTitle = "Oyun Programlama", NoteContent = "rigibody nesneye fizik kurullarını uygular" , NoteAddTime=DateTime.Now,NoteCategory="okul"} ,
            new Note() { Noteid = 6, NoteTitle = "VeriTabanı", NoteContent = "inner join 2 tablounun birleşmesini sağlar" , NoteAddTime=DateTime.Now,NoteCategory="okul"} ,

            };
        }

        public static Note GetByid(int id)
        {
            return _Not.FirstOrDefault(_Not => _Not.Noteid == id);
        }

    }
}


