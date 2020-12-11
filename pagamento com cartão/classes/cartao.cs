namespace pagamento_com_cartão.classes
{
    public class cartao
    {
        public string bandeira;
        public string numero;
        public string cvv;
        public string titular; 
        public int CouD;
        public string SalvarCartao (){
            return $"NOME DO TITULAR{titular}\nNÚMERO: {numero}\nBANDEIRA: {bandeira}\nCVV: {cvv}";
        }
    }
}