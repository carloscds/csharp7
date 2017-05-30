using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCSharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = "10";

            int.TryParse(x, out int i);

            if(i is int y)
            {
                y++;
            }

            Teste(1);
            Teste("CDS");

            Tuple<int, int> valor = new Tuple<int, int>(1, 2);

            (int valor1, int valor2) valores = (10, 20);

            var c = new Cliente();
            (_, decimal salario) = c;

            var bin = 0b10;
            var ex = 0x10;

            var loc = funcaoLocal(2);

            int funcaoLocal(int par) => par * 2;

            RefCli(ref c);

        }

        public static void RefCli(ref Cliente c)
        {
            c.Nome = "Maria";
        }

        public static (string nome, double salario) Pessoa()
        {
            return ("Carlos", 10);
        }

        public static void Teste(object o)
        {
            if(o is int i)
            {
                i++;
                Console.WriteLine($"Inteiro: {i}");
            }
            if(o is string s)
            {
                s += " mudou";
                Console.WriteLine($"String: {s}");
            }

            switch(o)
            {
                case int ii:
                    {
                        Console.WriteLine("int");
                        break;
                    }
                case string ss:
                    {
                        Console.WriteLine("string");
                        break;
                    }
            }

        }
    }

    public class Cliente
    {
        private string _nome;
        private decimal _salario;

        public string Nome { get { return _nome; } set { _nome = value; } }
        public void Deconstruct(out string nome, out decimal salario) { nome = "Carlos"; salario = 100; }
    }
}
