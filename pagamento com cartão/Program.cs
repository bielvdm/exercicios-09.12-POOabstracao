using System;
using pagamento_com_cartão.classes;

namespace pagamento_com_cartão
{
    class Program
    {
        static void Main(string[] args)
        {   int Escolha; 
            bool refazer=true;
            boleto boleto = new boleto ();
            cartao cartao = new cartao ();
            credito credito = new credito ();
            debito debito = new debito ();
            boleto.Valor=750;
                do{
                System.Console.WriteLine("Qual é o valor desejado para efetuar o pagamento?");
                boleto.Valor= double.Parse (Console.ReadLine());
                Console.WriteLine("Escolha um método de pagamento:\n[1] boleto\n[2] cartão\n[3] encerrar");
                Escolha = int.Parse(Console.ReadLine());
                switch(Escolha){
                    case 1 :
                    System.Console.WriteLine($"Copie a sequência do código de barras abaixo e pague em até 2 dias úteis.");
                    System.Console.WriteLine($"00000323454224464337{boleto.Valor}");
                    break;

                    case 2 :
                    while(refazer==true){
                    System.Console.WriteLine("ESCOLHA UMA OPÇÃO:\n[1] crédito\n[2] débito");
                    cartao.CouD=int.Parse(Console.ReadLine());
                            System.Console.WriteLine("Digite o número do cartão: ");
                            cartao.numero = Console.ReadLine();
                            System.Console.WriteLine("Digite o nome completo do titular: ");
                            cartao.titular = Console.ReadLine();
                            System.Console.WriteLine("Digite a bandeira: ");
                            cartao.bandeira = Console.ReadLine();
                            System.Console.WriteLine("Digite o cvv: ");
                            cartao.cvv = Console.ReadLine();
                            System.Console.WriteLine($"CONFIRMANDO DADOS PARA REALIZAR A COMPRA...");
                            System.Console.WriteLine($"NOME DO TITULAR: {cartao.titular}");System.Console.WriteLine($"NÚMERO DO CARTÃO: {cartao.numero}");System.Console.WriteLine($"CVV: {cartao.cvv}");System.Console.WriteLine($"BANDEIRA: {cartao.bandeira}");
                    switch(cartao.CouD){

                        case 1 :
                        System.Console.WriteLine($"Escolha a parcela que você deseja pagar:\n[1] 1x de {boleto.Valor} reais S/juros\n[2] 2x de {boleto.Valor / 2} reais S/juros\n[3] 3x de {(boleto.Valor + (boleto.Valor * 0.08)) / 3} com 8% de juros");
                        int escolhaC = int.Parse(Console.ReadLine());

                        switch (escolhaC){

                        case 1 : 
                        System.Console.WriteLine($"A compra será em 1x de {boleto.Valor}...\nCOMPRA EFETUADA");
                        break;
                        case 2 :
                        System.Console.WriteLine($"A compra será em 2x de {boleto.Valor/2}...\nCOMPRA EFETUADA");
                        break;
                        case 3 :
                        System.Console.WriteLine($"A compra será em 3x de {(boleto.Valor + (boleto.Valor * 0.08)) / 3}...\nCOMPRA EFETUADA");break;
                        default: System.Console.WriteLine("opcão invalida");
                        break;}
                        
                        System.Console.WriteLine($"Seu limite restante é de {credito.Limite - boleto.Valor}");
                        break;

                        case 2 :
                        if(debito.Saldo <boleto.Valor){
                            System.Console.WriteLine("COMPRA CANCELADA\nmotivo: saldo insuficiente");
                        }else{
                            System.Console.WriteLine($"COMPRA EFETUADA!\nRestam: {debito.Saldo - boleto.Valor} reais de saldo disponíveis no seu cartão.");
                        }
                        break;
                    }
                    } System.Console.WriteLine("Deseja refazer a compra? s/n");
                    string refazer1 = Console.ReadLine();
                    if(refazer1!="s"){
                        refazer=false;
                    }else{}

                    break;
                    case 3 :
                    System.Console.WriteLine("Agradecemos o uso da plataforma!");
                    break;

                    default: 
                    System.Console.WriteLine("opcão invalida");
                    break;
                }
            }while (Escolha != 3);
        }
    }
}
