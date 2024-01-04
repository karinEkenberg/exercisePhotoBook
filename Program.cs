/*
Skapa ett C#-program för att hantera en fotobok med hjälp av objektorienterad programmering.
För att börja skapa en klass som heter PhotoBook med ett privat attribut numPages av typen
int. Den måste också ha en public metod GetNumberPages som returnerar antalet
fotobokssidor.
Standardkonstruktören kommer att skapa ett album med 16 sidor. Det kommer att finnas en
extra konstruktör med vilken vi kan ange hur många sidor vi vill ha i albumet.
Det finns också en BigPhotoBook-klass vars konstruktör kommer att skapa ett album med 64
sidor.
Skapa slutligen en PhotoBookTest-klass för att utföra följande åtgärder:
• Skapa en standardfotobok och visa antalet sidor
• Skapa en fotobok med 24 sidor och visa antalet sidor
• Skapa en stor fotobok och visa antalet sidor
 */

namespace exercisePhotoBook
{
    public class PhotoBook
    {
        private int numPages;
        
        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int pages)
        {
            numPages = pages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }

    public class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook() : base(64) { }
    }

    public class PhotoBookTest 
    {
        static void Main()
        {
            PhotoBook standardPhotoBook = new PhotoBook();
            Console.WriteLine("Standard PhotoBook har {0} sidor.", standardPhotoBook.GetNumberPages());

            PhotoBook customPhotoBook = new PhotoBook(24);
            Console.WriteLine("Custom PhotoBook har {0} sidor.", customPhotoBook.GetNumberPages());

            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            Console.WriteLine("Big PhotoBook har {0} sidor.", bigPhotoBook.GetNumberPages());
        }
    }
}
