//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Datos_Personales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Datos_Personales()
        {
            this.Horarios = new HashSet<Horarios>();
        }
    
        public int Id_Datos_Personales { get; set; }
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public int Edad { get; set; }
        public string Lugar_de_Nacimiento { get; set; }
        public string Estado_Civil { get; set; }
        public string CURP { get; set; }
        public string Direccion { get; set; }
        public string Numero_Casa { get; set; }
        public string Numero_Celular { get; set; }
        public string Nombre_Licenciatura { get; set; }
        public string Institucion_Lic { get; set; }
        public Nullable<int> Periodo_Lic { get; set; }
        public string Año_Titulacion_Lic { get; set; }
        public string Nombre_Maestria { get; set; }
        public string Institucion_Mae { get; set; }
        public Nullable<int> Periodo_Mae { get; set; }
        public string Año_Titulacion_Mae { get; set; }
        public string Nombre_Doctorado { get; set; }
        public string Institucion_Doc { get; set; }
        public Nullable<int> Periodo_Doc { get; set; }
        public string Años_Titulacion_Doc { get; set; }
        public string Nombre_Especializacion { get; set; }
        public string Institucion_Espe { get; set; }
        public Nullable<int> Periodo_Espe { get; set; }
        public string Año_Titulacion_Espe { get; set; }
        public string Nombre_Curso { get; set; }
        public string Institucion_Curso { get; set; }
        public Nullable<int> Horas { get; set; }
        public string Fecha { get; set; }
        public string Idioma { get; set; }
        public string Habla { get; set; }
        public string Lee { get; set; }
        public string Escribe { get; set; }
        public string Dominio { get; set; }
        public string Actividad_Puesto { get; set; }
        public string Organizacion_Empresa { get; set; }
        public string Periodo { get; set; }
        public string Actividad_Puesto2 { get; set; }
        public string Organizacion_Empresa2 { get; set; }
        public string Periodo2 { get; set; }
        public string Actividad_Puesto3 { get; set; }
        public string Organizacion_Empresa3 { get; set; }
        public string Periodo3 { get; set; }
        public string Actividad_Puesto_Aca { get; set; }
        public string Institucion_Aca { get; set; }
        public string Periodo_Aca { get; set; }
        public string Actividad_Puesto_Aca2 { get; set; }
        public string Institucion_Aca2 { get; set; }
        public string Periodo_Aca2 { get; set; }
        public string Actividad_Puesto_Aca3 { get; set; }
        public string Institucion_Aca3 { get; set; }
        public string Periodo_Aca3 { get; set; }
        public Nullable<int> Ingenieria_Idustrial { get; set; }
        public Nullable<int> Ingenieria_Sistemas { get; set; }
        public Nullable<int> Tics { get; set; }
        public Nullable<int> Ingenieria_Gestion { get; set; }
        public Nullable<int> Ingenieria_Logistica { get; set; }
        public Nullable<int> Ingenieria_Industrial_Dis { get; set; }
        public Nullable<int> Contador { get; set; }
        public Nullable<int> Ingenieria_Mecatronica { get; set; }
        public Nullable<int> Ingenieria_Gestion_Dis { get; set; }
        public Nullable<int> Ingenieria_Administracion { get; set; }
        public string Nombre_Materia_Ant { get; set; }
        public string Carrera_Ant { get; set; }
        public string Semestre_Ant { get; set; }
        public string Nombre_Materia_Ant2 { get; set; }
        public string Carrera_Ant2 { get; set; }
        public string Semestre_Ant2 { get; set; }
        public string Nombre_Materia_Ant3 { get; set; }
        public string Carrera_Ant3 { get; set; }
        public string Semestre_Ant3 { get; set; }
        public string Nombre_Materia_Ant4 { get; set; }
        public string Carrera_Ant4 { get; set; }
        public string Semestre_Ant4 { get; set; }
        public string Nombre_Materia_Ant5 { get; set; }
        public string Carrera_Ant5 { get; set; }
        public string Semestre_Ant5 { get; set; }
        public string Nombre_Materia_Ant6 { get; set; }
        public string Carrera_Ant6 { get; set; }
        public string Semestre_Ant6 { get; set; }
        public string Nombre_Materia_Ant7 { get; set; }
        public string Carrera_Ant7 { get; set; }
        public string Semestre_Ant7 { get; set; }
        public string Nombre_Materia_Ant8 { get; set; }
        public string Carrera_Ant8 { get; set; }
        public string Semestre_Ant8 { get; set; }
        public string Nombre_Materia_Ant9 { get; set; }
        public string Carrera_Ant9 { get; set; }
        public string Semestre_Ant9 { get; set; }
        public string Nombre_Materia_Imp { get; set; }
        public string Carrera_Imp { get; set; }
        public string Semestre_Imp { get; set; }
        public string Nombre_Materia_Imp2 { get; set; }
        public string Carrera_Imp2 { get; set; }
        public string Semestre_Imp2 { get; set; }
        public string Nombre_Materia_Imp3 { get; set; }
        public string Carrera_Imp3 { get; set; }
        public string Semestre_Imp3 { get; set; }
        public string Nombre_Materia_Imp4 { get; set; }
        public string Carrera_Imp4 { get; set; }
        public string Semestre_Imp4 { get; set; }
        public string Nombre_Materia_Imp5 { get; set; }
        public string Carrera_Imp5 { get; set; }
        public string Semestre_Imp5 { get; set; }
        public string Nombre_Materia_Imp6 { get; set; }
        public string Carrera_Imp6 { get; set; }
        public string Semestre_Imp6 { get; set; }
        public string Nombre_Materia_Imp7 { get; set; }
        public string Carrera_Imp7 { get; set; }
        public string Semestre_Imp7 { get; set; }
        public string Nombre_Materia_Imp8 { get; set; }
        public string Carrera_Imp8 { get; set; }
        public string Semestre_Imp8 { get; set; }
        public string Nombre_Materia_Imp9 { get; set; }
        public string Carrera_Imp9 { get; set; }
        public string Semestre_Imp9 { get; set; }
        public string Nombre_Materia_Imp10 { get; set; }
        public string Carrera_Imp10 { get; set; }
        public string Semestre_Imp10 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Horarios> Horarios { get; set; }
    }
}
