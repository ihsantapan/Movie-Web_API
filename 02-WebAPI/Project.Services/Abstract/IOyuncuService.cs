using Project.Entities;
using Project.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services.Abstract
{
    public interface IOyuncuService
    {

        List<Oyuncu> TumOyuncularıGetir();
        Task<Oyuncu> IdyeGoreOyunculariGetir(int id);      
        Oyuncu OyuncuEkle(OyuncuDTO oyuncu);
        Oyuncu OyuncuGuncelle(OyuncuDTO oyuncu,int id);
        void OyuncuSil(int id);

    }
}
