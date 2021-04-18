using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using teste_webmotors.Domain.Models;
using teste_webmotors.Domain.Models.AnuncioWebmotorsAgregates.Entities;

namespace teste_webmotors.Domain.Validator
{
    public class AnuncioWebmotorsValidator : AbstractValidator<AnuncioWebmotors>
    {
        public AnuncioWebmotorsValidator()
        {
            RuleFor(x => x.Marca).NotNull().NotEmpty();
            RuleFor(x => x.Modelo).NotNull().NotEmpty();
            RuleFor(x => x.Ano).NotNull(); 
            RuleFor(x => x.Quilometragem).NotNull();
            RuleFor(x => x.Versao).NotNull().NotEmpty();
            RuleFor(x => x.Observacao).NotNull().NotEmpty();
        }
    }
}
