using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
///using MCPRHBCRYS.TO;
using ProyectoCrud.Models;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

namespace ProyectoGIcrud.Controllers
{
    public class ADSController : Controller
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["conexionazure"].ToString();

        private static List<TOADS> olista = new List<TOADS>();

        // GET: ADS
        public ActionResult Inicio()
        {
            olista = new List<TOADS>();

            using (SqlConnection oconexion = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("SELECT inid , inIdADS,inIdSolicitudHC,inIdPerfilPuesto,inIdPuesto FROM ADS", oconexion);
                cmd.CommandType = CommandType.Text;
                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        TOADS nuevoADS = new TOADS();

                        nuevoADS.Key = Convert.ToInt32(dr["inId"]);
                        nuevoADS.IdADS = Convert.ToInt32(dr["inIdADS"]);
                        nuevoADS.IdSolicitudHC = Convert.ToInt32(dr["inIdSolicitudHC"]);
                        nuevoADS.IdPerfilPuesto = Convert.ToInt32(dr["inIdPerfilPuesto"]);
                        nuevoADS.IdPuesto = Convert.ToInt32(dr["inIdPuesto"]);

                        olista.Add(nuevoADS);

                    }
                }
            }
            return View(olista);
        }



        [HttpGet]
        public ActionResult Registrar()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Editar(int? IdADS)
        {
            if (IdADS == null)
                return RedirectToAction("Inicio", "ADS");


            TOADS oADS = olista.Where(c => c.IdADS == IdADS).FirstOrDefault();


            return View(oADS);
        }

        [HttpGet]
        public ActionResult Eliminar(int? idADS)
        {
            if (idADS == null)
                return RedirectToAction("Inicio", "ADS");


            TOADS oADS = olista.Where(c => c.IdADS == idADS).FirstOrDefault();
            return View(oADS);
        }


        [HttpPost]
        public ActionResult Registrar(TOADS oADS)
        {
            using (SqlConnection oconexion = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("ins_ADS", oconexion);
                cmd.Parameters.AddWithValue("inId", oADS.Key);
                cmd.Parameters.AddWithValue("inIdADS", oADS.IdADS);
                cmd.Parameters.AddWithValue("inIdSolicitudHC", oADS.IdSolicitudHC);
                cmd.Parameters.AddWithValue("inIdPerfilPuesto", oADS.IdPerfilPuesto);
                cmd.Parameters.AddWithValue("inIdPuesto", oADS.IdPuesto);
                cmd.CommandType = CommandType.StoredProcedure;
                oconexion.Open();
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Inicio", "ADS");
        }


        [HttpPost]
        public ActionResult Editar(TOADS oADS)
        {
            using (SqlConnection oconexion = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("upd_ADS", oconexion);
                cmd.Parameters.AddWithValue("inId", oADS.Key);
                cmd.Parameters.AddWithValue("inIdADS", oADS.IdADS);
                cmd.Parameters.AddWithValue("inIdSolicitudHC", oADS.IdSolicitudHC);
                cmd.Parameters.AddWithValue("inIdPerfilPuesto", oADS.IdPerfilPuesto);
                cmd.Parameters.AddWithValue("inIdPuesto", oADS.IdPuesto);

                cmd.CommandType = CommandType.StoredProcedure;
                oconexion.Open();
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Inicio", "ADS");
        }


        [HttpPost]
        public ActionResult Eliminar(string IdADS)
        {
            using (SqlConnection oconexion = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("del_ADS", oconexion);
                cmd.Parameters.AddWithValue("inIdADS", IdADS);
                cmd.CommandType = CommandType.StoredProcedure;
                oconexion.Open();
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Inicio", "ADS");
        }
    }



}
