using ProyectoPSWMain.Entities;
using ProyectoPSWMain.EntityFramework;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPSWMain.Services
{
    public class DatabaseService : IDatabaseService
    {

        private readonly IRepository repository;

        public DatabaseService(IRepository repository) 
        {
            this.repository = repository;
        }

        #region DB

        public void RemoveAllData()
        {
            repository.RemoveAllData();
        }

        public void Commit()
        {
            repository.Commit();
        }

        #endregion

        #region User

        public void DeleteUser(int dni)
        {
            User user = repository.GetById<User>(dni);
            if (user == null) throw new ServiceException("There is no user with that DNI");
            repository.Delete<User>(user);
        }

        public void Register(String Nombre, String Email, String Password)
        {

            User usuario = new User(Nombre, Email, Password);
            repository.Insert<User>(usuario);
            Commit();
            // Esto lo comprobamos en el form? para poder sacar los textos en tiempo real ?
            /*
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var hasSpecialChar = new Regex(@"[%!@#$%^&*()?/>.<,:;'\|_~`+=-]+");
            if (!Regex.IsMatch(Email, regex, RegexOptions.IgnoreCase))
            {
                throw new ServiceException("The Email does not contain the right format");
            }

            if (repository.GetWhere<User>(x => x.Nombre == Nombre).Any())
            {
                throw new ServiceException("There is a user with that Name");
            }
            if (repository.GetWhere<User>(x => x.Email == Email).Any())
            {
                throw new ServiceException("There is a user with that Email");
            }
            
            
            if (hasNumber.IsMatch(Password) && hasUpperChar.IsMatch(Password) && hasMinimum8Chars.IsMatch(Password) && ) {
                throw new ServiceException("Password does not follow the format");
            }*/




            //if (repository.GetById<User>(usuario.Id) == null)
            //{
            //    repository.Insert<User>(usuario);
            //    repository.Commit();
            //}
            //else {
            //    throw new ServiceException("User with DNI" + usuario.Id + "already exists");
            //}

        }



        public User Login(string login, string password)
        {
            User user = repository.GetWhere<User>((u) => u.Nombre.Equals(login) || u.Email.Equals(login)).FirstOrDefault();
            if(user == null) throw new ServiceException("There is no user with that username");
            if(!user.Contraseña.Equals(password)) throw new ServiceException("The password is not correct");
            return user;
        }

        public void Logout()
        {
            Commit();
        }

        #endregion


        #region Pregunta

        public List<Pregunta> LoadQuestionsByDifficulty(int difficulty)
        {
            List<Pregunta> questions = new List<Pregunta>();
            questions = repository.GetWhere<Pregunta>(x => x.Dificultad == difficulty).ToList();
            return questions;
        }

        #endregion

        #region Partida

        public void SavePartida(Partida partida)
        {
            repository.Insert(partida);
        }

        #endregion
    }
}
