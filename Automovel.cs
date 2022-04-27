using System;

namespace RegistrosDeCarros
{
    class Automovel
    {
        private int id;
        private int quantRodas;
        private int quantLuzes;
        private bool ligado;
        private double quantGasolina;

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

        public bool getLigado()
        {
            return this.ligado;
        }

        public void setLigado(bool ligado)
        {
            this.ligado = ligado;
        }

        public double getQuantGasolina()
        {
            return this.quantGasolina;
        }

        public void setQuantGasolina(double quantGasolina)
        {
            this.quantGasolina = quantGasolina;
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

        public void GasolinaAtual()
        {
            if(getQuantGasolina() <= 0)
            {
                Console.WriteLine("\n Espere aí, motorista! Você está sem gasolina!");
            }else
            {
                Console.WriteLine("\n O tanque do seu automóvel possui " + getQuantGasolina() + " de gasolina");
                
            }
        }

    }
}