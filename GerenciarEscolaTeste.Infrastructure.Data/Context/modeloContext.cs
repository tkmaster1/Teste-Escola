﻿using GerenciarEscolaTeste.Domain.Entities;
using GerenciarEscolaTeste.Infrastructure.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.SqlServer;
using System.Linq;

namespace GerenciarEscolaTeste.Infrastructure.Data.Context
{
    public class modeloContext : DbContext
    {
        public modeloContext()
            : base("modeloDDD")
        {
            Database.SetInitializer<modeloContext>(null);
            var ensureDLLIsCopied = SqlProviderServices.Instance;
        }

        public DbSet<TipoPessoa> TipoPessoas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new TipoPessoaConfiguration());
            modelBuilder.Configurations.Add(new PessoaConfiguration());
            modelBuilder.Configurations.Add(new ContatoConfiguration());
            modelBuilder.Configurations.Add(new TurmaConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataInclusao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataInclusao").CurrentValue = DateTime.Now;
                    entry.Property("DataAlteracao").IsModified = false;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataInclusao").IsModified = false;
                    entry.Property("DataAlteracao").CurrentValue = DateTime.Now;
                }
            }

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataAlteracao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataAlteracao").IsModified = false;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataAlteracao").CurrentValue = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
