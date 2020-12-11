namespace pagamento_com_cartão.classes
{
    public class boleto : pagamento
    {
        private string codigoDeBarras ;
        public string CodigoDeBarras {get {return codigoDeBarras;} set {codigoDeBarras= $"00000323454224464337{Valor}";}}
         
    }
}