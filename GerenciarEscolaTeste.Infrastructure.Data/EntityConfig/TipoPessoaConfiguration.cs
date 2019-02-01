using GerenciarEscolaTeste.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GerenciarEscolaTeste.Infrastructure.Data.EntityConfig
{
    public class TipoPessoaConfiguration : EntityTypeConfiguration<TipoPessoa>
    {
        public TipoPessoaConfiguration()
        {
            // Primary Key
            HasKey(c => c.TipoPessoaId);

            // Properties
            Property(c => c.Descricao)
                .IsRequired();

            Property(c => c.DataInclusao);
            Property(c => c.DataAlteracao);
            Property(c => c.DataExclusao);
        }
    }
}
