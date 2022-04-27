using System;

namespace RegistrosDeCarros
{
    class Moto : Automovel
    {
        private int id;
       
        private bool estouComCapacete;

        private string modeloMoto;
    
        public Moto()
        {
            Console.WriteLine("Pegando minha nova moto!");
        }

        public Moto(bool estouComCapacete)
        {
             setEstouComCapacete(estouComCapacete);
        }


        public int getId()
        {
            return this.id;
        }

        public bool getEstouComCapacete()
        {
            return this.estouComCapacete;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getModeloMoto()
        {
            return this.modeloMoto;
        }

        public void setModeloMoto(string modeloMoto)
        {
            this.modeloMoto = modeloMoto;
        }

        public void setEstouComCapacete(bool estouComCapacete)
        {
            this.estouComCapacete = estouComCapacete;
        }

        public void EmpinarMoto()
        {
            Console.WriteLine("OPA! Estou empinando a moto!");
        }
        




    }
}