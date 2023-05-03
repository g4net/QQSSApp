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
        public void Register(string nombre, string email, string password, string reppassword)
        {
            if(repository.GetWhere<User>(u => u.Nombre == nombre).FirstOrDefault() != null) throw new ServiceException("UsernameExists");
            if (repository.GetWhere<User>(u => u.Email == email).FirstOrDefault() != null) throw new ServiceException("EmailExists");
            if (password != reppassword) throw new ServiceException("Passwordsnotmatch");
            User usuario = new User(nombre, email, password);
            repository.Insert<User>(usuario);
            Commit();
            

        }



        public User Login(string login, string password)
        {
            User user = repository.GetWhere<User>((u) => u.Nombre.Equals(login) || u.Email.Equals(login)).FirstOrDefault();
            if(user == null) throw new ServiceException("UserNotRegistered");
            if(!user.Contraseña.Equals(password)) throw new ServiceException("NotRightPassword");
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

        public List<Frase> LoadFrasesByDifficulty(int difficulty)
        {
            List<Frase> frases = new List<Frase>();
            frases = repository.GetWhere<Frase>(x => x.Dificultad == difficulty).ToList();
            return frases;

        }

        public List<Reto> LoadRetosByDifficulty(int difficulty)
        {
            List<Reto> retos = new List<Reto>();
            retos = repository.GetWhere<Reto>(x => x.Dificultad == difficulty).ToList();
            return retos;
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
