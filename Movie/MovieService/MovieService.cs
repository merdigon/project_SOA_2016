﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MoviesService.Models;
using MoviesService.DAL;

namespace MoviesService
{
    public class MovieService : IMovieService
    {
        private MovieContext db = new MovieContext();
        public List<Genre> GetGenres()
        {
            return db.Genres.ToList();
        }

        public List<Movie> GetMovies()
        {
            return db.Movies.Include("Genre").ToList();
        }

        public List<Movie> GetMoviesByGenre(Genre genre)
        {
            return db.Movies.Include("Genre").Where(x => x.Genre == genre).ToList();
        }

        public List<Movie> GetMoviesByTitle(string title)
        {
            return db.Movies.Include("Genre").Where(x => x.Title == title).ToList();
        }

        public List<Movie> GetMoviesByTitlePart(string part)
        {
            return db.Movies.Include("Genre").Where(x => x.Title.Contains(part)).ToList();
        }

        public List<Movie> GetMoviesByYear(int year)
        {
            return db.Movies.Include("Genre").Where(x => x.Year == year).ToList();
        }


        public bool AddMovie(Movie movie)
        {
            try 
            {
                db.Movies.Add(movie);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddGenre(Genre genre)
        {
            try
            {
                db.Genres.Add(genre);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void DeleteMovie(Movie movie)
        {
            db.Movies.Remove(movie);
            db.SaveChanges();
        }

        public void DeleteGenre(Genre genre)
        {
            db.Genres.Remove(genre);
            db.SaveChanges();
        }

        public bool UpdateMovie(Movie movie)
        {
            var result = db.Movies.SingleOrDefault(b => b.MovieID == movie.MovieID);
            if (result != null)
            {
                result.Description = movie.Description;
                result.CoverURI = movie.CoverURI;
                result.Genre = movie.Genre;
                result.Title = movie.Title;
                result.Country = movie.Country;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateGenre(Genre genre)
        {

            var result = db.Genres.SingleOrDefault(b => b.GenreID == genre.GenreID);
            if (result != null)
            {
                result.Name = genre.Name;
                db.SaveChanges();
                return true;
            }
            return false;

        }
    }
}
