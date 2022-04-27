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
            Caminhao caminhao1 = new Caminhao();


            // CARRO

            // Definição dos atributos e interação 
            Console.WriteLine("\n Olá! Hoje eu vou testar 3 automóveis aqui da loja. Vamos nessa?");
            Console.ReadLine();
            Console.WriteLine("\n Muito bem! Primeiro, vamos ver a marca do meu carro");

            carro1.setQuantLuzes(4);
            carro1.setQuantRodas(4);
            carro1.setAno("2010");
            carro1.setQuantGasolina(5);

            Console.WriteLine("\n Qual é marca do meu carro mesmo?");
            carro1.setMarca(Console.ReadLine());

            //Primeiro começamos com um carro que acabamos de comprar da loja 
            carro1.meuCarro();

            carro1.setTemArCondicionado(true);
            //E verificamos que o carro tem ar condicionado
            // ->>>> SOBRECARGA DO MÉTODO
            carro1.meuCarro(true);
            carro1.Radio();

            //E o dirigimos
            carro1.ligar();
            carro1.Dirigir();


            //MOTO

            Console.WriteLine("\n Agora vamos experimentar esta moto");

            moto1.setQuantRodas(2);
            moto1.setQuantLuzes(1);
            moto1.setQuantGasolina(3);
            moto1.setAno("2000");
            moto1.setMarca("Hondai");
            moto1.ligar();
            moto1.EmpinarMoto();
            moto1.SegurancaCapacete();

            moto1.setEstouComCapacete(true);
            Console.WriteLine("Achei meu capacete");
            moto1.EmpinarMoto();



            // CAMINHAO

            Console.WriteLine("\n Irado. Agora está pronto para testar o último automóvel?");
            Console.ReadLine();
            Console.WriteLine("Então vamos nessa!");

            caminhao1.setQuantGasolina(5);
            caminhao1.setQuantRodas(4);
            caminhao1.setQuantLuzes(4);
            caminhao1.setAno("1990");
            
            Console.WriteLine("\n Qual é marca deste caminhão?");
            caminhao1.setMarca(Console.ReadLine());

            caminhao1.ligar();
            
            caminhao1.Buzinar();
            //Ativando a buzina
            Console.WriteLine("Perai. Nós podemos ativar a buzina dele");
            caminhao1.setBuzinaCaminhao(true);
            caminhao1.Buzinar();
            Console.WriteLine("Agora está buzinando!");
            caminhao1.fazerEntrega();

            Console.WriteLine("\n Maravilha. Temos muitas possibilidades de automóveis, como o carro, para explorarmos! Até a próxima");

        }
    }
}
