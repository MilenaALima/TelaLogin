using System;
using System.Collections.Generic;

namespace telaLogin
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, string>> usuarios = new Dictionary<string, Dictionary<string, string>>();

            Console.WriteLine("Hello World!");

            Console.WriteLine("Faça seu Login!");

            Console.WriteLine("E-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Senha: ");
            string senha = Console.ReadLine();

            usuarios[email] = new Dictionary<string, string>
            {
                {"nome", nome },
                {"senha", senha }
            };
            Console.WriteLine("\nUsuário cadastrado com sucesso");

            Login(usuarios);
        }

        static void Login(Dictionary<string, Dictionary<string, string>> usuarios)
        {
            //solicitando informções para o login
            Console.WriteLine("Digite seu e-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine("Digite seu senha: ");
            string senha = Console.ReadLine();

            if(usuarios.ContainsKey(email) && usuarios[email]["senha"] == senha)
            {
                Console.WriteLine("\nLogin realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("\nEmail ou senha incorretos.");
            }
        }
    }
}
