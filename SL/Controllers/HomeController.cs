using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http.Formatting;

namespace SL.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44372/");

            var request = clientHttp.GetAsync("api/GetAll").Result;

            if (request.IsSuccessStatusCode)
            {
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<List<ML.Entities.Datos_Personales>>(DatosInfo);
                return View(Listado);
            }
            return View();

        }

        public ActionResult VerHorario(int ID)
        {

            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44372/");

            var request = clientHttp.GetAsync("api/GetByIdH/" + ID).Result;

            if (request.IsSuccessStatusCode)
            {
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<List<ML.Entities.Horarios>>(DatosInfo);
                return View(Listado);
            }
            return View();

        }


        public ActionResult Agregar(int id = 0)
        {
            return View(new ML.Entities.Datos_Personales());
        }

        [HttpPost]
        public ActionResult Agregar(ML.Entities.Datos_Personales datos_Personales)
        {
            
          
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44372/");

            var request = clientHttp.PostAsync("api/Add", datos_Personales, new JsonMediaTypeFormatter()).Result;

            if (request.IsSuccessStatusCode)
            {
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<ML.Entities.Datos_Personales>(DatosInfo);
                if (!ModelState.IsValid)
                {
                    return View(Listado);
                }
                return RedirectToAction("Index");
            }

            return View();
        }


        [HttpGet]
        public ActionResult Editar(int ID)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44372/");

            var request = clientHttp.GetAsync("api/GetById/" + ID).Result;

            if (request.IsSuccessStatusCode)
            {
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<List<ML.Entities.Datos_Personales>>(DatosInfo);
                ML.Entities.Datos_Personales datos_Personales = new ML.Entities.Datos_Personales();
                foreach (var obj in Listado)
                {
                    datos_Personales.Id_Datos_Personales = obj.Id_Datos_Personales;
                    datos_Personales.Nombre = obj.Nombre;
                    datos_Personales.APaterno = obj.APaterno;
                    datos_Personales.AMaterno = obj.AMaterno;
                    datos_Personales.Edad = obj.Edad;
                    datos_Personales.Lugar_de_Nacimiento = obj.Lugar_de_Nacimiento;
                    datos_Personales.Estado_Civil = obj.Estado_Civil;
                    datos_Personales.CURP = obj.CURP;
                    datos_Personales.Direccion = obj.Direccion;
                    datos_Personales.Numero_Casa = obj.Numero_Casa;
                    datos_Personales.Numero_Celular = obj.Numero_Celular;
                    datos_Personales.Nombre_Licenciatura = obj.Nombre_Licenciatura;
                    datos_Personales.Institucion_Lic = obj.Institucion_Lic;
                    datos_Personales.Periodo_Lic = obj.Periodo_Lic;
                    datos_Personales.Año_Titulacion_Lic = obj.Año_Titulacion_Lic;
                    datos_Personales.Nombre_Maestria = obj.Nombre_Maestria;
                    datos_Personales.Institucion_Mae = obj.Institucion_Mae;
                    datos_Personales.Periodo_Mae = obj.Periodo_Mae;
                    datos_Personales.Año_Titulacion_Mae = obj.Año_Titulacion_Mae;
                    datos_Personales.Nombre_Doctorado = obj.Nombre_Doctorado;
                    datos_Personales.Institucion_Doc = obj.Institucion_Doc;
                    datos_Personales.Periodo_Doc = obj.Periodo_Doc;
                    datos_Personales.Año_Titulacion_Doc = obj.Año_Titulacion_Doc;
                    datos_Personales.Nombre_Especializacion = obj.Nombre_Especializacion;
                    datos_Personales.Institucion_Espe = obj.Institucion_Espe;
                    datos_Personales.Periodo_Espe = obj.Periodo_Espe;
                    datos_Personales.Año_Titulacion_Espe = obj.Año_Titulacion_Espe;
                    datos_Personales.Nombre_Curso = obj.Nombre_Curso;
                    datos_Personales.Instituto_Curso = obj.Instituto_Curso;
                    datos_Personales.Horas = obj.Horas;
                    datos_Personales.Fecha = obj.Fecha;
                    datos_Personales.Idioma = obj.Idioma;
                    datos_Personales.Habla = obj.Habla;
                    datos_Personales.Lee = obj.Lee;
                    datos_Personales.Escribe = obj.Escribe;
                    datos_Personales.Dominio = obj.Dominio;
                    datos_Personales.Actividad_Puesto = obj.Actividad_Puesto;
                    datos_Personales.Organizacion_Empresa = obj.Organizacion_Empresa;
                    datos_Personales.Periodo = obj.Periodo;
                    datos_Personales.Actividad_Puesto2 = obj.Actividad_Puesto2;
                    datos_Personales.Organizacion_Empresa2 = obj.Organizacion_Empresa2;
                    datos_Personales.Periodo2 = obj.Periodo2;
                    datos_Personales.Actividad_Puesto3 = obj.Actividad_Puesto3;
                    datos_Personales.Organizacion_Empresa3 = obj.Organizacion_Empresa3;
                    datos_Personales.Periodo3 = obj.Periodo3;
                    datos_Personales.Actividad_Puesto_Aca = obj.Actividad_Puesto_Aca;
                    datos_Personales.Institucion_Aca = obj.Institucion_Aca;
                    datos_Personales.Periodo_Aca = obj.Periodo_Aca;
                    datos_Personales.Actividad_Puesto_Aca2 = obj.Actividad_Puesto_Aca2;
                    datos_Personales.Institucion_Aca2 = obj.Institucion_Aca2;
                    datos_Personales.Periodo_Aca2 = obj.Periodo_Aca2;
                    datos_Personales.Actividad_Puesto_Aca3 = obj.Actividad_Puesto_Aca3;
                    datos_Personales.Institucion_Aca3 = obj.Institucion_Aca3;
                    datos_Personales.Periodo_Aca3 = obj.Periodo_Aca3 = obj.Periodo_Aca3;
                    datos_Personales.Ingenieria_Industrial = obj.Ingenieria_Industrial;
                    datos_Personales.Ingenieria_Sistemas = obj.Ingenieria_Sistemas;
                    datos_Personales.Tics = obj.Tics;
                    datos_Personales.Ingenieria_Gestion = obj.Ingenieria_Gestion;
                    datos_Personales.Ingenieria_Logistica = obj.Ingenieria_Logistica;
                    datos_Personales.Ingenieria_Industial_Dis = obj.Ingenieria_Industial_Dis;
                    datos_Personales.Contador = obj.Contador;
                    datos_Personales.Ingenieria_Mecatronica = obj.Ingenieria_Mecatronica;
                    datos_Personales.Ingenieria_Gestion_Dis = obj.Ingenieria_Gestion_Dis;
                    datos_Personales.Ingenieria_Administracion = obj.Ingenieria_Administracion;
                    datos_Personales.Nombre_Materia_Ant = obj.Nombre_Materia_Ant;
                    datos_Personales.Carrera_Ant = obj.Carrera_Ant;
                    datos_Personales.Semestre_Ant = obj.Semestre_Ant;
                    datos_Personales.Nombre_Materia_Ant2 = obj.Nombre_Materia_Ant2;
                    datos_Personales.Carrera_Ant2 = obj.Carrera_Ant2;
                    datos_Personales.Semestre_Ant2 = obj.Semestre_Ant2;
                    datos_Personales.Nombre_Materia_Ant3 = obj.Nombre_Materia_Ant3;
                    datos_Personales.Carrera_Ant3 = obj.Carrera_Ant3;
                    datos_Personales.Semestre_Ant3 = obj.Semestre_Ant3;
                    datos_Personales.Nombre_Materia_Ant4 = obj.Nombre_Materia_Ant4;
                    datos_Personales.Carrera_Ant4 = obj.Carrera_Ant4;
                    datos_Personales.Semestre_Ant4 = obj.Semestre_Ant4;
                    datos_Personales.Nombre_Materia_Ant5 = obj.Nombre_Materia_Ant5;
                    datos_Personales.Carrera_Ant5 = obj.Carrera_Ant5;
                    datos_Personales.Semestre_Ant5 = obj.Semestre_Ant5;
                    datos_Personales.Nombre_Materia_Ant6 = obj.Nombre_Materia_Ant6;
                    datos_Personales.Carrera_Ant6 = obj.Carrera_Ant6;
                    datos_Personales.Semestre_Ant6 = obj.Semestre_Ant6;
                    datos_Personales.Nombre_Materia_Ant7 = obj.Nombre_Materia_Ant7;
                    datos_Personales.Carrera_Ant7 = obj.Carrera_Ant7;
                    datos_Personales.Semestre_Ant7 = obj.Semestre_Ant7;
                    datos_Personales.Nombre_Materia_Ant8 = obj.Nombre_Materia_Ant8;
                    datos_Personales.Carrera_Ant8 = obj.Carrera_Ant8;
                    datos_Personales.Semestre_Ant8 = obj.Semestre_Ant8;
                    datos_Personales.Nombre_Materia_Ant9 = obj.Nombre_Materia_Ant9;
                    datos_Personales.Carrera_Ant9 = obj.Carrera_Ant9;
                    datos_Personales.Semestre_Ant9 = obj.Semestre_Ant9;
                    datos_Personales.Nombre_Materia_Imp = obj.Nombre_Materia_Imp;
                    datos_Personales.Carrera_Imp = obj.Carrera_Imp;
                    datos_Personales.Semestre_Imp = obj.Semestre_Imp;
                    datos_Personales.Nombre_Materia_Imp2 = obj.Nombre_Materia_Imp2;
                    datos_Personales.Carrera_Imp2 = obj.Carrera_Imp2;
                    datos_Personales.Semestre_Imp2 = obj.Semestre_Imp2;
                    datos_Personales.Nombre_Materia_Imp3 = obj.Nombre_Materia_Imp3;
                    datos_Personales.Carrera_Imp3 = obj.Carrera_Imp3;
                    datos_Personales.Semestre_Imp3 = obj.Semestre_Imp3;
                    datos_Personales.Nombre_Materia_Imp4 = obj.Nombre_Materia_Imp4;
                    datos_Personales.Carrera_Imp4 = obj.Carrera_Imp4;
                    datos_Personales.Semestre_Imp4 = obj.Semestre_Imp4;
                    datos_Personales.Nombre_Materia_Imp5 = obj.Nombre_Materia_Imp5;
                    datos_Personales.Carrera_Imp5 = obj.Carrera_Imp5;
                    datos_Personales.Semestre_Imp5 = obj.Semestre_Imp5;
                    datos_Personales.Nombre_Materia_Imp6 = obj.Nombre_Materia_Imp6;
                    datos_Personales.Carrera_Imp6 = obj.Carrera_Imp6;
                    datos_Personales.Semestre_Imp6 = obj.Semestre_Imp6;
                    datos_Personales.Nombre_Materia_Imp7 = obj.Nombre_Materia_Imp7;
                    datos_Personales.Carrera_Imp7 = obj.Carrera_Imp7;
                    datos_Personales.Semestre_Imp7 = obj.Semestre_Imp7;
                    datos_Personales.Nombre_Materia_Imp8 = obj.Nombre_Materia_Imp8;
                    datos_Personales.Carrera_Imp8 = obj.Carrera_Imp8;
                    datos_Personales.Semestre_Imp8 = obj.Semestre_Imp8;
                    datos_Personales.Nombre_Materia_Imp9 = obj.Nombre_Materia_Imp9;
                    datos_Personales.Carrera_Imp9 = obj.Carrera_Imp9;
                    datos_Personales.Semestre_Imp9 = obj.Semestre_Imp9;
                    datos_Personales.Nombre_Materia_Imp10 = obj.Nombre_Materia_Imp10;
                    datos_Personales.Carrera_Imp10 = obj.Carrera_Imp10;
                    datos_Personales.Semestre_Imp10 = obj.Semestre_Imp10; ;
                }
                return View(datos_Personales);
            }
            return View();
        }

        [HttpPost]
        public ActionResult Editar(ML.Entities.Datos_Personales alumnos)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44372/");

            var request = clientHttp.PutAsync("api/Update/", alumnos, new JsonMediaTypeFormatter()).Result;

            if (request.IsSuccessStatusCode)
            {
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<ML.Entities.Datos_Personales>(DatosInfo);
                if (!ModelState.IsValid)
                {
                    return View(Listado);
                }
                return RedirectToAction("Index");
            }

            return View();
        }


        [HttpGet]
        public ActionResult Delete(int ID)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44372/");

            var request = clientHttp.DeleteAsync("api/Delete/" + ID).Result;

            if (request.IsSuccessStatusCode)
            {
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<ML.Entities.Datos_Personales>(DatosInfo);
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult DeleteA(int ID, int ID2)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44372/");

            var request = clientHttp.DeleteAsync("api/DeleteH/" + ID + "/"+ ID2).Result;

            if (request.IsSuccessStatusCode)
            {
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<ML.Entities.Datos_Personales>(DatosInfo);
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Asignar(int id = 0)
        {
            return View(new ML.Entities.Horarios());
        }

        [HttpPost]
        public ActionResult Asignar(ML.Entities.Horarios horarios)
        {


            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44372/");

            var request = clientHttp.PostAsync("api/AddH", horarios, new JsonMediaTypeFormatter()).Result;

            if (request.IsSuccessStatusCode)
            {
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<ML.Entities.Horarios>(DatosInfo);
                if (!ModelState.IsValid)
                {
                    return View(Listado);
                }
                return RedirectToAction("Index");
            }

            return View();
        }




    }    
}

