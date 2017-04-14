using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP_14._04
{
     class File
    {
       public string Extension { get; set;}
        public int Size { get; set; }
        public string Comments { get; set; }
    }
    class Movie:File
    {
        public string Format { get; set; }
        public string LengthMovie { get; set; }
    }
    class TextFiles : File
    {

    }
    class Images : File
    {

    }
    class Program
    {
        public static string text =  @"Text:file.txt(6B);Some string content 
                                    Image:img.bmp(19MB);1920х1080 
                                    Text:data.txt(12B);Another string 
                                    Text:data1.txt(7B);Yet another string 
                                    Movie:logan.2017.mkv(19GB);1920х1080;2h12m";
        public string[] sections = new string[] { "Text", "Image", "Movie" };
        string[] separator = text.Split(new Char[]{ ';', '(', ')' });
        public static List<Movie> movies = new List<Movie>();



        static void Main(string[] args)
        {
            foreach (var item in text)
            {
                
            }
        
            

        }
    }
}
