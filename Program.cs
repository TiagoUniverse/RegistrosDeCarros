using System;

namespace RegistrosDeCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação do objeto
            Carro carro1 = new Carro();
            Moto moto1 = new Moto();


            // Definição dos atributos
            carro1.setQuantLuzes(4);
            carro1.setQuantRodas(4);
            carro1.setMarca("Hondai");
            Console.WriteLine("\n O seu carro é: " + carro1.getMarca());
            
            moto1.setQuantGasolina(3);
            moto1.setAno("2000");
            moto1.ligar();

            
            
        }
    }
}
