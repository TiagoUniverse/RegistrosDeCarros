using System;

namespace RegistrosDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação do objeto
            Carro carro1 = new Carro();
            
            // Definição dos atributos
            carro1.setQuantLuzes(4);
            carro1.setQuantRodas(4);
            carro1.setMarca("Hondai");
            Console.WriteLine("\n O seu carro é: " + carro1.getMarca());
            
        }
    }
}
