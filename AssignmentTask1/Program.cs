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
        public int CalcAge(Date today){
            int age = today.Year - PubDate.Year;
            if(today.Month<PubDate.Month || (today.Month==PubDate.Month && today.Day<PubDate.Day)){
                age--;
            }return age;
        }
        public virtual void ShowInfo(){
            Console.WriteLine($"\tBook Info:\nISBN: {ISBN}\tName: {Title}\nAuthor: {Author}\tPubDate: {PubDate.Day}/{PubDate.Month}/{PubDate.Year}");
        }
    }
    public class FictionBook : Book{
        public string Genre{ get; set; }
        public FictionBook(string ISBN, string Title, string Author,Date pubDate,string genre):base(ISBN,Title,Author,pubDate){
            this.Genre = genre;
        }
        public override void ShowInfo(){
            base.ShowInfo();
            Console.WriteLine("Genre: "+Genre);
        }
    }
}