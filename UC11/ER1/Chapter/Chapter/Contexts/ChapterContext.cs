﻿using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext: DbContext
    {
        public ChapterContext()
        {

        }

        public ChapterContext(DbContextOptions<ChapterContext> options): base(options)
        {

        }
        //vamos utilizar esse método para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                //cada provedor tem sua sintaxe para especificacao
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-CG7J4I1\\SQLEXPRESS; initial catalog =  Chapter; Integrated Security = true");
            }
        }

        //dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleçao.
        public DbSet<Livro> Livros { get; set; }
       
    }
}
