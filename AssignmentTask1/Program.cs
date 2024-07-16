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
    }
    public static class Books{  //total books
        public static int books=0;  //initial
        public static void increment(){books++;}
        public static int getBooks(){return books;}
    }
    public abstract class Book{
        public string ISBN{ get; set; }
        public string Title{ get; set; }
        public string Author{get;set; }
        public Date PubDate{get;set; }
        public Book(string ISBN, string Title, string Author,Date pubDate){
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
            this.PubDate = pubDate;
            Books.increment();
        }
        public int CalcAge(Date today){
            int age = today.Year - PubDate.Year;
            if(today.Month<PubDate.Month || (today.Month==PubDate.Month && today.Day<PubDate.Day)){
                age--;
            }return age;
        }
        public virtual void ShowInfo(Date today){
            Console.WriteLine($"Book Info:\nISBN: {ISBN}\tName: {Title}\nAuthor: {Author}\tPubDate: {PubDate.Day}/{PubDate.Month}/{PubDate.Year}");
        }
    }
    public class FictionBook : Book{
        public string Genre{ get; set; }
        public FictionBook(string ISBN, string Title, string Author,Date pubDate,string genre):base(ISBN,Title,Author,pubDate){
            this.Genre = genre;
        }
        public override void ShowInfo(Date today){
            base.ShowInfo(today);
            Console.WriteLine($"Genre: {Genre}\nAge: {CalcAge(today)}\n");
        }
    }
    public class NonFictional : Book{
        public string FieldStudy{get;set;}
        public NonFictional(string ISBN, string Title, string Author,Date pubDate,string FieldStudy):base(ISBN,Title,Author,pubDate){
            this.FieldStudy = FieldStudy;
        }
        public override void ShowInfo(Date today){
            base.ShowInfo(today);
            Console.WriteLine($"Field of Study: {FieldStudy}\nAge: {CalcAge(today)}\n");
        }
    }
    class Program{
        public static void Main(string[] args){
            Date today=new(16,7,2024);
            FictionBook fb=new("1234","Napoleon","Roberts Andrew",new Date(4,11,2014),"Romance");
            NonFictional nf = new("1235","The Book","J J Unknown",new Date(12,7,2011),"History");

            fb.ShowInfo(today);
            nf.ShowInfo(today);
            System.Console.WriteLine($"Total books: {Books.getBooks()}\n");
        }
    }
}