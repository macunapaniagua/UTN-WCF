using Loteria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Loteria
{
    public class LoteriaNacional : ILoteriaNacional
    {
        public int NumeroGanador()
        {
            Random oRandom = new Random();
            return oRandom.Next();
        }

        public Premio PremioMayor()
        {
            Random oRandom = new Random();
            return new Premio()
            {
                Id = 5455,
                monto = 5000000000,
                premio = oRandom.Next()
            };
        }

        public void AgregarPremio(Premio premio)
        {
            
        }


        public double TipoCambio()
        {
            tipoCambio.wsIndicadoresEconomicosSoapClient oTipoCambio = new tipoCambio.wsIndicadoresEconomicosSoapClient("wsIndicadoresEconomicosSoap");
            var tipoCambio = oTipoCambio.ObtenerIndicadoresEconomicos("317", "14/03/2015", "14/03/2015", "UTN","N");

            return Convert.ToDouble(tipoCambio.Tables[0].Rows[0]["NUM_VALOR"].ToString());
        }
    }
}
