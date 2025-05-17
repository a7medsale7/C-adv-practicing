namespace Ienumreble_prac;

internal class Program
{
    private static void Main(string[] args)
    {

        #region Colors_prob1
        ColorCollection colorCollection = new ColorCollection();
        colorCollection.Add("Red");
        colorCollection.Add("Green");
        colorCollection.Add("Blue");
        colorCollection.Add("Yellow");
        colorCollection.display();
        #endregion

        #region Book_prob2
        Book book = new Book();
        book.add(new Book { Title = "Book1", Author = "Author1" });
        book.add(new Book { Title = "Book2", Author = "Author2" });
        book.add(new Book { Title = "Book3", Author = "Author3" });
        book.display();
        #endregion

        #region Letter_prob3
        LetterCollection letterCollection = new LetterCollection();

        letterCollection.Add('A');
        letterCollection.Add('B');
        letterCollection.Add('C');
        letterCollection.Add('D');
        letterCollection.Add('E');
        letterCollection.display();
        #endregion

        #region Songs_prob4
        Playlist playlist = new Playlist();
        playlist.Add(new Song { Title = "Song1", Artist = "Artist1" });
        playlist.Add(new Song { Title = "Song2", Artist = "Artist2" });
        playlist.Add(new Song { Title = "Song3", Artist = "Artist3" });
        playlist.display();
        Product product = new Product();
        #endregion

        #region Product_Prob5
        product.Add(new Product { Name = "Product1", Price = 10.99, Quantity = 5 });
        product.Add(new Product { Name = "Product2", Price = 20.99, Quantity = 3 });
        product.Add(new Product { Name = "Product3", Price = 15.99, Quantity = 8 });
        product.Add(new Product { Name = "Product4", Price = 5.99, Quantity = 10 });
        product.SortProductsByPrice();
        product.display();
        #endregion

        #region Employee_Prob6
        Employee employee = new Employee();
        Administration administration = new Administration();
        administration.Add(new FullTimeEmployee { name = "John Doe", BaseSalary = 5000 });
        administration.Add(new PartTimeEmployee { name = "Jane Smith", BaseSalary = 10000 });
        administration.Add(new Freelancer { name = "Alice Johns", BaseSalary = 2000 });
        administration.Add(new FullTimeEmployee { name = "Bob Brown", BaseSalary = 14000 });
        administration.SortEmployeesBySalary();
        administration.GenerateReports();
        #endregion

        #region Film_Prob6
        MediaLibrary mediaLibrary = new MediaLibrary();
        mediaLibrary.Add(new Movie { title = "Oppenheimer", year = 2023, Director = "Christopher Nolan" });
        mediaLibrary.Add(new Documentary { title = "The Social Dilemma", year = 2020, Topic = "Social Media" });
        mediaLibrary.Add(new TVShow { title = "Breaking Bad", year = 2008, Seasons = 5 });

        foreach (MediaItem item in mediaLibrary)
        {
            Console.WriteLine(item.GetInfo());
        } 
        #endregion



    }
}