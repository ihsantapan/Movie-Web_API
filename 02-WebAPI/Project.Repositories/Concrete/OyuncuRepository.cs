using Project.Entities;
using Project.Repositories.Abstract;
using Project.Repositories.Context;
using Project.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repositories.Concrete
{
    public class OyuncuRepository : IOyuncuRepository
    {
        private readonly AppDbContext _context;

        public OyuncuRepository(AppDbContext context)
        {
            _context = context;
        }


        public Oyuncu CreatePlayer(OyuncuDTO playerDto)
        {
            Oyuncu oyuncu = new Oyuncu
            {
                Ad = playerDto.Ad,
                Soyad = playerDto.Soyad,
                FilmId = playerDto.FilmId,
            };

            _context.Oyuncular.Add(oyuncu);
            _context.SaveChanges();
            return oyuncu;
        }


        public void DeletePlayer(int playerId)
        {
            var oyuncu = _context.Oyuncular.FirstOrDefault(x => x.Id == playerId);
            _context.Oyuncular.Remove(oyuncu);
            _context.SaveChanges();
        }


        public List<Oyuncu> GetAll()
        {
            return _context.Oyuncular.ToList();
        }

    
        public async Task<Oyuncu> GetPlayerById(int playerId)
        {
            return await _context.Oyuncular.FindAsync(playerId);
        }


        public Oyuncu UpdatePlayer(OyuncuDTO player, int id)
        {
            var guncellenecekOyuncu = _context.Oyuncular.FirstOrDefault(x => x.Id == id);
            guncellenecekOyuncu.Ad=player.Ad;
            guncellenecekOyuncu.Soyad=player.Soyad;
            guncellenecekOyuncu.FilmId=player.FilmId;

            _context.Oyuncular.Update(guncellenecekOyuncu);
            _context.SaveChanges();
            return guncellenecekOyuncu;
        }
    }
}
