namespace WebApplication1.Data.Entites;

public class Book
{
    public int Id { get; set; }
    public string BookName { get; set; }= string.Empty;
    public decimal Price { get; set; }
    public string Category { get; set; }=string.Empty;
    //navigation
   /* public int AuthorId { get; set; }
    public  virtual Author Author { get; set; }*/
}
