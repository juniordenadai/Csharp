using Course;
using System;
using System.Globalization;
using System.Collections.Generic;
using Curso.Entities;

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
            /*exercicio 2 (funcionario)

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
            */

            /* exercicio aluno
            Aluno pessoa = new Aluno();
            Console.Write("Digite o nome do Aluno: ");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Digite As tres notas do Aluno: ");
            pessoa.NotaPrimeiroTrimestre = double.Parse(Console.ReadLine());
            pessoa.NotaSegundoTrimestre = double.Parse(Console.ReadLine());
            pessoa.NotaTerceiroTrimestre = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final: " + pessoa.Notafinal());

            if (pessoa.Notafinal() > 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60 - pessoa.Notafinal()) + " PONTOS");
            }
            */

            /*
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Product { Nome = name, Price = price };
            }

            double sum = 0.0;
            for(int i = 0; i < n; i++)
            {
                sum += vect[i].Price; 
            }
            double avg = sum / n;

            Console.WriteLine("precomedio de produtos: " + avg);

        }
            */

            // vetor de alugueldequartos
            /*
            Console.WriteLine("how many rooms do you need?");
            int n = int.Parse(Console.ReadLine());
            Reserva[] reserva = new Reserva[10];

            for (int i = 0 ; i < n; i++)
            {
                Console.WriteLine("Entre com o nome do Hospede: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Entre com o email do Hospede: ");
                string email = Console.ReadLine();
                Console.WriteLine("Entre com o quarto desejado: ");
                int quarto = int.Parse(Console.ReadLine());

                reserva[quarto] = new Reserva { Nome = nome, Email = email, Room = quarto };

            }
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
                if (reserva[i] != null)
                {
                    Console.WriteLine(reserva[i]);
                }
            */
            /*
            int result = Calculator.Sum(5,5,5);
            Console.WriteLine( result);

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);


            int b = 10;
            int triple;
            Calculator.Triple3x(b, out triple);
            Console.WriteLine(triple);

            */

            /*listas
            List<string> list = new List<string>();
            */

            /*matriz

            int n;
            Console.WriteLine("entre com a dimensaoda matriz: ");
            n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n,n];
            Console.WriteLine("entre com os dados: ");

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j<n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("diagonal numbers: ");

            for (int i=0; i<n; i++)
            {
                Console.WriteLine(mat[i,i]);
            }

            int count = 0;
            for (int i=0; i < n; i++)
            {
                for(int j=0; j< n; j++)
                {
                    if(mat[i,j] < 0)
                    
                        count++;
                    
                }
            }
            Console.WriteLine("negative numbers: "+ count);

            */

            Console.Write("Entre com Numero de Empregados: ");
            int n = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            char outsourced;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee # {i} data");
                Console.Write("Outsourced (y/n) ");
                outsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                if (outsourced == 'Y' || outsourced == 'y')
                {
                    Console.WriteLine("Adittional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourceEmployee(name, hour, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hour, valuePerHour));
                }
            }

            Console.WriteLine("Payments:");
           
            
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp);
            }

        }
    }
}