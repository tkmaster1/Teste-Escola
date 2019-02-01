using GerenciarEscolaTeste.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GerenciarEscolaTeste.Infrastructure.Data.EntityConfig
{
    public class ContatoConfiguration : EntityTypeConfiguration<Contato>
    {
        public ContatoConfiguration()
        {
            // Primary Key
            HasKey(c => c.ContatoId);

            // Properties
            Property(c => c.Ddi)
                .IsRequired()
                .HasMaxLength(3);

            Property(c => c.Ddd)
                .HasMaxLength(3);

            Property(c => c.TelFixo)
                .HasMaxLength(10);

            Property(c => c.TelCelular)
                .HasMaxLength(10);

            Property(c => c.DataInclusao);
            Property(c => c.DataAlteracao);
            Property(c => c.DataExclusao);

            HasRequired(p => p.Pessoa)
               .WithMany()
               .HasForeignKey(p => p.PessoaId);
        }
    }
}
