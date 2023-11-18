using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string FilmAdi { get; set; }
        public int KategoriId { get; set; }
        public List<Oyuncu>? Oyuncu { get; set; }=new List<Oyuncu>();

    }
}
