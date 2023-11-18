using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Entities;
using Project.Entities.DTOs;
using Project.Services.Abstract;

namespace _02_WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmService _service;

        public FilmController(IFilmService filmService)
        {
            _service = filmService;
        }


        [HttpGet]
        public IActionResult TumFilmleriGetir()
        {
            var film = _service.TumFilmleriGetir();

            if (film.Count > 0)
            {
                return Ok(film);
            }
            else if (film.Count == 0)
            {
                return BadRequest("Film bulunamadı!");
            }
            else
            {
                return NotFound();
            }
        }


        [HttpGet]
        public async Task<IActionResult> IdyeGoreFilmGetir(int id)
        {
            var film = await _service.IdyeGoreFilmGetir(id);

            if (film != null)
            {
                return Ok(film);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpGet]
        public IActionResult FilmdekiOyuncularıGetir(int id)
        {
            var oyuncular = _service.FilmdekiOyuncularıGetir(id);

            if (oyuncular.Count > 0)
            {
                return Ok(oyuncular);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPost]
        public IActionResult FilmEkle(FilmDTO filmDto)
        {
            var eklenecekFilm = _service.FilmEkle(filmDto);

            if (eklenecekFilm != null)
            {
                return Ok(eklenecekFilm);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut]
        public IActionResult FilmGuncelle(FilmDTO film, int id)
        {
            return Ok(_service.FilmGuncelle(film, id));
        }


        [HttpDelete]
        public IActionResult FilmSil(int id)
        {
            _service.FilmSil(id);
            return Ok("Film silindi");
        }


    }
}
