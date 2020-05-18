using System;

namespace LogicaNegocio
{
    public class Envio
    {

        public static int CalcularVentaDeLicores(int TotalBotellas, int TipoLicor, bool Aniejo)
        {
            int PrecioTotal = 0, PrecioPorBotella = 0;
            

            if(TipoLicor == 1){
                if (Aniejo)
                {
                    PrecioPorBotella = 80000;
                }
                else
                {
                    PrecioPorBotella = 65000;
                }
            }
            else if(TipoLicor == 2)
            {
                if (Aniejo)
                {
                    PrecioPorBotella = 84000;
                }
                else
                {
                    PrecioPorBotella = 60000;
                }
            }
            else if (TipoLicor == 3)
            {
                if (Aniejo)
                {
                    PrecioPorBotella = 68000;
                }
                else
                {
                    PrecioPorBotella = 50000;
                }
            }
            else if (TipoLicor == 4)
            {
                if (Aniejo)
                {
                    PrecioPorBotella = 200000;
                }
                else
                {
                    PrecioPorBotella = 160000;
                }

            }
            
            PrecioTotal = TotalBotellas * PrecioPorBotella ;

            return PrecioTotal;
        }

    }
}
