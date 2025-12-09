using Microsoft.AspNetCore.Http.HttpResults;

namespace RedRidersNew.Models
{
    public class Restaurante
    {
        public int Id_Restaurante { get; set; }

        public string Nome_Fantasia_Restaurante { get; set; }
        public string Razao_Social_Restaurante { get; set; }
        public string? Imagem_Restaurante { get; set; }
        public string Cnpj_Restaurante { get; set; }
        public string Cep_Restaurante { get; set; }

        public string Rua_Restaurante { get; set; }
        public string Numero_Restaurante { get; set; }
        public string? Complemento_Restaurante { get; set; }
        public string Bairro_Restaurante { get; set; }
        public string Cidade_Restaurante { get; set; }
        public string Estado_Restaurante { get; set; }
        public string? Ponto_De_Referencia_Restaurante { get; set; }

        public string Nome_Do_Dono_Restaurante { get; set; }
        public string Cpf_Do_Dono_Restaurante { get; set; }
    }
}