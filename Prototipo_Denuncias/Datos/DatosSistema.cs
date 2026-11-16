using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text;

namespace Prototipo_Denuncias
{
    internal class DatosSistema
    {

        public static readonly string RutaManual = Path.Combine(Application.StartupPath, "ManualUsuario.pdf");

        public static void AbrirManualUsuario()
        {

            if(!File.Exists(RutaManual)){

                MessageBox.Show("No se encontro el archivo ManualUsuario.pdf en la carpeta del sistema",
                    "Archivo no encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;

            }

            Process.Start(new ProcessStartInfo
            {
                FileName = RutaManual,
                UseShellExecute = true
            });

        }


        public static readonly Dictionary<string, string> usuariosPoliciales = new Dictionary<string, string>()
        {
            { "31894022", "admin123" },
            { "76543210", "seguro456" },
            { "12345678", "policia123" }
        };

        private static readonly string RutaPlantillas = Path.Combine(Application.StartupPath, "plantillas.txt");

        public static void InicializarPlantillas()
        {
            if (File.Exists(RutaPlantillas)) return;

            string[] plantillasBase = {
                     "Delito Contra el Patrimonio|Siendo las [HH:MM] hrs, el ciudadano denuncia haber sido víctima de sustracción de sus pertenencias ([ESPECIFICAR BIENES]) en las inmediaciones de [LUGAR / REFERENCIA], por parte de [N° SUJETOS] sujetos que se dieron a la fuga.",
                        "Extorsion y Cobro de Cupos|El denunciante refiere recibir amenazas mediante [LLAMADAS / MENSAJES WHATSAPP] desde el número [N° TELEFÓNICO], exigiéndole el pago de S/ [MONTO] a cambio de no atentar contra su integridad familiar o su negocio ubicado en [DIRECCIÓN].",
                     "Delito Contra la Vida, el Cuerpo y la Salud|El recurrente manifiesta haber sufrido agresión física con [OBJETO / ARMA / GOLPES] en [LUGAR DEL SUCESO], presentando lesiones visibles por las cuales se solicita el reconocimiento médico legal correspondiente.",
                     "Microcomercialización de Drogas|Se deja constancia por información recibida que en la intersección de [CALLE / AVENIDA] se estaría realizando el expendio ilícito de sustancias prohibidas por parte de individuos identificados con las características: [DESCRIPCIÓN].",
                     "Delitos Informaticos y Estafas|El agraviado reporta operaciones no reconocidas desde su cuenta bancaria [ENTIDAD] por el importe total de S/ [MONTO], tras haber recibido un enlace fraudulento o contacto engañoso a través de [MEDIO DIGITAL]."
            };

            File.WriteAllLines(RutaPlantillas, plantillasBase);
        }

        public static string ObtenerPlantilla(string categoriaSeleccionada)
        {
            InicializarPlantillas();

            foreach (string linea in File.ReadAllLines(RutaPlantillas))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] partes = linea.Split("|");

                if(partes.Length == 2 && partes[0] == categoriaSeleccionada)
                {
                    return partes[1];
                }

            }
            return "";
        }

        public static readonly string[] TiposDelitos =
        {
            "Delito Contra el Patrimonio",
            "Extorsion y Cobro de Cupos",
            "Delito Contra la Vida, el Cuerpo y la Salud",
            "Microcomercialización de Drogas",
            "Delitos Informaticos y Estafas"
        };

        public static readonly string[] TiposDistritos =
        {
            "Independencia", "Los Olivos", "Comas", "Carabayllo", "Miraflores"
        };

        public static readonly string[] TiposEstados =
        {
            "Recibida", "En trámite", "Resuelta"
        };

        public static void CargarTiposDelitos(ComboBox comboDestino)
        {
            comboDestino.Items.Clear();
            comboDestino.Items.AddRange(TiposDelitos);
        }

        public static void CargarTiposDistritos(ComboBox comboDestino)
        {
            comboDestino.Items.Clear();
            comboDestino.Items.AddRange(TiposDistritos);
        }

        public static void CargarTiposEstados(ComboBox comboDestino)
        {
            comboDestino.Items.Clear();
            comboDestino.Items.AddRange(TiposEstados);
        }

    }
}
