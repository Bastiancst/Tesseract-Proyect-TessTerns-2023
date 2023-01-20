using Microsoft.EntityFrameworkCore;
using ferreteria_backend.Models;
using System.Data.Common;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ferreteria_backend.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

		public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        
        public DbSet<Item> Items { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Item>().HasData(
				new Item()
				{
					Id = 1,
					Name = "Martillo",
					Price = 5000,
					ImageUrl = "https://easycl.vtexassets.com/arquivos/ids/160093/120144.jpg?v=637527403541830000",
					Description = "pega fuerte",
					CreatedDate = DateTime.Now
				}, new Item()
				{
					Id = 2,
					Name = "Destornillador",
					Price = 4000,
					ImageUrl = "https://pimdatacdn.bahco.com/media/sub624/16a0ffdce467453f.png",
					Description = "ta chido",
					CreatedDate = DateTime.Now
				},
				new Item()
				{
					Id = 3,
					Name = "Cinta de medir",
					Price = 3000,
					ImageUrl = "https://png.pngtree.com/element_our/20190602/ourlarge/pngtree-construction-tool-ruler-illustration-image_1425976.jpg",
					Description = "ta wena",
					CreatedDate = DateTime.Now
				},
				new Item()
				{
					Id = 4,
					Name = "Taladro Percutor Electrico Bauker",
					Price = 34000,
					ImageUrl = "https://pbs.twimg.com/media/EJ-h_niWoAEXN3e?format=jpg&name=medium",
					Description = "NUEVO TALADRO PERCUTOR SKILL 6060 13 Mm 700WATTS VEL VARIABLE + ACCESORIOS MALETIN ELECTRICO HORMIGON ACERO SKILL",
					CreatedDate = DateTime.Now
				});
		}
	}
}
