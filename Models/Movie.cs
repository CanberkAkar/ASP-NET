namespace MyApplication.Models
{
    public class Movie
    {
        public string Title { get; set; }

        public string Desc { get; set; }

        public string Director { get; set; }

        public string[] Players { get; set; } // Bu satır doğru syntax
    } 
}
