using System;
using System.Collections.Generic;
using System.Text;

namespace MovieListLab
{
    class Movie
    {
        private string title;
        private MovieGenre category;
        private string tagline;
        private int yearReleased;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public MovieGenre Category
        {
            get { return category; }
            set {category = value; }
        }

        public string Tagline
        {
            get { return tagline; }
            set {tagline = value; }
        }
        public int YearReleased
        {
            get { return yearReleased; }
            set { yearReleased = value; }
        }


        public Movie(string title, MovieGenre category, string tagline, int yearReleased)
        {
            Title = title;
            Category = category;
            Tagline = tagline;
            YearReleased = yearReleased;
        }
        public Movie(string title, MovieGenre category)
        {
            Title = title;
            Category = category;
        }


    }
}
