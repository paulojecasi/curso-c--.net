﻿using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorTotal = 0;
            int addQtEstoque = 0, delQtEstoque = 0;

            Produto produto = new Produto();

            //----- dados do produto - entrada

            Console.Write("Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a quantidade de produtos para entrada no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
     
            valorTotal = produto.ValorTotalEmEstoque();
            Console.WriteLine("Dados do produto----------------------------------------------");
            Console.WriteLine(produto);
       

            //----- atualizando - adicionando quantidades 

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            addQtEstoque = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(addQtEstoque);
            valorTotal = produto.ValorTotalEmEstoque();
            Console.WriteLine("Dados atualizados--------------------------------------------");
            Console.WriteLine(produto);


            //----- atualizando - subtraindo quantidades 

            Console.Write("Digite o numero de produtos a ser retirado do estoque: ");
            delQtEstoque = int.Parse(Console.ReadLine());

            produto.RemoverProdutos(delQtEstoque);
            valorTotal = produto.ValorTotalEmEstoque();
            Console.WriteLine("Dados atualizados--------------------------------------------");
            Console.WriteLine(produto);

        }

        
    }
}
