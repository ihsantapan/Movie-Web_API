using Project.Entities;
using Project.Entities.DTOs;
using Project.Repositories.Abstract;
using Project.Repositories.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repositories.Concrete
{
    public class KategoriRepository : IKategoriRepository
    {
        private readonly AppDbContext _context;

        public KategoriRepository(AppDbContext context)
        {
            _context = context;
        }


        public Kategori CreateCategory(KategoriDTO category)
        {
            Kategori kategori = new Kategori
            {
                KategoriAdi = category.KategoriAdi,

            };
            _context.Kategoriler.Add(kategori);
            _context.SaveChanges();
            return kategori;
        }


        public void DeleteCategory(int categoryId)
        {
            var kategori = _context.Kategoriler.FirstOrDefault(x => x.Id == categoryId);
            _context.Kategoriler.Remove(kategori);
            _context.SaveChanges();
        }


        public List<Kategori> GetAll()
        {
            return _context.Kategoriler.ToList();
        }


        public async Task<Kategori> GetCategoryById(int categoryId)
        {
            return await _context.Kategoriler.FindAsync(categoryId);
        }


        public List<Film> GetFilmsByCategory(int id)
        {
            var films=_context.Filmler.Where(x=>x.KategoriId== id).ToList();    
            return films;
        }


        public Kategori UpdateCategory(KategoriDTO category, int id)
        {
            var kategori = _context.Kategoriler.FirstOrDefault(x => x.Id == id);
            kategori.KategoriAdi = category.KategoriAdi;

            _context.Kategoriler.Update(kategori);
            _context.SaveChanges();
            return kategori;
        }
    }
}
