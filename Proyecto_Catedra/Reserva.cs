using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Proyecto_Catedra.GuiaEntity;
using System.Security.Cryptography.X509Certificates;


namespace Proyecto_Catedra
{
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
        }



        private void Reserva_Load(object sender, EventArgs e)
        {

        }

        //Tabla General
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //Campos de Hotel

        private void Btt_IngreHotel_Click(object sender, EventArgs e)
        {
            using (hotel_CabanasEntities db = new hotel_CabanasEntities())
            {

                Hotel h = new Hotel();
                h.HotelID = int.Parse(txtHotel_id.Text);
                h.Nombre = txtHotelNombre.Text;
                h.Direccion = txtHotelDireccion.Text;

                List<CRUD_General.hotelReg> ListaHotel = new List<CRUD_General.hotelReg>();
                ListaHotel.Add(new CRUD_General.hotelReg { idhotel = h.HotelID, hotelname = h.Nombre, address = h.Direccion });
                dataGridView1.DataSource = ListaHotel;
                db.Hotel.Add(h);
                db.SaveChanges();
            }

        }
        private void txtHotelDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHotelNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHotel_id_TextChanged(object sender, EventArgs e)
        {

        }


        //Campos de Habitaciones
        private void txtHabitacionID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHabitacionPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHabitacionTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btt_IngreHabt_Click(object sender, EventArgs e)
        {
            using (hotel_CabanasEntities db = new hotel_CabanasEntities())
            {
                Habitaciones ha = new Habitaciones();
                ha.HabitacionID = int.Parse(txtHabitacionID.Text);
                ha.Precio = Convert.ToDecimal(txtHabitacionPrecio.Text);
                ha.Tipo = txtHabitacionTipo.Text;

                List<CRUD_General.HabitacionReg> ListaHabitacion = new List<CRUD_General.HabitacionReg>();
                ListaHabitacion.Add(new CRUD_General.HabitacionReg {H_id = ha.HabitacionID, kind = ha.Tipo, price = Convert.ToDecimal(txtHabitacionPrecio.Text) });
                dataGridView1.DataSource = ListaHabitacion;
                db.Habitaciones.Add(ha);
                db.SaveChanges();
            }
        }



        //Campos de Reservacion

        private void txtReservacionesFechaFin_TextChanged(object sender, EventArgs e)
        {

        }
        private void Btt_IngreResrv_Click(object sender, EventArgs e)
        {
            using (hotel_CabanasEntities db = new hotel_CabanasEntities())
            {
                Reservaciones Re = new Reservaciones();
                Re.FechaFin = Convert.ToDateTime(txtReservacionesFechaFin.Text);
                Re.FechaInicio = Convert.ToDateTime(txtReservacionesFechaInicio.Text);
                Re.ReservacionID = int.Parse(txtReservacionID.Text);

                List<CRUD_General.ReservacionReg> ListaReserva = new List<CRUD_General.ReservacionReg>();
                ListaReserva.Add(new CRUD_General.ReservacionReg { FechaFin = Convert.ToDateTime(txtReservacionesFechaFin.Text), FechaInicio = Convert.ToDateTime(txtReservacionesFechaInicio.Text), ReservationID = Re.ReservacionID });
                dataGridView1.DataSource = ListaReserva;

                db.Reservaciones.Add(Re);
                db.SaveChanges();

                

                
            }

        }

        private void txtReservacionesFechaInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReservacionID_TextChanged(object sender, EventArgs e)
        {

        }



        //Campos de Huespedes
        private void txtHuespedID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btt_IngreHusp_Click(object sender, EventArgs e)
        {
            using (hotel_CabanasEntities db = new hotel_CabanasEntities())
            {
                Huespedes Ha = new Huespedes();
                Ha.HuespedID = int.Parse(txtHuespedID.Text);
                Ha.Nombre = txtHuespedNombre.Text;
                Ha.Email = txtHuespedEmail.Text;

                List<CRUD_General.huespedesReg> ListaHuespedes = new List<CRUD_General.huespedesReg>();
                ListaHuespedes.Add(new CRUD_General.huespedesReg {huesID = Ha.HuespedID, name = Ha.Nombre,mail = Ha.Email });
                dataGridView1.DataSource = ListaHuespedes;

                db.Huespedes.Add(Ha);
                db.SaveChanges();
            }
        }

        private void txtHuespedNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHuespedEmail_TextChanged(object sender, EventArgs e)
        {

        }



        // Campos de Empleados:
        private void txtEmpleadosID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btt_IngreEmpl_Click(object sender, EventArgs e)
        {
            using (hotel_CabanasEntities db = new hotel_CabanasEntities())
            {
                Empleados E = new Empleados();
                E.EmpleadoID = int.Parse(txtEmpleadosID.Text);
                E.Nombre = txtEmpleadosNombre.Text;
                E.Cargo = txtEmpleadoSueldo.Text;

                List<CRUD_General.EmpleadoReg> ListaEmpleado = new List<CRUD_General.EmpleadoReg>();
                ListaEmpleado.Add(new CRUD_General.EmpleadoReg {EmpID = E.EmpleadoID, name = E.Nombre, cobro = E.Cargo});
                dataGridView1.DataSource = ListaEmpleado;

                db.Empleados.Add(E);
                db.SaveChanges();
            }
        }

        private void txtEmpleadosNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpleadoSueldo_TextChanged(object sender, EventArgs e)
        {

        }


        //Campos de Ingresos

        private void Btt_IngreIngress_Click(object sender, EventArgs e)
        {
            using (hotel_CabanasEntities db = new hotel_CabanasEntities())
            {
                Ingresos In = new Ingresos();
                In.Monto = decimal.Parse(txtIngresosMonto.Text);
                In.Fecha = Convert.ToDateTime(txtIngresosFecha.Text);
                In.IngresoID = int.Parse(txtIngresosID.Text);

                List<CRUD_General.ingresoReg> ListaIngreso = new List<CRUD_General.ingresoReg>();
                ListaIngreso.Add(new CRUD_General.ingresoReg {monto= decimal.Parse(txtIngresosMonto.Text),fecha = Convert.ToDateTime(txtIngresosFecha.Text),IngID = In.IngresoID });
                dataGridView1.DataSource = ListaIngreso;

                db.Ingresos.Add(In);
                db.SaveChanges();
            }
        }

        private void txtIngresosMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIngresosFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIngresosID_TextChanged(object sender, EventArgs e)
        {

        }



        //Campo de Gastos

        private void btnGastosIngresar_Click(object sender, EventArgs e)
        {
            using (hotel_CabanasEntities db = new hotel_CabanasEntities())
            {
                Gastos Ga = new Gastos();
                Ga.GastoID = int.Parse(txtGastosID.Text);
                Ga.Descripcion = txtGastosDescripcion.Text;
                Ga.Monto = decimal.Parse(txtGastosMonto.Text);
                Ga.Fecha = Convert.ToDateTime(txtGastosFecha.Text);

                List<CRUD_General.gastoReg> ListaGasto = new List<CRUD_General.gastoReg>();
                ListaGasto.Add(new CRUD_General.gastoReg {gastID = Ga.GastoID, Desc = Ga.Descripcion,cost = decimal.Parse(txtGastosMonto.Text), fech  = Convert.ToDateTime(txtGastosFecha.Text) });
                dataGridView1.DataSource = ListaGasto;

                db.Gastos.Add(Ga);
                db.SaveChanges();

            }
        }

        private void txtGastosFecha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtGastosID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGastosDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGastosMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }


        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {

            if (tabControl1.SelectedTab == tabPage1)
            {
                using (hotel_CabanasEntities db = new hotel_CabanasEntities())
                {
                    var list = from datos in db.Hotel
                               select datos;
                    dataGridView1.DataSource = list.ToList();
                }
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                using (hotel_CabanasEntities db = new hotel_CabanasEntities())
                {
                    var list = from datos in db.Habitaciones
                               select datos;
                    dataGridView1.DataSource = list.ToList();
                }
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                using (hotel_CabanasEntities db = new hotel_CabanasEntities())
                {
                    var list = from datos in db.Reservaciones
                               select datos;
                    dataGridView1.DataSource = list.ToList();
                }
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                using (hotel_CabanasEntities db = new hotel_CabanasEntities())
                {
                    var list = from datos in db.Huespedes
                               select datos;
                    dataGridView1.DataSource = list.ToList();
                }
            }
            else if (tabControl1.SelectedTab == tabPage5)
            {
                using (hotel_CabanasEntities db = new hotel_CabanasEntities())
                {
                    var list = from datos in db.Empleados
                               select datos;
                    dataGridView1.DataSource = list.ToList();
                }
            }
            else if (tabControl1.SelectedTab == tabPage7)
            {
                using (hotel_CabanasEntities db = new hotel_CabanasEntities())
                {
                    var list = from datos in db.Ingresos
                               select datos;
                    dataGridView1.DataSource = list.ToList();
                }
            }
            else if (tabControl1.SelectedTab == tabPage8)
            {
                using (hotel_CabanasEntities db = new hotel_CabanasEntities())
                {
                    var list = from datos in db.Gastos
                               select datos;
                    dataGridView1.DataSource = list.ToList();
                }
            }
        }

        
    }
}
