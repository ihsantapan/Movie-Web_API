using Project.Entities;
using Project.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Abstract
{
    public interface IFilmService
    {
        List<Film> TumFilmleriGetir();
        Task<Film> IdyeGoreFilmGetir(int id);
        List<Oyuncu> FilmdekiOyuncularıGetir(int id);
        Film FilmEkle(FilmDTO filmDTO);
        Film FilmGuncelle(FilmDTO film,int id);
        void FilmSil(int id);

    }
}
