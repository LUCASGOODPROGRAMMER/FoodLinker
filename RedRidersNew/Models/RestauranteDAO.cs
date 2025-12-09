using Microsoft.AspNetCore.Razor.TagHelpers;
using RedRidersNew.Configs;

namespace RedRidersNew.Models
{
    public class RestauranteDAO
    {
        private readonly Conexao _conexao;

        public RestauranteDAO(Conexao conexao)
        {
            _conexao = conexao;
        }

        public void CadastrarRestaurante(Restaurante restaurante)
        {
            try
            {
                var comando = _conexao.CreateCommand("INSERT INTO restaurante VALUES (null, @_nome_fantasia_restaurante, @_razao_social_restaurante, @_imagem_restaurante, @_cnpj_restaurante, @_cep_restaurante, @_rua_restaurante, @_numero_restaurante, @_complemento_restaurante, @_bairro_restaurante, @_cidade_restaurante, @_estado_restaurante, @_ponto_de_referencia_restaurante, @_nome_do_dono_restaurante, @_cpf_do_dono_restaurante) ");

                comando.Parameters.AddWithValue("@_nome_fantasia_restaurante", restaurante.Nome_Fantasia_Restaurante);
                comando.Parameters.AddWithValue("@_razao_social_restaurante", restaurante.Razao_Social_Restaurante);
                comando.Parameters.AddWithValue("@_imagem_restaurante", restaurante.Imagem_Restaurante);
                comando.Parameters.AddWithValue("@_cnpj_restaurante", restaurante.Cnpj_Restaurante);
                comando.Parameters.AddWithValue("@_cep_restaurante", restaurante.Cep_Restaurante);
                comando.Parameters.AddWithValue("@_rua_restaurante", restaurante.Rua_Restaurante);
                comando.Parameters.AddWithValue("@_numero_restaurante", restaurante.Numero_Restaurante);
                comando.Parameters.AddWithValue("@_complemento_restaurante", restaurante.Complemento_Restaurante);
                comando.Parameters.AddWithValue("@_bairro_restaurante", restaurante.Bairro_Restaurante);
                comando.Parameters.AddWithValue("@_cidade_restaurante", restaurante.Cidade_Restaurante);
                comando.Parameters.AddWithValue("@_estado_restaurante", restaurante.Estado_Restaurante);
                comando.Parameters.AddWithValue("@_ponto_de_referencia_restaurante", restaurante.Ponto_De_Referencia_Restaurante);
                comando.Parameters.AddWithValue("@_nome_do_dono_restaurante", restaurante.Nome_Do_Dono_Restaurante);
                comando.Parameters.AddWithValue("@_cpf_do_dono_restaurante", restaurante.Cpf_Do_Dono_Restaurante);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Restaurante> ListarRestaurantes()
        {
            var lista = new List<Restaurante>();

            try
            {
                var comando = _conexao.CreateCommand(@"
                    SELECT 
                        id_restaurante,
                        nome_fantasia_restaurante,
                        razao_social_restaurante,
                        imagem_restaurante,
                        cnpj_restaurante,
                        cep_restaurante,
                        rua_restaurante,
                        numero_restaurante,
                        complemento_restaurante,
                        bairro_restaurante,
                        cidade_restaurante,
                        estado_restaurante,
                        ponto_de_referencia_restaurante,
                        nome_do_dono_restaurante,
                        cpf_do_dono_restaurante
                    FROM restaurante
                ");

                using var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var restaurante = new Restaurante
                    {
                        Id_Restaurante = reader.GetInt32("id_restaurante"),
                        Nome_Fantasia_Restaurante = reader.GetString("nome_fantasia_restaurante"),
                        Razao_Social_Restaurante = reader.GetString("razao_social_restaurante"),
                        Imagem_Restaurante = reader.GetString("imagem_restaurante"),
                        Cnpj_Restaurante = reader.GetString("cnpj_restaurante"),
                        Cep_Restaurante = reader.GetString("cep_restaurante"),
                        Rua_Restaurante = reader.GetString("rua_restaurante"),
                        Numero_Restaurante = reader.GetString("numero_restaurante"),
                        Complemento_Restaurante = reader.GetString("complemento_restaurante"),
                        Bairro_Restaurante = reader.GetString("bairro_restaurante"),
                        Cidade_Restaurante = reader.GetString("cidade_restaurante"),
                        Estado_Restaurante = reader.GetString("estado_restaurante"),
                        Ponto_De_Referencia_Restaurante = reader.GetString("ponto_de_referencia_restaurante"),
                        Nome_Do_Dono_Restaurante = reader.GetString("nome_do_dono_restaurante"),
                        Cpf_Do_Dono_Restaurante = reader.GetString("cpf_do_dono_restaurante")
                    };

                    lista.Add(restaurante);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

    }
}
