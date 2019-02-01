using GerenciarEscolaTeste.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GerenciarEscolaTeste.Infrastructure.Data.EntityConfig
{
    public class TurmaConfiguration : EntityTypeConfiguration<Turma>
    {
        public TurmaConfiguration()
        {
            // Primary Key
            HasKey(c => c.TurmaId);

            // Properties
            Property(c => c.NumTurma)
                .IsRequired()
                .HasMaxLength(15);

            Property(c => c.Periodo)
                .HasMaxLength(10);

            Property(c => c.DataInclusao);
            Property(c => c.DataAlteracao);

            HasRequired(p => p.Pessoa)
              .WithMany()
              .HasForeignKey(p => p.PessoaId);
        }
    }
}
