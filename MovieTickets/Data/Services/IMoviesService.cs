﻿using MovieTickets.Data.Base;
using MovieTickets.Data.ViewModels;
using MovieTickets.Models;

namespace MovieTickets.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();

        Task AddNewMovieAsync(NewMovieVM data);
    }
}
