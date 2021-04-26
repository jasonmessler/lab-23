using System;
using System.Collections.Generic;

namespace Lab_11___2
{
    public class Movie
    {
        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        public Movie()
        {

        }

        private string _category;
        private string _title;

        public void GetHorror()
        {
            var list = InitializeList();

            foreach (var movie in list)
            {
                if (movie._category == "horror")
                {
                    Console.WriteLine(movie._title);
                }
            }
        }
        public void GetAnimated()
        {
            var list = InitializeList();

            foreach (var movie in list)
            {
                if (movie._category == "animated")
                {
                    Console.WriteLine(movie._title);
                }
            }
        }
        public void GetSciFi()
        {
            var list = InitializeList();

            foreach (var movie in list)
            {
                if (movie._category == "sci-fi")
                {
                    Console.WriteLine(movie._title);
                }
            }
        }
        public void GetDrama()
        {
            var list = InitializeList();

            foreach (var movie in list)
            {
                if (movie._category == "drama")
                {
                    Console.WriteLine(movie._title);
                }
            }
        }
        public List<Movie> InitializeList()
        {
            var list = new List<Movie>();

            list.Add(new Movie("The Void", "horror"));
            list.Add(new Movie("The Exorcist", "horror"));
            list.Add(new Movie("The Thing", "horror"));
            list.Add(new Movie("Alien", "sci-fi"));
            list.Add(new Movie("The Terminator", "sci-fi"));
            list.Add(new Movie("Blade Runner", "sci-fi"));
            list.Add(new Movie("Akira", "animated"));
            list.Add(new Movie("Fritz The Cat", "animated"));
            list.Add(new Movie("Goodfellas", "drama"));
            list.Add(new Movie("The Hateful 8", "drama"));

            return list;
        }
    }
}
    