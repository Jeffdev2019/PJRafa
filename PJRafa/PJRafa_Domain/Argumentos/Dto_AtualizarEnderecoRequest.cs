namespace PJRafa_Domain.Argumentos
{
    public class Dto_AtualizarEnderecoRequest
    {
        public Dto_AtualizarEnderecoRequest()
        {

        }

        public Dto_AtualizarEnderecoRequest(int id_Endereco, string cEP, string logradouro, string cidade, string uF, string numero)
        {
            Id_Endereco = id_Endereco;
            CEP = cEP;
            Logradouro = logradouro;
            Cidade = cidade;
            UF = uF;
            Numero = numero;
        }

        public int Id_Endereco { get; set; }

        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        public string Numero { get; set; }
    }
}