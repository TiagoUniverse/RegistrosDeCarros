using System;

namespace RegistrosDeCarros
{
    class Carro : Automovel
    {
        private int id;
        private string ano;
        private string marca;
        private bool temArCondicionado;
        private bool ligado;

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

        public string getAno()
        {
            return this.ano;
        }

        public string getMarca()
        {
            return this.marca;
        }

        public bool getLigado()
        {
            return this.ligado;
        }
        public bool getTemArCondicionado()
        {
            return this.temArCondicionado;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setAno(string ano)
        {
            this.ano = ano;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public void setTemArCondicionado(bool temArCondicionado)
        {
            this.temArCondicionado = temArCondicionado;
        }

        public void setLigado(bool ligado)
        {
            this.ligado = ligado;
        }


        public void estaLigado()
        {
            if (getLigado() == true)
            {
                Console.WriteLine("\n O automóvel está ligado!");
            }
            else
            {
                Console.WriteLine("\n O automóvel não está ligado!");

            }

        }

        public void ligar()
        {
            if (getLigado() == true)
            {
                Console.WriteLine("\n O carro já está ligado!");
            }
            else
            {
                Console.WriteLine("\n Ligando o carro!");
                setLigado(true);
            }

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






    }
}