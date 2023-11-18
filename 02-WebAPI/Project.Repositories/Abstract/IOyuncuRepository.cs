using Project.Entities;
using Project.Services.DTOs;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repositories.Abstract
{
    public interface IOyuncuRepository
    {
        Task<Oyuncu> GetPlayerById(int playerId);
        List<Oyuncu> GetAll();
        Oyuncu CreatePlayer(OyuncuDTO player);
        Oyuncu UpdatePlayer(OyuncuDTO player, int id);
        void DeletePlayer(int playerId);
    }
}
