﻿using MoviesService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MoviesService
{
    [ServiceContract]
    public interface IMovieService
    {
        [OperationContract]
        List<Genre> GetGenres();

        [OperationContract]
        List<Movie> GetMovies();

        [OperationContract]
        List<Movie> GetMoviesByTitle(string title);

        [OperationContract]
        List<Movie> GetMoviesByGenre(Genre genre);

        [OperationContract]
        List<Movie> GetMoviesByTitlePart(string part);

        [OperationContract]
        List<Movie> GetMoviesByYear(int year);

        [OperationContract]
        bool AddMovie(Movie movie);

        [OperationContract]
        bool AddGenre(Genre genre);

        [OperationContract]
        void DeleteMovie(Movie movie);

        [OperationContract]
        void DeleteGenre(Genre genre);

        [OperationContract]
        bool UpdateMovie(Movie movie);

        [OperationContract]
        bool UpdateGenre(Genre genre);
    }
}