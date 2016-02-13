using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tema3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classe pessoa
            Pessoa p = new Pessoa();
            p.setNome("João");
            p.setSobrenome("Fagundes Ferreira");
            p.setIdade(30);

            p.mostrarNomeCompleto();
            Console.WriteLine("Idade: {0}", p.getIdade());
            //fim classe pessoa

            Console.WriteLine("----------------------------------------------------");
            
            //classe funcionario
            Funcionario f = new Funcionario();

            f.setNome("Suelen");
            f.setSobrenome("Souza");
            f.setIdade(22);

            f.CodFuncionario = 123;
            f.Desconto = 200;

            
            f.mostrarNomeCompleto();

            Console.WriteLine("Idade: {0}", f.getIdade());
            Console.WriteLine("Cod.: {0}", f.CodFuncionario);
            Console.WriteLine("Salario: {0}", f.ValorSalario);

            f.SalarioBruto();
            //fim classe pessoa

            Console.WriteLine("----------------------------------------------------");

            //classe cliente
            Cliente c = new Cliente(3000);
            c.setNome("João");
            c.setSobrenome("Fagundes Ferreira");
            c.setIdade(30);
            c.codCliente = 963;
            
            c.mostrarNomeCompleto();
            Console.WriteLine("Idade: {0}", c.getIdade());
            Console.WriteLine("Cod.: {0}", c.codCliente);
            Console.WriteLine("Limite: {0}", c.limite);
            c.novaCompra(200);
            c.novaCompra(300);
            c.novaCompra(600);
            c.novaCompra(100);

            c.MostrarValorGasto();

            //fim classe funcionario
            Console.ReadKey();
        }
    }
}
