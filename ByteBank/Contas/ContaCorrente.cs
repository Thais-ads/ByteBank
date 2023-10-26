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

        private int numero_agencia;
       
        public Cliente Titular;

        public static int totaldecontascriadas { get; private set; }

        public int conta;

        private double saldo=100;


        //construtor
        public ContaCorrente(int numero_agencia, int conta)
        {
            this.numero_agencia = numero_agencia;
            this.conta = conta;
            totaldecontascriadas++;
        }




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

        public void Setasaldo(double valor)
        {
            if (valor < 0)
            {
                return;
                //para a operaçao do metodo
            }
            else
            {
                this.saldo = valor;
            }
        }


        // esse metodo ele muda o valor real do atributo que esteja na mesma folha de rosto, e apos chamado no Program ele pode exibir.
        public double Getsaldo()
        {
            return this.saldo;
        }


        //Propriedades.
        public int Numero_Agencia
        {

            get { return this.numero_agencia; }

           //ele somente exibe dentro da mesma class
          private  set
            {

                if (value > 0)
                {
                    this.numero_agencia = value;

                }

            }


        }

        //totalizar a quantidade de contas;
        //public List<int> Listaquantidadescontas(int conta)
        //{
        //    List<int> qtdadescontas = new List<int> ();
            
        //    qtdadescontas.Add(conta);

        //    return qtdadescontas;


        //}
       


    }




}