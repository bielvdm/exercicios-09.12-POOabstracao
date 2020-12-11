using System;

namespace pagamento_com_cartão.classes
{
    public abstract class pagamento
    {
        
        protected double valor; 
        public double Valor{get {return valor;} set{}}
        public string Cancelar (){
            return "";      
        }
    }
}