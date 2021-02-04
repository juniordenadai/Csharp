using System;

namespace Curso
{
	public class Funcionario
	{
		public string Nome;
		public double SalarioBruto;
		public double Imposto;
		public double SalarioLiquido()
		{
			return SalarioBruto - Imposto;
		}

		public void AumentarSalario(double porcentagem)
        {
			SalarioBruto = SalarioBruto + (SalarioBruto * (porcentagem / 100));
        }


		public override string ToString()
		{
			return Nome
				+ ", Salario Bruto: R$ "
				+ SalarioBruto.ToString("F2")
				+ " , Imposto $: "
				+ Imposto.ToString("F2")
				+ " , Salario Liquido $: "
				+ SalarioLiquido().ToString("F2"); 
		}
	}
}