/* Photo book class
Last updated: 8/26/2020 ⁃ Difficulty: Intermediate

Create a C# program to manage a photo book using object-oriented programming.

To start, create a class called PhotoBook with a private attribute numPages of type int.
It must also have a public method GetNumberPages that will return the number of photo
 book pages.

The default constructor will create an album with 16 pages. There will be an additional
 constructor, with which we can specify the number of pages we want in the album.

There is also a BigPhotoBook class whose constructor will create an album with 64 pages.

Finally create a PhotoBookTest class to perform the following actions:

    Create a default photo book and show the number of pages
    Create a photo book with 24 pages and show the number of pages
    Create a large photo book and show the number of pages

Input

Output

    16
    24
    64*/

class Ejercicio04
    {     
        static void Main(string[] args) {
            PhotoBookTest pbt = new();
            pbt.Main();
        }
        
        class PhotoBook {
            protected int numPages;

            public int GetNumPages(){
                return numPages;
            }
            public PhotoBook () {
                numPages = 16;
            }
            public PhotoBook (int pages) {
                numPages = pages;
            }
        }
        class BigPhotoBook : PhotoBook {
            public BigPhotoBook() {
                numPages = 64;
            }
        }
        class PhotoBookTest {
            public void Main() {
                PhotoBook pb1 = new();
                Console.WriteLine(pb1.GetNumPages());
                PhotoBook pb2 = new(24);
                Console.WriteLine(pb2.GetNumPages());
                BigPhotoBook bpb = new();
                Console.WriteLine(bpb.GetNumPages());
            }
            
            }
    }
