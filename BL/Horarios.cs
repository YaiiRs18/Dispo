using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Horarios
    {
        public static ML.Response.Horarios_Response GetAll()
        {
            ML.Response.Horarios_Response response = new ML.Response.Horarios_Response();
            try
            {
                using (DL.DisponibilidadHorariosEntities1 context = new DL.DisponibilidadHorariosEntities1())
                {
                    var GetAll = context.SP_Horarios_GetAll().ToList();

                    if (GetAll != null)
                    {
                        response.Code = 100;
                        response.Message = "Mapeo Exitoso";
                        response.HorariosList = new List<ML.Entities.Horarios>();


                        foreach (var obj in GetAll)
                        {
                            ML.Entities.Horarios HorariosItem = new ML.Entities.Horarios();

                            HorariosItem.Id_Horarios = obj.Id_Horarios;
                            HorariosItem.Lunes7a8 = obj.Lunes7a8;
                            HorariosItem.Martes7a8 = obj.Martes7a8;
                            HorariosItem.Miercoles7a8 = obj.Miercoles7a8;
                            HorariosItem.Jueves7a8 = obj.Jueves7a8;
                            HorariosItem.Viernes7a8 = obj.Viernes7a8;
                            HorariosItem.Sabado7a8 = obj.Sabado7a8;
                            HorariosItem.Lunes8a9 = obj.Lunes8a9;
                            HorariosItem.Martes8a9 = obj.Martes8a9;
                            HorariosItem.Miercoles8a9 = obj.Miercoles8a9;
                            HorariosItem.Jueves8a9 = obj.Jueves8a9;
                            HorariosItem.Viernes8a9 = obj.Viernes8a9;
                            HorariosItem.Sabado8a9 = obj.Sabado8a9;
                            HorariosItem.Lunes9a10 = obj.Lunes9a10;
                            HorariosItem.Martes9a10 = obj.Martes9a10;
                            HorariosItem.Miercoles9a10 = obj.Miercoles9a10;
                            HorariosItem.Jueves9a10 = obj.Jueves9a10;
                            HorariosItem.Viernes9a10 = obj.Viernes9a10;
                            HorariosItem.Sabado9a10 = obj.Sabado9a10;
                            HorariosItem.Lunes10a11 = obj.Lunes10a11;
                            HorariosItem.Martes10a11 = obj.Martes10a11;
                            HorariosItem.Miercoles10a11 = obj.Miercoles10a11;
                            HorariosItem.Jueves10a11 = obj.Jueves10a11;
                            HorariosItem.Viernes10a11 = obj.Viernes10a11;
                            HorariosItem.Sabado10a11 = obj.Sabado10a11;
                            HorariosItem.Lunes11a12 = obj.Lunes11a12;
                            HorariosItem.Martes11a12 = obj.Martes11a12;
                            HorariosItem.Miercoles11a12 = obj.Miercoles11a12;
                            HorariosItem.Jueves11a12 = obj.Jueves11a12;
                            HorariosItem.Viernes11a12 = obj.Viernes11a12;
                            HorariosItem.Sabado11a12 = obj.Sabado11a12;
                            HorariosItem.Lunes12a13 = obj.Lunes12a13;
                            HorariosItem.Martes12a13 = obj.Martes12a13;
                            HorariosItem.Miercoles12a13 = obj.Miercoles12a13;
                            HorariosItem.Jueves12a13 = obj.Jueves12a13;
                            HorariosItem.Viernes12a13 = obj.Viernes12a13;
                            HorariosItem.Sabado12a13 = obj.Sabado12a13;
                            HorariosItem.Lunes13a14 = obj.Lunes13a14;
                            HorariosItem.Martes13a14 = obj.Martes13a14;
                            HorariosItem.Miercoles13a14 = obj.Miercoles13a14;
                            HorariosItem.Jueves13a14 = obj.Jueves13a14;
                            HorariosItem.Viernes13a14 = obj.Viernes13a14;
                            HorariosItem.Sabado13a14 = obj.Sabado13a14;
                            HorariosItem.Lunes14a15 = obj.Lunes14a15;
                            HorariosItem.Martes14a15 = obj.Martes14a15;
                            HorariosItem.Miercoles14a15 = obj.Miercoles14a15;
                            HorariosItem.Jueves14a15 = obj.Jueves14a15;
                            HorariosItem.Viernes14a15 = obj.Viernes14a15;
                            HorariosItem.Sabado14a15 = obj.Sabado14a15;
                            HorariosItem.Lunes15a16 = obj.Lunes15a16;
                            HorariosItem.Martes15a16 = obj.Martes15a16;
                            HorariosItem.Miercoles15a16 = obj.Miercoles15a16;
                            HorariosItem.Jueves15a16 = obj.Jueves15a16;
                            HorariosItem.Viernes15a16 = obj.Viernes15a16;
                            HorariosItem.Sabado15a16 = obj.Sabado15a16;
                            HorariosItem.Lunes16a17 = obj.Lunes16a17;
                            HorariosItem.Martes16a17 = obj.Martes16a17;
                            HorariosItem.Miercoles16a17 = obj.Miercoles16a17;
                            HorariosItem.Jueves16a17 = obj.Jueves16a17;
                            HorariosItem.Viernes16a17 = obj.Viernes16a17;
                            HorariosItem.Sabado16a17 = obj.Sabado16a17;
                            HorariosItem.Lunes17a18 = obj.Lunes17a18;
                            HorariosItem.Martes17a18 = obj.Martes17a18;
                            HorariosItem.Miercoles17a18 = obj.Miercoles17a18;
                            HorariosItem.Jueves17a18 = obj.Jueves17a18;
                            HorariosItem.Viernes17a18 = obj.Viernes17a18;
                            HorariosItem.Sabado17a18 = obj.Sabado17a18;
                            HorariosItem.Lunes18a19 = obj.Lunes18a19;
                            HorariosItem.Martes18a19 = obj.Martes18a19;
                            HorariosItem.Miercoles18a19 = obj.Miercoles18a19;
                            HorariosItem.Jueves18a19 = obj.Jueves18a19;
                            HorariosItem.Viernes18a19 = obj.Viernes18a19;
                            HorariosItem.Sabado18a19 = obj.Sabado18a19;
                            HorariosItem.Lunes19a20 = obj.Lunes19a20;
                            HorariosItem.Martes19a20 = obj.Martes19a20;
                            HorariosItem.Miercoles19a20 = obj.Miercoles19a20;
                            HorariosItem.Jueves19a20 = obj.Jueves19a20;
                            HorariosItem.Viernes19a20 = obj.Viernes19a20;
                            HorariosItem.Sabado19a20 = obj.Sabado19a20;
                            HorariosItem.Lunes20a21 = obj.Lunes20a21;
                            HorariosItem.Martes20a21 = obj.Martes20a21;
                            HorariosItem.Miercoles20a21 = obj.Miercoles20a21;
                            HorariosItem.Jueves20a21 = obj.Jueves20a21;
                            HorariosItem.Viernes20a21 = obj.Viernes20a21;
                            HorariosItem.Sabado20a21 = obj.Sabado20a21;
                            HorariosItem.Lunes21a22 = obj.Lunes21a22;
                            HorariosItem.Martes21a22 = obj.Martes21a22;
                            HorariosItem.Miercoles21a22 = obj.Miercoles21a22;
                            HorariosItem.Jueves21a22 = obj.Jueves21a22;
                            HorariosItem.Viernes21a22 = obj.Viernes21a22;
                            HorariosItem.Sabado21a22 = obj.Sabado21a22;
                        
                            HorariosItem.Id_Datos_Personales = obj.Id_Datos_Personales;
                            response.HorariosList.Add(HorariosItem);







                        }
                        return response;

                    }
                    else
                    {
                        response.Code = 50;
                        response.Message = "Error al mapear";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;
                    }


                }
            }
            catch (Exception ex)
            {
                response.Code = -100;
                response.Message = "Reporta con sistemas" + ex;
                response.HorariosList = new List<ML.Entities.Horarios>();
                return response;
            }



        }

        public static ML.Response.Horarios_Response GetById(int ID)
        {
            ML.Response.Horarios_Response response = new ML.Response.Horarios_Response();
            try
            {
                using (DL.DisponibilidadHorariosEntities1 context = new DL.DisponibilidadHorariosEntities1())
                {
                    var GetById = context.SP_GetByIdDP(ID);

                    if (GetById != null)
                    {
                        response.Code = 100;
                        response.Message = "Mapeo Exitoso";
                        response.HorariosList = new List<ML.Entities.Horarios>();


                        foreach (var obj in GetById)
                        {
                            ML.Entities.Horarios HorariosItem = new ML.Entities.Horarios();

                            HorariosItem.Id_Horarios = obj.Id_Horarios;
                            HorariosItem.Lunes7a8 = obj.Lunes7a8;
                            HorariosItem.Martes7a8 = obj.Martes7a8;
                            HorariosItem.Miercoles7a8 = obj.Miercoles7a8;
                            HorariosItem.Jueves7a8 = obj.Jueves7a8;
                            HorariosItem.Viernes7a8 = obj.Viernes7a8;
                            HorariosItem.Sabado7a8 = obj.Sabado7a8;
                            HorariosItem.Lunes8a9 = obj.Lunes8a9;
                            HorariosItem.Martes8a9 = obj.Martes8a9;
                            HorariosItem.Miercoles8a9 = obj.Miercoles8a9;
                            HorariosItem.Jueves8a9 = obj.Jueves8a9;
                            HorariosItem.Viernes8a9 = obj.Viernes8a9;
                            HorariosItem.Sabado8a9 = obj.Sabado8a9;
                            HorariosItem.Lunes9a10 = obj.Lunes9a10;
                            HorariosItem.Martes9a10 = obj.Martes9a10;
                            HorariosItem.Miercoles9a10 = obj.Miercoles9a10;
                            HorariosItem.Jueves9a10 = obj.Jueves9a10;
                            HorariosItem.Viernes9a10 = obj.Viernes9a10;
                            HorariosItem.Sabado9a10 = obj.Sabado9a10;
                            HorariosItem.Lunes10a11 = obj.Lunes10a11;
                            HorariosItem.Martes10a11 = obj.Martes10a11;
                            HorariosItem.Miercoles10a11 = obj.Miercoles10a11;
                            HorariosItem.Jueves10a11 = obj.Jueves10a11;
                            HorariosItem.Viernes10a11 = obj.Viernes10a11;
                            HorariosItem.Sabado10a11 = obj.Sabado10a11;
                            HorariosItem.Lunes11a12 = obj.Lunes11a12;
                            HorariosItem.Martes11a12 = obj.Martes11a12;
                            HorariosItem.Miercoles11a12 = obj.Miercoles11a12;
                            HorariosItem.Jueves11a12 = obj.Jueves11a12;
                            HorariosItem.Viernes11a12 = obj.Viernes11a12;
                            HorariosItem.Sabado11a12 = obj.Sabado11a12;
                            HorariosItem.Lunes12a13 = obj.Lunes12a13;
                            HorariosItem.Martes12a13 = obj.Martes12a13;
                            HorariosItem.Miercoles12a13 = obj.Miercoles12a13;
                            HorariosItem.Jueves12a13 = obj.Jueves12a13;
                            HorariosItem.Viernes12a13 = obj.Viernes12a13;
                            HorariosItem.Sabado12a13 = obj.Sabado12a13;
                            HorariosItem.Lunes13a14 = obj.Lunes13a14;
                            HorariosItem.Martes13a14 = obj.Martes13a14;
                            HorariosItem.Miercoles13a14 = obj.Miercoles13a14;
                            HorariosItem.Jueves13a14 = obj.Jueves13a14;
                            HorariosItem.Viernes13a14 = obj.Viernes13a14;
                            HorariosItem.Sabado13a14 = obj.Sabado13a14;
                            HorariosItem.Lunes14a15 = obj.Lunes14a15;
                            HorariosItem.Martes14a15 = obj.Martes14a15;
                            HorariosItem.Miercoles14a15 = obj.Miercoles14a15;
                            HorariosItem.Jueves14a15 = obj.Jueves14a15;
                            HorariosItem.Viernes14a15 = obj.Viernes14a15;
                            HorariosItem.Sabado14a15 = obj.Sabado14a15;
                            HorariosItem.Lunes15a16 = obj.Lunes15a16;
                            HorariosItem.Martes15a16 = obj.Martes15a16;
                            HorariosItem.Miercoles15a16 = obj.Miercoles15a16;
                            HorariosItem.Jueves15a16 = obj.Jueves15a16;
                            HorariosItem.Viernes15a16 = obj.Viernes15a16;
                            HorariosItem.Sabado15a16 = obj.Sabado15a16;
                            HorariosItem.Lunes16a17 = obj.Lunes16a17;
                            HorariosItem.Martes16a17 = obj.Martes16a17;
                            HorariosItem.Miercoles16a17 = obj.Miercoles16a17;
                            HorariosItem.Jueves16a17 = obj.Jueves16a17;
                            HorariosItem.Viernes16a17 = obj.Viernes16a17;
                            HorariosItem.Sabado16a17 = obj.Sabado16a17;
                            HorariosItem.Lunes17a18 = obj.Lunes17a18;
                            HorariosItem.Martes17a18 = obj.Martes17a18;
                            HorariosItem.Miercoles17a18 = obj.Miercoles17a18;
                            HorariosItem.Jueves17a18 = obj.Jueves17a18;
                            HorariosItem.Viernes17a18 = obj.Viernes17a18;
                            HorariosItem.Sabado17a18 = obj.Sabado17a18;
                            HorariosItem.Lunes18a19 = obj.Lunes18a19;
                            HorariosItem.Martes18a19 = obj.Martes18a19;
                            HorariosItem.Miercoles18a19 = obj.Miercoles18a19;
                            HorariosItem.Jueves18a19 = obj.Jueves18a19;
                            HorariosItem.Viernes18a19 = obj.Viernes18a19;
                            HorariosItem.Sabado18a19 = obj.Sabado18a19;
                            HorariosItem.Lunes19a20 = obj.Lunes19a20;
                            HorariosItem.Martes19a20 = obj.Martes19a20;
                            HorariosItem.Miercoles19a20 = obj.Miercoles19a20;
                            HorariosItem.Jueves19a20 = obj.Jueves19a20;
                            HorariosItem.Viernes19a20 = obj.Viernes19a20;
                            HorariosItem.Sabado19a20 = obj.Sabado19a20;
                            HorariosItem.Lunes20a21 = obj.Lunes20a21;
                            HorariosItem.Martes20a21 = obj.Martes20a21;
                            HorariosItem.Miercoles20a21 = obj.Miercoles20a21;
                            HorariosItem.Jueves20a21 = obj.Jueves20a21;
                            HorariosItem.Viernes20a21 = obj.Viernes20a21;
                            HorariosItem.Sabado20a21 = obj.Sabado20a21;
                            HorariosItem.Lunes21a22 = obj.Lunes21a22;
                            HorariosItem.Martes21a22 = obj.Martes21a22;
                            HorariosItem.Miercoles21a22 = obj.Miercoles21a22;
                            HorariosItem.Jueves21a22 = obj.Jueves21a22;
                            HorariosItem.Viernes21a22 = obj.Viernes21a22;
                            HorariosItem.Sabado21a22 = obj.Sabado21a22;
                            HorariosItem.Id_Datos_Personales = obj.Id_Datos_Personales;
                            response.HorariosList.Add(HorariosItem);







                        }
                        return response;

                    }
                    else
                    {
                        response.Code = 50;
                        response.Message = "Error al mapear";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;
                    }


                }
            }
            catch (Exception ex)
            {
                response.Code = -100;
                response.Message = "Reporta con sistemas" + ex;
                response.HorariosList = new List<ML.Entities.Horarios>();
                return response;
            }



        }

        public static ML.Response.Horarios_Response Add(ML.Entities.Horarios horarios)
        {
            ML.Response.Horarios_Response response = new ML.Response.Horarios_Response();
            try
            {

                using (DL.DisponibilidadHorariosEntities1 context = new DL.DisponibilidadHorariosEntities1())
                {
                   
                    var Add = context.SP_Horarios_Add(horarios.Lunes7a8, horarios.Martes7a8, horarios.Miercoles7a8,
                        horarios.Jueves7a8, horarios.Viernes7a8, horarios.Sabado7a8,
                        horarios.Lunes8a9, horarios.Martes8a9, horarios.Miercoles8a9,
                        horarios.Jueves8a9, horarios.Viernes8a9, horarios.Sabado8a9,
                        horarios.Lunes9a10, horarios.Martes9a10, horarios.Miercoles9a10,
                        horarios.Jueves9a10, horarios.Viernes9a10, horarios.Sabado9a10,
                        horarios.Lunes10a11, horarios.Martes10a11, horarios.Miercoles10a11,
                        horarios.Jueves10a11, horarios.Viernes10a11, horarios.Sabado10a11,
                        horarios.Lunes11a12, horarios.Martes11a12, horarios.Miercoles11a12,
                        horarios.Jueves11a12, horarios.Viernes11a12, horarios.Sabado11a12,
                        horarios.Lunes12a13, horarios.Martes12a13, horarios.Miercoles12a13,
                        horarios.Jueves12a13, horarios.Viernes12a13, horarios.Sabado12a13,
                        horarios.Lunes13a14, horarios.Martes13a14, horarios.Miercoles13a14,
                        horarios.Jueves13a14, horarios.Viernes13a14, horarios.Sabado13a14,
                        horarios.Lunes14a15, horarios.Martes14a15, horarios.Miercoles14a15,
                        horarios.Jueves14a15, horarios.Viernes14a15, horarios.Sabado14a15,
                        horarios.Lunes15a16, horarios.Martes15a16, horarios.Miercoles15a16,
                        horarios.Jueves15a16, horarios.Viernes15a16, horarios.Sabado15a16,
                        horarios.Lunes16a17, horarios.Martes16a17, horarios.Miercoles16a17,
                        horarios.Jueves16a17, horarios.Viernes16a17, horarios.Sabado16a17,
                        horarios.Lunes17a18, horarios.Martes17a18, horarios.Miercoles17a18,
                        horarios.Jueves17a18, horarios.Viernes17a18, horarios.Sabado17a18,
                        horarios.Lunes18a19, horarios.Martes18a19, horarios.Miercoles18a19,
                        horarios.Jueves18a19, horarios.Viernes18a19, horarios.Sabado18a19,
                        horarios.Lunes19a20, horarios.Martes19a20, horarios.Miercoles19a20,
                        horarios.Jueves19a20, horarios.Viernes19a20, horarios.Sabado19a20,
                        horarios.Lunes20a21, horarios.Martes20a21, horarios.Miercoles20a21,
                        horarios.Jueves20a21, horarios.Viernes20a21, horarios.Sabado20a21,
                        horarios.Lunes21a22, horarios.Martes21a22, horarios.Miercoles21a22,
                        horarios.Jueves21a22, horarios.Viernes21a22, horarios.Sabado21a22,horarios.Id_Datos_Personales);

                    if (Add > 0)
                    {
                        response.Code = 100;
                        response.Message = "Se Agrego con exito";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;


                    }

                    else
                    {
                        response.Code = 50;
                        response.Message = "Error al agregar";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;


                    }

                }

            }
            catch (Exception ex)
            {

                response.Code = -100;
                response.Message = "Reporta con sistemas" + ex;
                response.HorariosList = new List<ML.Entities.Horarios>();
                return response;

            }





        }

        public static ML.Response.Horarios_Response Update(ML.Entities.Horarios horarios)
        {
            ML.Response.Horarios_Response response = new ML.Response.Horarios_Response();
            try
            {
                using (DL.DisponibilidadHorariosEntities1 context = new DL.DisponibilidadHorariosEntities1())
                {
                    var Update = context.SP_Horarios_Editar(horarios.Id_Horarios,horarios.Lunes7a8, horarios.Martes7a8, horarios.Miercoles7a8,
                                                            horarios.Jueves7a8, horarios.Viernes7a8, horarios.Sabado7a8,
                                                            horarios.Lunes8a9, horarios.Martes8a9, horarios.Miercoles8a9,
                                                            horarios.Jueves8a9, horarios.Viernes8a9, horarios.Sabado8a9,
                                                            horarios.Lunes9a10, horarios.Martes9a10, horarios.Miercoles9a10,
                                                            horarios.Jueves9a10, horarios.Viernes9a10, horarios.Sabado9a10,
                                                            horarios.Lunes10a11, horarios.Martes10a11, horarios.Miercoles10a11,
                                                            horarios.Jueves10a11, horarios.Viernes10a11, horarios.Sabado10a11,
                                                            horarios.Lunes11a12, horarios.Martes11a12, horarios.Miercoles11a12,
                                                            horarios.Jueves11a12, horarios.Viernes11a12, horarios.Sabado11a12,
                                                            horarios.Lunes12a13, horarios.Martes12a13, horarios.Miercoles12a13,
                                                            horarios.Jueves12a13, horarios.Viernes12a13, horarios.Sabado12a13,
                                                            horarios.Lunes13a14, horarios.Martes13a14, horarios.Miercoles13a14,
                                                            horarios.Jueves13a14, horarios.Viernes13a14, horarios.Sabado13a14,
                                                            horarios.Lunes14a15, horarios.Martes14a15, horarios.Miercoles14a15,
                                                            horarios.Jueves14a15, horarios.Viernes14a15, horarios.Sabado14a15,
                                                            horarios.Lunes15a16, horarios.Martes15a16, horarios.Miercoles15a16,
                                                            horarios.Jueves15a16, horarios.Viernes15a16, horarios.Sabado15a16,
                                                            horarios.Lunes16a17, horarios.Martes16a17, horarios.Miercoles16a17,
                                                            horarios.Jueves16a17, horarios.Viernes16a17, horarios.Sabado16a17,
                                                            horarios.Lunes17a18, horarios.Martes17a18, horarios.Miercoles17a18,
                                                            horarios.Jueves17a18, horarios.Viernes17a18, horarios.Sabado17a18,
                                                            horarios.Lunes18a19, horarios.Martes18a19, horarios.Miercoles18a19,
                                                            horarios.Jueves18a19, horarios.Viernes18a19, horarios.Sabado18a19,
                                                            horarios.Lunes19a20, horarios.Martes19a20, horarios.Miercoles19a20,
                                                            horarios.Jueves19a20, horarios.Viernes19a20, horarios.Sabado19a20,
                                                            horarios.Lunes20a21, horarios.Martes20a21, horarios.Miercoles20a21,
                                                            horarios.Jueves20a21, horarios.Viernes20a21, horarios.Sabado20a21,
                                                            horarios.Lunes21a22, horarios.Martes21a22, horarios.Miercoles21a22,
                                                            horarios.Jueves21a22, horarios.Viernes21a22, horarios.Sabado21a22, horarios.Id_Datos_Personales);

                    if (Update > 0)
                    {
                        response.Code = 100;
                        response.Message = "Se Actualizo con exito";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;
                    }

                    else
                    {

                        response.Code = 50;
                        response.Message = "Error al actualizar";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;

                    }
                }
          



            }
            catch (Exception ex)
            {

                response.Code = -100;
                response.Message = "Reporta con sistemas" + ex;
                response.HorariosList = new List<ML.Entities.Horarios>();
                return response;
            }




        }

        public static ML.Response.Horarios_Response Delete(int ID, int ID2)
        {
            ML.Response.Horarios_Response response = new ML.Response.Horarios_Response();
            try
            {
                using (DL.DisponibilidadHorariosEntities1 context = new DL.DisponibilidadHorariosEntities1())
                {

                    var Delete = context.SP_DatosANDHorariosDelete(ID, ID2);

                    if (Delete>0)
                    {
                        response.Code = 100;
                        response.Message = "se elimino con exito";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;



                    }
                    else
                    {
                        response.Code = 50;
                        response.Message = "error al eliminar";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;
                    }


                }
            }
            catch (Exception ex)
            {
                response.Code = 100;
                response.Message = "se elimino con exito" + ex;
                response.HorariosList = new List<ML.Entities.Horarios>();
                return response;
            }



        }

    }
}
