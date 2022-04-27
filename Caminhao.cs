using System;

namespace RegistrosDeCarros
{
    class Caminhao : Automovel
    {
        private int id;
        private string produtoDeEntrega;

        private bool buzinaCaminhao;

        public Caminhao()
        {
             Console.WriteLine("Pegando meu novo caminhão!");
        }

        public Caminhao(string produtoDeEntrega)
        {
            setProdutoDeEntrega(produtoDeEntrega);
        }

        public int getId()
        {
            return this.id;
        }

        public string getProdutoDeEntrega()
        {
            return this.produtoDeEntrega;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setProdutoDeEntrega(string produtoDeEntrega)
        {
            this.produtoDeEntrega = produtoDeEntrega;
        }

        public bool getBuzinaCaminhao()
        {
            return this.buzinaCaminhao;
        }

        public void setBuzinaCaminhao(bool buzinaCaminhao)
        {
            this.buzinaCaminhao = buzinaCaminhao;
        }
       
        public void fazerEntrega()
        {
            Console.WriteLine("\n Vou entregar meu produto de " + getProdutoDeEntrega());
        }

        public void Buzinar()
        {
            if(getBuzinaCaminhao() == true)
            {
                Console.WriteLine("\n Este caminhão possui buzina. Vamos usar:");
                Console.WriteLine("FOM!!");
            }else
            {
                Console.WriteLine("\n Sem buzina neste caminhão!");
            }
        }

    }
}