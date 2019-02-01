using GerenciarEscolaTeste.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GerenciarEscolaTeste.Infrastructure.Data.EntityConfig
{
    public class PessoaConfiguration : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfiguration()
        {
            // Primary Key
            HasKey(c => c.PessoaId);

            // Properties
            Property(c => c.NomePessoa)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11);

            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.DataInclusao);
            Property(c => c.DataAlteracao);
            Property(c => c.DataExclusao);

            HasRequired(p => p.TipoPessoa)
               .WithMany()
               .HasForeignKey(p => p.TipoPessoaId);
        }
    }
}
