namespace LibraryManagement.Models
{
  public class Library
  {
      public int bookId { get;set;}
      public string Author { get;set;}
      public string Title { get;set;}
      public int Published {get;set; }

      public string Branch{get;set;}
      public int Quantity{get;set;}
  }




}