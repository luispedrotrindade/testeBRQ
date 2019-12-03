namespace testeBRQ.Models
{ 
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public int IdPais{ get; set; }
    }
}