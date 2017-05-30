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

            object[] obj = { "Carlos", 10, "string bem grande"};

            foreach(var o in obj)
            {
                Teste(o);
            }

            Teste(1);
            Teste("CDS");

            Tuple<int, int> valor = new Tuple<int, int>(1, 2);

            (int valor1, int valor2) valores = (10, 20);

            var c = new Cliente();
            (_, decimal salario) = c;

            var bin = 0b10_11_100;
            var ex = 0x10_A_E;

            var loc = funcaoLocal(2);

            int funcaoLocal(int par) => par * 2;

            c.MetodoComErroSeNaoPassarValor(null);

        }

        public static (string nome, double salario) Pessoa()
        {
            return ("Carlos", 10);
        }

        public static void Teste(object o)
        {
            //if(o is int i)
            //{
            //    i++;
            //    Console.WriteLine($"Inteiro: {i}");
            //}
            //if(o is string s)
            //{
            //    s += " mudou";
            //    Console.WriteLine($"String: {s}");
            //}

            switch(o)
            {
                case int ii:
                    {
                        Console.WriteLine("int");
                        break;
                    }
                case string ss when ss.Length > 10:
                    {
                        Console.WriteLine("string > 10 - "+ss);
                        break;
                    }
                case string ss:
                    {
                        Console.WriteLine("string - " + ss);
                        break;
                    }
            }

        }
    }

    public class Cliente
    {
        private string _nome;
        private decimal _salario;

        //public string Nome { get { return _nome; } set { _nome = value; } }
        public string Nome { get => _nome; set => _nome = value; }
        public void Deconstruct(out string nome, out decimal salario) { nome = "Carlos"; salario = 100; }

        public void MetodoComErroSeNaoPassarValor(object nome) => _nome = (string)nome ?? throw new Exception("Erro");
    }
}
