namespace basics.Models{

    public class Repository{

        private static readonly List<Bootcamp> _bootcamp = new();

        static Repository(){
            _bootcamp = new List<Bootcamp>(){
                new Bootcamp(){Id = 1, Title = "Aspnet Core Bootcamp", Description = "Aspnet Core Bootcampi başladı ve devam ediyor",Image = "1.png", Tags = new string[] {"aspnet","web geliştirme"}, isActive = true ,isHome= false},
                new Bootcamp(){Id = 2, Title = "Full Stack Bootcamp", Description = "Full Stack Bootcamp başladı ve devam ediyor",Image = "2.png", Tags = new string[] {"aspnet","web geliştirme"}, isActive = true ,isHome= true},
                new Bootcamp(){Id = 3, Title = "Game Bootcamp", Description = "Game Bootcamp başladı ve devam ediyor",Image = "3.jpg", Tags = new string[] {"game","game geliştirme"}, isActive = true ,isHome= true}
            };
        }
        
        public static List<Bootcamp> Bootcamps{
            get{return _bootcamp;}
        }

        public static Bootcamp? GetById(int id){
            return _bootcamp.FirstOrDefault(b=>b.Id == id);
        }
    }
}