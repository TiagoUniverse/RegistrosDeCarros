using System;

namespace RegistrosDeCarros
{
    class Moto : Automovel
    {
        private int id;
       
        private bool estouComCapacete;
        private bool ligado;

        public Moto()
        {

        }

        public Moto(string estouComCapacete)
        {

        }


        public int getId()
        {
            return this.id;
        }


        public bool getLigado()
        {
            return this.ligado;
        }
        public bool getEstouComCapacete()
        {
            return this.estouComCapacete;
        }

        public void setId(int id)
        {
            this.id = id;
        }


        public void setEstouComCapacete(bool estouComCapacete)
        {
            this.estouComCapacete = estouComCapacete;
        }

    




    }
}