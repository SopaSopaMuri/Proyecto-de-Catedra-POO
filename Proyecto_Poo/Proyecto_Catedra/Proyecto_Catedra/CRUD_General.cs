using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Catedra.GuiaEntity;


namespace Proyecto_Catedra
{
    internal class CRUD_General
    {
        //Campos de Hotel

        public class hotelReg {
        public int idhotel { get; set; }
        public string hotelname { get; set; }
        public string address { get; set; }
        
        }

        public class HabitacionReg {
        public int H_id { get; set; }
        public decimal price { get; set; }
        public string kind { get; set; }
        
        }

        public class ReservacionReg {
        public DateTime FechaFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public int ReservationID { get; set; }
        
        }

        public class huespedesReg {
        public int huesID { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        }

        public class EmpleadoReg {
        public int EmpID { get; set; }
        public string name { get; set; }
        public string cobro { get; set; }

        }

        public class ingresoReg {
        public decimal monto { get; set; }
        public DateTime fecha { get; set; }
        public int IngID { get; set; }
        }

        public class gastoReg {
            public int gastID { get; set; }
            public string Desc { get; set; }

            public decimal cost { get; set; }
            public DateTime fech { get; set; }
        
        }
    }
}
