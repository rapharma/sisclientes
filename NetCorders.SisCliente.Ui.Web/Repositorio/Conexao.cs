using WebApp.SisCliente.Ui.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp.SisCliente.Ui.Web.Repositorio
{
    public class Conexao : DbContext
    {
        //

        //ctor
        public Conexao() : base("Data Source=(localdb)\\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")//base é o construtor da classe pai
        {

        }

        public DbSet<clienteMOD> Cliente { get; set; }
    }
}