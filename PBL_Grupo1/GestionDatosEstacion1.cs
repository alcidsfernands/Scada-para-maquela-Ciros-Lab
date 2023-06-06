using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PBL_Grupo1
{
    public class GestionDatosEstacion1
    {
        private delegadoMensajes imprimirMensajeRecibido;
        private pintaLuces pintarLuces;
        private List<Ellipse> lucesEstacion1;
        private List<Ellipse> lucesEstacion2;
        private List<Ellipse> lucesEstacion3;
        private List<Ellipse> lucesOverview;
        private BitArray conveyor;
        private BitArray estacion1;
        private BitArray estacion2;
        private BitArray estacion3;
        private BitArray overview;


        public GestionDatosEstacion1(delegadoMensajes _datos, pintaLuces _delLuces, List<Ellipse> _luces, List<Ellipse> _luces2, List<Ellipse> _luces3, List<Ellipse> listOverview)
        {
            imprimirMensajeRecibido = _datos;
            lucesEstacion1 = _luces;
            lucesEstacion2 = _luces2;
            lucesEstacion3 = _luces3;
            lucesOverview = listOverview;
            pintarLuces = _delLuces;
        }

        public void procesar(byte[] datos, int dim)
        {
            Estacion1(datos);
            //Estacion2(datos);
            //Estacion3(datos);

            //getOverview();
        }

        private void getOverview()
        {
            BitArray aux = Append(conveyor, this.estacion1);
            BitArray aux2 = Append(this.estacion2, this.estacion3);

            this.overview = Append(aux, aux2);

            for (int i = 0; i < overview.Count; i++)
            {
                pintarLuces(overview[i], lucesOverview[i], overview, 0);
            }
        }

        private void Estacion1(byte[] datos)
        {
            BitArray frontCoverOutputs = new BitArray(new byte[] { datos[150] });
            BitArray frontCoverInputs = new BitArray(new byte[] { datos[0] });
            BitArray bitsbasicModuleOutputs = new BitArray(new byte[] { datos[151] });
            BitArray bitsbasicModuleInputs = new BitArray(new byte[] { datos[1] });

            BitArray StopperInputs = new BitArray(new byte[] { datos[42] });

            imprimirMensajeRecibido(new byte[] { datos[0], datos[1] }, 8);

            BitArray module1 = Append(bitsbasicModuleInputs, bitsbasicModuleOutputs);
            this.conveyor = module1;
            BitArray module2 = Append(frontCoverInputs, frontCoverOutputs);
            this.estacion1 = module2;
            BitArray aux = Append(module1, module2);
            BitArray estacion1 = Append(aux, StopperInputs);

            for (int i = 0; i < estacion1.Count; i++)
            {
                pintarLuces(estacion1[i], lucesEstacion1[i], estacion1, 1);
            }
        }


        private void Estacion2(byte[] datos)
        {
            //TODO
            BitArray bitsbasicModule_2_Outputs = new BitArray(new byte[] { datos[8] });
            BitArray bitsbasicModule_2_Inputs = new BitArray(new byte[] { datos[50] });

            BitArray measuringOutputs = new BitArray(new byte[] { datos[8] });
            BitArray measuringInputs = new BitArray(new byte[] { datos[51] });

            BitArray StopperInputs = new BitArray(new byte[] { datos[92] });

            BitArray module1_2 = Append(bitsbasicModule_2_Inputs, bitsbasicModule_2_Outputs);
            BitArray module2_2 = Append(measuringInputs, measuringOutputs);
            this.estacion2 = module2_2;
            BitArray aux = Append(module1_2, module2_2);

            BitArray estacion2 = Append(aux, StopperInputs);

            for (int i = 0; i < estacion2.Count; i++)
            {
                pintarLuces(estacion2[i], lucesEstacion2[i], estacion2, 2);
            }

        }

        private void Estacion3(byte[] datos)
        {
            //TODO
            BitArray bitsbasicModule_2_Outputs = new BitArray(new byte[] { datos[12] });
            BitArray bitsbasicModule_2_Inputs = new BitArray(new byte[] { datos[101] });

            BitArray measuringOutputs = new BitArray(new byte[] { datos[14] });
            BitArray measuringInputs = new BitArray(new byte[] { datos[100] });

            BitArray StopperInputs = new BitArray(new byte[] { datos[142] });

            BitArray module1_2 = Append(bitsbasicModule_2_Inputs, bitsbasicModule_2_Outputs);
            BitArray module2_2 = Append(measuringInputs, measuringOutputs);
            this.estacion3 = module2_2;
            BitArray aux = Append(module1_2, module2_2);

            BitArray estacion3 = Append(aux, StopperInputs);

            for (int i = 0; i < estacion3.Count; i++)
            {
                pintarLuces(estacion3[i], lucesEstacion3[i], estacion3, 3);
            }

        }

        public BitArray Append(BitArray current, BitArray after)
        {
            bool[] bools = new bool[current.Count + after.Count];
            current.CopyTo(bools, 0);
            after.CopyTo(bools, current.Count);
            return new BitArray(bools);
        }

    }
}
