using System;

namespace ExemploEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(10, "1122334455");
            carro.TanqueVazio += new Carro.EventoCarro(tanque_vazio);
            carro.TanqueVazio += new Carro.EventoCarro(alerta_posto);
            carro.Ligacao += new Carro.Chamar(ligar_casa);
            carro.Ligar();
        }

        static void tanque_vazio(){
            Console.WriteLine("Tanque vazio");
        }

        static void alerta_posto(){
            Console.WriteLine("Parar no posto para abastecer");
        }

        static void ligar_casa(string Telefone){
            Console.WriteLine("Ligar para: " + Telefone);
        }
    }
}
