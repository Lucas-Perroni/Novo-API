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
    public class ValuesController2 : ControllerBase
    {
        [HttpGet]
        public string List3(string p_nome1)

        {
            string Chaveconexao = "Data Source=10.39.45.44;Initial Catalog=BancoAula;User ID=Turma2022;Password=Turma2022@2022";
            DataSet resultadoCEP2 = new DataSet();


            SqlConnection Conexao = new SqlConnection(Chaveconexao);
            Conexao.Open();

            string wQuery = $"select * from Paloma where Nome like '%{p_nome1}%' ";
            SqlDataAdapter adapter = new SqlDataAdapter(wQuery, Conexao);
            adapter.Fill(resultadoCEP2);

            string json = JsonConvert.SerializeObject(resultadoCEP2, Formatting.Indented);

            return json;
        }
    }
}
