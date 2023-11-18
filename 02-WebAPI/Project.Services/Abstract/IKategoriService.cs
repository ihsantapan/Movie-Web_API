using Project.Entities;
using Project.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Abstract
{
    public interface IKategoriService
    {
        List<Kategori> TumKategorileriGetir();
        Task<Kategori> IdyeGoreKategoriGetir(int id);
        List<Film> KategoridekiFilmleriGetir(int id);
        Kategori KategoriEkle(KategoriDTO kategoriDTO);
        Kategori KategoriGuncele(KategoriDTO kategori, int id);
        void KategoriSil(int id);

    }
}
