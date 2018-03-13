using System;

namespace DelegateDevMedia
{
    public delegate void PagarEvent(double valor);
    public class Boleto
    {
        public void Pagar(double valor)
        {
            Console.WriteLine($"Boleto pago no valor de {valor}");
        }
    }

    public class Pedido
    {
        public event PagarEvent Pagar;

        public void Fechar(double valor)
        {
            // Delegação
            this.Pagar(valor);
        }
    }
}
