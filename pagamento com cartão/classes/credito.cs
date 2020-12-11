using System;
namespace pagamento_com_cartão.classes
{
    public class credito : cartao
    {
        private float limite = 3000;
        public float Limite {get {return limite;}set{}}
    }
}