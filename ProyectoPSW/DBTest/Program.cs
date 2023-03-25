using ProyectoPSWMain.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ProyectoPSWMain.Entities;
using System.Data.Entity.Validation;
using ProyectoPSWMain.Services;

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
            
              Console.WriteLine("\n// CREACIÓN DE UNA REVISTA Y SU EDITOR EN JEFE");
              User user = new User("0",500,1);
              dal.Insert<User>(user);
              dal.Commit();
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
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta = new Pregunta(respuestasMal, "¿Cuál es la meta de la ODS 1 para el año 2030?", 1, 100, respuestaBien.Texto, 1);
            dal.Insert<Pregunta>(pregunta);
            dal.Commit();

            respuesta1mal.Texto = "La falta de acceso a la educación";
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "La falta de acceso a servicios de salud";
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "La discriminación racial y de género";
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "La falta de empleo y oportunidades económicas";
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta1 = new Pregunta(respuestasMal, "¿Cuál es la principal causa de la pobreza extrema según la ODS 1?", 2, 200, respuestaBien.Texto, 1);
            dal.Insert<Pregunta>(pregunta1);
            dal.Commit();

            respuesta1mal.Texto = "América Latina y el Caribe";
            dal.Insert<Respuesta>(respuesta1mal);
            respuesta2mal.Texto = "Asia meridional";
            dal.Insert<Respuesta>(respuesta2mal);
            respuesta3mal.Texto = "Europa del Este y Asia Central";
            dal.Insert<Respuesta>(respuesta3mal);
            respuestaBien.Texto = "África subsahariana";
            dal.Insert<Respuesta>(respuestaBien);

            Pregunta pregunta2 = new Pregunta(respuestasMal, "¿Cuál es la región del mundo con el mayor número de personas en situación de pobreza extrema según la ODS 1?", 3, 300, respuestaBien.Texto, 1);
            dal.Insert<Pregunta>(pregunta2);
            dal.Commit();

            Console.WriteLine(respuestasMal.First().Texto + ", " + respuestasMal.Last().Texto);
            Console.WriteLine(pregunta.RespuestaCorrecta + ", " + pregunta1.RespuestaCorrecta);



            dal.Commit();
            
            Console.ReadKey();




            Console.WriteLine("aaaaaaaaa");
            
        } 

    }
}

       