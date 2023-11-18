using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Entities;
using Project.Services.Abstract;
using Project.Services.DTOs;

namespace _02_WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OyuncuController : ControllerBase
    {
        private readonly IOyuncuService _service;

        public OyuncuController(IOyuncuService oyuncuService)
        {
            _service = oyuncuService;
          
        }

        [HttpGet]
        public IActionResult TumOyunculariGetir()
        {
            var oyuncu = _service.TumOyuncularıGetir();

            if (oyuncu.Count > 0)
            {
                return Ok(oyuncu);
            }
            else if (oyuncu.Count == 0)
            {
                return BadRequest("Oyuncu bulunamadı!");
            }
            else
            {
                return NotFound();
            }
        }


        [HttpGet]
        public async Task<IActionResult> IdyeGoreOyuncuGetir(int id)
        {
            var oyuncu = await _service.IdyeGoreOyunculariGetir(id);
            if (oyuncu != null)
            {
                return Ok(oyuncu);
            }
            else
            {
                return NotFound();
            }
        }    


        [HttpPost]
        public IActionResult OyuncuEkle(OyuncuDTO oyuncu)
        {
            var eklenecekOyuncu = _service.OyuncuEkle(oyuncu);
            if (eklenecekOyuncu != null)
            {
                return Ok(eklenecekOyuncu);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut]
        public IActionResult OyuncuGuncelle(OyuncuDTO oyuncu,int id  )
        {
            return Ok(_service.OyuncuGuncelle(oyuncu,id));
        }


        [HttpDelete]
        public IActionResult OyuncuSil(int id)
        {
            _service.OyuncuSil(id);
            return Ok("Oyuncu silindi.");
        }

    }
}
