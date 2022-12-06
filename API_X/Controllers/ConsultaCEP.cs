using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_X.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaCEP : ControllerBase
    {
        //METODO GET
        [HttpGet]
        public string CEP(string p_cep)
        {
            string resultadoCEP = string.Empty;

            resultadoCEP = "Retorno do processo de definido";

            return resultadoCEP;
        }
        //METODO POST
        [HttpPost]
        public string CEP2(string p_cep)
        {
            string resultadoCEP = string.Empty;

            resultadoCEP = "Retorno do processo de definido";

            return resultadoCEP;
        }
    }
}
