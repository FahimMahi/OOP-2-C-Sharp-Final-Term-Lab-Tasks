using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLT3
{
    internal class MusicFile
    {
        private string title;
        private string artist;
        private int yearOfRelease;
        private int durationInSeconds;

        public MusicFile()
        {
            //Empty Constructor
        }
        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)        {
            this.Title = title;
            this.Artist = artist;
            this.YearOfRelease = yearOfRelease;
            this.DurationInSeconds = durationInSeconds;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }
        public int YearOfRelease
        {
            get { return yearOfRelease; }
            set
            {
                yearOfRelease = value;
            }
        }
        public int DurationInSeconds
        {
            get { return durationInSeconds; }
            set
            {
                durationInSeconds = value;
            }
        }
        public void changeTitle(string title)
        {
            Console.WriteLine("Changing The Title ");
        }
    }
}
