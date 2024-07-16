namespace UnversityLib{
    public class Date{
        public int Year{ get; set; }
        public int Month{ get; set; }
        public int Day{ get; set; }
        public Date(int day, int month, int year){
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }
    }public abstract class Book{
        public string ISBN{ get; set; }
        public string Title{ get; set; }
        public string Author{get;set; }
        public Date PubDate{get;set; }
        public Book(string ISBN, string Title, string Author,Date pubDate){
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
            this.PubDate = pubDate;
        }
    }
}