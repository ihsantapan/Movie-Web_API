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
    public class KategoriManager : IKategoriService
    {
        private readonly IKategoriRepository _kategoriRepository;

        public KategoriManager(IKategoriRepository kategoriRepository)
        {
            _kategoriRepository = kategoriRepository;
        }


        public async Task<Kategori> IdyeGoreKategoriGetir(int id)
        {
            if (id > 0)
            {
                return await _kategoriRepository.GetCategoryById(id);
            }
            else
            {
                throw new Exception("Id parametresi 1'den küçük olamaz!");
            }
        }


        public List<Film> KategoridekiFilmleriGetir(int id)
        {
            if (id > 0)
            {
                return _kategoriRepository.GetFilmsByCategory(id);
            }
            else
            {
                throw new Exception("Id parametresi 0 veya NULL olamaz!");
            }
        }


        public Kategori KategoriEkle(KategoriDTO kategoriDTO)
        {
            if (kategoriDTO == null)
            {
                throw new Exception("Kategori boş olamaz!");
            }
            else
            {
                Kategori kategori = new Kategori
                {
                    KategoriAdi = kategoriDTO.KategoriAdi
                };
                return _kategoriRepository.CreateCategory(kategoriDTO);
            }
        }


        public Kategori KategoriGuncele(KategoriDTO kategori, int id)
        {
            return _kategoriRepository.UpdateCategory(kategori, id);
        }


        public void KategoriSil(int id)
        {
            if (id > 0)
            {
                _kategoriRepository.DeleteCategory(id);
            }
            else
            {
                throw new Exception("Id parametresi 0 veya NULL olamaz");
            }
        }


        public List<Kategori> TumKategorileriGetir()
        {
            return _kategoriRepository.GetAll();
        }
    }
}
