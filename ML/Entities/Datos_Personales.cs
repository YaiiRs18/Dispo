using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Entities
{
    public class Datos_Personales
    {  
        
        public int Id_Datos_Personales { get; set; }

        [Required(ErrorMessage ="Este campo es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string APaterno { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string AMaterno { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Lugar_de_Nacimiento { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Estado_Civil { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string CURP { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Numero_Casa { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Numero_Celular { get; set; }

        public string Nombre_Licenciatura { get; set; }
        public string Institucion_Lic { get; set; }
        public int? Periodo_Lic { get; set; }
        public string Año_Titulacion_Lic { get; set; }
        public string Nombre_Maestria { get; set; }
        public string Institucion_Mae { get; set; }
        public int? Periodo_Mae { get; set; }
        public string Año_Titulacion_Mae { get; set; }
        public string Nombre_Doctorado{ get; set; }
        public string Institucion_Doc { get; set; }
        public int? Periodo_Doc { get; set; }
        public string Año_Titulacion_Doc { get; set; }
        public string Nombre_Especializacion { get; set; }
        public string Institucion_Espe { get; set; }
        public int? Periodo_Espe { get; set; }
        public string Año_Titulacion_Espe { get; set; }
        public string Nombre_Curso { get; set; }
        public string Instituto_Curso { get; set; }
        public int? Horas { get; set; }
        public string Fecha { get; set; }
        public string Idioma { get; set; }
        public string Habla { get; set; }
        public string Lee { get; set; }
        public string Escribe { get; set; }
        public string Dominio { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio")]
        public string Actividad_Puesto { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Organizacion_Empresa { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Periodo { get; set; }
        public string Actividad_Puesto2 { get; set; }
        public string Organizacion_Empresa2 { get; set; }
        public string Periodo2 { get; set; }
        public string Actividad_Puesto3 { get; set; }
        public string Organizacion_Empresa3 { get; set; }
        public string Periodo3 { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Actividad_Puesto_Aca { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Institucion_Aca { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Periodo_Aca { get; set; }
        public string Actividad_Puesto_Aca2 { get; set; }
        public string Institucion_Aca2 { get; set; }
        public string Periodo_Aca2 { get; set; }
        public string Actividad_Puesto_Aca3 { get; set; }
        public string Institucion_Aca3 { get; set; }
        public string Periodo_Aca3 { get; set; }
        public int? Ingenieria_Industrial { get; set; }
        public int? Ingenieria_Sistemas { get; set; }
        public int? Tics { get; set; }
        public int? Ingenieria_Gestion { get; set; }
        public int? Ingenieria_Logistica { get; set; }
        public int? Ingenieria_Industial_Dis { get; set; }
        public int? Contador { get; set; }
        public int? Ingenieria_Mecatronica { get; set; }
        public int? Ingenieria_Gestion_Dis { get; set; }
        public int? Ingenieria_Administracion { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre_Materia_Ant { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Carrera_Ant { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
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
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre_Materia_Imp { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Carrera_Imp { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
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

    }
}
