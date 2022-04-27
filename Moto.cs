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
            Console.WriteLine("\n OPA! Estou empinando a moto!");

            if(getEstouComCapacete() == true)
            {
                Console.WriteLine("\n E estou com meu capacete de segurança! Agora sim.");
            }else
            {
                Console.WriteLine("\n Mas devo tomar cuidado! Estou sem meu capacete de segurança");
            }
        }
        
          public void SegurancaCapacete()
        {
            if(getEstouComCapacete() == true)
            {
                Console.WriteLine("\n Estou seguro e com meu capacete. Posso pilotar melhor agora.");
            }else
            {
                Console.WriteLine("\n Preciso do meu capacete. É perigoso pilotar sem ele");
            }
        }



    }
}