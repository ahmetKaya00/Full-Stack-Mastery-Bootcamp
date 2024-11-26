namespace FormsApp.Models{
    public class Repository{

        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository(){
            _categories.Add(new Category {CategoryId = 1, Name = "Telefon"});
            _categories.Add(new Category {CategoryId = 2, Name = "Bilgisayar"});

            _products.Add(new Product {ProductId = 1, Name = "Iphone 15", Price = 85000, Image = "3.jpg",IsActive=true,CategoryId=1});
            _products.Add(new Product {ProductId = 2, Name = "Iphone 13", Price = 50000, Image = "4.jpg",IsActive=true,CategoryId=1});
            _products.Add(new Product {ProductId = 3, Name = "Macbook Air", Price = 50000, Image = "2.jpeg",IsActive=true,CategoryId=2});
            _products.Add(new Product {ProductId = 4, Name = "Macbook Air Pro", Price = 580000, Image = "1.jpg",IsActive=true,CategoryId=2});
        }

        public static List<Product> Products{get{return _products;}}
        public static List<Category> Categories{get{return _categories;}}
    }
}