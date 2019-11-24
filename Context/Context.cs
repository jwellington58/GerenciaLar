using GerenciaLar.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciaLar.Context
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options) : base(options){}
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}