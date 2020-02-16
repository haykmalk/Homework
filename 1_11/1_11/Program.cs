using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("Hayk");
            document.Body = "Sam";
            document.Footer = "DDD";
            document.Show();
        }
    }
}
