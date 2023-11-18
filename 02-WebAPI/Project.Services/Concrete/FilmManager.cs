using Project.Entities;
using Project.Entities.DTOs;
using Project.Repositories.Abstract;
using Project.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Concrete
{
    public class FilmManager : IFilmService
    {
        private readonly IFilmRepository _filmRepository;

        public FilmManager(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }


        public List<Oyuncu> FilmdekiOyuncularıGetir(int id)
        {
            if (id < 0)
            {
                throw new Exception("Id bilgisi 0 veya null olamaz!");
            }
            else
            {
                return _filmRepository.GetAllPlayersByFilm(id);
            }
        }


        public Film FilmEkle(FilmDTO filmDTO)
        {
            if (filmDTO == null)
            {
                throw new Exception("Film boş olamaz!");
            }
            else
            {
                Film film = new Film
                {
                    FilmAdi = filmDTO.FilmAdi,
                    KategoriId = filmDTO.KategoriId
                };
                return _filmRepository.CreateFilm(filmDTO);
            }
        }


        public Film FilmGuncelle(FilmDTO film, int id)
        {
            return _filmRepository.UpdateFilm(film, id);
        }


        public void FilmSil(int id)
        {
            if (id != 0)
            {
                _filmRepository.DeleteFilm(id);
            }
            else
            {
                throw new Exception("Id parametresi 0 veya NULL olamaz!");
            }
        }


        public async Task<Film> IdyeGoreFilmGetir(int id)
        {
            if (id > 0)
            {
                return await _filmRepository.GetFilmById(id);
            }
            else
            {
                throw new Exception("Id parametresi 1'den küçük olamaz!");
            }
        }


        public List<Film> TumFilmleriGetir()
        {
            return _filmRepository.GetAll();
        }
    }
}
