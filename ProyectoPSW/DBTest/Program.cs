using ProyectoPSWMain.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ProyectoPSWMain.Entities;
using System.Data.Entity.Validation;
using ProyectoPSWMain.Services;
using System.Data.Entity.Infrastructure;

namespace DBTest
{
    internal class Program
    {
       
            static void Main(string[] args)
            {

                try
                {
                    new Program();
                }
                catch (Exception e)
                {
                    printError(e);
                }
                Console.WriteLine("\nPulse una tecla para salir");
                Console.ReadLine();
            }
        
            static void printError(Exception e)
            {
                while (e != null)
                {
                    if (e is DbEntityValidationException)
                    {
                        DbEntityValidationException dbe = (DbEntityValidationException)e;

                        foreach (var eve in dbe.EntityValidationErrors)
                        {
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                    ve.PropertyName,
                                    eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                    ve.ErrorMessage);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR: " + e.Message);
                    }
                    e = e.InnerException;
                }
            }
        
        
            Program()
            {
            IRepository dal = new EntityFrameworkDAL( new ProyectPSWDBContext());

                CreateSampleDB(dal);
            }
       
            private void CreateSampleDB(IRepository dal)
            {
                dal.RemoveAllData();
            
                Console.WriteLine("Creando los datos y almacenándolos en la BD");
                Console.WriteLine("===========================================");
            
              Console.WriteLine("\n// CREACIÓN DE UNA PARTIDA Y SUS PREGUNTITAS");
              User user = new User("NickElodeon","nickputero@gmail.com","NickPutero123?", new Estadistica(0,0));
                Partida partida = new Partida(1, 0);
                dal.Insert<Partida>(partida);
                 dal.Insert<User>(user);
                dal.Commit();

            //--------------------------------ODS 1---------------------------------------------
            ICollection<Respuesta> respuestasMal = new List<Respuesta>();
            Respuesta respuesta1mal = new Respuesta("Reducir a la mitad la pobreza extrema en todas sus formas");
            respuestasMal.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            Respuesta respuesta2mal = new Respuesta("Reducir en un 25% la pobreza extrema en todas sus formas");
            respuestasMal.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            Respuesta respuesta3mal = new Respuesta("Reducir en un 75% la pobreza extrema en todas sus formas");
            respuestasMal.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            Respuesta respuestaBien = new Respuesta("Erradicar la pobreza extrema en todas sus formas");
            respuestasMal.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);
            
            Pregunta pregunta = new Pregunta(respuestasMal, "¿Cuál es la meta de la ODS 1 para el año 2030?", 1, 100, respuestaBien.Texto, 1, false);
            
            dal.Insert<Pregunta>(pregunta);
            dal.Commit();


            ICollection<Respuesta> respuestasMal1 = new List<Respuesta>();
            respuesta1mal.Texto = "La falta de acceso a la educación";
            respuestasMal1.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La falta de acceso a servicios de salud";
            respuestasMal1.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "La discriminación racial y de género";
            respuestasMal1.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "La falta de empleo y oportunidades económicas";
            respuestasMal1.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta1 = new Pregunta(respuestasMal1, "¿Cuál es la principal causa de la pobreza extrema según la ODS 1?", 2, 200, respuestaBien.Texto, 1, true);
            dal.Insert<Pregunta>(pregunta1);
            dal.Commit();

            ICollection<Respuesta> respuestasMal2 = new List<Respuesta>();
            respuesta1mal.Texto = "Promover el crecimiento económico sin regulaciones";
            respuestasMal2.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Proporcionar asistencia financiera sin condiciones";
            respuestasMal2.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Promover la filantropía y las donaciones privadas";
            respuestasMal2.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Implementar políticas públicas que fomenten la inclusión social y económica";
            respuestasMal2.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta2 = new Pregunta(respuestasMal2, "¿Qué estrategia propone la ODS 1 para reducir la pobreza extrema?", 3, 300, respuestaBien.Texto, 1, true);
            dal.Insert<Pregunta>(pregunta2);
            dal.Commit();

            ICollection<Respuesta> respuestasMal3 = new List<Respuesta>();
            respuesta1mal.Texto = "Promover la igualdad salarial entre hombres y mujeres";
            respuestasMal3.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Garantizar el acceso a la educación de calidad para todas las niñas";
            respuestasMal3.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Todas las anteriores";
            respuestasMal3.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Reducir la brecha de género en el acceso al empleo";
            respuestasMal3.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta3 = new Pregunta(respuestasMal3, "¿Cuál es el objetivo específico de la ODS 1 relacionado con la igualdad de género?", 3, 300, respuestaBien.Texto, 1, true);
            dal.Insert<Pregunta>(pregunta3);
            dal.Commit();

            ICollection<Respuesta> respuestasMal4 = new List<Respuesta>();
            respuesta1mal.Texto = "América Latina y el Caribe";
            respuestasMal4.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Asia meridional";
            respuestasMal4.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Europa del Este y Asia Central";
            respuestasMal4.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "África subsahariana";
            respuestasMal4.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta4 = new Pregunta(respuestasMal4, "¿Cuál es la región del mundo con el mayor número de personas en situación de pobreza extrema según la ODS 1?", 3, 300, respuestaBien.Texto, 1, true);
            dal.Insert<Pregunta>(pregunta4);
            dal.Commit();

            ICollection<Respuesta> respuestasMal5 = new List<Respuesta>();
            respuesta1mal.Texto = "La pobreza no tiene impacto en la salud";
            respuestasMal5.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Las personas en situación de pobreza tienen una mejor salud que las personas de mayores ingresos";
            respuestasMal5.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Las personas en situación de pobreza tienen un acceso igualitario a los servicios de salud";
            respuestasMal5.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);

            respuestaBien.Texto = "Las personas en situación de pobreza tienen un mayor riesgo de enfermedades y mortalidad";
            respuestasMal5.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta5 = new Pregunta(respuestasMal5, "¿Cuál es el impacto de la pobreza en la salud según la ODS 1?", 2, 200, respuestaBien.Texto, 1, true);
            dal.Insert<Pregunta>(pregunta5);
            dal.Commit();

            //--------------------------------ODS 2---------------------------------------------

            ICollection<Respuesta> respuestasMal6 = new List<Respuesta>();
            respuesta1mal.Texto = "Reducir el cambio climático";
            respuestasMal6.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Erradicar la pobreza extrema";
            respuestasMal6.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Promover la igualdad de género";
            respuestasMal6.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Lograr la seguridad alimentaria y la nutrición para todos";
            respuestasMal6.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta6 = new Pregunta(respuestasMal6, "¿Cuál es el objetivo principal de la ODS 2?", 1, 100, respuestaBien.Texto, 2, false);
            dal.Insert<Pregunta>(pregunta6);
            dal.Commit();

            ICollection<Respuesta> respuestasMal7 = new List<Respuesta>();
            respuesta1mal.Texto = "Reducir a la mitad la cantidad de personas que padecen hambre";
            respuestasMal7.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Aumentar la producción de alimentos en un 50%";
            respuestasMal7.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Reducir el desperdicio de alimentos en un 75%";
            respuestasMal7.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Erradicar el hambre en todas sus formas";
            respuestasMal7.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta7 = new Pregunta(respuestasMal7, "¿Cuál es la meta de la ODS 2 para el año 2030?", 1, 100, respuestaBien.Texto, 2, true);
            dal.Insert<Pregunta>(pregunta7);
            dal.Commit();

            ICollection<Respuesta> respuestasMal8 = new List<Respuesta>();
            respuesta1mal.Texto = "América Latina y el Caribe";
            respuestasMal8.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Asia meridional";
            respuestasMal8.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Europa del Este y Asia Central";
            respuestasMal8.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "África subsahariana";
            respuestasMal8.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta8 = new Pregunta(respuestasMal8, "¿Cuál es la región del mundo con el mayor número de personas que padecen hambre según la ODS 2?", 2, 200, respuestaBien.Texto, 2, true);
            dal.Insert<Pregunta>(pregunta8);
            dal.Commit();

            ICollection<Respuesta> respuestasMal9 = new List<Respuesta>();
            respuesta1mal.Texto = "La falta de acceso a alimentos nutritivos";
            respuestasMal9.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La falta de recursos financieros para comprar alimentos";
            respuestasMal9.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "La discriminación racial y de género";
            respuestasMal9.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "La falta de tecnología y conocimientos agrícolas";
            respuestasMal9.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta9 = new Pregunta(respuestasMal9, "¿Cuál es la principal causa del hambre según la ODS 2?", 2, 200, respuestaBien.Texto, 2, true);
            dal.Insert<Pregunta>(pregunta9);
            dal.Commit();


            ICollection<Respuesta> respuestasMal10 = new List<Respuesta>();
            respuesta1mal.Texto = "Promover la igualdad salarial entre hombres y mujeres en el sector agrícola";
            respuestasMal10.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Garantizar el acceso a la educación de calidad para todas las niñas en áreas rurales";
            respuestasMal10.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Todas las anteriores";
            respuestasMal10.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Reducir la brecha de género en el acceso a la tierra y otros recursos productivos";
            respuestasMal10.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta10 = new Pregunta(respuestasMal10, "¿Cuál es el objetivo específico de la ODS 2 relacionado con la igualdad de género?", 3, 300, respuestaBien.Texto, 2, true);
            dal.Insert<Pregunta>(pregunta10);
            dal.Commit();

            ICollection<Respuesta> respuestasMal11 = new List<Respuesta>();
            respuesta1mal.Texto = "Erradicar la Pobreza";
            respuestasMal11.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Hambre Cero";
            respuestasMal11.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Salud y Bienestar";
            respuestasMal11.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Acabar con la Inseguridad Alimentaria";
            respuestasMal11.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta11 = new Pregunta(respuestasMal11, "¿Cuál es el nombre completo de la segunda ODS?", 1, 100, respuestaBien.Texto, 2, false);
            dal.Insert<Pregunta>(pregunta11);
            dal.Commit();

            ICollection<Respuesta> respuestasMal12 = new List<Respuesta>();
            respuesta1mal.Texto = "Aumentar el acceso a servicios de salud de calidad";
            respuestasMal12.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Mejorar la educación primaria en países en desarrollo";
            respuestasMal12.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Fomentar el uso de energías renovables";
            respuestasMal12.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Erradicar el hambre en el mundo";
            respuestasMal12.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta12 = new Pregunta(respuestasMal12, "¿Cuál es el objetivo principal de la segunda ODS?", 1, 100, respuestaBien.Texto, 2, false);
            dal.Insert<Pregunta>(pregunta12);
            dal.Commit();

            ICollection<Respuesta> respuestasMal13 = new List<Respuesta>();
            respuesta1mal.Texto = "5%";
            respuestasMal13.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "10%";
            respuestasMal13.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "30%";
            respuestasMal13.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "20%";
            respuestasMal13.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta13 = new Pregunta(respuestasMal13, "¿Qué porcentaje de la población mundial sufre de inseguridad alimentaria?", 3, 300, respuestaBien.Texto, 2, true);
            dal.Insert<Pregunta>(pregunta13);
            dal.Commit();

            ICollection<Respuesta> respuestasMal14 = new List<Respuesta>();
            respuesta1mal.Texto = "Tecnología de la información";
            respuestasMal14.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Turismo";
            respuestasMal14.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Desigualdad de género";
            respuestasMal14.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Cambio climático";
            respuestasMal14.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta14 = new Pregunta(respuestasMal14, "¿Cuál es uno de los principales factores que contribuyen a la inseguridad alimentaria?", 2, 200, respuestaBien.Texto, 2, true);
            dal.Insert<Pregunta>(pregunta14);
            dal.Commit();

            ICollection<Respuesta> respuestasMal15 = new List<Respuesta>();
            respuesta1mal.Texto = "Aumentar el uso de pesticidas y fertilizantes químicos";
            respuestasMal15.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Promover la agricultura industrial";
            respuestasMal15.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Todas las anteriores";
            respuestasMal15.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Mejorar la productividad y la resiliencia de la agricultura familiar";
            respuestasMal15.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta15 = new Pregunta(respuestasMal15, "¿Cuál es una de las estrategias para lograr la segunda ODS?", 3, 300, respuestaBien.Texto, 2, true);
            dal.Insert<Pregunta>(pregunta15);
            dal.Commit();

            ICollection<Respuesta> respuestasMal16 = new List<Respuesta>();
            respuesta1mal.Texto = "Porque la inseguridad alimentaria contribuye al cambio climático";
            respuestasMal16.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Porque el acceso a alimentos nutritivos es un derecho humano fundamental";
            respuestasMal16.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Porque la falta de seguridad alimentaria perpetúa el ciclo de la pobreza";
            respuestasMal16.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal16.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta16 = new Pregunta(respuestasMal16, "¿Por qué la segunda ODS es importante para lograr un mundo sostenible?", 2, 200, respuestaBien.Texto, 2, true);
            dal.Insert<Pregunta>(pregunta16);
            dal.Commit();

            ICollection<Respuesta> respuestasMal17 = new List<Respuesta>();
            respuesta1mal.Texto = "El porcentaje de la población mundial que vive en áreas urbanas";
            respuestasMal17.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La tasa de mortalidad infantil";
            respuestasMal17.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "El índice de precios de los alimentos";
            respuestasMal17.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "La prevalencia de la inseguridad alimentaria";
            respuestasMal17.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta17 = new Pregunta(respuestasMal17, "¿Cuál es uno de los indicadores utilizados para medir el progreso hacia la segunda ODS?", 2, 200, respuestaBien.Texto, 2, true);
            dal.Insert<Pregunta>(pregunta17);
            dal.Commit();

            ICollection<Respuesta> respuestasMal18 = new List<Respuesta>();
            respuesta1mal.Texto = "La capacidad de cocinar alimentos de manera adecuada";
            respuestasMal18.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Comida rápida y conveniente disponible en todo momento";
            respuestasMal18.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Ninguna de las anteriores";
            respuestasMal18.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Acceso físico y económico a suficientes alimentos nutritivos";
            respuestasMal18.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta18 = new Pregunta(respuestasMal18, "¿Qué se entiende por seguridad alimentaria?", 3, 300, respuestaBien.Texto, 2, true);
            dal.Insert<Pregunta>(pregunta18);
            dal.Commit();
            //--------------ODS 3---------------------------
            ICollection<Respuesta> respuestasMal19 = new List<Respuesta>();
            respuesta1mal.Texto = "Educación de Calidad";
            respuestasMal19.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Igualdad de Género";
            respuestasMal19.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Trabajo Decente y Crecimiento Económico";
            respuestasMal19.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Salud y Bienestar";
            respuestasMal19.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta19 = new Pregunta(respuestasMal19, "¿Cuál es el nombre completo de la tercera ODS?", 1, 100, respuestaBien.Texto, 3, false);
            dal.Insert<Pregunta>(pregunta19);
            dal.Commit();

            ICollection<Respuesta> respuestasMal20 = new List<Respuesta>();
            respuesta1mal.Texto = "Erradicar el hambre en el mundo";
            respuestasMal20.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Mejorar la educación primaria en países en desarrollo";
            respuestasMal20.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Fomentar el uso de energías renovables";
            respuestasMal20.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Aumentar el acceso a servicios de salud de calidad";
            respuestasMal20.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta20 = new Pregunta(respuestasMal20, "¿Cuál es el objetivo principal de la tercera ODS?", 1, 100, respuestaBien.Texto, 3, false);
            dal.Insert<Pregunta>(pregunta20);
            dal.Commit();


            ICollection<Respuesta> respuestasMal21 = new List<Respuesta>();
            respuesta1mal.Texto = "Reducir la mortalidad infantil";
            respuestasMal21.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Mejorar la salud materna";
            respuestasMal21.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Combatir enfermedades no transmisibles";
            respuestasMal21.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Mejorar la calidad de la educación en los países en desarrollo";
            respuestasMal21.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta21 = new Pregunta(respuestasMal21, "¿Cuál de los siguientes no es uno de los objetivos específicos de la tercera ODS?", 1, 100, respuestaBien.Texto, 3, true);
            dal.Insert<Pregunta>(pregunta21);
            dal.Commit();


            ICollection<Respuesta> respuestasMal22 = new List<Respuesta>();
            respuesta1mal.Texto = "La tasa de mortalidad infantil";
            respuestasMal22.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La esperanza de vida al nacer";
            respuestasMal22.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "La prevalencia del VIH/SIDA";
            respuestasMal22.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "El porcentaje de la población que vive en zonas urbanas";
            respuestasMal22.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta22 = new Pregunta(respuestasMal22, "¿Cuál de los siguientes no es un indicador utilizado para medir el progreso hacia la tercera ODS?", 2, 200, respuestaBien.Texto, 3, true);
            dal.Insert<Pregunta>(pregunta22);
            dal.Commit();

            ICollection<Respuesta> respuestasMal23 = new List<Respuesta>();
            respuesta1mal.Texto = "VIH/SIDA";
            respuestasMal23.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Tuberculosis";
            respuestasMal23.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Malaria";
            respuestasMal23.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Poliomielitis";
            respuestasMal23.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta23 = new Pregunta(respuestasMal23, "¿Cuál de las siguientes enfermedades se ha logrado erradicar a nivel mundial gracias a los esfuerzos de la tercera ODS?", 3, 300, respuestaBien.Texto, 3, true);
            dal.Insert<Pregunta>(pregunta23);
            dal.Commit();

            ICollection<Respuesta> respuestasMal24 = new List<Respuesta>();
            respuesta1mal.Texto = "Que todas las personas tengan acceso a los mismos tratamientos médicos";
            respuestasMal24.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Que todas las personas estén cubiertas por un seguro médico privado";
            respuestasMal24.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Ninguna de las anteriores";
            respuestasMal24.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Que todas las personas tengan acceso a servicios de salud de calidad sin tener que enfrentar dificultades financieras";
            respuestasMal24.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta24 = new Pregunta(respuestasMal24, "¿Qué se entiende por cobertura universal de salud?", 3, 300, respuestaBien.Texto, 3, true);
            dal.Insert<Pregunta>(pregunta24);
            dal.Commit();

            ICollection<Respuesta> respuestasMal25 = new List<Respuesta>();
            respuesta1mal.Texto = "Falta de financiamiento para los sistemas de salud";
            respuestasMal25.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Falta de infraestructura adecuada";
            respuestasMal25.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Falta de personal médico capacitado";
            respuestasMal25.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal25.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta25 = new Pregunta(respuestasMal25, "¿Cuál es uno de los principales desafíos para lograr la tercera ODS en los países en desarrollo?", 2, 200, respuestaBien.Texto, 3, true);
            dal.Insert<Pregunta>(pregunta25);
            dal.Commit();

            ICollection<Respuesta> respuestasMal26 = new List<Respuesta>();
            respuesta1mal.Texto = "La ausencia de enfermedades físicas";
            respuestasMal26.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La capacidad de realizar actividades físicas sin problemas de salud";
            respuestasMal26.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Ninguna de las anteriores";
            respuestasMal26.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "El bienestar emocional y psicológico de las personas";
            respuestasMal26.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta26 = new Pregunta(respuestasMal26, "¿Qué se entiende por salud mental según la tercera ODS?", 2, 200, respuestaBien.Texto, 3, true);
            dal.Insert<Pregunta>(pregunta26);
            dal.Commit();

            //------------------------------ODS 4------------------------
            ICollection<Respuesta> respuestasMal27 = new List<Respuesta>();
            respuesta1mal.Texto = "Igualdad de Género";
            respuestasMal27.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Reducción de las Desigualdades";
            respuestasMal27.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Paz, Justicia e Instituciones Sólidas";
            respuestasMal27.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Educación de Calidad";
            respuestasMal27.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta27 = new Pregunta(respuestasMal27, "¿Cuál es el nombre completo de la cuarta ODS?", 1, 100, respuestaBien.Texto, 4, false);
            dal.Insert<Pregunta>(pregunta27);
            dal.Commit();

            ICollection<Respuesta> respuestasMal28 = new List<Respuesta>();
            respuesta1mal.Texto = "Fomentar la igualdad de género en todos los ámbitos";
            respuestasMal28.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Reducir la pobreza y la desigualdad en todo el mundo";
            respuestasMal28.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Promover la paz, la justicia y la solidaridad en todo el mundo";
            respuestasMal28.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Asegurar que todos los niños y niñas tengan acceso a una educación de calidad";
            respuestasMal28.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta28 = new Pregunta(respuestasMal28, "¿Cuál es el objetivo principal de la cuarta ODS?", 1, 100, respuestaBien.Texto, 4, false);
            dal.Insert<Pregunta>(pregunta28);
            dal.Commit();

            ICollection<Respuesta> respuestasMal29 = new List<Respuesta>();
            respuesta1mal.Texto = "Asegurar que todos los niños y niñas completen una educación primaria y secundaria gratuita y equitativa";
            respuestasMal29.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Fomentar la formación de habilidades para el empleo y el emprendimiento";
            respuestasMal29.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Mejorar la calidad de la educación a través de la capacitación de docentes y la utilización de tecnologías innovadoras";
            respuestasMal29.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Aumentar el número de estudiantes universitarios en países en desarrollo";
            respuestasMal29.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta29 = new Pregunta(respuestasMal29, "¿Cuál de las siguientes no es una meta específica de la cuarta ODS?", 2, 200, respuestaBien.Texto, 4, false);
            dal.Insert<Pregunta>(pregunta29);
            dal.Commit();

            ICollection<Respuesta> respuestasMal30 = new List<Respuesta>();
            respuesta1mal.Texto = "La tasa de alfabetización";
            respuestasMal30.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "El porcentaje de niños y niñas que completan la educación primaria";
            respuestasMal30.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "La cantidad de estudiantes universitarios matriculados";
            respuestasMal30.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "La esperanza de vida al nacer";
            respuestasMal30.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta30 = new Pregunta(respuestasMal30, "¿Cuál de los siguientes no es un indicador utilizado para medir el progreso hacia la cuarta ODS?", 1, 100, respuestaBien.Texto, 4, true);
            dal.Insert<Pregunta>(pregunta30);
            dal.Commit();

            ICollection<Respuesta> respuestasMal31 = new List<Respuesta>();
            respuesta1mal.Texto = "Una educación que promueve la igualdad de género";
            respuestasMal31.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Una educación que se enfoca en la tecnología y las habilidades digitales";
            respuestasMal31.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Ninguna de las anteriores";
            respuestasMal31.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Una educación que se adapta a las necesidades de cada estudiante";
            respuestasMal31.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta31 = new Pregunta(respuestasMal31, "¿Qué se entiende por educación inclusiva según la cuarta ODS?", 3, 300, respuestaBien.Texto, 4, true);
            dal.Insert<Pregunta>(pregunta31);
            dal.Commit();

            ICollection<Respuesta> respuestasMal32 = new List<Respuesta>();
            respuesta1mal.Texto = "La falta de infraestructura educativa adecuada";
            respuestasMal32.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "El costo de la educación y los materiales escolares";
            respuestasMal32.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "La falta de capacitación de los docentes";
            respuestasMal32.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "El exceso de oferta de programas de educación";
            respuestasMal32.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta32 = new Pregunta(respuestasMal32, "¿Cuál de las siguientes no es una barrera para el acceso a una educación de calidad según la cuarta ODS?", 2, 200, respuestaBien.Texto, 4, true);
            dal.Insert<Pregunta>(pregunta32);
            dal.Commit();

            ICollection<Respuesta> respuestasMal33 = new List<Respuesta>();
            respuesta1mal.Texto = "Una educación que se enfoca en habilidades prácticas y en el trabajo";
            respuestasMal33.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Una educación que promueve la igualdad de género";
            respuestasMal33.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Ninguna de las anteriores";
            respuestasMal33.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Una educación que se lleva a cabo fuera de un entorno escolar tradicional";
            respuestasMal33.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta33 = new Pregunta(respuestasMal33, "¿Qué se entiende por educación no formal según la cuarta ODS?", 3, 300, respuestaBien.Texto, 4, true);
            dal.Insert<Pregunta>(pregunta33);
            dal.Commit();

            ICollection<Respuesta> respuestasMal34 = new List<Respuesta>();
            respuesta1mal.Texto = "Asegurar la inclusión de todos los niños y niñas, independientemente de su género, raza, origen étnico o condición económica";
            respuestasMal34.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Promover el aprendizaje y la innovación mediante el uso de tecnologías y métodos educativos innovadores";
            respuestasMal34.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Mejorar la capacitación de los docentes y la calidad de la enseñanza";
            respuestasMal34.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Aumentar el número de estudiantes matriculados en programas de educación superior";
            respuestasMal34.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta34 = new Pregunta(respuestasMal34, "¿Cuál de las siguientes medidas no es una forma de promover la calidad de la educación según la cuarta ODS?", 2, 200, respuestaBien.Texto, 4, true);
            dal.Insert<Pregunta>(pregunta34);
            dal.Commit();

            ICollection<Respuesta> respuestasMal35 = new List<Respuesta>();
            respuesta1mal.Texto = "La tecnología no tiene un papel importante en la cuarta ODS";
            respuestasMal35.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La tecnología puede ser perjudicial para la educación de calidad";
            respuestasMal35.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "La tecnología solo es importante en los países desarrollados";
            respuestasMal35.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "La tecnología es un elemento clave para promover la calidad de la educación y la igualdad de oportunidades";
            respuestasMal35.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta35 = new Pregunta(respuestasMal35, "¿Cuál es el papel de la tecnología en la cuarta ODS?", 1, 100, respuestaBien.Texto, 4, true);
            dal.Insert<Pregunta>(pregunta35);
            dal.Commit();

            //------------------------------ODS 5------------------------

            ICollection<Respuesta> respuestasMal36 = new List<Respuesta>();
            respuesta1mal.Texto = "Reducir la mortalidad infantil";
            respuestasMal36.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Mejorar la calidad de la educación";
            respuestasMal36.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Erradicar la pobreza extrema";
            respuestasMal36.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Lograr la igualdad de género";
            respuestasMal36.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta36 = new Pregunta(respuestasMal36, "¿Cuál es el objetivo de la quinta ODS?", 1, 100, respuestaBien.Texto, 5, false);
            dal.Insert<Pregunta>(pregunta36);
            dal.Commit();

            ICollection<Respuesta> respuestasMal37 = new List<Respuesta>();
            respuesta1mal.Texto = "Empoderar a las mujeres y niñas";
            respuestasMal37.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Mejorar la salud materna";
            respuestasMal37.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Eliminar la violencia de género";
            respuestasMal37.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal37.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta37 = new Pregunta(respuestasMal37, "¿Qué medidas se deben tomar para lograr la quinta ODS?", 1, 100, respuestaBien.Texto, 5, true);
            dal.Insert<Pregunta>(pregunta37);
            dal.Commit();

            ICollection<Respuesta> respuestasMal38 = new List<Respuesta>();
            respuesta1mal.Texto = "10%";
            respuestasMal38.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "25%";
            respuestasMal38.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "50%";
            respuestasMal38.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "35%";
            respuestasMal38.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta38 = new Pregunta(respuestasMal38, "¿Qué porcentaje de mujeres entre 15 y 49 años ha sufrido violencia física o sexual por parte de su pareja en todo el mundo?", 3, 300, respuestaBien.Texto, 5, true);
            dal.Insert<Pregunta>(pregunta38);
            dal.Commit();

            ICollection<Respuesta> respuestasMal39 = new List<Respuesta>();
            respuesta1mal.Texto = "100 millones";
            respuestasMal39.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "300 millones";
            respuestasMal39.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "400 millones";
            respuestasMal39.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "200 millones";
            respuestasMal39.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta39 = new Pregunta(respuestasMal39, "¿Cuántas mujeres han sufrido mutilación genital femenina en todo el mundo?", 2, 200, respuestaBien.Texto, 5, true);
            dal.Insert<Pregunta>(pregunta39);
            dal.Commit();

            ICollection<Respuesta> respuestasMal40 = new List<Respuesta>();
            respuesta1mal.Texto = "10%";
            respuestasMal40.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "20%";
            respuestasMal40.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "40%";
            respuestasMal40.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "30%";
            respuestasMal40.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta40 = new Pregunta(respuestasMal40, "¿Cuál es el porcentaje de mujeres en todo el mundo que ocupan cargos parlamentarios?", 2, 200, respuestaBien.Texto, 5, true);
            dal.Insert<Pregunta>(pregunta40);
            dal.Commit();

            ICollection<Respuesta> respuestasMal41 = new List<Respuesta>();
            respuesta1mal.Texto = "10 millones";
            respuestasMal41.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "50 millones";
            respuestasMal41.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "100 millones";
            respuestasMal41.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "130 millones";
            respuestasMal41.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta41 = new Pregunta(respuestasMal41, "¿Cuántas niñas en todo el mundo no van a la escuela?", 2, 200, respuestaBien.Texto, 5, true);
            dal.Insert<Pregunta>(pregunta41);
            dal.Commit();

            ICollection<Respuesta> respuestasMal42 = new List<Respuesta>();
            respuesta1mal.Texto = "Dinamarca";
            respuestasMal42.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Noruega";
            respuestasMal42.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Finlandia";
            respuestasMal42.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Suecia";
            respuestasMal42.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta42 = new Pregunta(respuestasMal42, "¿Qué país ha logrado la igualdad de género en todos los ámbitos?", 3, 300, respuestaBien.Texto, 5, true);
            dal.Insert<Pregunta>(pregunta42);
            dal.Commit();

            ICollection<Respuesta> respuestasMal43 = new List<Respuesta>();
            respuesta1mal.Texto = "Eliminar la violencia contra las mujeres y las niñas";
            respuestasMal43.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Empoderar a las mujeres y niñas en todos los ámbitos";
            respuestasMal43.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Garantizar la igualdad de acceso a los recursos económicos y a la propiedad";
            respuestasMal43.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal43.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta43 = new Pregunta(respuestasMal43, "¿Cuál es la meta específica de la quinta ODS?", 1, 100, respuestaBien.Texto, 5, false);
            dal.Insert<Pregunta>(pregunta43);
            dal.Commit();
            //------------------------------ODS 6------------------------
            ICollection<Respuesta> respuestasMal44 = new List<Respuesta>();
            respuesta1mal.Texto = "Reducir la mortalidad infantil";
            respuestasMal44.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Lograr la igualdad de género";
            respuestasMal44.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Erradicar la pobreza extrema";
            respuestasMal44.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Garantizar la disponibilidad y gestión sostenible del agua y saneamiento para todos";
            respuestasMal44.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta44 = new Pregunta(respuestasMal44, "¿Cuál es el objetivo de la sexta ODS?", 1, 100, respuestaBien.Texto, 6, false);
            dal.Insert<Pregunta>(pregunta44);
            dal.Commit();

            ICollection<Respuesta> respuestasMal45 = new List<Respuesta>();
            respuesta1mal.Texto = "5%";
            respuestasMal45.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "10%";
            respuestasMal45.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "15%";
            respuestasMal45.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "20%";
            respuestasMal45.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta45 = new Pregunta(respuestasMal45, "¿Qué porcentaje de la población mundial no tiene acceso a agua potable?", 2, 200, respuestaBien.Texto, 6, true);
            dal.Insert<Pregunta>(pregunta45);
            dal.Commit();

            ICollection<Respuesta> respuestasMal46 = new List<Respuesta>();
            respuesta1mal.Texto = "15%";
            respuestasMal46.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "35%";
            respuestasMal46.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "45%";
            respuestasMal46.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "25%";
            respuestasMal46.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta46 = new Pregunta(respuestasMal46, "¿Qué porcentaje de la población mundial no tiene acceso a servicios de saneamiento básico?", 2, 200, respuestaBien.Texto, 6, true);
            dal.Insert<Pregunta>(pregunta46);
            dal.Commit();

            ICollection<Respuesta> respuestasMal47 = new List<Respuesta>();
            respuesta1mal.Texto = "El consumo de alimentos contaminados";
            respuestasMal47.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La exposición a sustancias químicas tóxicas";
            respuestasMal47.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "La falta de acceso a atención médica";
            respuestasMal47.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "La falta de higiene personal";
            respuestasMal47.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta47 = new Pregunta(respuestasMal47, "¿Cuál es la principal causa de enfermedades relacionadas con el agua y el saneamiento?", 1, 100, respuestaBien.Texto, 6, true);
            dal.Insert<Pregunta>(pregunta47);
            dal.Commit();

            ICollection<Respuesta> respuestasMal48 = new List<Respuesta>();
            respuesta1mal.Texto = "500.000";
            respuestasMal48.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "1 millón";
            respuestasMal48.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "5 millones";
            respuestasMal48.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "2,5 millones";
            respuestasMal48.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta48 = new Pregunta(respuestasMal48, "¿Cuántas personas mueren cada año por enfermedades relacionadas con la falta de agua y saneamiento?", 3, 300, respuestaBien.Texto, 6, true);
            dal.Insert<Pregunta>(pregunta48);
            dal.Commit();

            ICollection<Respuesta> respuestasMal49 = new List<Respuesta>();
            respuesta1mal.Texto = "Aumentar el acceso a agua potable y saneamiento en zonas rurales";
            respuestasMal49.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Reducir la contaminación de los cuerpos de agua";
            respuestasMal49.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Todas las anteriores";
            respuestasMal49.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Asegurar el acceso equitativo a agua y saneamiento para todos";
            respuestasMal49.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta49 = new Pregunta(respuestasMal49, "¿Cuál es la meta específica de la sexta ODS?", 1, 100, respuestaBien.Texto, 6, false);
            dal.Insert<Pregunta>(pregunta49);
            dal.Commit();

            ICollection<Respuesta> respuestasMal50 = new List<Respuesta>();
            respuesta1mal.Texto = "China";
            respuestasMal50.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Brasil";
            respuestasMal50.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Nigeria";
            respuestasMal50.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "India";
            respuestasMal50.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta50 = new Pregunta(respuestasMal50, "¿Qué país tiene la mayor cantidad de personas sin acceso a agua potable?", 3, 300, respuestaBien.Texto, 6, true);
            dal.Insert<Pregunta>(pregunta50);
            dal.Commit();

            ICollection<Respuesta> respuestasMal51 = new List<Respuesta>();
            respuesta1mal.Texto = "Sistemas de filtración de agua";
            respuestasMal51.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Inodoros sin agua";
            respuestasMal51.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Sistemas de recolección de agua de lluvia";
            respuestasMal51.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal51.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta51 = new Pregunta(respuestasMal51, "¿Qué tecnologías se pueden utilizar para mejorar el acceso al agua y saneamiento en zonas rurales?", 1, 100, respuestaBien.Texto, 6, true);
            dal.Insert<Pregunta>(pregunta51);
            dal.Commit();

            //------------------------------ODS 7------------------------

            ICollection<Respuesta> respuestasMal52 = new List<Respuesta>();
            respuesta1mal.Texto = "Promover la igualdad de género";
            respuestasMal52.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Garantizar una educación inclusiva, equitativa y de calidad para todos";
            respuestasMal52.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Lograr que las ciudades sean más sostenibles";
            respuestasMal52.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Asegurar el acceso a energía asequible, segura, sostenible y moderna para todos";
            respuestasMal52.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta52 = new Pregunta(respuestasMal52, "¿Cuál es el objetivo de la séptima ODS?", 1, 100, respuestaBien.Texto, 7, false);
            dal.Insert<Pregunta>(pregunta52);
            dal.Commit();

            ICollection<Respuesta> respuestasMal53 = new List<Respuesta>();
            respuesta1mal.Texto = "100 millones";
            respuestasMal53.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "500 millones";
            respuestasMal53.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "2.000 millones";
            respuestasMal53.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "1.000 millones";
            respuestasMal53.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta53 = new Pregunta(respuestasMal53, "¿Cuántas personas en todo el mundo carecen de acceso a la electricidad?", 3, 300, respuestaBien.Texto, 7, true);
            dal.Insert<Pregunta>(pregunta53);
            dal.Commit();

            ICollection<Respuesta> respuestasMal54 = new List<Respuesta>();
            respuesta1mal.Texto = "Energía solar";
            respuestasMal54.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Energía eólica";
            respuestasMal54.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Biomasa";
            respuestasMal54.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Energía hidráulica";
            respuestasMal54.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta54 = new Pregunta(respuestasMal54, "¿Qué tipo de energía renovable es la más utilizada en todo el mundo?", 2, 200, respuestaBien.Texto, 7, true);
            dal.Insert<Pregunta>(pregunta54);
            dal.Commit();

            ICollection<Respuesta> respuestasMal55 = new List<Respuesta>();
            respuesta1mal.Texto = "20%";
            respuestasMal55.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "30%";
            respuestasMal55.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "40%";
            respuestasMal55.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "10%";
            respuestasMal55.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta55 = new Pregunta(respuestasMal55, "¿Cuál es el porcentaje de energía renovable en el consumo energético mundial en 2019?", 2, 200, respuestaBien.Texto, 7, true);
            dal.Insert<Pregunta>(pregunta55);
            dal.Commit();

            ICollection<Respuesta> respuestasMal56 = new List<Respuesta>();
            respuesta1mal.Texto = "Falta de recursos financieros";
            respuestasMal56.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Falta de tecnología";
            respuestasMal56.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Falta de conocimiento técnico";
            respuestasMal56.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal56.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta56 = new Pregunta(respuestasMal56, "¿Cuál es el principal obstáculo para la adopción de energías renovables en los países en desarrollo?", 1, 100, respuestaBien.Texto, 7, true);
            dal.Insert<Pregunta>(pregunta56);
            dal.Commit();

            ICollection<Respuesta> respuestasMal57 = new List<Respuesta>();
            respuesta1mal.Texto = "Estados Unidos";
            respuestasMal57.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Alemania";
            respuestasMal57.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "España";
            respuestasMal57.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "China";
            respuestasMal57.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta57 = new Pregunta(respuestasMal57, "¿Qué país es el mayor productor de energía eólica en todo el mundo?", 2, 200, respuestaBien.Texto, 7, true);
            dal.Insert<Pregunta>(pregunta57);
            dal.Commit();

            ICollection<Respuesta> respuestasMal58 = new List<Respuesta>();
            respuesta1mal.Texto = "Iluminación LED";
            respuestasMal58.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Aislamiento térmico";
            respuestasMal58.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Paneles solares";
            respuestasMal58.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal58.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta58 = new Pregunta(respuestasMal58, "¿Qué tecnologías pueden ayudar a aumentar la eficiencia energética en hogares y edificios?", 1, 100, respuestaBien.Texto, 7, true);
            dal.Insert<Pregunta>(pregunta58);
            dal.Commit();

            ICollection<Respuesta> respuestasMal59 = new List<Respuesta>();
            respuesta1mal.Texto = "Préstamos bancarios";
            
            respuestasMal59.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Inversión privada";
            respuestasMal59.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Fondos gubernamentales";
            respuestasMal59.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal59.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta59 = new Pregunta(respuestasMal59, "¿Qué tipo de financiamiento se utiliza para impulsar proyectos de energías renovables?", 1, 100, respuestaBien.Texto, 7, true);
            dal.Insert<Pregunta>(pregunta59);
            dal.Commit();

            //------------------------------ODS 8------------------------
            ICollection<Respuesta> respuestasMal60 = new List<Respuesta>();
            respuesta1mal.Texto = "Promover la igualdad de género";
            respuestasMal60.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Lograr que las ciudades sean más sostenibles";
            respuestasMal60.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Asegurar el acceso a energía asequible, segura, sostenible y moderna para todos";
            respuestasMal60.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Fomentar el crecimiento económico sostenido, inclusivo y sostenible";
            respuestasMal60.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta60 = new Pregunta(respuestasMal60, "¿Cuál es el objetivo de la octava ODS?", 1, 100, respuestaBien.Texto, 8, false);
            dal.Insert<Pregunta>(pregunta60);
            dal.Commit();

            ICollection<Respuesta> respuestasMal61 = new List<Respuesta>();
            respuesta1mal.Texto = "Menos del 5%";
            respuestasMal61.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Entre el 5% y el 10%";
            respuestasMal61.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Entre el 10% y el 15%";
            respuestasMal61.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Más del 15%";
            respuestasMal61.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta61 = new Pregunta(respuestasMal61, "¿Qué porcentaje de la población mundial vive con menos de 1,90 dólares al día?", 3, 300, respuestaBien.Texto, 8, true);
            dal.Insert<Pregunta>(pregunta61);
            dal.Commit();

            ICollection<Respuesta> respuestasMal62 = new List<Respuesta>();
            respuesta1mal.Texto = "Estados Unidos";
            respuestasMal62.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Japón";
            respuestasMal62.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Alemania";
            respuestasMal62.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "China";
            respuestasMal62.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta62 = new Pregunta(respuestasMal62, "¿Qué país es el mayor productor de bienes manufacturados en el mundo?", 2, 200, respuestaBien.Texto, 8, true);
            dal.Insert<Pregunta>(pregunta62);
            dal.Commit();

            ICollection<Respuesta> respuestasMal63 = new List<Respuesta>();
            respuesta1mal.Texto = "Menos del 10%";
            respuestasMal63.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Entre el 10% y el 20%";
            respuestasMal63.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Entre el 20% y el 30%";
            respuestasMal63.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Más del 30%";
            respuestasMal63.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta63 = new Pregunta(respuestasMal63, "¿Cuál es el porcentaje de la población mundial que está empleada en el sector agrícola?", 2, 200, respuestaBien.Texto, 8, true);
            dal.Insert<Pregunta>(pregunta63);
            dal.Commit();

            ICollection<Respuesta> respuestasMal64 = new List<Respuesta>();
            respuesta1mal.Texto = "Menos del 10%";
            respuestasMal64.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Entre el 10% y el 25%";
            respuestasMal64.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Más del 50%";
            respuestasMal64.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Entre el 25% y el 50%";
            respuestasMal64.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta64 = new Pregunta(respuestasMal64, "¿Qué porcentaje de la fuerza laboral mundial trabaja en el sector informal?", 3, 300, respuestaBien.Texto, 8, true);
            dal.Insert<Pregunta>(pregunta64);
            dal.Commit();

            ICollection<Respuesta> respuestasMal65 = new List<Respuesta>();
            respuesta1mal.Texto = "Trabajo que paga un salario justo";
            respuestasMal65.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Trabajo que respeta los derechos laborales";
            respuestasMal65.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Trabajo que es seguro y saludable";
            respuestasMal65.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal65.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta65 = new Pregunta(respuestasMal65, "¿Qué se entiende por trabajo decente?", 1, 100, respuestaBien.Texto, 8, true);
            dal.Insert<Pregunta>(pregunta65);
            dal.Commit();

            ICollection<Respuesta> respuestasMal66 = new List<Respuesta>();
            respuesta1mal.Texto = "Menos del 30%";
            respuestasMal66.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Entre el 30% y el 50%";
            respuestasMal66.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Entre el 50% y el 70%";
            respuestasMal66.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Más del 70%";
            respuestasMal66.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta66 = new Pregunta(respuestasMal66, "¿Qué porcentaje de la población mundial está empleada en el sector servicios?", 3, 300, respuestaBien.Texto, 8, true);
            dal.Insert<Pregunta>(pregunta66);
            dal.Commit();

            ICollection<Respuesta> respuestasMal67 = new List<Respuesta>();
            respuesta1mal.Texto = "Crecimiento que no daña el medio ambiente";
            respuestasMal67.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Crecimiento que beneficia a todas las personas, incluyendo a las generaciones futuras";
            respuestasMal67.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Crecimiento que no es dependiente de recursos no renovables";
            respuestasMal67.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);

            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal67.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta67 = new Pregunta(respuestasMal67, "¿Qué se entiende por crecimiento económico sostenible?", 2, 200, respuestaBien.Texto, 8, true);
            dal.Insert<Pregunta>(pregunta67);
            dal.Commit();
            //------------------------------ODS 9------------------------

            ICollection<Respuesta> respuestasMal68 = new List<Respuesta>();
            respuesta1mal.Texto = "Reducir la desigualdad";
            respuestasMal68.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Fomentar el desarrollo urbano sostenible";
            respuestasMal68.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Proteger la biodiversidad y los ecosistemas terrestres";
            respuestasMal68.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Promover la innovación y el desarrollo tecnológico";
            respuestasMal68.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta68 = new Pregunta(respuestasMal68, "¿Cuál es el objetivo principal de la novena ODS?", 1, 100, respuestaBien.Texto, 9, false);
            dal.Insert<Pregunta>(pregunta68);
            dal.Commit();

            ICollection<Respuesta> respuestasMal69 = new List<Respuesta>();
            respuesta1mal.Texto = "Tecnología que utiliza energía renovable";
            respuestasMal69.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Tecnología que reduce el uso de recursos no renovables";
            respuestasMal69.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Tecnología que reduce las emisiones de gases de efecto invernadero";
            respuestasMal69.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal69.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta69 = new Pregunta(respuestasMal69, "¿Qué se entiende por tecnología limpia?", 1, 100, respuestaBien.Texto, 9, true);
            dal.Insert<Pregunta>(pregunta69);
            dal.Commit();

            ICollection<Respuesta> respuestasMal70 = new List<Respuesta>();
            respuesta1mal.Texto = "Menos del 20%";
            respuestasMal70.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Entre el 20% y el 40%";
            respuestasMal70.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Entre el 40% y el 60%";
            respuestasMal70.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Más del 60%";
            respuestasMal70.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta70 = new Pregunta(respuestasMal70, "¿Qué porcentaje de la población mundial tiene acceso a internet?", 2, 200, respuestaBien.Texto, 9, true);
            dal.Insert<Pregunta>(pregunta70);
            dal.Commit();

            ICollection<Respuesta> respuestasMal71 = new List<Respuesta>();
            respuesta1mal.Texto = "Economía que reduce la producción y el consumo de bienes y servicios";
            respuestasMal71.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Economía que fomenta el consumo de productos sostenibles";
            respuestasMal71.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Economía que promueve el comercio justo";
            respuestasMal71.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Economía que se basa en el reciclaje y la reutilización de materiales";
            respuestasMal71.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta71 = new Pregunta(respuestasMal71, "¿Qué se entiende por economía circular?", 3, 300, respuestaBien.Texto, 9, true);
            dal.Insert<Pregunta>(pregunta71);
            dal.Commit();

            ICollection<Respuesta> respuestasMal72 = new List<Respuesta>();
            respuesta1mal.Texto = "Actividades que buscan mejorar la eficiencia en la producción de bienes y servicios";
            respuestasMal72.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Actividades que buscan desarrollar nuevos productos y procesos";
            respuestasMal72.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Actividades que buscan mejorar la calidad de los productos y servicios existentes";
            respuestasMal72.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal72.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta72 = new Pregunta(respuestasMal72, "¿Qué se entiende por investigación y desarrollo (I+D)?", 1, 100, respuestaBien.Texto, 9, true);
            dal.Insert<Pregunta>(pregunta72);
            dal.Commit();

            ICollection<Respuesta> respuestasMal73 = new List<Respuesta>();
            respuesta1mal.Texto = "Derechos de autor sobre obras literarias, artísticas y científicas";
            respuestasMal73.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Patentes sobre invenciones";
            respuestasMal73.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Marcas comerciales y diseños industriales";
            respuestasMal73.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal73.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta73 = new Pregunta(respuestasMal73, "¿Qué se entiende por propiedad intelectual?", 2, 200, respuestaBien.Texto, 9, true);
            dal.Insert<Pregunta>(pregunta73);
            dal.Commit();

            ICollection<Respuesta> respuestasMal74 = new List<Respuesta>();
            respuesta1mal.Texto = "Menos del 10%";
            respuestasMal74.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Entre el 30% y el 50%";
            respuestasMal74.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Más del 50%";
            respuestasMal74.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Entre el 10% y el 30%";
            respuestasMal74.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta74 = new Pregunta(respuestasMal74, "¿Qué porcentaje de la población mundial tiene acceso a servicios financieros formales?", 3, 300, respuestaBien.Texto, 9, true);
            dal.Insert<Pregunta>(pregunta74);
            dal.Commit();

            ICollection<Respuesta> respuestasMal75 = new List<Respuesta>();
            respuesta1mal.Texto = "Transferencia de tecnología de países desarrollados a países en desarrollo";
            respuestasMal75.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Transferencia de tecnología entre empresas";
            respuestasMal75.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Transferencia de tecnología entre sectores económicos";
            respuestasMal75.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal75.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta75 = new Pregunta(respuestasMal75, "¿Qué se entiende por transferencia de tecnología?", 2, 200, respuestaBien.Texto, 9, true);
            dal.Insert<Pregunta>(pregunta75);
            dal.Commit();
            //------------------------------ODS 10------------------------
            ICollection<Respuesta> respuestasMal76 = new List<Respuesta>();
            respuesta1mal.Texto = "Promover la igualdad de género";
            respuestasMal76.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Fomentar el crecimiento económico sostenible";
            respuestasMal76.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Garantizar la inclusión social y económica de todas las personas";
            respuestasMal76.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Reducir la desigualdad económica";
            respuestasMal76.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta76 = new Pregunta(respuestasMal76, "¿Cuál es el objetivo principal de la décima ODS?", 1, 100, respuestaBien.Texto, 10, false);
            dal.Insert<Pregunta>(pregunta76);
            dal.Commit();

            ICollection<Respuesta> respuestasMal77 = new List<Respuesta>();
            respuesta1mal.Texto = "Crecimiento económico que no tiene en cuenta la sostenibilidad ambiental";
            respuestasMal77.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Crecimiento económico que solo beneficia a una parte de la población";
            respuestasMal77.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Ninguna de las anteriores";
            respuestasMal77.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Crecimiento económico que beneficia a todas las personas, independientemente de su género, edad o origen étnico";
            respuestasMal77.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta77 = new Pregunta(respuestasMal77, "¿Qué se entiende por \"crecimiento económico inclusivo\"?", 2, 200, respuestaBien.Texto, 10, true);
            dal.Insert<Pregunta>(pregunta77);
            dal.Commit();

            ICollection<Respuesta> respuestasMal78 = new List<Respuesta>();
            respuesta1mal.Texto = "Menos del 10%";
            respuestasMal78.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Entre el 25% y el 50%";
            respuestasMal78.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Más del 50%";
            respuestasMal78.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Entre el 10% y el 25%";
            respuestasMal78.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta78 = new Pregunta(respuestasMal78, "¿Qué porcentaje de la población mundial vive en la pobreza extrema?", 3, 300, respuestaBien.Texto, 10, true);
            dal.Insert<Pregunta>(pregunta78);
            dal.Commit();

            ICollection<Respuesta> respuestasMal79 = new List<Respuesta>();
            respuesta1mal.Texto = "Proceso por el cual las personas adquieren poder político";
            respuestasMal79.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Proceso por el cual las personas adquieren habilidades sociales y emocionales";
            respuestasMal79.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Ninguna de las anteriores";
            respuestasMal79.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            
            respuestaBien.Texto = "Proceso por el cual las personas adquieren habilidades y recursos para mejorar su situación económica";
            respuestasMal79.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta79 = new Pregunta(respuestasMal79, "¿Qué se entiende por \"empoderamiento económico\"?", 2, 200, respuestaBien.Texto, 10, true);
            dal.Insert<Pregunta>(pregunta79);
            dal.Commit();

            ICollection<Respuesta> respuestasMal80 = new List<Respuesta>();
            respuesta1mal.Texto = "Conjunto de políticas y programas que fomentan la exclusión social";
            respuestasMal80.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Conjunto de políticas y programas que promueven la desigualdad económica";
            respuestasMal80.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Ninguna de las anteriores";
            respuestasMal80.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Conjunto de políticas y programas que garantizan la protección de los derechos sociales y económicos de las personas";
            respuestasMal80.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta80 = new Pregunta(respuestasMal80, "¿Qué se entiende por \"sistema de protección social\"?", 3, 300, respuestaBien.Texto, 10, true);
            dal.Insert<Pregunta>(pregunta80);
            dal.Commit();

            ICollection<Respuesta> respuestasMal81 = new List<Respuesta>();
            respuesta1mal.Texto = "Proceso por el cual las empresas extranjeras se establecen en una región y generan empleo";
            respuestasMal81.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Proceso por el cual las empresas locales se expanden a nivel internacional";
            respuestasMal81.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Ninguna de las anteriores";
            respuestasMal81.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Proceso por el cual las comunidades locales desarrollan su economía y mejoran su bienestar económico y social";
            respuestasMal81.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta81 = new Pregunta(respuestasMal81, "¿Qué se entiende por \"desarrollo económico local\"?", 2, 200, respuestaBien.Texto, 10, true);
            dal.Insert<Pregunta>(pregunta81);
            dal.Commit();

            ICollection<Respuesta> respuestasMal82 = new List<Respuesta>();
            respuesta1mal.Texto = "Protección de los derechos de autor sobre obras literarias, artísticas y científicas";
            respuestasMal82.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Protección de las patentes sobre invenciones";
            respuestasMal82.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Protección de las marcas comerciales y diseños industriales";
            respuestasMal82.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal82.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta82 = new Pregunta(respuestasMal82, "¿Qué se entiende por \"protección de los derechos de propiedad intelectual\"?", 1, 100, respuestaBien.Texto, 10, true);
            dal.Insert<Pregunta>(pregunta82);
            dal.Commit();

            ICollection<Respuesta> respuestasMal83 = new List<Respuesta>();
            respuesta1mal.Texto = "Ninguna de las anteriores";
            respuestasMal83.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Un sistema comercial que se enfoca en la exportación de productos agrícolas";
            respuestasMal83.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Un sistema comercial que solo beneficia a grandes corporaciones y deja fuera a pequeños productores";
            respuestasMal83.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Un sistema comercial que busca la igualdad de condiciones y el respeto por los derechos humanos y laborales de los trabajadores de países en desarrollo";
            respuestasMal83.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta83 = new Pregunta(respuestasMal83, "¿Qué se entiende por el término \"comercio justo\"?", 3, 300, respuestaBien.Texto, 10, true);
            dal.Insert<Pregunta>(pregunta83);
            dal.Commit();

            //------------------------------ODS 11------------------------
            ICollection<Respuesta> respuestasMal84 = new List<Respuesta>();
            respuesta1mal.Texto = "50%";
            respuestasMal84.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "60%";
            respuestasMal84.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "80%";
            respuestasMal84.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "70%";
            respuestasMal84.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta84 = new Pregunta(respuestasMal84, "¿Qué porcentaje de la población mundial se espera que viva en ciudades para 2050?", 2, 200, respuestaBien.Texto, 11, true);
            dal.Insert<Pregunta>(pregunta84);
            dal.Commit();

            ICollection<Respuesta> respuestasMal85 = new List<Respuesta>();
            respuesta1mal.Texto = "Aumentar la industrialización en áreas urbanas";
            respuestasMal85.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Mejorar el acceso a la tecnología en áreas rurales";
            respuestasMal85.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Promover la diversidad cultural en áreas urbanas";
            respuestasMal85.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Mejorar la calidad de vida en áreas urbanas";
            respuestasMal85.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta85 = new Pregunta(respuestasMal85, "¿Cuál es uno de los objetivos de la undécima ODS?", 1, 100, respuestaBien.Texto, 11, false);
            dal.Insert<Pregunta>(pregunta85);
            dal.Commit();

            ICollection<Respuesta> respuestasMal86 = new List<Respuesta>();
            respuesta1mal.Texto = "Una ciudad que atrae a un gran número de turistas cada año";
            respuestasMal86.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Una ciudad que tiene una gran cantidad de parques y espacios verdes";
            respuestasMal86.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Una ciudad que tiene un gran número de edificios históricos y monumentos";
            respuestasMal86.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Una ciudad que proporciona igualdad de oportunidades a todos sus residentes, independientemente de su origen o estatus social";
            respuestasMal86.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta86 = new Pregunta(respuestasMal86, "¿Qué se entiende por \"ciudad inclusiva\"?", 2, 200, respuestaBien.Texto, 11, true);
            dal.Insert<Pregunta>(pregunta86);
            dal.Commit();

            ICollection<Respuesta> respuestasMal87 = new List<Respuesta>();
            respuesta1mal.Texto = "Para reducir la cantidad de terreno dedicado a la agricultura";
            respuestasMal87.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Para reducir los costos de construcción";
            respuestasMal87.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Para aumentar la cantidad de edificios altos en las ciudades";
            respuestasMal87.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Para minimizar el impacto ambiental y promover el desarrollo económico y social sostenible";
            respuestasMal87.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta87 = new Pregunta(respuestasMal87, "¿Por qué es importante la planificación urbana sostenible?", 2, 200, respuestaBien.Texto, 11, true);
            dal.Insert<Pregunta>(pregunta87);
            dal.Commit();

            ICollection<Respuesta> respuestasMal88 = new List<Respuesta>();
            respuesta1mal.Texto = "Fomentar el uso de automóviles privados en lugar de transporte público";
            respuestasMal88.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Reducir el número de espacios verdes en la ciudad";
            respuestasMal88.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Aumentar el número de centros comerciales y grandes superficies";
            respuestasMal88.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Fomentar el uso de energías renovables como la energía solar y eólica";
            respuestasMal88.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta88 = new Pregunta(respuestasMal88, "¿Cuál es una forma de reducir la huella de carbono de una ciudad?", 1, 100, respuestaBien.Texto, 11, true);
            dal.Insert<Pregunta>(pregunta88);
            dal.Commit();

            ICollection<Respuesta> respuestasMal89 = new List<Respuesta>();
            respuesta1mal.Texto = "El derecho de los ciudadanos a poseer propiedades inmobiliarias en áreas urbanas";
            respuestasMal89.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "El derecho de los ciudadanos a tener acceso a servicios públicos gratuitos";
            respuestasMal89.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "El derecho de los ciudadanos a tener una vivienda propia";
            respuestasMal89.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "El derecho de los ciudadanos a participar en la toma de decisiones que afectan a sus comunidades";
            respuestasMal89.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta89 = new Pregunta(respuestasMal89, "¿Qué es el \"derecho a la ciudad\"?", 3, 300, respuestaBien.Texto, 11, true);
            dal.Insert<Pregunta>(pregunta89);
            dal.Commit();

            ICollection<Respuesta> respuestasMal90 = new List<Respuesta>();
            respuesta1mal.Texto = "Para mejorar la calidad del agua";
            respuestasMal90.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Para reducir los niveles de ruido en las calles";
            respuestasMal90.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Para aumentar la cantidad de turistas que visitan la ciudad";
            respuestasMal90.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Para reducir los costos de la atención médica debido a enfermedades respiratorias";
            respuestasMal90.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta90 = new Pregunta(respuestasMal90, "¿Por qué es importante reducir la contaminación del aire en las ciudades?", 1, 100, respuestaBien.Texto, 11, true);
            dal.Insert<Pregunta>(pregunta90);
            dal.Commit();

            //------------------------------ODS 12------------------------
            ICollection<Respuesta> respuestasMal91 = new List<Respuesta>();
            respuesta1mal.Texto = "Reducir el consumo de energía en los hogares";
            respuestasMal91.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Promover la agricultura orgánica";
            respuestasMal91.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Reducir la producción de bienes de lujo";
            respuestasMal91.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Fomentar la producción sostenible y el consumo responsable";
            respuestasMal91.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta91 = new Pregunta(respuestasMal91, "¿Cuál es el objetivo principal de la duodécima ODS?", 1, 100, respuestaBien.Texto, 12, false);
            dal.Insert<Pregunta>(pregunta91);
            dal.Commit();

            ICollection<Respuesta> respuestasMal92 = new List<Respuesta>();
            respuesta1mal.Texto = "La cantidad de agua que se utiliza para producir un producto";
            respuestasMal92.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La cantidad de energía que se utiliza para producir un producto";
            respuestasMal92.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "La cantidad de tierra que se utiliza para producir un producto";
            respuestasMal92.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "La cantidad de dióxido de carbono que se emite durante la producción y el uso de un producto";
            respuestasMal92.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta92 = new Pregunta(respuestasMal92, "¿Qué es la huella de carbono?", 2, 200, respuestaBien.Texto, 12, true);
            dal.Insert<Pregunta>(pregunta92);
            dal.Commit();

            ICollection<Respuesta> respuestasMal93 = new List<Respuesta>();
            respuesta1mal.Texto = "Una economía en la que todos los productos son biodegradables";
            respuestasMal93.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Una economía en la que todos los productos son producidos localmente";
            respuestasMal93.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Un sistema comercial que solo beneficia a grandes corporaciones y deja fuera a pequeños productores";
            respuestasMal93.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Una economía en la que todos los productos son producidos de manera sostenible";
            respuestasMal93.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta93 = new Pregunta(respuestasMal93, "¿Qué es la economía circular?", 2, 200, respuestaBien.Texto, 12, true);
            dal.Insert<Pregunta>(pregunta93);
            dal.Commit();

            ICollection<Respuesta> respuestasMal94 = new List<Respuesta>();
            respuesta1mal.Texto = "El proceso de reciclar productos de forma que se reduzcan los residuos";
            respuestasMal94.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "El proceso de producir nuevos productos a partir de materiales reciclados";
            respuestasMal94.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "El proceso de reducir el uso de productos químicos en la producción de bienes";
            respuestasMal94.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "El proceso de convertir productos no deseados o desechados en materiales de mayor valor";
            respuestasMal94.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta94 = new Pregunta(respuestasMal94, "¿Qué es el \"upcycling\"?", 2, 200, respuestaBien.Texto, 12, true);
            dal.Insert<Pregunta>(pregunta94);
            dal.Commit();

            ICollection<Respuesta> respuestasMal95 = new List<Respuesta>();
            respuesta1mal.Texto = "El proceso de diseñar productos de alta calidad";
            respuestasMal95.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "El proceso de diseñar productos que sean más asequibles para los consumidores";
            respuestasMal95.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "El proceso de diseñar productos que sean más resistentes y duraderos";
            respuestasMal95.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "El proceso de diseñar productos que tengan un menor impacto ambiental";
            respuestasMal95.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta95 = new Pregunta(respuestasMal95, "¿Qué es el ecodiseño?", 2, 200, respuestaBien.Texto, 12, true);
            dal.Insert<Pregunta>(pregunta95);
            dal.Commit();

            ICollection<Respuesta> respuestasMal96 = new List<Respuesta>();
            respuesta1mal.Texto = "La cantidad de recursos naturales que se utilizan en la producción de un producto";
            respuestasMal96.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La cantidad de residuos que se producen durante la producción de un producto";
            respuestasMal96.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "La cantidad de energía que se utiliza en la producción de un producto";
            respuestasMal96.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "La relación entre el valor económico y los recursos utilizados para producir un producto";
            respuestasMal96.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta96 = new Pregunta(respuestasMal96, "¿Qué es la eficiencia de los recursos?", 3, 300, respuestaBien.Texto, 12, true);
            dal.Insert<Pregunta>(pregunta96);
            dal.Commit();

            ICollection<Respuesta> respuestasMal97 = new List<Respuesta>();
            respuesta1mal.Texto = "Una economía que se centra en la producción de bienes de alta calidad";
            respuestasMal97.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Una economía que se centra en la producción de productos orgánicos";
            respuestasMal97.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Una economía que se centra en la producción de bienes y servicios de lujo";
            respuestasMal97.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Una economía que se centra en la producción de bienes y servicios que tienen un bajo impacto ambiental";
            respuestasMal97.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta97 = new Pregunta(respuestasMal97, "¿Qué es la \"economía verde\"?", 2, 200, respuestaBien.Texto, 12, true);
            dal.Insert<Pregunta>(pregunta97);
            dal.Commit();

            //------------------------------ODS 13------------------------

            ICollection<Respuesta> respuestasMal98 = new List<Respuesta>();
            respuesta1mal.Texto = "Promover la igualdad de género";
            respuestasMal98.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Combatir la pobreza extrema";
            respuestasMal98.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Aumentar el acceso a la educación de calidad";
            respuestasMal98.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Proteger el medio ambiente y combatir el cambio climático";
            respuestasMal98.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta98 = new Pregunta(respuestasMal98, "¿Cuál es el objetivo principal de la decimotercera ODS?", 1, 100, respuestaBien.Texto, 13, false);
            dal.Insert<Pregunta>(pregunta98);
            dal.Commit();

            ICollection<Respuesta> respuestasMal99 = new List<Respuesta>();
            respuesta1mal.Texto = "Acción climática para el desarrollo sostenible";
            respuestasMal99.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Protección del clima para la igualdad global";
            respuestasMal99.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Lucha contra el cambio climático y sus efectos";
            respuestasMal99.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Acción por el clima";
            respuestasMal99.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta99 = new Pregunta(respuestasMal99, "¿Cuál es el nombre completo de la decimotercera ODS?", 1, 100, respuestaBien.Texto, 13, false);
            dal.Insert<Pregunta>(pregunta99);
            dal.Commit();

            ICollection<Respuesta> respuestasMal100 = new List<Respuesta>();
            respuesta1mal.Texto = "Reducir las emisiones de gases de efecto invernadero a niveles seguros";
            respuestasMal100.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Asegurar que los países más vulnerables tengan acceso a tecnologías limpias y recursos financieros para luchar contra el cambio climático";
            respuestasMal100.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Promover la educación y conciencia ambiental en la sociedad";
            respuestasMal100.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal100.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta100 = new Pregunta(respuestasMal100, "¿Qué se espera lograr con la decimotercera ODS?", 2, 200, respuestaBien.Texto, 13, true);
            dal.Insert<Pregunta>(pregunta100);
            dal.Commit();

            ICollection<Respuesta> respuestasMal101 = new List<Respuesta>();
            respuesta1mal.Texto = "Establecer medidas y políticas para reducir las emisiones de gases de efecto invernadero";
            respuestasMal101.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Fortalecer su capacidad de adaptación al cambio climático";
            respuestasMal101.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Movilizar recursos financieros y tecnológicos para ayudar a los países más vulnerables a luchar contra el cambio climático";
            respuestasMal101.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal101.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta101 = new Pregunta(respuestasMal101, "¿Qué se espera que hagan los países para cumplir con la decimotercera ODS?", 2, 200, respuestaBien.Texto, 13, true);
            dal.Insert<Pregunta>(pregunta101);
            dal.Commit();

            ICollection<Respuesta> respuestasMal102 = new List<Respuesta>();
            respuesta1mal.Texto = "Un acuerdo internacional sobre la protección de la fauna y flora silvestres";
            respuestasMal102.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Un acuerdo internacional para promover la educación y conciencia ambiental en la sociedad";
            respuestasMal102.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Un acuerdo internacional para fomentar la investigación y el desarrollo de tecnologías limpias";
            respuestasMal102.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Un acuerdo internacional para reducir las emisiones de gases de efecto invernadero y limitar el calentamiento global a menos de 2°C por encima de los niveles preindustriales";
            respuestasMal102.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta102 = new Pregunta(respuestasMal102, "¿Qué es el \"acuerdo de París\"?", 3, 300, respuestaBien.Texto, 13, true);
            dal.Insert<Pregunta>(pregunta102);
            dal.Commit();

            ICollection<Respuesta> respuestasMal103 = new List<Respuesta>();
            respuesta1mal.Texto = "La acción por el clima es uno de los objetivos de desarrollo sostenible";
            respuestasMal103.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La acción por el clima no tiene relación con los objetivos de desarrollo sostenible";
            respuestasMal103.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "La acción por el clima es un obstáculo para lograr los objetivos de desarrollo sostenible";
            respuestasMal103.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "La acción por el clima es una forma de lograr los objetivos de desarrollo sostenible";
            respuestasMal103.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta103 = new Pregunta(respuestasMal103, "¿Cuál es la relación entre la acción por el clima y los objetivos de desarrollo sostenible?", 3, 300, respuestaBien.Texto, 13, true);
            dal.Insert<Pregunta>(pregunta103);
            dal.Commit();

            ICollection<Respuesta> respuestasMal104 = new List<Respuesta>();
            respuesta1mal.Texto = "Adoptando estilos de vida más sostenibles y reduciendo su huella de carbono";
            respuestasMal104.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Promoviendo la educación y conciencia ambiental en su comunidad";
            respuestasMal104.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Participando en iniciativas de acción por el clima y apoyando a las organizaciones que trabajan en este ámbito";
            respuestasMal104.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal104.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta104 = new Pregunta(respuestasMal104, "¿Cómo puede la sociedad contribuir a la acción por el clima?", 1, 100, respuestaBien.Texto, 13, true);
            dal.Insert<Pregunta>(pregunta104);
            dal.Commit();

            //------------------------------ODS 14------------------------
            ICollection<Respuesta> respuestasMal105 = new List<Respuesta>();
            respuesta1mal.Texto = "Protección del océano para la igualdad global";
            respuestasMal105.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Conservación de los océanos y sus recursos";
            respuestasMal105.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Vida marina";
            respuestasMal105.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Vida submarina para el desarrollo sostenible";
            respuestasMal105.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta105 = new Pregunta(respuestasMal105, "¿Cuál es el nombre completo de la decimocuarta ODS?", 1, 100, respuestaBien.Texto, 14, false);
            dal.Insert<Pregunta>(pregunta105);
            dal.Commit();

            ICollection<Respuesta> respuestasMal106 = new List<Respuesta>();
            respuesta1mal.Texto = "Porque los ecosistemas marinos proporcionan servicios esenciales para la vida en la Tierra, como la producción de oxígeno y la regulación del clima";
            respuestasMal106.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Porque los océanos son una fuente importante de alimento y medios de vida para muchas personas en todo el mundo";
            respuestasMal106.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Porque la biodiversidad marina es fundamental para el funcionamiento de los ecosistemas terrestres";
            respuestasMal106.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal106.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta106 = new Pregunta(respuestasMal106, "¿Por qué es importante la protección de la vida submarina?", 1, 100, respuestaBien.Texto, 14, true);
            dal.Insert<Pregunta>(pregunta106);
            dal.Commit();


            ICollection<Respuesta> respuestasMal107 = new List<Respuesta>();
            respuesta1mal.Texto = "Una zona del océano en la que se permiten ciertas actividades humanas, pero se aplican medidas para minimizar su impacto en el ecosistema marino";
            respuestasMal107.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Una zona del océano en la que se permiten todas las actividades humanas, pero se establecen límites en la cantidad y tipo de actividades permitidas";
            respuestasMal107.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Una zona del océano en la que se realizan investigaciones científicas sobre la vida submarina";
            respuestasMal107.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Una zona del océano en la que está prohibida la pesca y otras actividades humanas";
            respuestasMal107.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta107 = new Pregunta(respuestasMal107, "¿Qué es el Área Marina Protegida (AMP)?", 3, 300, respuestaBien.Texto, 14, true);
            dal.Insert<Pregunta>(pregunta107);
            dal.Commit();

            ICollection<Respuesta> respuestasMal108 = new List<Respuesta>();
            respuesta1mal.Texto = "Porque pueden ayudar a restaurar y proteger la biodiversidad y los ecosistemas marinos";
            respuestasMal108.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Porque pueden ayudar a mantener poblaciones de peces saludables y sostenibles";
            respuestasMal108.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Porque pueden reducir la contaminación y la sobrepesca en los océanos";
            respuestasMal108.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal108.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta108 = new Pregunta(respuestasMal108, "¿Por qué es importante establecer Áreas Marinas Protegidas?", 2, 200, respuestaBien.Texto, 14, true);
            dal.Insert<Pregunta>(pregunta108);
            dal.Commit();

            ICollection<Respuesta> respuestasMal109 = new List<Respuesta>();
            respuesta1mal.Texto = "Establecer Áreas Marinas Protegidas y promover prácticas de pesca sostenible";
            respuestasMal109.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Reducir la contaminación del agua y la acumulación de desechos plásticos en los océanos";
            respuestasMal109.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Promover la educación y conciencia ambiental sobre la importancia de la vida submarina";
            respuestasMal109.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal109.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta109 = new Pregunta(respuestasMal109, "¿Qué medidas pueden tomar los gobiernos y las organizaciones para proteger la vida submarina?", 2, 200, respuestaBien.Texto, 14, true);
            dal.Insert<Pregunta>(pregunta109);
            dal.Commit();

            ICollection<Respuesta> respuestasMal110 = new List<Respuesta>();
            respuesta1mal.Texto = "La sobrepesca y la pesca ilegal";
            respuestasMal110.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La contaminación del agua y la acumulación de desechos plásticos";
            respuestasMal110.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "El cambio climático y la acidificación de los océanos";
            respuestasMal110.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal110.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta110 = new Pregunta(respuestasMal110, "¿Cuál es la principal amenaza para la vida submarina?", 3, 300, respuestaBien.Texto, 14, true);
            dal.Insert<Pregunta>(pregunta110);
            dal.Commit();

            //------------------------------ODS 15------------------------

            ICollection<Respuesta> respuestasMal111 = new List<Respuesta>();
            respuesta1mal.Texto = "Promover el uso sostenible de los océanos y sus recursos";
            respuestasMal111.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Proteger la vida marina y los ecosistemas marinos";
            respuestasMal111.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Reducir la contaminación del aire y del agua";
            respuestasMal111.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Proteger la biodiversidad terrestre";
            respuestasMal111.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta111 = new Pregunta(respuestasMal111, "¿Cuál es el objetivo principal de la decimoquinta ODS?", 1, 100, respuestaBien.Texto, 15, false);
            dal.Insert<Pregunta>(pregunta111);
            dal.Commit();

            ICollection<Respuesta> respuestasMal112 = new List<Respuesta>();
            respuesta1mal.Texto = "Proteger y restaurar los ecosistemas terrestres y su biodiversidad";
            respuestasMal112.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Promover prácticas agrícolas sostenibles y la gestión sostenible de los bosques";
            respuestasMal112.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Reducir la deforestación y la pérdida de hábitats naturales";
            respuestasMal112.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal112.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta112 = new Pregunta(respuestasMal112, "¿Qué se espera lograr con la decimoquinta ODS?", 1, 100, respuestaBien.Texto, 15, false);
            dal.Insert<Pregunta>(pregunta112);
            dal.Commit();

            ICollection<Respuesta> respuestasMal113 = new List<Respuesta>();
            respuesta1mal.Texto = "Porque los ecosistemas terrestres proporcionan servicios esenciales para la vida en la Tierra, como la producción de oxígeno y la regulación del clima";
            respuestasMal113.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Porque la biodiversidad terrestre es fundamental para el funcionamiento de los ecosistemas acuáticos";
            respuestasMal113.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Porque la biodiversidad terrestre es una fuente importante de alimento y medios de vida para muchas personas en todo el mundo";
            respuestasMal113.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal113.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta113 = new Pregunta(respuestasMal113, "¿Por qué es importante la protección de la biodiversidad terrestre?", 2, 200, respuestaBien.Texto, 15, true);
            dal.Insert<Pregunta>(pregunta113);
            dal.Commit();

            ICollection<Respuesta> respuestasMal114 = new List<Respuesta>();
            respuesta1mal.Texto = "La expansión de los desiertos hacia áreas previamente habitables";
            respuestasMal114.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La pérdida de suelo fértil y la capacidad de producción agrícola en una región";
            respuestasMal114.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "La extinción de especies animales y vegetales en un ecosistema";
            respuestasMal114.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "La degradación de las tierras productivas, especialmente en regiones áridas, semiáridas y subhúmedas";
            respuestasMal114.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta114 = new Pregunta(respuestasMal114, "¿Qué es la desertificación?", 3, 300, respuestaBien.Texto, 15, true);
            dal.Insert<Pregunta>(pregunta114);
            dal.Commit();

            ICollection<Respuesta> respuestasMal115 = new List<Respuesta>();
            respuesta1mal.Texto = "Porque puede llevar a la pérdida de tierras productivas y la reducción de la seguridad alimentaria";
            respuestasMal115.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Porque puede tener efectos negativos en la biodiversidad y la capacidad de los ecosistemas terrestres para proporcionar servicios esenciales";
            respuestasMal115.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Porque puede aumentar la vulnerabilidad de las comunidades locales a la sequía y otros desastres naturales";
            respuestasMal115.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal115.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta115 = new Pregunta(respuestasMal115, "¿Por qué es importante abordar la desertificación?", 3, 300, respuestaBien.Texto, 15, true);
            dal.Insert<Pregunta>(pregunta115);
            dal.Commit();

            ICollection<Respuesta> respuestasMal116 = new List<Respuesta>();
            respuesta1mal.Texto = "Promover prácticas agrícolas sostenibles y la gestión sostenible de la tierra";
            respuestasMal116.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Restaurar tierras degradadas y fomentar la reforestación y la conservación de la biodiversidad";
            respuestasMal116.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Promover la educación y la conciencia ambiental sobre la importancia de la protección de los ecosistemas terrestres";
            respuestasMal116.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal116.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta116 = new Pregunta(respuestasMal116, "¿Qué medidas pueden tomar los gobiernos y las comunidades para abordar la desertificación?", 2, 200, respuestaBien.Texto, 15, true);
            dal.Insert<Pregunta>(pregunta116);
            dal.Commit();

            ICollection<Respuesta> respuestasMal117 = new List<Respuesta>();
            respuesta1mal.Texto = "La deforestación y la pérdida de hábitats naturales";
            respuestasMal117.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "El cambio climático y la acidificación de los océanos";
            respuestasMal117.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "La contaminación del aire y del agua";
            respuestasMal117.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal117.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta117 = new Pregunta(respuestasMal117, "¿Cuál es la principal amenaza para la biodiversidad terrestre?", 3, 300, respuestaBien.Texto, 15, true);
            dal.Insert<Pregunta>(pregunta117);
            dal.Commit();

            //------------------------------ODS 16------------------------

            ICollection<Respuesta> respuestasMal118 = new List<Respuesta>();
            respuesta1mal.Texto = "Fomentar la igualdad de género";
            respuestasMal118.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Promover el acceso a la educación";
            respuestasMal118.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Mejorar la salud y el bienestar";
            respuestasMal118.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Fortalecer las instituciones y la gobernanza";
            respuestasMal118.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta118 = new Pregunta(respuestasMal118, "¿Qué es la meta principal de la decimosexta ODS?", 1, 100, respuestaBien.Texto, 16, false);
            dal.Insert<Pregunta>(pregunta118);
            dal.Commit();

            ICollection<Respuesta> respuestasMal119 = new List<Respuesta>();
            respuesta1mal.Texto = "Las leyes y regulaciones que rigen el comportamiento de la sociedad";
            respuestasMal119.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Las prácticas y políticas que promueven la transparencia, la responsabilidad y la participación ciudadana";
            respuestasMal119.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Las organizaciones y estructuras gubernamentales responsables de la toma de decisiones y la implementación de políticas públicas";
            respuestasMal119.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal119.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta119 = new Pregunta(respuestasMal119, "¿Qué se entiende por instituciones y gobernanza?", 2, 200, respuestaBien.Texto, 16, true);
            dal.Insert<Pregunta>(pregunta119);
            dal.Commit();

            ICollection<Respuesta> respuestasMal120 = new List<Respuesta>();
            respuesta1mal.Texto = "Porque puede ayudar a prevenir la corrupción y el abuso de poder";
            respuestasMal120.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Porque puede mejorar la calidad de vida de la población al garantizar el acceso a servicios básicos y la protección de sus derechos";
            respuestasMal120.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Porque puede fomentar el desarrollo económico sostenible y la estabilidad política";
            respuestasMal120.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal120.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta120 = new Pregunta(respuestasMal120, "¿Por qué es importante fortalecer las instituciones y la gobernanza?", 2, 200, respuestaBien.Texto, 16, true);
            dal.Insert<Pregunta>(pregunta120);
            dal.Commit();

            ICollection<Respuesta> respuestasMal121 = new List<Respuesta>();
            respuesta1mal.Texto = "La corrupción y la falta de transparencia";
            respuestasMal121.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La falta de recursos y capacidad institucional";
            respuestasMal121.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "La falta de voluntad política y la resistencia al cambio";
            respuestasMal121.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal121.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta121 = new Pregunta(respuestasMal121, "¿Cuáles son algunos de los principales desafíos para fortalecer las instituciones y la gobernanza?", 1, 100, respuestaBien.Texto, 16, true);
            dal.Insert<Pregunta>(pregunta121);
            dal.Commit();

            ICollection<Respuesta> respuestasMal122 = new List<Respuesta>();
            respuesta1mal.Texto = "La capacidad de la población para elegir a sus representantes mediante elecciones libres y justas";
            respuestasMal122.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La capacidad de la población para protestar y manifestarse en contra del gobierno";
            respuestasMal122.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Todas las anteriores";
            respuestasMal122.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "La capacidad de la población para involucrarse en la toma de decisiones y la implementación de políticas públicas";
            respuestasMal122.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta122 = new Pregunta(respuestasMal122, "¿Qué se entiende por participación ciudadana?", 3, 300, respuestaBien.Texto, 16, true);
            dal.Insert<Pregunta>(pregunta122);
            dal.Commit();

            ICollection<Respuesta> respuestasMal123 = new List<Respuesta>();
            respuesta1mal.Texto = "Promoviendo la transparencia y la rendición de cuentas";
            respuestasMal123.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Fomentando la participación ciudadana y la educación cívica";
            respuestasMal123.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Monitoreando el desempeño de las instituciones y denunciando actos de corrupción";
            respuestasMal123.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal123.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta123 = new Pregunta(respuestasMal119, "¿Cómo pueden las organizaciones de la sociedad civil contribuir a fortalecer las instituciones y la gobernanza?", 3, 300, respuestaBien.Texto, 16, true);
            dal.Insert<Pregunta>(pregunta123);
            dal.Commit();

            ICollection<Respuesta> respuestasMal124 = new List<Respuesta>();
            respuesta1mal.Texto = "Puede fomentar la participación ciudadana y la educación cívica";
            respuestasMal124.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Puede mejorar la capacidad institucional y la formación de funcionarios públicos";
            respuestasMal124.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Puede promover la transparencia y la rendición de cuentas";
            respuestasMal124.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal124.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta124 = new Pregunta(respuestasMal124, "¿Qué papel juega la educación en la promoción de instituciones y gobernanza fuertes?", 2, 200, respuestaBien.Texto, 16, true);
            dal.Insert<Pregunta>(pregunta124);
            dal.Commit();

            //------------------------------ODS 17------------------------

            ICollection<Respuesta> respuestasMal125 = new List<Respuesta>();
            respuesta1mal.Texto = "Erradicar la pobreza extrema y el hambre";
            respuestasMal125.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Proteger y restaurar el medio ambiente";
            respuestasMal125.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Promover la paz, la justicia y la inclusión social";
            respuestasMal125.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Fortalecer la cooperación internacional para el desarrollo sostenible";
            respuestasMal125.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta125 = new Pregunta(respuestasMal125, "¿Cuál es el objetivo principal de la ODS 17?", 1, 100, respuestaBien.Texto, 17, false);
            dal.Insert<Pregunta>(pregunta125);
            dal.Commit();

            ICollection<Respuesta> respuestasMal126 = new List<Respuesta>();
            respuesta1mal.Texto = "No tiene ningún papel en la implementación de la ODS 17";
            respuestasMal126.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Es responsable de financiar y liderar todos los proyectos de la ODS 17";
            respuestasMal126.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Solo puede contribuir a través de donaciones benéficas";
            respuestasMal126.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Debe contribuir al desarrollo sostenible y alinearse con los objetivos de la ODS 17";
            respuestasMal126.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta126 = new Pregunta(respuestasMal126, "¿Qué rol juega el sector privado en la implementación de la ODS 17?", 2, 200, respuestaBien.Texto, 17, true);
            dal.Insert<Pregunta>(pregunta126);
            dal.Commit();

            ICollection<Respuesta> respuestasMal127 = new List<Respuesta>();
            respuesta1mal.Texto = "Asegurar que los países ricos proporcionen ayuda financiera a los países pobres";
            respuestasMal127.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Promover el libre comercio internacional";
            respuestasMal127.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Ninguna de las anteriores";
            respuestasMal127.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Apoyar la implementación de la ODS 17";
            respuestasMal127.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta127 = new Pregunta(respuestasMal127, "¿Cuál es el objetivo de la Asociación Mundial para el Desarrollo Sostenible (AMDS)?", 1, 100, respuestaBien.Texto, 17, true);
            dal.Insert<Pregunta>(pregunta127);
            dal.Commit();

            ICollection<Respuesta> respuestasMal128 = new List<Respuesta>();
            respuesta1mal.Texto = "Ninguna de las anteriores";
            respuestasMal128.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Plan de Inversión en el Bienestar";
            respuestasMal128.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Participación Internacional en Bienes";
            respuestasMal128.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Producto Interno Bruto";
            respuestasMal128.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta128 = new Pregunta(respuestasMal128, "¿Qué significa la sigla PIB?", 2, 200, respuestaBien.Texto, 17, true);
            dal.Insert<Pregunta>(pregunta128);
            dal.Commit();

            ICollection<Respuesta> respuestasMal129 = new List<Respuesta>();
            respuesta1mal.Texto = "Asegurar que los países ricos reduzcan sus emisiones de gases de efecto invernadero";
            respuestasMal129.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Proporcionar financiamiento para proyectos de energía nuclear";
            respuestasMal129.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Ninguna de las anteriores";
            respuestasMal129.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Proporcionar financiamiento para proyectos de desarrollo sostenible";
            respuestasMal129.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta129 = new Pregunta(respuestasMal129, "¿Cuál es el objetivo del Fondo Verde para el Clima?", 3, 300, respuestaBien.Texto, 17, true);
            dal.Insert<Pregunta>(pregunta129);
            dal.Commit();

            ICollection<Respuesta> respuestasMal130 = new List<Respuesta>();
            respuesta1mal.Texto = "A través de acuerdos bilaterales entre países";
            respuestasMal130.Add(respuesta1mal);
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "A través de la ayuda financiera internacional";
            respuestasMal130.Add(respuesta2mal);
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "A través de la creación de alianzas público-privadas";
            respuestasMal130.Add(respuesta3mal);
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "Todas las anteriores";
            respuestasMal130.Add(respuestaBien);
            dal.Insert<Respuesta>(respuestaBien);
                        Pregunta pregunta130 = new Pregunta(respuestasMal130, "¿Cómo se puede promover la cooperación internacional para el desarrollo sostenible?", 3, 300, respuestaBien.Texto, 17, true);
            dal.Insert<Pregunta>(pregunta130);
            dal.Commit();
            //-------------------Reto Frase--------------------
            //-------------------ODS 1-------------------------
            Frase frase1 = new Frase("Esta ODS se enfoca en erradicar la pobreza extrema y el hambre en todo el mundo, trabajando para asegurar que todas las personas tengan acceso a alimentos nutritivos y suficientes recursos para satisfacer sus necesidades básicas.",
                "No podemos avanzar como sociedad si dejamos atrás a los más vulnerables", 1, 100, 1, false);
            dal.Insert<Frase>(frase1);
            Frase frase2 = new Frase("La ODS 1 busca promover el acceso igualitario a servicios básicos, como la salud y la educación, y asegurar que todas las personas tengan la oportunidad de mejorar su calidad de vida.",
                "Un mundo justo y equitativo comienza con la eliminación de la pobreza", 1, 100, 1, true);
            dal.Insert<Frase>(frase2);
            dal.Commit();
            //-------------------ODS 2-------------------------
            Frase frase3 = new Frase("Esta ODS busca erradicar el hambre y la malnutrición en todo el mundo, asegurando que todas las personas tengan acceso a alimentos nutritivos y sostenibles, y promoviendo prácticas agrícolas sostenibles.",
                "La alimentación es un derecho humano fundamental y un requisito previo para el logro de la seguridad alimentaria y la nutrición.", 2, 200, 2, false);
            dal.Insert<Frase>(frase3);
            Frase frase4 = new Frase("La ODS 2 busca promover el acceso igualitario a alimentos nutritivos y mejorar la productividad y la sostenibilidad en el sector agrícola, para asegurar la seguridad alimentaria a largo plazo.",
                "La agricultura es la fuente de alimentación de la humanidad", 1, 100, 2, true);
            dal.Insert<Frase>(frase4);
            dal.Commit();
            //-------------------ODS 3-------------------------
            Frase frase5 = new Frase("Esta ODS se enfoca en asegurar que todas las personas tengan acceso a servicios de salud de calidad y asequibles, promoviendo la prevención y el tratamiento de enfermedades y lesiones.",
                "La salud es un estado de completo bienestar físico, mental y social, y no solamente la ausencia de enfermedad o dolencia.", 3, 300, 3, false);
            dal.Insert<Frase>(frase5);
            Frase frase6 = new Frase("La ODS 3 busca promover la salud y el bienestar de todas las personas, en todas las etapas de la vida, a través de la prevención y el tratamiento de enfermedades, y la promoción de estilos de vida saludables.",
                "La salud es la inversión más valiosa que podemos hacer", 2, 200, 3, true);
            dal.Insert<Frase>(frase6);
            dal.Commit();
            //-------------------ODS 4-------------------------
            Frase frase7 = new Frase("Esta ODS busca garantizar que todas las personas tengan acceso a una educación de calidad, desde la educación primaria hasta la educación superior, promoviendo la igualdad de oportunidades y la educación para el desarrollo sostenible.",
                "La educación es la llave maestra que abre las puertas del desarrollo y el progreso", 2, 200, 4, false);
            dal.Insert<Frase>(frase7);
            Frase frase8 = new Frase("La ODS 4 busca promover la igualdad de acceso a una educación de calidad, y mejorar los resultados educativos a través de la promoción de prácticas pedagógicas innovadoras y el desarrollo de habilidades relevantes para el mercado laboral.",
                "La educación es el arma más poderosa que puedes usar para cambiar el mundo", 1, 100, 4, true);
            dal.Insert<Frase>(frase8);
            dal.Commit();
            //-------------------ODS 5-------------------------
            Frase frase9 = new Frase("Esta ODS se enfoca en promover la igualdad de género y el empoderamiento de todas las mujeres y niñas, eliminando todas las formas de discriminación y violencia de género.",
                "No podemos avanzar como sociedad si dejamos atrás a la mitad de la población", 1, 100, 5, false);
            dal.Insert<Frase>(frase9);
            Frase frase10 = new Frase("La ODS 5 busca promover la igualdad de género y el empoderamiento de las mujeres y niñas, fomentando su participación en la toma de decisiones y eliminando las barreras que limitan su acceso a oportunidades económicas y educativas.",
                "La igualdad de género no es solo un derecho humano fundamental, sino también un medio para lograr un mundo pacífico y sostenible", 3, 300, 5, true);
            dal.Insert<Frase>(frase10);
            dal.Commit();
            //-------------------ODS 6-------------------------
            Frase frase11 = new Frase("Esta ODS se enfoca en garantizar el acceso universal y equitativo al agua potable y al saneamiento, promoviendo prácticas sostenibles y la gestión integrada de los recursos hídricos.",
                "El agua es esencial para la vida, pero más de 2 mil millones de personas carecen de acceso a agua potable segura y saneamiento", 2, 200, 6, false);
            dal.Insert<Frase>(frase11);
            Frase frase12 = new Frase("La ODS 6 busca promover el acceso universal al agua potable y al saneamiento, asegurando una gestión sostenible de los recursos hídricos y la protección de los ecosistemas acuáticos.",
                "El acceso al agua potable y al saneamiento es esencial para la salud, la dignidad y el bienestar humano.", 2, 200, 6, true);
            dal.Insert<Frase>(frase12);
            dal.Commit();
            //-------------------ODS 7-------------------------
            Frase frase13 = new Frase("Esta ODS se enfoca en garantizar el acceso universal a una energía asequible, confiable, sostenible y moderna, promoviendo la eficiencia energética y el uso de fuentes renovables de energía.",
                "La energía limpia y asequible es una fuente esencial de prosperidad para todos.", 1, 100, 7, false);
            dal.Insert<Frase>(frase13);
            Frase frase14= new Frase("La ODS 7 busca promover el acceso universal a una energía limpia y sostenible, fomentando la inversión en tecnologías energéticas innovadoras y la promoción de políticas públicas que impulsen la transición hacia un sistema energético sostenible.",
                "La energía sostenible es clave para lograr un futuro más próspero, justo y sostenible para todos.", 3, 300, 7, true);
            dal.Insert<Frase>(frase14);
            dal.Commit();
            //-------------------ODS 8-------------------------
            Frase frase15 = new Frase("Esta ODS se enfoca en promover el crecimiento económico sostenido, inclusivo y sostenible, fomentando la generación de empleos decentes y productivos, y garantizando condiciones de trabajo seguras y protegidas para todos los trabajadores.",
                "La creación de empleos decentes y productivos es un elemento clave para lograr un crecimiento económico sostenible e inclusivo", 2, 200, 8, false);
            dal.Insert<Frase>(frase15);
            Frase frase16 = new Frase("La ODS 8 busca promover el crecimiento económico sostenible e inclusivo, fomentando la generación de empleos decentes y la protección de los derechos laborales, y eliminando las formas de trabajo forzoso y explotación laboral.",
                "La igualdad de oportunidades y el acceso al empleo decente son fundamentales para el desarrollo sostenible", 2, 200, 8, true);
            dal.Insert<Frase>(frase16);
            dal.Commit();
            //-------------------ODS 9-------------------------
            Frase frase17 = new Frase("Esta ODS se enfoca en construir infraestructuras resilientes, promover la industrialización inclusiva y sostenible, y fomentar la innovación y el uso de tecnologías avanzadas para lograr un desarrollo sostenible y equitativo.",
                "La inversión en infraestructura resiliente y sostenible es clave para el crecimiento económico y la inclusión social", 1, 100, 9, false);
            dal.Insert<Frase>(frase17);
            Frase frase18 = new Frase("La ODS 9 busca promover la construcción de infraestructuras resilientes y sostenibles, fomentando la inversión en tecnologías limpias y avanzadas y la promoción de políticas públicas que impulsen la innovación y el emprendimiento.",
                "La infraestructura y la innovación son fundamentales para impulsar el desarrollo sostenible y alcanzar los objetivos de la Agenda 2030", 2, 200, 9, true);
            dal.Insert<Frase>(frase18);
            dal.Commit();
            //-------------------ODS 10-------------------------
            Frase frase19 = new Frase("Esta ODS se enfoca en reducir la desigualdad económica, social y territorial, promoviendo la inclusión social y económica de todas las personas, independientemente de su origen, género, edad o capacidad.",
                "La lucha contra la discriminación y la promoción de la igualdad de oportunidades son fundamentales para lograr una sociedad inclusiva y sostenible", 1, 100, 10, false);
            dal.Insert<Frase>(frase19);
            Frase frase20 = new Frase("La ODS 10 busca reducir las brechas de desigualdad económica y social, promoviendo la inclusión de todas las personas y comunidades en el desarrollo sostenible, y garantizando la protección de sus derechos y libertades.",
                "La eliminación de la pobreza y la reducción de las desigualdades son fundamentales para lograr una sociedad más justa y sostenible para todos", 3, 300, 10, true);
            dal.Insert<Frase>(frase20);
            dal.Commit();
            //-------------------ODS 11-------------------------
            Frase frase21 = new Frase("Esta ODS se enfoca en lograr ciudades y comunidades más inclusivas, seguras, resilientes y sostenibles, garantizando el acceso a servicios básicos, infraestructuras y espacios públicos de calidad para todas las personas.",
                "La planificación urbana integrada es clave para lograr ciudades y comunidades sostenibles y resilientes", 2, 200, 11, false);
            dal.Insert<Frase>(frase21);
            Frase frase22 = new Frase("La ODS 11 busca promover el desarrollo de ciudades y comunidades más sostenibles y resilientes, fomentando la planificación urbana inclusiva y participativa, y garantizando el acceso a servicios básicos y espacios públicos de calidad para todas las personas.",
                "El acceso a viviendas adecuadas y asequibles es un derecho humano fundamental y una condición esencial para lograr una expansión urbana sostenible", 3, 300, 11, true);
            dal.Insert<Frase>(frase22);
            dal.Commit();
            //-------------------ODS 12-------------------------
            Frase frase23 = new Frase("Esta ODS se enfoca en fomentar patrones de consumo y producción sostenibles, promoviendo la eficiencia de los recursos, la reducción de la contaminación y el uso responsable de los recursos naturales.",
                "El fomento de la innovación y la tecnología sostenible es clave para promover patrones de consumo y producción sostenibles", 1, 100, 12, false);
            dal.Insert<Frase>(frase23);
            Frase frase24 = new Frase("La ODS 12 busca fomentar patrones de consumo y producción sostenibles, promoviendo la eficiencia de los recursos, la reducción de la contaminación y el uso responsable de los recursos naturales.",
                "La adopción de patrones de consumo y producción sostenible es fundamental para garantizar la sostenibilidad ambiental y social", 2, 200, 12, true);
            dal.Insert<Frase>(frase24);
            dal.Commit();
            //-------------------ODS 13-------------------------
            Frase frase25 = new Frase("La ODS 13 se enfoca en combatir el cambio climático y sus efectos negativos, mediante la adopción de medidas de mitigación y adaptación, y la promoción de la resiliencia climática.",
                "La transición hacia una economía baja en carbono es fundamental para reducir las emisiones de gases de efecto invernadero y combatir el cambio climático", 1, 100, 13, true);
            dal.Insert<Frase>(frase25);
            Frase frase26 = new Frase("La ODS 13 busca combatir el cambio climático y sus efectos negativos, mediante la adopción de medidas de mitigación y adaptación, y la promoción de la resiliencia climática.",
                "La colaboración multilateral es clave para combatir el cambio climático y sus efectos negativos", 2, 200, 13, true);
            dal.Insert<Frase>(frase26);
            dal.Commit();
            //-------------------ODS 14-------------------------
            Frase frase27 = new Frase("La ODS 14 busca conservar y utilizar de manera sostenible los océanos, los mares y los recursos marinos para el desarrollo sostenible, y promover la protección de la biodiversidad marina.",
                "La gestión sostenible de los recursos marinos es clave para conservar los océanos y mares y proteger la biodiversidad marina", 3, 300, 14, true);
            dal.Insert<Frase>(frase27);
            Frase frase28 = new Frase("La ODS 14 se enfoca en la conservación y uso sostenible de los océanos, mares y recursos marinos para el desarrollo sostenible, y promover la protección de la biodiversidad marina.",
                "La adopción de prácticas sostenible es fundamental para reducir la contaminación marina y proteger la biodiversidad marina", 3, 300, 14, true);
            dal.Insert<Frase>(frase28);
            dal.Commit();
            //-------------------ODS 15-------------------------
            Frase frase29 = new Frase("La ODS 15 se enfoca en proteger, restaurar y promover el uso sostenible de los ecosistemas terrestres, la gestión forestal sostenible, la lucha contra la desertificación, la detención y reversión de la degradación de la tierra y la pérdida de biodiversidad.",
                "La pérdida de biodiversidad es una amenaza para la biodiversidad y los ecosistemas terrestres, por lo que es importante detener y revertir su degradación", 1, 100, 15, true);
            dal.Insert<Frase>(frase29);
            Frase frase30 = new Frase("La ODS 15 busca proteger, restaurar y promover el uso sostenible de los ecosistemas terrestres, la gestión forestal sostenible, la lucha contra la desertificación, la detención y reversión de la degradación de la tierra y la pérdida de biodiversidad.",
                "La conservación y restauración de los ecosistemas terrestres son fundamentales para la protección de la biodiversidad y el uso sostenible de los recursos naturales", 2, 200, 15, true);
            dal.Insert<Frase>(frase30);
            dal.Commit();
            //-------------------ODS 16-------------------------
            Frase frase31 = new Frase("La ODS 16 se enfoca en promover sociedades pacíficas e inclusivas para el desarrollo sostenible, el acceso a la justicia y la construcción de instituciones efectivas e inclusivas.",
                "La corrupción es un obstáculo para alcanzar una sociedad pacífica e inclusiva, por lo que es necesario tomar medidas para prevenirla y combatirla", 3, 300, 16, true);
            dal.Insert<Frase>(frase31);
            Frase frase32 = new Frase("La ODS 16 busca promover sociedades pacíficas e inclusivas para el desarrollo sostenible, el acceso a la justicia y la construcción de instituciones efectivas e inclusivas.",
                "El acceso a una justicia imparcial y efectiva es fundamental para el desarrollo sostenible y la protección de los derechos humanos", 1, 100, 16, true);
            dal.Insert<Frase>(frase32);
            dal.Commit();
            //-------------------ODS 17-------------------------
            Frase frase33 = new Frase("La ODS 17 se enfoca en fortalecer los medios de implementación y revitalizar la Alianza Mundial para el Desarrollo Sostenible.",
                "La cooperación internacional es esencial para lograr la ODS 17 y asegurar un desarrollo sostenible integral", 2, 200, 17, true);
            dal.Insert<Frase>(frase33);
            Frase frase34 = new Frase("La ODS 17 busca fortalecer los medios de implementación y revitalizar la Alianza Mundial para el Desarrollo Sostenible.",
                "El sector privado tiene un papel importante en la implementación de la ODS 17, ya que puede contribuir con su experiencia, tecnología y recursos para lograr un desarrollo sostenible y sostenible", 1, 100, 17, true);
            dal.Insert<Frase>(frase34);
            dal.Commit();




            //*Console.WriteLine(respuestasMal.First().Texto + ", " + respuestasMal.Last().Texto);
            //*Console.WriteLine(pregunta.RespuestaCorrecta + ", " + pregunta1.RespuestaCorrecta);



            //* dal.Commit();

            Console.ReadKey();




            Console.WriteLine("aaaaaaaaa");
            
        } 

    }
}

       