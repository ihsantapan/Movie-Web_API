using Project.Entities;
using Project.Entities.DTOs;
using Project.Repositories.Abstract;
using Project.Repositories.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repositories.Concrete
{
    public class FilmRepository : IFilmRepository
    {
        private readonly AppDbContext _context;

        public FilmRepository(AppDbContext context)
        {
            _context = context;
        }


        public Film CreateFilm(FilmDTO eklenecekfilm)
        {
            Film film = new Film
            {
                FilmAdi = eklenecekfilm.FilmAdi,
                KategoriId= eklenecekfilm.KategoriId
                
            };
            _context.Filmler.Add(film);
            _context.SaveChanges();
            return film;
        }


        public void DeleteFilm(int filmId)
        {
            var film=_context.Filmler.FirstOrDefault(x=>x.Id == filmId);
            _context.Filmler.Remove(film);
            _context.SaveChanges();
        }


        public List<Film> GetAll()
        {
            return _context.Filmler.ToList();   
        }


        public List<Oyuncu> GetAllPlayersByFilm(int  id)
        {
            List<Oyuncu> players = _context.Oyuncular.Where(x => x.FilmId == id).ToList();
            return players;
        }


        public async Task<Film> GetFilmById(int filmId)
        {
            return await _context.Filmler.FindAsync(filmId);
        }


        public Film UpdateFilm(FilmDTO film, int id)
        {
            var guncellenecekFilm = _context.Filmler.Find(id);
            guncellenecekFilm.FilmAdi = film.FilmAdi;
            guncellenecekFilm.KategoriId= film.KategoriId;
            
            _context.Filmler.Update(guncellenecekFilm);
            _context.SaveChanges();
            return guncellenecekFilm;
        }
    }
}
