using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using teste_webmotors.Domain.Models;
using teste_webmotors.Domain.Models.AnuncioWebmotorsAgregates.Entities;

namespace teste_webmotors.Data.Data.Mapping
{
    public class AnuncioWebmotorsMapping : IEntityTypeConfiguration<AnuncioWebmotors>
    {
        public void Configure(EntityTypeBuilder<AnuncioWebmotors> builder)
        {
            builder.ToTable("tb_AnuncioWebmotors");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Marca).HasColumnType("varchar(45)").IsRequired();

            builder.Property(x => x.Modelo).HasColumnType("varchar(45)").IsRequired();
            
            builder.Property(x => x.Versao).HasColumnType("varchar(45)").IsRequired();
            
            builder.Property(x => x.Ano).HasColumnType("int").IsRequired();
            
            builder.Property(x => x.Quilometragem).HasColumnType("int").IsRequired();
            
            builder.Property(x => x.Observacao).HasColumnType("varchar(200)").IsRequired();
        }
    }
}
