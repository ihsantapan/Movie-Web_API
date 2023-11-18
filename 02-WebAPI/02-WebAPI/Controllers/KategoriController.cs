using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Entities;
using Project.Entities.DTOs;
using Project.Services.Abstract;

namespace _02_WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        private readonly IKategoriService _service;

        public KategoriController(IKategoriService kategoriService)
        {
            _service = kategoriService;
        }

        [HttpGet]
        public IActionResult TumKategorileriGetir()
        {
            var kategori = _service.TumKategorileriGetir();

            if (kategori.Count > 0)
            {
                return Ok(kategori);
            }
            else if (kategori.Count == 0)
            {
                return BadRequest("Kategori bulunamadı!");
            }
            else
            {
                return NotFound();
            }
        }


        [HttpGet]
        public async Task<IActionResult> IdyeGoreKategoriGetir(int id)
        {
            var kategori = await _service.IdyeGoreKategoriGetir(id);

            if (kategori != null)
            {
                return Ok(kategori);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpGet]
        public IActionResult KategoridekiFilmleriGetir(int id)
        {
            var filmler = _service.KategoridekiFilmleriGetir(id);

            if (filmler != null)
            {
                return Ok(filmler);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPost]
        public IActionResult KategoriEkle(KategoriDTO kategoriDto)
        {
            var eklenecekKategori = _service.KategoriEkle(kategoriDto);

            if (eklenecekKategori != null)
            {
                return Ok(eklenecekKategori);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut]
        public IActionResult KategoriGuncelle(KategoriDTO kategori, int id)
        {
            return Ok(_service.KategoriGuncele(kategori, id));
        }


        [HttpDelete]
        public IActionResult KategoriSil(int id)
        {
            _service.KategoriSil(id);
            return Ok("Kategori silindi.");
        }


    }
}
