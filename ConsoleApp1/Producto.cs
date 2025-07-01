using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Producto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Producto(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Producto other)
            {
                return Name == other.Name && Price == other.Price;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
        public static bool operator ==(Producto left, Producto right)
        {
            if (left is null && right is null) return true;
            if (left is null || right is null) return false;
            return left.Equals(right);
        }

        public static bool operator !=(Producto left, Producto right)
        {
            return !(left == right);
        }

    }
}