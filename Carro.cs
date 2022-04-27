using System;

namespace RegistrosDeCarros
{
    class Carro : Automovel
    {
        private int id;
        private bool temArCondicionado;

        public Carro()
        {

        }

        public Carro(string marca)
        {

        }

        public Carro(string ano, string marca)
        {

        }

        public int getId()
        {
            return this.id;
        }

        public bool getTemArCondicionado()
        {
            return this.temArCondicionado;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setTemArCondicionado(bool temArCondicionado)
        {
            this.temArCondicionado = temArCondicionado;
        }

    
        public void Ligar(bool temArCondicionado)
        {
            if (getTemArCondicionado() == true )
            {
                if(getLigado() == false){
                   Console.WriteLine("Ligando o carro E o ar condicionadoo!"); 
                }    
            }else{
                Console.WriteLine("OPS! Algo deu errado! Por favor, tenha ar condicionado no seu carro E desligue seu carro, para assim ligá-lo");
            }
        }

        public void Dirigir()
        {
            Console.WriteLine("Dirigindo meu carro com velocidade!");
        }




    }
}