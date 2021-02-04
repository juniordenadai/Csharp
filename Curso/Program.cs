﻿using Course;
using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            /* aula de triangulo - caucular area
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com as medidas do triangulo Y");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p - x.A)* (p-x.B)*(p - x.C);

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p - y.A) * (p - y.B) * (p - y.C);

            Console.WriteLine("Area de X:" + areaX);
            Console.WriteLine("Area de Y:" + areaY);

            if (areaX > areaY)
            {
                Console.WriteLine("TRiangulo X é maior que triangulo Y");
            }
            else
                Console.WriteLine("TRiangulo Y é maior que triangulo X");

            //fim aula triangulo

            */

            /*exercicio 01 - dados de pessoa

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Entre com osdados da pessoa");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Entre com a Idade da Pessoa");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com osdados da pessoa");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Entre com a Idade da Pessoa");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"{p1.Nome} é mais velho(a)");
            }
            else
            {
                Console.WriteLine($"{p2.Nome} é mais velho(a)");
            }

            */

            /*exercicio 2

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Entre com os dados da pessoa");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Entre com salario da Pessoa");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados da pessoa");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Entre com salario da Pessoa");
            f2.Salario = double.Parse(Console.ReadLine());

            double salarioMedio = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine(salarioMedio);
            */

            /*/Aula 42 Produto

            Produto p1 = new Produto();

            Console.Write("Entre com Nome do Produto: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Entre com Preço do Produto: ");
            p1.Preco = double.Parse(Console.ReadLine());
            Console.Write("Entre com Quantidade do Produto: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(p1);

            Console.WriteLine("Entre com a quantidade a ser adicionada ");
            int qtd = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(qtd);
            Console.WriteLine("Dados Atualizados: "+ p1);

            Console.WriteLine("Entre com a quantidade a ser removida ");
            qtd = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(qtd);
            Console.WriteLine("Dados Atualizados: " + p1);*/

            /*exercicio 1 - fixacao
            //calcular area, perimetro e diagonal de um retangulo
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largula e altura de um retangulo: " );
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());
            
            Console.WriteLine("largura :" + r.Largura + " Altura: " +  r.Altura+ " Area:  " + r.CalcularArea() + " perimetro: " + r.CalcularPerimetro()+ " Diagonal: "+ r.CalcularDiagonal());


            */
            //exercicio 2 (funcionario)

            Funcionario pessoa = new Funcionario();
            
            Console.Write("Entre com Nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Entre com Salario: ");
            pessoa.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Entre com Imposto: ");
            pessoa.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(pessoa);

            Console.Write("Entre com porcentagem aumento salario: ");
            double porcentagem = double.Parse(Console.ReadLine());
            pessoa.AumentarSalario(porcentagem);
            Console.WriteLine("dados atualizados: " + pessoa);

        }
    }
}