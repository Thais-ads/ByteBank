using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Titular;

namespace ByteBank.Contas
{

    //definição de uma classe com os seus atributos publicos e visiveis; 
    public class ContaCorrente
    {

        public int numero_agencia;

        public Cliente titular;

        public string conta;

        public double saldo;

        //criando um Medodo ;
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {

                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Transferir(double valor, ContaCorrente transferencia)
        {
            if (saldo <= valor)
            {
                Console.WriteLine("Transferencia insuficiente;");
                return false;

            }
            else
            {
                //double recebe = this.saldo - valor;
                //transferencia.saldo += valor;
                //this.saldo = recebe; 

                Sacar(valor);
                transferencia.Depositar(valor);

                return true;
            }
        }
    }




}