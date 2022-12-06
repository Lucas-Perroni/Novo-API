using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API_X.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NovaPesquisa : ControllerBase
    {
        [HttpGet]
        public string List(string p_nome_produto)

        {
            string Chaveconexao = "Data Source=10.39.45.44;Initial Catalog=TI_Noite;User ID=Turma2022;Password=Turma2022@2022";
            DataSet resultadoCEP2 = new DataSet();


            SqlConnection Conexao = new SqlConnection(Chaveconexao);
            Conexao.Open();

            string wQuery = $"select * from Produto where Nome_produto like '%{p_nome_produto}%' ";
            SqlDataAdapter adapter = new SqlDataAdapter(wQuery, Conexao);
            adapter.Fill(resultadoCEP2);

            string json = JsonConvert.SerializeObject(resultadoCEP2, Formatting.Indented);

            return json;
        }
        [HttpPost]
        public string List2(string p_nome)

        {
            string Chaveconexao = "Data Source=10.39.45.44;Initial Catalog=TI_Noite;User ID=Turma2022;Password=Turma2022@2022";
            DataSet resultadoCEP3 = new DataSet();


            SqlConnection Conexao = new SqlConnection(Chaveconexao);
            Conexao.Open();

            string wQuery = $"select * from Contatos where GivenName like '%{p_nome}%' ";
            SqlDataAdapter adapter = new SqlDataAdapter(wQuery, Conexao);
            adapter.Fill(resultadoCEP3);

            string json = JsonConvert.SerializeObject(resultadoCEP3, Formatting.Indented);

            return json;
        }
    }
}
