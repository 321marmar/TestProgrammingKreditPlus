using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kreditPlus {
    class Program {
        static void Main(string[] args) {
            var a = 5;
            var b = 3;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Tukar nilai: ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            int[] x = { 20, 10, 50, 46, 26, 87, 25, 5, 97, 24 };
            int t = 0;
            for (int i = 0; i < x.Length - 1; i++) {
                for (int j = i; j < x.Length; j++) {
                    if (x[i] > x[j]) {
                        t = x[i];
                        x[i] = x[j];
                        x[j] = t;
                    }
                }
            }
            Console.WriteLine("\nPengurutan dari terkecil ke terbesar:");
            foreach (int item in x) {
                Console.WriteLine(item + " ");
            }
        }
    }
}
