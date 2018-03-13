using System;

namespace DelegateDevMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            pedido.Fechar(2000);
            Console.ReadLine();
        }
    }
}
