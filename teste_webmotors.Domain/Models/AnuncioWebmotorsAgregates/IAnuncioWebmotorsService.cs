using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste_webmotors.Domain.Models.AnuncioWebmotorsAgregates.Entities;

namespace teste_webmotors.Domain.Models.AnuncioWebmotorsAgregates
{
    public interface IAnuncioWebmotorsService
    {
        Task<bool> CriarAnuncio(AnuncioWebmotors anuncio);
        Task<bool> AtualizarAnuncio(AnuncioWebmotors anuncio);
        Task<bool> DeletarAnuncio(AnuncioWebmotors anuncio);
    }
}
