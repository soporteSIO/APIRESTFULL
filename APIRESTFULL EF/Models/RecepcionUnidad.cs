using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIRESTFULL_EF.Models
{
    public class RecepcionUnidad
    {
        [Key]
        public int IdFolioRecepcion { get; set; }
        public string? NAguaRadiador { get; set; }
        public string? NAceiteMotor { get; set; }
        public string? NAceiteHID { get; set; }
        public string? SELuzDeFreno { get; set; }
        public string? SETorreta { get; set; }
        public string? SELuzDeReversa { get; set; }
        public string? SEFarosDelanteros { get; set; }
        public string? SEDireccionales { get; set; }
        public string? SEIntermitentes { get; set; }
        public string? ISinFugasFiltro { get; set; }
        public string? IFiltroAireLimpio { get; set; }
        public string? IFiltroDieselSinFugas { get; set; }
        public string? ITaponRadiador { get; set; }
        public string? ITapaFiltroAire { get; set; }
        public string? IBayonetaAceite { get; set; }
        public string? ITuboAceite { get; set; }
        public string? ISinFugasCarter { get; set; }
        public string? IFugasSistemaFrenos { get; set; }
        public string? IBateriaYCables { get; set; }
        public string? CVidriosBuenEstado { get; set; }
        public string? CPuertasCierranBien { get; set; }
        public string? CEspejosLateralesCompletos { get; set; }
        public string? CZoqueterasCompletas { get; set; }
        public string? CFaldonesYEstribos { get; set; }
        public string? CLimpiabrisasFuncionando { get; set; }
        public string? CPlacas { get; set; }
        public string? PBombas { get; set; }
        public string? PMirillas { get; set; }
        public string? PValvulas { get; set; }
        public string? PExtintor { get; set; }
        public string? PFiltros { get; set; }
        public string? PMangueras { get; set; }
        public string? PCarretes { get; set; }
        public string? Mecanico { get; set; }
        public string? FechaRegistro { get; set; }
        public string? Unidad { get; set; }
        public string? Comentarios { get; set; }
        public string? MotivoIngreso { get; set; }
        public string? Operador { get; set; }
    }
}
