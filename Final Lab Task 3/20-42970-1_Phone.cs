using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLT3
{
    internal class Phone : MusicPlayerInterface, RadioPlayerInterface
    {
        public Phone()
        {
            MusicFile[] MusicFile = new MusicFile[500];
        }
        public void changeChannel()
        {
            Console.WriteLine("Changing the Music");
        }

        public void play(bool on)
        {
            Console.WriteLine("Playing the Music" + on);
        }

        public void playNext()
        {
            Console.WriteLine("Playing Next Music");
        }

        public void playPrevious()
        {
            Console.WriteLine("Playing Previous Music");
        }

        public void retune(double frequency)
        {
            Console.WriteLine("Retune of The Music is: " + frequency);
        }

        public void setVolume(int loudness)
        {
            Console.WriteLine("Volume for the Music is: " + loudness);
        }

        public void switchh(bool on)
        {
            Console.WriteLine("Switching for the Music is: " + on);
        }
    }
}
