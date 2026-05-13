using ContactManagerMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        /*base(options) = Hace referencia de la POO y la herencia, significa que los parametros 
         * del metodo DbContextOptions<ApplicationDbContext> options 
         * se envian a la clase base DbContext la cual la clase ApplicationDbContext hereda
         */

        /*DbContext = Es la clase base del EntityFrameworkCore
         * DbContextOptions<ApplicationDbContext> = Recibe la configuración de la DB (Conexion, cadena SQL, etc)
         */
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)  
        {
            
        }

        //Se agregarán los DbSet más adelante

        public DbSet<Contact> Contacts { get; set; }
    }

}
