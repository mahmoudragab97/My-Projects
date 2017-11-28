using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_program
{
    class Program
    {
        static void Main(string[] args)
        {
            imagefile tree = new imagefile();
            tree.name = "Tree";
            tree.size = "1.2 MB";                  
            tree.typeofimage();
            tree.printbase();
            tree.imageresolution(); 
            tree.date = "2/3/2017";
            tree.path = "D drive";
            tree.protection = "Low";        
            tree.filecreationdate();
            tree.filepath();          
            tree.fileprotectionlevel();

            Console.WriteLine();

            audiofile hello = new audiofile();
            hello.name = "hello";
            hello.size = "6.3 MB";
            hello.typeofaudio();
            hello.printbase();
            hello.audiofilelength();
            hello.date = "6/8/2017";
            hello.path = "F drive";
            hello.protection = "Medium";
            hello.filecreationdate();
            hello.filepath();
            hello.fileprotectionlevel();

            Console.WriteLine();

            videofile saw = new videofile();
            saw.name = "SAW";
            saw.size = "1.3 GB";
            saw.videotype();
            saw.printbase();
            saw.videoduration();
            saw.date = "1/2/2016";
            saw.path = "E drive";
            saw.protection = "Low";
            saw.filecreationdate();
            saw.filepath();
            saw.fileprotectionlevel();

            Console.WriteLine();

            textfile WWII = new textfile();
            WWII.name = "World War Two";
            WWII.size = "15.2 MB";
            WWII.subjectoftext();
            WWII.printbase();
            WWII.numbersofwords();
            WWII.date = "28/11/2017";
            WWII.path = "E drive";
            WWII.protection = "High";
            WWII.filecreationdate();
            WWII.filepath();
            WWII.fileprotectionlevel();           
            Console.ReadKey();
        }
    }
    public class File
    {
        public string name,size,path,protection,date,res;
             
        public void printbase()
        {
            Console.WriteLine("File name :" + name);
            Console.WriteLine("File size :" + size);
        }
        public void filecreationdate()
        {
            Console.WriteLine("Date created : " + date);
        }
        public void filepath()
        {
            Console.WriteLine("File is in : " + path);
        }
        public void fileprotectionlevel()
        {
            Console.WriteLine("File protection level is : " + protection);
        }
    }
    public class imagefile : File
    {       
        public void typeofimage()
        {
            Console.WriteLine("Images from nature");
        }
        public void imageresolution()
        {
            Console.WriteLine("Image resolution is 1920x1080");
        }
    }
    public class audiofile : File
    {       
        public void typeofaudio()
        {
            Console.WriteLine("Love songs");
        }
        public void audiofilelength()
        {
            Console.WriteLine("Song length is 3:42");
        }
    }
    public class videofile : File
    {       
        public void videotype()
        {
            Console.WriteLine("Horror videos");
        }
        public void videoduration()
        {
            Console.WriteLine("Duration is 2:13:23");
        }
    }
    public class textfile : File
    {       
        public void subjectoftext()
        {
            Console.WriteLine("History books");
        }
        public void numbersofwords()
        {
            Console.WriteLine("The book contains 7250 word");
        }
        public void authorname()
        {
            Console.WriteLine("Mahmoud ragab");
        }
    }
}
