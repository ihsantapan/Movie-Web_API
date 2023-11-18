using Project.Entities;
using Project.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repositories.Abstract
{
    public interface IFilmRepository
    {
        Task<Film> GetFilmById(int filmId);
        List<Film> GetAll();
        List<Oyuncu> GetAllPlayersByFilm(int id);
        Film CreateFilm(FilmDTO film);
        Film UpdateFilm(FilmDTO film, int id);
        void DeleteFilm(int filmId);

    }
}
