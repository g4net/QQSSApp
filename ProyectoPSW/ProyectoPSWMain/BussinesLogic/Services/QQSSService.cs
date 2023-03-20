﻿using ProyectoPSWMain.Services;
using ProyectoPSWMain.Entities;
using ProyectoPSWMain.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Emit;

namespace ProyectoPSWMain.Services
{
    public class QQSSService : IQQSSService
    {
        // Dal persistence service
        private readonly IRepository repository;

        // Resources Manager for error messaging
        private ResourceManager resourceManager;

        private User loggedUser;


        public QQSSService(IRepository repository)
        {
            this.repository = repository;

        }

        public void DBInitialization()
        {

        }

        #region User
        public void AddUser(User usuario) {
            if (repository.GetById<User>(usuario.Id) == null)
            {
                repository.Insert<User>(usuario);
                repository.Commit();
            }
            else {
                throw new ServiceException("User with DNI" + usuario.Id + "already exists");
            }

        }
        public void Login(String dni) {
            if (repository.GetById<User>(dni) != null)
            {
                this.loggedUser = repository.GetById<User>(dni);
            }else {
                throw new ServiceException("There is no user with that DNI");
            }
        }
        public User GetLoggedUser()
        {
            if (this.loggedUser != null)
            {
                return this.loggedUser;
            }
            else throw new ServiceException("There is no user logged in");

        }
        public void UpdateScore(int points) {
            if (this.loggedUser != null)
            {
                this.loggedUser.SetPoints(points);
                repository.Commit();
            }
            else {
                throw new ServiceException("There is no user logged in");
            }
        }
        #endregion

        #region Partida

        public void AddPartida(Partida game) {
            if (!repository.GetWhere<Partida>(x => x.PuntuacionPartida == game.PuntuacionPartida && x.Nivel == game.Nivel).Any()){
                repository.Insert<Partida>(game);
                repository.Commit() ;
            }
            else {
                throw new ServiceException("There is already a game with that dificulty and that punctuation");
            }
        }
        public Partida GetPartida(int level, int points) {
            var random = new Random();
            List<Partida> PartidasDb = repository.GetAll<Partida>().ToList();
            /*int index = random.Next(PartidasDb.Count);

            return PartidasDb.ElementAt(index);*/
            return PartidasDb.First();
        }
        public int[] GetDifficultyArray(int level)
        {
            // falta implementar el ServiceException y el archivo de las excepciones
            if(level > 4) throw new ServiceException(resourceManager.GetString("Difficulty level does not exist!"));
            switch (level)
            {
                case 0: return new int[] { 0, 0, 0, 0, 0, 1, 1, 1, 2, 2 };
                case 1: return new int[] { 0, 0, 0, 0, 1, 1, 1, 2, 2, 2 };
                case 2: return new int[] { 0, 0, 0, 1, 1, 1, 1, 2, 2, 2 };
                case 3: return new int[] { 0, 0, 1, 1, 1, 1, 2, 2, 2, 2 };
                case 4: return new int[] { 1, 1, 1, 1, 1, 2, 2, 2, 2, 2 };
            }

            return null;
        }
        #endregion

        #region Reto

        #endregion

        #region Pregunta
        public void AddPreguntaToPartida(Pregunta pregutna, Partida partida)
        {
            partida.AddReto(pregutna);
            repository.Insert<Pregunta>(pregutna);
            repository.Commit();
        }
        public void AddPregunta(Pregunta pregutna)
        {

            repository.Insert<Pregunta>(pregutna);
            repository.Commit();
        }

        public List<Pregunta> Questions(int[] dificultad) {
            List<Pregunta> Questions = new List<Pregunta>();
            int puntero = 0;
            List<Pregunta> QuestionsDB = repository.GetWhere<Pregunta>(x => x.Dificultad == dificultad[puntero]).ToList() ;
            var random = new Random();
           
            int dificAnt = dificultad[puntero];
            
            while (puntero > 9)
            {
                if (dificAnt != dificultad[puntero]) {
                    QuestionsDB = repository.GetWhere<Pregunta>(x => x.Dificultad == dificultad[puntero]).ToList();
                    dificAnt = dificultad[puntero];
                }
                int index = random.Next(QuestionsDB.Count);

                Questions.Add(QuestionsDB.ElementAt(index));
                QuestionsDB.RemoveAt(index);
                puntero++;
            }

            return Questions;
        }

        #endregion

        #region Respuesta
        public List<Respuesta> AnswerShuffle(Pregunta Question){
            List<Respuesta> Answers = new List<Respuesta>();
            int pointer = 0;
            var random = new Random();
            List<Respuesta> NoMix = Question.getAllAnswers();

            while (pointer < 4)
            {
                int index = random.Next(NoMix.Count);
                Answers.Add(NoMix.ElementAt(index));
                NoMix.RemoveAt(index);
                pointer++;

            }
            return Answers;
        }
        public bool TestAnswer(String txt, Pregunta pregunta) {
            if (pregunta.RespuestaCorrecta.getText() == txt)
            {
                return true;
            }
            else {
                return false;
            }
        }
        #endregion
    }
}
