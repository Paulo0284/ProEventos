using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Model;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]
            { 
                new Evento()
                {
                    EventoId = 1,
                    Tema = "Angular com .NET Core",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    QtdPessoas = 1000,
                    Local = "Riachão do Jacuípe - Bahia",
                    ImagemURL = "/Imagens/",
                    Lote = "Lote 1"
                },
                new Evento()
                {
                    EventoId = 2,
                    Tema = ".NET Core Avançado",
                    DataEvento = DateTime.Now.AddDays(10).ToString("dd/MM/yyyy"),
                    QtdPessoas = 1000,
                    Local = "Riachão do Jacuípe - Bahia",
                    ImagemURL = "/Imagens/1234",
                    Lote = "Lote 2"
                }
            };
      
        public EventoController(ILogger<EventoController> logger)
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{Id}")]
        public Evento Get(int Id)
        {
            return _evento.Where(evento => evento.EventoId == Id).FirstOrDefault();
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Post(int id)
        {
            return $"Exemplo de Put com Id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com Id = {id}";
        }
    }
}
