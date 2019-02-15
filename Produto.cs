
using System.Globalization;

/// <summary>
/// Descrição resumida de Produto
/// </summary>
public class Produto
{
    /*
     ORDEM SUGERIDA ENCAPSULAMENTO - REGRA
     - ATRIBUTOS PRIVADOS
     - PROPRIEDADES AUTO IMPLEMENTADAS
     - CONSTRUTORES
     - PROPRIEDADES CUSTOMIZADAS
     - OUTROS METODOS DA CLASSE    
     
     */

namespace Course
{
    class Produto
    {
        private string _nome;  //- ATRIBUTOS PRIVADOS
        public double Preco { get; private set; } // - PROPRIEDADES AUTO IMPLEMENTADAS - QUANDO NÃO HÁ TRATAMENTO E RESTRINGIR GRAVAR ALGO NO PRECO COLOCANDO PRIVATE
        public double Quantidade { get; set; }
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade) //- CONSTRUTORES
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // - PROPRIEDADES CUSTOMIZADAS
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
    }



    // - OUTROS METODOS DA CLASSE
    public double ValorTotalEmEstoque
    {
        get { return Preco * Quantidade; }
    }
    public void AdicionarProdutos(int quantidade)
    {
        Quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade)
    {
        Quantidade -= quantidade;
    }
    public override string ToString()
    {
        return _nome
        + ", $ "
        + Preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + Quantidade
        + " unidades, Total: $ "
        + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
    }
}
}