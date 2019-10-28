using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiImc.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoIMCController : ApiController
    {
        /// <summary>
        /// Metodo "Get" quando levado get em seu nome do meto o .net web api
        /// identifica automaticamente que esta função e uma função de 
        /// resposta "GET" em nosso protoco HTTP
        /// </summary>
        /// <returns>retorna o texto informado que esta ativo corretamente</returns>
        public string Get()
        {
            //Informo que minha api esta rodando normalmente
            return "Olá você está conectado na WebAPI";
        }
       
        /// <summary>
        /// Metodo que retorna nosso calculo de imc o mesmo e identificado pela
        /// webapi de acordo com os parametros, já que o mesmo contem tem o nome 
        /// igual ao metodo superio
        /// </summary>
        /// <param name="peso">Peso</param>
        /// <param name="altura">Altura</param>
        /// <param name="nome">Nome da pessoa que foi informado Peso e Altura</param>
        /// <returns>retorna nossa api com seu imc calculado</returns>
        public string Get(double peso,double altura,string nome)
        {
            //Temos nossa regra de negocio calculando o imc
            var imc = peso / (altura * altura);
            //Aqui temos o retorno do texto de acordo com a solicitação da questão
            return $"Olá {nome} seu IMC é {imc} e ele foi calculado de acordo com sua Altura:{altura} e Peso:{peso}";
        }

    }
}
