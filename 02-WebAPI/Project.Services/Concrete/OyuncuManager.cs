using Project.Entities;
using Project.Services.Abstract;
using Project.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Services.DTOs;

namespace Project.Services.Concrete
{
    public class OyuncuManager : IOyuncuService
    {
        private readonly IOyuncuRepository _oyuncuRepository;

        public OyuncuManager(IOyuncuRepository oyuncuRepository)
        {
            _oyuncuRepository = oyuncuRepository;
        }


        public async Task<Oyuncu> IdyeGoreOyunculariGetir(int id)
        {
            if (id > 0)
            {
                return await _oyuncuRepository.GetPlayerById(id);
            }
            else
            {
                throw new Exception("Id parametresi 1'den küçük olamaz!");
            }
        }


        public Oyuncu OyuncuEkle(OyuncuDTO oyuncuDto)
        {

            if (oyuncuDto == null)
            {
                throw new Exception("Oyuncu kısmı boş olamaz!");
            }
            else
            {
                Oyuncu oyuncu = new Oyuncu
                {
                    Ad = oyuncuDto.Ad,
                    Soyad = oyuncuDto.Soyad,
                    FilmId = oyuncuDto.FilmId,
                };
                return _oyuncuRepository.CreatePlayer(oyuncuDto);
            }
        }


        public Oyuncu OyuncuGuncelle(OyuncuDTO oyuncu, int id)
        {
            return _oyuncuRepository.UpdatePlayer(oyuncu, id);
        }



        public void OyuncuSil(int id)
        {
            if (id != 0)
            {
                _oyuncuRepository.DeletePlayer(id);
            }
            else
            {
                throw new Exception("Id parametresi 0 veya NULL olamaz!");
            }
        }


        public List<Oyuncu> TumOyuncularıGetir()
        {
            return _oyuncuRepository.GetAll();
        }
    }
}
