using Project.Entities;
using Project.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repositories.Abstract
{
    public interface IKategoriRepository
    {
        Task<Kategori> GetCategoryById(int categoryId);
        List<Kategori> GetAll();
        List<Film> GetFilmsByCategory(int id);
        Kategori CreateCategory(KategoriDTO category);
        Kategori UpdateCategory(KategoriDTO category,int id);
        void DeleteCategory(int categoryId);      

    }
}
