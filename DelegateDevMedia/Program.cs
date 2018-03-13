using System;

namespace DelegateDevMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            pedido.Pagar += Pedido_Pagar;
            pedido.Fechar(2000);
            Console.ReadLine();
        }

        private static void Pedido_Pagar(double valor)
        {
            Console.WriteLine($"Pago boleto no valor de {valor}");
        }
    }
}
