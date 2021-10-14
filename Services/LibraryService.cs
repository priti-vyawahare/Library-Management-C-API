using  LibraryManagement.Models;
using System.Collections.Generic;
using System.Linq;

 namespace LibraryManagement.Services
 {
     public static class LibraryService
     {
         static List<Library> Libraries{get;}
         static int nextId = 7;
         static LibraryService()
         {
             Libraries = new List<Library>
             {
                 new Library {bookId =1, Author ="Williams Van Smith", Title = "React JS",Published = 2018,Branch="CS and IT",Quantity = 25},
                 new Library {bookId =2, Author ="Evan Thomas", Title = "Angular TS",Published = 2017,Branch="CS and IT",Quantity = 10},
                 new Library {bookId =3, Author ="R Ramanujan", Title = "Fundamentals of Math",Published =2018 ,Branch="Mathematics",Quantity = 22},
                 new Library {bookId =4, Author ="P Sudha Ranjan", Title = "Machin Learning",Published =2019 ,Branch="Mechanical",Quantity = 15},
                 new Library {bookId =5, Author ="Garry k.", Title = "Elctronics",Published = 2018,Branch="Electrical",Quantity = 12},
                 new Library {bookId =6, Author ="Sanna Heno", Title = "Engineering Drawing-I",Published = 2018,Branch="Engineering Drawing",Quantity = 15}

         };
             
         }
           public static List<Library> GetAll() => Libraries;
           public static Library Get(int bookid) =>  Libraries.FirstOrDefault(l => l.bookId == bookid);
            
            public static void Add(Library library)
        {
            library.bookId = nextId++;
            Libraries.Add(library);
        }

         public static void Delete(int bookid)
        {
            var library = Get(bookid);
            if(library is null)
                return;
          Libraries.Remove(library);
        }

         public static void Update(Library library)
        {
            var index = Libraries.FindIndex(l => l.bookId == library.bookId);
            if(index == -1)
                return;

            Libraries[index] = library;
        }

     }
 }


       
           

  