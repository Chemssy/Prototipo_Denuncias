using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Prototipo_Denuncias
{
    internal class DatosSistema
    {
        public static readonly Dictionary<string, string> usuariosPoliciales = new Dictionary<string, string>()
        {
            { "31894022", "admin123" },
            { "76543210", "seguro456" },
            { "12345678", "policia123" }
        };

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
