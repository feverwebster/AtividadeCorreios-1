using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApiImc.Models;

namespace WebApiImc.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculoIMCController : ApiController
    {
        //criamos nossalisata de objetos
        List<ObjectImc> listaDeObjetos = new List<ObjectImc>()

        {
        new ObjectImc(){Nome = "Felipe"},
          new ObjectImc(){Nome = "Web"},
            new ObjectImc(){Nome = "CIlba"},
        };
        public List<ObjectImc> Get()
        {
            return listaDeObjetos;
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



        public ObjectImc Post( ObjectImc values)
        {
            ObjectImc imcCalc = values;
            imcCalc.ImcValue = imcCalc.Peso / (imcCalc.Altura * imcCalc.Altura);

            listaDeObjetos.Add(imcCalc);

            return imcCalc;
        }

    }
}
