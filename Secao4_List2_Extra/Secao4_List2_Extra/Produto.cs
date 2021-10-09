using System;

namespace Secao4_List2_Extra
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdiconarProtuos(int quant)
        {
            Quantidade += quant;
        }

        public void RemoverProdutos(int quant)
        {
            Quantidade -= quant;
        }

        public override string ToString()
        {
            return $"{Nome}, {Preco:C2}, {Quantidade} unidades, Total: {ValorTotalEmEstoque():C2}";
        }


    }
}
