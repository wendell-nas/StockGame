using StockApp.Core.Entidades;
using StockApp.Data.SqlServer.DataContexto;
using Dapper;
using StockApp.Core.Repository;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Reflection.Metadata;
using StockApp.Core.Entidades.Comun;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace StockApp.Data.SqlServer.Repositorio
{
    public class ColaboradorRepository : IColaboradorRepository
    {
        public bool Deletar(int id)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {
                    connection.Open();

                    // Construa o comando SQL para o DELETE
                    string sql = @"DELETE FROM Colaborador WHERE Id = @Id";

                    // Execute o comando SQL usando Dapper
                    connection.Execute(sql, new { Id = id });

                    var linhasAfetadas = connection.Execute(sql);

                    if (linhasAfetadas == 1) return true;

                    return false;
                }
            }
            catch (Exception )
            {
                throw ;
            }
        }

        public bool Incluir(Colaborador1 colaborador)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {
                    connection.Open();
                    //-------------------ENDERECO-------------------

                    string sqlEnde = @" INSERT INTO Endereco (Cep, Estado, Cidade, Bairro, Rua, Numero)
                                    OUTPUT INSERTED.Id  
                                    VALUES
                                    (@Cep, @Estado, @Cidade, @Bairro, @Rua, @Numero)";
                    
                    var parametrosEndereco = new DynamicParameters();
                    parametrosEndereco.Add("@Cep", colaborador.Cep);
                    parametrosEndereco.Add("@Estado", colaborador.Estado);
                    parametrosEndereco.Add("@Cidade", colaborador.Cidade);
                    parametrosEndereco.Add("@Bairro", colaborador.Bairro);
                    parametrosEndereco.Add("@Rua", colaborador.Rua);
                    parametrosEndereco.Add("@Numero", colaborador.Numero);

                    int IdEndereco = connection.QueryFirst<int>(sqlEnde, colaborador);

                    //---------------------TELEFONE--------------------

                    string sqlTele = @"INSERT INTO Telefone 
                                      (Numero)
                                    OUTPUT INSERTED.Id 
                                    VALUES (@Numero)";

                    var parametrosTelefone = new DynamicParameters();
                    parametrosTelefone.Add("@Numero", colaborador.Telefone);

                    int IdTelefone = connection.QueryFirst<int>(sqlTele, colaborador);


                    //------------------------CARGO------------------

                    string sqlCargo = @"INSERT INTO Cargo (NomeCargo, DepartamentoId) OUTPUT INSERTED.Id 
                                        VALUES 
                                        (@NomeCargo, @DepartamentoId);";

                    var parametrosCargo = new DynamicParameters();
                    parametrosCargo.Add("@NomeCargo", colaborador.Cargo);

                    int IdDepartamento = connection.QueryFirst<int>(sqlCargo, colaborador);


                    //-----------------------COLABORADOR----------------

                    string sqlColab = @"INSERT INTO Colaborador 
                                       (DepartamentoId, Departamento, Nome, Cpf, Email, DataNascimento,
                                       TelefoneId, EnderecoId, Status, CriadoEm, CriadoPor, AlteradoEm, AlteradoPor) 
                                    VALUES 
                                       (@DepartamentoId, @Departamento, @Nome, @Cpf, @Email, @DataNascimento,
                                       @TelefoneId, @EnderecoId, @Status, @CriadoEm, @CriadoPor, @AlteradoEm, @AlteradoPor)";

                    var parametrosColab = new DynamicParameters();
                    parametrosColab.Add("@DepartamentoId", IdDepartamento);
                    parametrosColab.Add("@Departamento", colaborador.Departamento);
                    parametrosColab.Add("@Nome", colaborador.Nome);
                    parametrosColab.Add("@Cpf", colaborador.Cpf);
                    parametrosColab.Add("@Email", colaborador.Email);
                    parametrosColab.Add("@DataNascimento", colaborador.DataNascimento);
                    parametrosColab.Add("@TelefoneId", IdTelefone);
                    parametrosColab.Add("@EnderecoId", IdEndereco);
                    parametrosColab.Add("@Status", colaborador.Status);
                    parametrosColab.Add("@CriadoEm", colaborador.CriadoEm);
                    parametrosColab.Add("@CriadoPor", colaborador.CriadoEm);
                    parametrosColab.Add("@AlteradoEm", colaborador.AlteradoEm);
                    parametrosColab.Add("@AlteradoPor", colaborador.AlteradoPor);


                    var linhasAfetadas = connection.Execute(sqlColab, colaborador);

                    return linhasAfetadas == 1;
                }
            }
            catch (Exception ex)
            {
                // Faça algo com a exceção, como logar ou lançar uma exceção personalizada com uma mensagem descritiva
                throw new Exception("Erro ao incluir Colaborador.", ex);
            }

        }

        public List<Colaborador1> ObterTodos()
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {
                    var sql = @"SELECT * FROM Colaborador";

                    /*@"SELECT
                            Colaborador.Id AS colaboradorId,
                            Colaborador.NomeColaborador AS nome,
                            Colaborador.Cpf AS cpf,
                            Colaborador.Email AS email,
                            Colaborador.DataNascimento AS dataNascimento,
                            Colaborador.CriadoEm AS criadoEm,
                            Colaborador.CriadoPor AS criadoPor,
                            Colaborador.AlteradoEm AS alteradoEm,
                            Colaborador.AlteradoPor AS alteradoPor,
                            Colaborador.Status AS status,
                            Cargo.Id AS cargoId,
                            Cargo.NomeCargo AS cargo,
                            Endereco.Id AS enderecoId,
                            Endereco.Cep AS cep,
                            Endereco.Estado AS estado,
                            Endereco.Cidade AS cidade,
                            Endereco.Bairro AS bairro,
                            Endereco.Rua AS rua,

                            Endereco.Numero AS numero,
                            Telefone.Numero AS telefone
                        FROM
                            Colaborador
                        INNER JOIN Cargo ON Colaborador.CargoId = Cargo.Id
                        INNER JOIN Endereco ON Colaborador.EnderecoId = Endereco.Id
                        INNER JOIN Telefone ON Colaborador.TelefoneId = Telefone.Id";
                    */

                    var colaboradores = connection.Query<Colaborador1>(sql);


                    return colaboradores.ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool Atualizar(Colaborador1 colaborador)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {
                    connection.Open();

                    // Construa o comando SQL para o UPDATE
                    string sql = @"
                                    UPDATE Colaborador
                                    SET 
                                        Nome = @Nome,
                                        Cpf = @Cpf,
                                        Email = @Email,
                                        Departamento = @Departamento,
                                        DataNascimento = @DataNascimento,
                                        Status = @Status,
                                        CriadoEm = @CriadoEm,
                                        CriadoPor = @CriadoPor,
                                        AlteradoEm = @AlteradoEm,
                                        AlteradoPor = @AlteradoPor
                                    WHERE Id = @Id";

                    // Execute o comando SQL usando Dapper



                    //Protege os valores que estão chegando pela Classe Cargo de SqlInjection
                    //E passa para o Dapper Substituir no "var sql" os valores @ pelo valor que chegou
                    //no parametro.
                    var parametros = new DynamicParameters();
                    parametros.Add("@Nome", colaborador.Nome);
                    parametros.Add("@Cpf", colaborador.Cpf);
                    parametros.Add("@Email", colaborador.Email);
                    parametros.Add("@Departamento", colaborador.Departamento);
                    parametros.Add("@DataNascimento", colaborador.DataNascimento);
                    parametros.Add("@Status", colaborador.Status);
                    parametros.Add("@CriadoEm", colaborador.CriadoEm);
                    parametros.Add("@CriadoPor", colaborador.CriadoEm);
                    parametros.Add("@AlteradoEm", colaborador.AlteradoEm);
                    parametros.Add("@AlteradoPor", colaborador.AlteradoPor);

                    connection.Execute(sql, colaborador);


                    var resultado = connection.Execute(sql, parametros);

                    if (resultado == 1) return true;
                    return false;
                }

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Colaborador1> ObterDepartamento()
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {
                    var sql = "SELECT Departamento FROM Colaborador";

                   
                    var colaboradores = connection.Query<Colaborador1>(sql);
                    

                    return colaboradores.ToList();
                }
            }
            catch (Exception )
            {

                throw;
            }
        }

        public List<Colaborador1> FiltrarDepartamento(string departamento)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {
                    var sql = "SELECT * FROM Colaborador WHERE Departamento = @Departamento";

                    var parametro = new DynamicParameters();
                    parametro.Add("@Departamento", departamento);

                    var departamentos = connection.Query<Colaborador1>(sql, parametro);

                    return departamentos.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Colaborador1> ObterPorId(int id)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {

                    var sql = @"SELECT * FROM Colaborador WHERE Id = @Id";

                    //Cria os parametros 
                    var parametros = new DynamicParameters();
                    parametros.Add("@Id", id);
                    var colaboradores = connection.Query<Colaborador1>(sql, parametros);

                     return colaboradores.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

       

        public List<Colaborador1> ObterTodosPorStatus(int status)
        {
            try
            {
                using (var connection = new SqlConnection(SqlServerConnection.Conexao))
                {

                    
                    var sql = "SELECT * FROM Colaborador WHERE Status = @Status";

                    //Cria os parametros 
                    var parametros = new DynamicParameters();
                    parametros.Add("@Status", status);
                    var colaboradores = connection.Query<Colaborador1>(sql, parametros);

                    return colaboradores.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public List<Colaborador> ObterPorEmail(Colaborador colaborador)
        {
            using(var connection = new SqlConnection(SqlServerConnection.Conexao))
            {
                try
                {
                    var sql = @"SELECT * FROM Colaborador WHERE Email = @email";

                    var parametros = new DynamicParameters();
                    parametros.Add("@email", colaborador.Email);

                    var resultado = connection.Query<Colaborador>(sql, parametros);

                    return resultado.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
               ;
            }
        }

        public bool AtualizarSenha(Colaborador colaborador)
        {
            using(var connection = new SqlConnection( SqlServerConnection.Conexao))
            {
                var sql = @"UPDATE Colaborador SET Senha = @senha, AlteradoEm = @alteradoEm, AlteradoPor = @alteradoPor
                            WHERE Email = @email";

                var parametros = new DynamicParameters();

                parametros.Add("@email", colaborador.Email);
                parametros.Add("@senha", colaborador.Senha);
                parametros.Add("@alteradoEm", DateTime.Now);
                parametros.Add("@alteradoPor", "Recuperação de senha");

                var resultado = connection.Execute(sql, parametros);

                if (resultado == 1) return true;
                return false;
                

            }
        }
    }
}
