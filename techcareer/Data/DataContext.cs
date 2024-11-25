using Microsoft.EntityFrameworkCore;

namespace techcareer.Data{

    public class DataContext : DbContext{
        public DataContext(DbContextOptions<DataContext> options):base(options){}

        public DbSet<Bootcamp>Bootcamps => Set<Bootcamp>();
        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>();
        public DbSet<BootcampKayit> BootcampKayitlari => Set<BootcampKayit>();
        public DbSet<Ogretmen> Ogretmenler => Set<Ogretmen>();
    }
}