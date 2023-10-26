//using ByteBank.Contas;
//using ByteBank.Titular;

////definindo uma classe do objeto ContaCorrente.

//Cliente cliente = new Cliente();
//cliente.Nome = "";
//cliente.profissa = "";
//cliente.cpf = "";


//ContaCorrente Pedro = new ContaCorrente();


//Pedro.numero_agencia = 1;
//Pedro.titular = cliente;
//Pedro.conta = "2TDSPJ";
//Pedro.saldo = 0;



//Pedro.numero_agencia = 1;
//Pedro.titular = cliente;
//Pedro.conta = "2TDSPJ";
//Pedro.saldo = 0;


////testando a referencia ..
//ContaCorrente conta = new ContaCorrente();

//conta.titular = new Cliente();

//conta.numero_agencia = 1;
//conta.titular.Nome = "jose";
//conta.titular.profissa = "tester";
//conta.titular.cpf = "49397316850";
//conta.conta = "2TDSPJ";
//conta.saldo = 10;


//Console.WriteLine($"A agencia de numero: {conta.numero_agencia}," +
//                  $" titular: {conta.titular}," +
//                  $" conta: {conta.conta}," +
//                  $" saldo de: {conta.saldo}");


//conta.Depositar(100);

//Console.WriteLine($"A conta da thais é de: {conta.saldo}");



//if (conta.Sacar(300) == true)
//    {
//    Console.WriteLine($"Saldo pos-saque: {conta.saldo}");
//    }
//else
//{
//    Console.WriteLine($"Saldo insuficiente para saque");
//}

//Console.WriteLine($" O Saldo atual da thais antes-transferencia é: {conta.saldo}");

//conta.Transferir(90, Pedro);

//Console.WriteLine($" O Saldo atual do pedro é: {Pedro.saldo}");
//Console.WriteLine($" O Saldo atual da thais pos-transferencia é: {conta.saldo}");



//ContaCorrente contaDoPedro = new ContaCorrente();
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.conta);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.saldo);



using ByteBank.Contas;
using ByteBank.Titular;

//ContaCorrente Testeconta = new ContaCorrente();

////testando os valores e metodos
//Testeconta.Setasaldo(200);

//Console.WriteLine($"testando o valor do metodo manipulado: {Testeconta.Getsaldo()}");



////Chamando no Main a função encapsulada da classe;
//Testeconta.Numero_Agencia=18;
//Console.WriteLine($"testensdo {Testeconta.Numero_Agencia}" );

ContaCorrente novaconta1 = new ContaCorrente(22, 2);
Console.WriteLine(ContaCorrente.totaldecontascriadas);



ContaCorrente novaconta = new ContaCorrente(21, 0);
Console.WriteLine(ContaCorrente.totaldecontascriadas);



ContaCorrente novaconta5 = new ContaCorrente(21, 0);
Console.WriteLine(ContaCorrente.totaldecontascriadas);

//definir alguns campos : numero agencia. numero conta.
//List<int> listaDeQuantidades = novaconta.Listaquantidadescontas(novaconta.conta);

//foreach (int quantidade in listaDeQuantidades)
//{
//    Console.WriteLine($"Quantidade na lista: {quantidade}");
//}




