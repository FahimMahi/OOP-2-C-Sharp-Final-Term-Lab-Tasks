using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicFile musicFile = new MusicFile("High Hopes","Pink Floyed",1994,769);
            Console.WriteLine("Title: " + musicFile.Title);
            Console.WriteLine("Artist: " + musicFile.Artist);
            Console.WriteLine("Year of Release: " + musicFile.YearOfRelease);
            Console.WriteLine("Duration in seconds: " + musicFile.DurationInSeconds);

            Console.WriteLine();
            Console.WriteLine("Ipod: ");
            Ipod ipod = new Ipod();
            ipod.switchh(true);
            ipod.retune(500);
            ipod.setVolume(400);
            ipod.changeChannel();

            Console.WriteLine();
            Console.WriteLine("Phone: ");
            Phone phone = new Phone();
            phone.switchh(true);
            phone.play(true);
            phone.setVolume(100);
            phone.playNext();
            phone.playPrevious();

        }
    }
}
