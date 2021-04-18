using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_webmotors.Domain.Models.AnuncioWebmotorsAgregates.Entities
{
    public class AnuncioWebmotors
    {
        public int Id { get; private set; }
        
        public string Marca { get; private set; }

        public string Modelo { get; private set; }
        
        public string Versao { get; private set; }

        public int Ano { get; private set; }

        public int Quilometragem { get; private set; }

        public string Observacao { get; private set; }
    }
}
