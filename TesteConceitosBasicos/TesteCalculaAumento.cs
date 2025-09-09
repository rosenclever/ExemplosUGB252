using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConceitosBasicos.uteis;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class TesteCalculaAumento
    {
        [TestMethod]
        public void TesteCalcular()
        {
            //cenario
            decimal salario = 1000;
            float percentualAumento = 10;
            decimal valorAumento;
            CalculaAumento calculaAumento = new CalculaAumento();
            //ação
            valorAumento = calculaAumento.Calcular(salario, percentualAumento);

            //verificação
            Assert.AreEqual(100, valorAumento);
        }
    }
}
