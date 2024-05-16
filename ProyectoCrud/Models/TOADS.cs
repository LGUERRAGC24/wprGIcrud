
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoCrud.Models
{
    public class TOADS
    {
        #region Propiedades

        public int Key  { get; set; }
        public int IdADS { get; set; }
        public int IdSolicitudHC { get; set; }
        public int IdPerfilPuesto { get; set; }
        public int IdPuesto { get; set; }
        public string ChCubiertaInternamente { get; set; }
        public string CubiertaInternamente { get; set; }
        public string ChCubiertaPorComunidad { get; set; }
        public string CubiertaPorComunidad { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public int IdPersonalClienteInterno { get; set; }
        public int idPersonalGerenteArea { get; set; }
        public int idPersonalVicepresidenteArea { get; set; }
        public int IdPersonalRegistro { get; set; }
        //public int IdPersonalRegistro { get; set; }

        public string ChActivo { get; set; }
        public string Estado  { get; set; }
        public int idVP { get; set; }
        public int IdDepartamento { get; set; }
        public string HabilitarGerente { get; set; }
        public string HabilitarVP { get; set; }
        public int  IdTipoADS { get; set; }
        public string UsuarioCrea { get; set; }
        public string UsuarioModifica { get; set; }
        public string FechaRegistro { get; set; }
        public string FechaModificacion { get; set; }

        #endregion

        #region Constructor

        public TOADS()
        {
            // Se inicializan las propiedades con valores predeterminados
            this.Key = 0;
            this.IdADS = 0;
            this.IdSolicitudHC = 0;
            this.IdPerfilPuesto = 0;
            this.IdPuesto = 0;
            this.ChCubiertaInternamente = string.Empty;
            this.CubiertaInternamente = string.Empty;
            this.ChCubiertaPorComunidad = string.Empty;
            this.CubiertaPorComunidad = string.Empty;
            this.FechaInicio = string.Empty;
            this.FechaFin = string.Empty;
            this.IdPersonalClienteInterno = 0;
            this.idPersonalGerenteArea = 0;
            this.idPersonalVicepresidenteArea =0;
            this.IdPersonalRegistro = 0;
            this.ChActivo = string.Empty;
            this.Estado = string.Empty; 
            this.idVP = 0;
            this.IdDepartamento = 0;
            this.HabilitarGerente = string.Empty;
            this.HabilitarVP = string.Empty;
            this.IdTipoADS =  0;
            this.UsuarioCrea = string.Empty;
            this.UsuarioModifica = string.Empty;
            this.FechaRegistro = string.Empty;
            this.FechaModificacion = string.Empty;
        }


        #endregion
    }

}