using System;

namespace odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productCategory = "Elektronik";
            product1.productName = "Laptop";
            product1.productCompany = "Monster";
            product1.productPrice = 5500;

            Product product2 = new Product();
            product2.productCategory = "Giyim";
            product2.productName = "Galatasaray 20-21 Forma";
            product2.productCompany = "Galatasaray";
            product2.productPrice = 250;

            Product product3 = new Product();
            product3.productCategory = "Kitap";
            product3.productName = "Sunay Akın - Bir Çift Ayakkabı";
            product3.productCompany = "İş bankası yayınevi";
            product3.productPrice = 20;

            Product product4 = new Product();
            product4.productCategory = "Ayakkabı";
            product4.productName = "XFL100"; //sallamasyon
            product4.productCompany = "Adidas";
            product4.productPrice = 300;

            Product[] products = new Product[] { product1, product2, product3, product4 };



            foreach (var Product in products)
            {
                Console.WriteLine(Product.productCategory + " : " + Product.productName + " : " + Product.productCompany + " : " + Product.productPrice);
            }

            Console.WriteLine("Foreach bitti");

            int i = 0;
            while (i < products.Length)
            {
                var Product = products[i];
                Console.WriteLine(Product.productCategory + " : " + Product.productName + " : " + Product.productCompany + " : " + Product.productPrice);
                i++;
            }

            Console.WriteLine("while bitti");





        }
    }

    class Product
    {
        public string productCategory { get; set; }
        public string productName { get; set; }
        public string productCompany { get; set; }
        public int productPrice { get; set; }

    }
}
