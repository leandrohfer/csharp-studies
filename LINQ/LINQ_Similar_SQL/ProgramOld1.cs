using LINQ.LINQ_Lambda.Entities;

namespace LINQ.LINQ_Similar_SQL
{
    internal class ProgramOld1
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Teste3(String[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };
            Category c4 = new Category() { Id = 4, Name = "Category Test", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, CategoryId = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, CategoryId = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, CategoryId = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, CategoryId = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, CategoryId = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, CategoryId = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, CategoryId = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, CategoryId = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, CategoryId = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, CategoryId = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, CategoryId = c1 },
                new Product() { Id = 12, Name = "Test Product", Price = 300.0, CategoryId = c4 }
            };

            /* Outra forma de se escrever as expressões LINQ*/

            //var r1 = products.Where(p => p.CategoryId.Tier == 1 && p.Price < 900.0);
            var r1 =
                from p in products
                where p.CategoryId.Tier == 1 && p.Price < 900.0
                select p;
            Print("TIER 1 AND PRICE < 900:", r1);

            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 =
                from p in products
                where p.CategoryId.Name == "Tools"
                select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.CategoryId.Name
                };
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 =
                from p in products
                where p.CategoryId.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 =
                (from p in r4
                 select p)
                 .Skip(2)
                 .Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            // var r6 = products.FirstOrDefault();
            var r6 =
                (from p in products
                 select p)
                 .FirstOrDefault();
            Console.WriteLine("First or default test1: " + r6);

            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);
            Console.WriteLine();

            //var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            var r8 =
                (from p in products
                 where p.Id == 3
                 select p)
                 .SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);
            Console.WriteLine();

            // var r10 = products.Max(p => p.Price);
            var r10 =
                (from p in products
                 select p)
                 .Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            var r12 = products.Where(p => p.CategoryId.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);

            var r13 = products.Where(p => p.CategoryId.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);

            var r14 = products.Where(p => p.CategoryId.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);

            var r15 = products.Where(p => p.CategoryId.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);

            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            //var r16 = products.GroupBy(p => p.CategoryId).OrderBy(p => p.Key.Tier).ToList();
            var r16 =
                from p in products
                orderby p.CategoryId.Tier
                group p by p.CategoryId;
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }

}
