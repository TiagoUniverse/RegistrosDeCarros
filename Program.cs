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
            Console.WriteLine("\n Olá! Hoje eu vou testar 3 automóveis aqui da loja. Vamos nessa?");
            Console.ReadLine();
            Console.WriteLine("\n Muito bem! Primeiro, vamos ver a marca do meu carro");
            carro1.setQuantLuzes(4);
            carro1.setQuantRodas(4);
            carro1.setMarca("Hondai");
            //Primeiro começamos com um carro que acabamos de comprar da loja 
            carro1.meuCarro();

            carro1.setTemArCondicionado(true);
            //E verificamos que o carro tem ar condicionado
            carro1.meuCarro(true);
            //E o dirigimos
            carro1.ligar();
            carro1.Dirigir();

            Console.WriteLine("\n Agora vamos experimentar esta moto");
            moto1.setQuantGasolina(3);
            moto1.setAno("2000");
            moto1.ligar();


            
        }
    }
}
