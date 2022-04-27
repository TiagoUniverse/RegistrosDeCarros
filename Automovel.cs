using System;

namespace RegistrosDeCarros
{
    class Automovel
    {
        private int id;
        private int quantRodas;
        private int quantLuzes;
        private string ano;
        private string marca;
        private double quantGasolina;

        private bool ligado;

        public Automovel()
        {

        }
        public int getId()
        {
            return this.id;
        }

        public int getQuantRodas()
        {
            return this.quantRodas;
        }

        public int getQuantLuzes()
        {
            return this.quantLuzes;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setQuantRodas(int quantRodas)
        {
            this.quantRodas = quantRodas;
        }

        public void setQuantLuzes(int quantLuzes)
        {
            this.quantLuzes = quantLuzes;
        }


        public double getQuantGasolina()
        {
            return this.quantGasolina;
        }

        public void setQuantGasolina(double quantGasolina)
        {
            this.quantGasolina = quantGasolina;
        }


        public string getAno()
        {
            return this.ano;
        }

        public string getMarca()
        {
            return this.marca;
        }

        public void setAno(string ano)
        {
            this.ano = ano;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

         public bool getLigado()
        {
            return this.ligado;
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
                Console.WriteLine("\n O automovel já está ligado!");
            }
            else
            {
                Console.WriteLine("\n Ligando o automovel!" );
                setLigado(true);
            }

        }

        public void desligar()
        {
              if (getLigado() == false)
            {
                Console.WriteLine("\n O automovel já está desligado!");
            }
            else
            {
                Console.WriteLine("\n Desligando o automovel!");
                setLigado(true);
            }
        }
        public void GasolinaAtual()
        {
            if (getQuantGasolina() <= 0)
            {
                Console.WriteLine("\n Espere aí, motorista! Você está sem gasolina!");
            }
            else
            {
                Console.WriteLine("\n O tanque do seu automóvel possui " + getQuantGasolina() + " de gasolina");

            }
        }

    

    }
}