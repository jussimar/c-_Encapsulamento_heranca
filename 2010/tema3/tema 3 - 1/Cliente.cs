using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tema3
{
    public class Cliente : Pessoa
    {
        public int codCliente { get; set; }
        public double valorGasto { get; private set; }
        public double limite { get; private set; }

        /// <summary>
        /// metodo construtor 
        /// </summary>
        /// <param name="limite">passa o valor do limite de compras do cliente</param>
        public Cliente(double limite)
        {
            this.limite = limite;
        }

        /// <summary>
        /// faz a ção de uma nova compra debitando o valor da compra do limite do  cliente
        /// </summary>
        /// <param name="valor"></param>
        public void novaCompra(double valor)
        {
            this.valorGasto += valor;
            this.limite -= valor;
        }

        /// <summary>
        /// Exibe o valor gasto e o limite do cliente
        /// </summary>
        public void MostrarValorGasto()
        {
            Console.WriteLine("Valor Gasto: {0}", valorGasto);
            Console.WriteLine("Limite disponivel: {0}", limite); 
        }

    }
}
