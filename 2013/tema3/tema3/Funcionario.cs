using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema3
{
    public class Funcionario : Pessoa
    {
        private int codFuncionario;
        private double valorSalario = 2000;
        private double desconto;

        public int CodFuncionario
        {
            get { return this.codFuncionario; }
            set { this.codFuncionario = value; }
        }

        public double ValorSalario
        {
            get { return this.valorSalario; }
        }

        public double Desconto
        {
            set { this.desconto = value; }
        }

        /// <summary>
        /// mostra o valor do salario do funcionario com descontos
        /// </summary>
        public void SalarioBruto()
        {
            double total = this.valorSalario - this.desconto;
            Console.WriteLine("Salario Bruto:  {0}", total);
        }
    }
}
