namespace KlebertsWebshop.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Brave new world",
                    Description = "Brave New World is a dystopian novel by English author Aldous Huxley, written in 1931 and published in 1932. Largely set in a futuristic World State, whose citizens are environmentally engineered into an intelligence-based social hierarchy, the novel anticipates huge scientific advancements in reproductive technology, sleep-learning, psychological manipulation and classical conditioning that are combined to make a dystopian society which is challenged by the story's protagonist. Huxley followed this book with a reassessment in essay form, Brave New World Revisited (1958), and with his final novel, Island (1962), the utopian counterpart. This novel is often compared to George Orwell's Nineteen Eighty-Four (1949).",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/6/62/BraveNewWorld_FirstEdition.jpg/220px-BraveNewWorld_FirstEdition.jpg",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "The Lord of the Rings",
                    Description = "he Lord of the Rings is an epic high-fantasy novel by English author and scholar J. R. R. Tolkien. Set in Middle-earth, the story began as a sequel to Tolkien's 1937 children's book The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling books ever written, with over 150 million copies sold.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/11/The_Return_of_the_King_cover.gif",
                    Price = 11.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Shantaram",
                    Description = "Shantaram is a 2003 novel by Gregory David Roberts, in which a convicted Australian bank robber and heroin addict escapes from Pentridge Prison and flees to India. The novel is commended by many for its vivid portrayal of life in Bombay in the early to late 1980s. The novel is reportedly influenced by real events in the life of the author, though some claims made by Roberts are contested by others involved in the story.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b9/GDR_Shantaram.jpg",
                    Price = 5.99m
                }
            );
    }

    public DbSet<Product> Products { get; set; }
}
