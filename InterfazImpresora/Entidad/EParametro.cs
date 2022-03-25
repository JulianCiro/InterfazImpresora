using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfazImpresora.Datos;

namespace InterfazImpresora.Entidad
{
    class EParametro
    {
        public static string IpPlc = ObtenerDb.ObtenerParametro("IpPlc");
        public static string IpImpresora = ObtenerDb.ObtenerParametro("IpImpresora");
        public static string Plc_Pistilos = ObtenerDb.ObtenerParametro("Plc_Pistilos");
        public static string Plc_Start_Remoto =  (ObtenerDb.ObtenerParametro("Plc_Start_Remoto"));
        public static string Plc_Stop_Remoto =  (ObtenerDb.ObtenerParametro("Plc_Stop_Remoto"));
        public static string Plc_Confir_Orden_Prod =  (ObtenerDb.ObtenerParametro("Plc_Confir_Orden_Prod"));
        public static string Plc_Remoto_Local	=  (ObtenerDb.ObtenerParametro("Plc_Remoto-Local"));
        public static string Plc_Modo_Auto =  (ObtenerDb.ObtenerParametro("Plc_Modo_Auto"));
        public static string Plc_Modo_Manual =  (ObtenerDb.ObtenerParametro("Plc_Modo_Manual"));
        public static string Plc_Confir_Cod_Impreso =  (ObtenerDb.ObtenerParametro("Plc_Confir_Cod_Impreso"));
        public static string Plc_Reset_Alarmas =  (ObtenerDb.ObtenerParametro("Plc_Reset_Alarmas"));
        public static string Plc_Impresora_Ok =  (ObtenerDb.ObtenerParametro("Plc_Impresora_Ok"));
        public static string Plc_Motor_Manual =  (ObtenerDb.ObtenerParametro("Plc_Motor_Manual"));
        public static string Plc_Jog_Motor_Adelante =  (ObtenerDb.ObtenerParametro("Plc_Jog_Motor_Adelante"));
        public static string Plc_Jog_Motor_Atras =  (ObtenerDb.ObtenerParametro("Plc_Jog_Motor_Atras"));
        public static string Plc_Disparo_Cam =  (ObtenerDb.ObtenerParametro("Plc_Disparo_Cam"));
        public static string Plc_Codigo_Impreso = ObtenerDb.ObtenerParametro("Plc_Codigo_Impreso");
        public static string Plc_Referencia_Empaque = (ObtenerDb.ObtenerParametro("Plc_Referencia_Empaque"));
        public static string Plc_Codigos_Imp	=	ObtenerDb.ObtenerParametro("Plc_Codigos_Imp"); //en plc es un Array[0..12]
        public static string PuertoImp =  (ObtenerDb.ObtenerParametro("PuertoImp"));
    }
}
