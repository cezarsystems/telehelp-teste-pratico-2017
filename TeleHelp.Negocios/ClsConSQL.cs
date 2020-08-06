using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using TeleHelp.Modelos;

namespace TeleHelp.Negocios
{
    public class ClsConSQL
    {
        string _con = ConfigurationManager.ConnectionStrings["_con_database_telehelp"].ConnectionString;
        ClsModelos modelos = new ClsModelos();

        public DataTable DTUtilizadorSistema(string usuario, string senha)
        {
            using (var con = new SqlConnection(_con))
            {
                using (var adaptador = new SqlDataAdapter(string.Format("sp_consulta_utilizador '{0}', '{1}'", usuario, senha), con))
                {
                    DataTable dt = new DataTable();
                    dt.TableName = "TabelaRetornoUtilizador";
                    adaptador.Fill(dt);
                    return dt;
                }
            }      
        }
        
        public DataTable DTBuscaTodosRegistros()
        {
            using (var con = new SqlConnection(_con))
            {
                using(var cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM vw_busca_tds_reg";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    using(var adaptador = new SqlDataAdapter(cmd.CommandText, con))
                    {
                        DataTable dt = new DataTable();
                        dt.TableName = "TodosRegistros";
                        adaptador.Fill(dt);

                        return dt;
                    }
                }
            }
        }

        public DataTable DTCarregaComboCargos()
        {
            string _query = "SELECT CARGO FROM [dbo].[SISCadastroFuncionarios]";

            using (var con = new SqlConnection(_con))
            {
                using (var adaptador = new SqlDataAdapter(_query, con))
                {
                    DataTable dt = new DataTable();
                    dt.TableName = "TabelaRetornoCargos";
                    adaptador.Fill(dt);
                    return dt;
                }
            }
        }

        public DataSet BuscandoRegistros(string nome, int id, string cargo)
        {
            modelos.NomeFuncionario = nome;
            modelos.IdFuncionario = id;
            modelos.CargoFuncionario = cargo;

            using (var con = new SqlConnection(_con))
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;

                    StringBuilder builderString = new StringBuilder();
                    builderString.Append("sp_busca_registros_opcoes ");
                    builderString.Append(string.Format("'{0}', ", modelos.NomeFuncionario));
                    
                    if(modelos.IdFuncionario == int.MinValue)
                        builderString.Append("null, ");
                    else
                        builderString.Append(string.Format("{0}, ", modelos.IdFuncionario));

                    builderString.Append(string.Format("'{0}'", modelos.CargoFuncionario));

                    cmd.CommandText = builderString.ToString();

                    using (var adaptador = new SqlDataAdapter(cmd.CommandText, con))
                    {
                        DataSet ds = new DataSet();
                        adaptador.Fill(ds);
                        return ds;
                    }
                }                                                  
            }                                
        }

        public bool InserindoAlterandoFuncionario(string nome, DateTime dtNascimento, string cargo, int idade, int flag, int idFuncionario = -1)
        {
            string _query = string.Empty;

            if (flag == 1)
                _query = "sp_insere_funcionario";
            else
                _query = "sp_altera_funcionario";

            modelos = new ClsModelos();
            modelos.NomeFuncionario = nome;            
            modelos.DataNascimento = dtNascimento.Date;
            modelos.CargoFuncionario = cargo;
            modelos.IdadeFuncionario = idade;
            modelos.IdFuncionario = idFuncionario;

            using (var con = new SqlConnection(_con))
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = _query;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = modelos.NomeFuncionario;
                    cmd.Parameters.Add("@dtNascimento", SqlDbType.DateTime).Value = modelos.DataNascimento;
                    cmd.Parameters.Add("@cargo", SqlDbType.VarChar).Value = modelos.CargoFuncionario;
                    cmd.Parameters.Add("@idade", SqlDbType.Int).Value = modelos.IdadeFuncionario;
                   
                    if(idFuncionario != -1 && flag != 1)
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = modelos.IdFuncionario;

                    try
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException)
                    {
                        return false;                    
                    }
                }
            }                    
        }

        public int DeletandoFuncionario(int idFuncionario)
        {
            using (var con = new SqlConnection(_con))
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = string.Format("DELETE FROM [dbo].[SISCadastroFuncionarios] WHERE [IdFuncionario] = {0}", idFuncionario);

                    try
                    {
                        if (con.State == ConnectionState.Closed)
                            con.Open();

                        int linhaAfetada = cmd.ExecuteNonQuery();
                        
                        return linhaAfetada;
                    }
                    catch (Exception)
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
