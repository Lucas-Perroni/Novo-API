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
    public class ValuesController : ControllerBase
    {
        string Chaveconexao = "Data Source=10.39.45.44;Initial Catalog=PICozinha_Lucas;User ID=Turma2022;Password=Turma2022@2022";

        //[HttpGet]
        //public string Consulta(string p_cep)
        //{
        //    string resultadoCEP = string.Empty;

        //    resultadoCEP = "Retorno do processo de definido";

        //    return resultadoCEP;
        //}

        [HttpPost]
        public string List_Endereco(string p_UF)

        {                        
            DataSet resultadoCEP = new DataSet();
          
                SqlConnection Conexao = new SqlConnection(Chaveconexao);
                Conexao.Open();
             
                string wQuery = $"select * from Endereco where UF like '%{p_UF}%' ";
                SqlDataAdapter adapter = new SqlDataAdapter(wQuery, Conexao);
                adapter.Fill(resultadoCEP);

            string json = JsonConvert.SerializeObject(resultadoCEP, Formatting.Indented);

            return json;
        }

        [HttpGet]
        public string List(string p_nome)

        {
            DataSet resultadoCEP1 = new DataSet();

            SqlConnection Conexao = new SqlConnection(Chaveconexao);
            Conexao.Open();

            string wQuery = $"select * from Restaurante where Nome like '%{p_nome}%' ";
            SqlDataAdapter adapter = new SqlDataAdapter(wQuery, Conexao);
            adapter.Fill(resultadoCEP1);

            string json = JsonConvert.SerializeObject(resultadoCEP1, Formatting.Indented);

            return json;
        }

    }
}
