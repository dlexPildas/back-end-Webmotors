using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste_webmotors.Data;
using teste_webmotors.Domain.Models.AnuncioWebmotorsAgregates.Entities;

namespace teste_webmotors.Domain.Models.AnuncioWebmotorsAgregates
{
    public class AnuncioWebmotorsService : IAnuncioWebmotorsService
    {
        private readonly IRepository _repository;

        public AnuncioWebmotorsService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> CriarAnuncio(AnuncioWebmotors anuncio)
        {
            _repository.Add(anuncio);

            return await _repository.SaveChangesAsync();
        }

        public async Task<bool> AtualizarAnuncio(AnuncioWebmotors anuncio)
        {
            _repository.Update(anuncio);

            return await _repository.SaveChangesAsync();
        }

        public async Task<bool> DeletarAnuncio(AnuncioWebmotors anuncio)
        {
            _repository.Delete(anuncio);

            return await _repository.SaveChangesAsync();
        }
    }
}
