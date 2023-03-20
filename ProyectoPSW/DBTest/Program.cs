using ProyectoPSWMain.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ProyectoPSWMain.Entities;
using System.Data.Entity.Validation;

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
                User user = new User("1235",500);
                dal.Insert<User>(user);
                dal.Commit();



               
            
            Respuesta rta1 = new Respuesta("AAAA");
            dal.Insert<Respuesta>(rta1);
            dal.Commit();
            Respuesta rta2 = new Respuesta("DDDD");
            dal.Insert<Respuesta>(rta2);
            dal.Commit();
            Respuesta rta3 = new Respuesta("CCCC");
            dal.Insert<Respuesta>(rta3);
            dal.Commit();
            Respuesta rta4 = new Respuesta("BBBB");
            dal.Insert<Respuesta>(rta4);
            dal.Commit();
            List<Respuesta> lresp = new List<Respuesta>();
            lresp.Add(rta1);
            lresp.Add(rta2);
            lresp.Add(rta3);
            lresp.Add(rta4);
            Pregunta pr1 = new Pregunta(lresp, "Es la bbbbbbb", 0, 100, rta4);
            dal.Insert<Pregunta>(pr1);
            dal.Commit();
            Console.ReadKey();

            Partida p = new Partida(1, 400);
            p.AddReto(pr1);
            
            dal.Insert<Partida>(p);

            dal.Commit();

            //User prueba = dal.GetWhere()
            Console.WriteLine("aaaaaaaaa");
            // Populate here the rest of the database with data

        } 

    }
}

       