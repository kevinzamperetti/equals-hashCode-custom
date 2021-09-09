using System;

namespace course {
    class Program {
        static void Main(string[] args) {
            
            Client a = new Client { Name = "Kevin", Email = "kevin@gmail.com"};
            Client b = new Client { Name = "John", Email = "john@gmail.com"};

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
