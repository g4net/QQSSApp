using ProyectoPSWMain.Services;
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
using System.Security.Cryptography;
using System.Net.NetworkInformation;
using System.Media;
using System.IO;

namespace ProyectoPSWMain.Services
{
    public class QQSSService : IQQSSService
    {
        // Dal persistence service
        private readonly IRepository repository;

        // Resources Manager for error messaging
        //private ResourceManager resourceManager;

        private User loggedUser;
        private Partida partidaActual;
        private List<Pregunta> QuestionServ;
        private int errores = 0;
        private List<int> progresoPreguntas = new List<int>();
        private bool consolidado = false;
        private int puntuacionAcumulada = 0;
        public readonly int[] Levels = { 500, 1000, 2000, 3000 };
        public QQSSService(IRepository repository)
        {
            this.repository = repository;
        }

        public void RemoveAllData()
        {
            repository.RemoveAllData();
        }

        public void Commit()
        {
            repository.Commit();
        }
        /*
        public void DBInitialization()
        {
            ICollection<Respuesta> respuestas = new List<Respuesta>();
            Respuesta respuestaCorrecta = new Respuesta();
            
         
            respuestas = CreateAnswers(CreateStringAnswers("Ambiental, tecnológica y económica", "Ambiental, social y económica", "Económica, acuática y vida", "Social, tecnológica y termica"));
            Pregunta p1 = new Pregunta(respuestas, "¿Cuáles son las tres dimensiones del desarrollo sostenible?", 1, 100, "Ambiental, social y económica", 10);
            AddPregunta(p1);

           
 
             
             
            respuestas = CreateAnswers(CreateStringAnswers("Objetivos de Desarrollo Sostentable", "Objetivos sociales", "Objetivos de Desarrollo Económico", "Objetivos de Desarrollo Tecnológico"));
            respuestaCorrecta = new Respuesta("Objetivos de Desarrollo Sostentable");
            Pregunta p2 = new Pregunta(respuestas, "¿Qué son los ODS?", 1, 100, respuestaCorrecta.getText(), 0);
            AddPregunta(p2);            
          

            respuestas = CreateAnswers(CreateStringAnswers("12", "15", "20", "17"));
            respuestaCorrecta = new Respuesta("17");
            Pregunta p3 = new Pregunta(respuestas, "¿Cuántas ODS hay?", 1, 100, respuestaCorrecta.getText(), 0);
            AddPregunta(p3);            
      
            respuestas = CreateAnswers(CreateStringAnswers("Erradicar la pobreza extrema", "Promover la igualdad de género", "Garantizar la educación de calidad", "Promover la energía renovable"));
            respuestaCorrecta = new Respuesta("Erradicar la pobreza extrema");
            Pregunta p4 = new Pregunta(respuestas, "¿Cuál es el objetivo de la ODS 1?", 1, 100, respuestaCorrecta.getText(), 1);
            AddPregunta(p4);
         
          

            respuestas = CreateAnswers(CreateStringAnswers("Más del 15%", "Menos del 5%", "Entre el 5% y el 10%", "Entre el 10% y el 15%"));
            respuestaCorrecta = new Respuesta("Más del 15%");
            Pregunta p5 = new Pregunta(respuestas, "¿Qué porcentaje de personas viven en situación de pobreza extrema según la ODS 1?", 2, 200, respuestaCorrecta.getText(), 1);
            AddPregunta(p5);
            
       
            Partida partida = new Partida(1, 0);
            partida.AddReto(p1);
            partida.AddReto(p2);
            partida.AddReto(p3);    
            partida.AddReto(p4);
            AddPartida(partida);
        }

        private ICollection<String> CreateStringAnswers(String t1, String t2, String t3, String t4)
        {
            ICollection<String> respuestas = new List<String>();
            respuestas.Add(t1);
            respuestas.Add(t2);
            respuestas.Add(t3);
            respuestas.Add(t4);
            return respuestas;
        }

        private ICollection<Respuesta> CreateAnswers(ICollection<String> respuestas)
        {
            ICollection<Respuesta> answers = new List<Respuesta>();
            foreach(String text in respuestas)
            {
                Respuesta answer = new Respuesta(text);
                answers.Add(answer);
            }
            return answers;
        }
        */


        #region User
        public void AddUser(User usuario) {
            if(usuario == null) throw new ServiceException("You cannot add a null user");
            if(repository.GetById<User>(usuario.Id) == null)
                throw new ServiceException("User with DNI" + usuario.Id + "already exists");

            repository.Insert<User>(usuario);
            Commit();

            //if (repository.GetById<User>(usuario.Id) == null)
            //{
            //    repository.Insert<User>(usuario);
            //    repository.Commit();
            //}
            //else {
            //    throw new ServiceException("User with DNI" + usuario.Id + "already exists");
            //}

        }
        public void Login(String dni) {
            User usuario = repository.GetById<User>(dni);
            if(usuario == null) throw new ServiceException("There is no user with that DNI");
            this.loggedUser = usuario;
            
            
            
            //if (repository.GetById<User>(dni) != null)
            //{
            //    this.loggedUser = repository.GetById<User>(dni);
            //}else {
            //    throw new ServiceException("There is no user with that DNI");
            //}
        }
        public void DeleteUser(int dni) {
            User user = repository.GetById<User>(dni);
            if(user == null) throw new ServiceException("There is no user with that DNI");
            repository.Delete<User>(user);
            
            
            //if (repository.GetById<User>(dni) != null)
            //{
            //    repository.Delete(repository.GetById<User>(dni));
            //}
            //else
            //{
            //    throw new ServiceException("There is no user with that DNI");
            //}
        }
        public User GetLoggedUser()
        {
            if (this.loggedUser != null)
            {
                return this.loggedUser;
            }
            else throw new ServiceException("There is no user logged in");

        }
        public void UpdateUserScore(int points) {
            if(this.loggedUser == null) throw new ServiceException("There is no user logged in");

            this.loggedUser.SetPoints(points < 0 ? 0 : points);
            Commit();

            //if (this.loggedUser != null)
            //{
            //    this.loggedUser.SetPoints(points);
            //    repository.Commit();
            //}
            //else {
            //    throw new ServiceException("There is no user logged in");
            //}
        }

        public void NextLevel(User usuario)
        {

            if (usuario == null) throw new ServiceException("No hay usuario registrado");

            int high = Levels.Length;
            int low = 0;

            while (high > low)
            {
                int mid = low + (high - low) / 2;
                if (usuario.PuntuacionAcumulada == Levels[mid]) { low = mid; break; }
                else if (usuario.PuntuacionAcumulada > Levels[mid]) low = mid + 1;
                else high = mid;
            }

            usuario.nivel = low;
            Commit();
            //usuario.nivel = 

            //if(usuario.PuntuacionAcumulada >= 4000)
            //{
            //    usuario.nivel = 4;
            //}else if(usuario.PuntuacionAcumulada >= 2000)
            //{
            //    usuario.nivel = 3;
            //}else if(usuario.PuntuacionAcumulada >= 1000)
            //{
            //    usuario.nivel = 2;
            //}else if(usuario.PuntuacionAcumulada >= 500)
            //{
            //    usuario.nivel = 1;
            //}
            //else
            //{
            //    usuario.nivel = 0;
            //}


        }

        //public void UpdateNivel(int nivel)
        //{
        //    repository.GetById<User>(GetLoggedUser().Id).nivel = nivel;
        //    Commit();
        //}
        #endregion

        #region Partida
        public int GetPuntuacionAcumulada() {
            return this.puntuacionAcumulada;
        }
        public void SetPuntuacionAcumulada(int points) {
            int punt = this.puntuacionAcumulada + points;
            this.puntuacionAcumulada = punt < 0 ? 0 : punt;
        }

        public void UpdateErrores() {             
            this.errores++;
        }
        
        public int GetErrores() { return errores; }
        public bool IsConsolidado() { return consolidado; }
        public void Consolidar() {
            this.consolidado = true;         
            int puntosConsolidados = this.partidaActual.PuntuacionPartida;
            this.partidaActual.PuntuacionConsolidada = puntosConsolidados;
            this.puntuacionAcumulada = 0;
            UpdateUserScore(puntosConsolidados);
        }
        public void ResetErroresyConsolidaciones() {
            this.errores = 0;
            this.consolidado = false;
        }
        public void CrearPartida(int nivel)
        {
            if (nivel < 0 || nivel > 10) throw new ServiceException("The level is not within the possible ones");
            partidaActual = new Partida(nivel);
        }

        public void AddPartida(Partida game) {
            if (!repository.GetWhere<Partida>(x => x.PuntuacionPartida == game.PuntuacionPartida && x.Nivel == game.Nivel).Any()){
                repository.Insert<Partida>(game);
                Commit();
            }
            else {
                throw new ServiceException("There is already a game with that dificulty and that punctuation");
            }
        }
        //public Partida GetPartida(int level, int points)
        //{
        //    var random = new Random();


        //    List<Partida> PartidasDb = repository.GetAll<Partida>().ToList();
        //    /*int index = random.Next(PartidasDb.Count);

        //    return PartidasDb.ElementAt(index);*/
        //    return PartidasDb.First();
        //}
        public Partida GetPartidaActual()
        {
            return partidaActual;
        }
        public void SetPartidaActual(Partida partida)
        {
            this.partidaActual = partida;
        }
        public int[] GetDifficultyArray(int level)
        {
            if(level > 4) throw new ServiceException("Difficulty level does not exist!");
            switch (level)
            {
                case 0: return new int[] { 1, 1, 1, 1, 1, 2, 2, 2, 3, 3 };
                case 1: return new int[] { 1, 1, 1, 1, 2, 2, 2, 3, 3, 3 };
                case 2: return new int[] { 1, 1, 1, 2, 2, 2, 2, 3, 3, 3 };
                case 3: return new int[] { 1, 1, 2, 2, 2, 2, 3, 3, 3, 3 };
                case 4: return new int[] { 2, 2, 2, 2, 2, 3, 3, 3, 3, 3 };
            }

            return null;
        }
        public void UpdateGameScore(int score) {
            int punt = this.partidaActual.PuntuacionPartida + score;
            this.partidaActual.PuntuacionPartida = punt < 0 ? 0 : punt;
            Commit();

        }
        public void ResetGameScore() {
            this.partidaActual.PuntuacionPartida = 0;
            Commit();
        }

        public bool GetConsolidado()
        {
            return this.consolidado;
        }
        #endregion

        #region Reto

        #endregion

        #region Pregunta
        public void UpdateUserQuestions(Pregunta pregunta) {
           
            this.loggedUser.PreguntasRealizadas.Add(pregunta);
            Commit();
        }
        public bool CheckQuestionPlayed(Pregunta pregunta) {
            List<Pregunta> QuestionsUsers = this.loggedUser.PreguntasRealizadas.ToList();
            return QuestionsUsers.Contains(pregunta);
        }
        public List<Pregunta> GetUsersQuestionByDificulty(int dificultad) {
            List<Pregunta> preguntas = this.loggedUser.PreguntasRealizadas.ToList();
            
            return preguntas.Where(x => x.Dificultad == dificultad).ToList();
        }
        public void ResetUserQuestions(int dificultad) {
            List<Pregunta> preguntas = this.loggedUser.PreguntasRealizadas.ToList();
            this.loggedUser.PreguntasRealizadas = preguntas.Where(x => x.Dificultad > dificultad).ToList();
        }
        
        public void AddPreguntaToPartida(Pregunta pregunta, Partida partida)
        {
            partida.AddReto(pregunta);
            repository.Insert<Pregunta>(pregunta);
            Commit();
        }
        public void AddPregunta(Pregunta pregunta)
        {
            repository.Insert<Pregunta>(pregunta);
            Commit();
        }

        public List<Pregunta> LoadQuestionsByDifficulty(int difficulty){
            List<Pregunta> questions = new List<Pregunta>();
            questions = repository.GetWhere<Pregunta>(x => x.Dificultad == difficulty).ToList();
            questions = questions.Except<Pregunta>(this.GetUsersQuestionByDificulty(difficulty)).ToList();
            return questions;
        }

        public void Questions(int[] dificultad) {
            if(dificultad.Length != 10) throw new ServiceException("Difficulty array has not the correct length");
            

            var questions = new List<Pregunta>();
            Random random = new Random();
            int prevDifficulty = -1;
            List<Pregunta> questionsDB = null;
         
             
            foreach(int difficulty in dificultad)
            {
               
                if (difficulty > 4 || difficulty < 0) throw new ServiceException("Difficulty array has incorrect values");
                if(difficulty != prevDifficulty)
                {
                    
                    questionsDB = LoadQuestionsByDifficulty(difficulty);
                    prevDifficulty = difficulty;
                }
                if (questionsDB.Count == 0)
                {
                    this.ResetUserQuestions(difficulty);
                    questionsDB = LoadQuestionsByDifficulty(difficulty);
                }
                int index = random.Next(questionsDB.Count);
                questions.Add(questionsDB[index]);
                

                
                questionsDB.RemoveAt(index);
            }

            QuestionServ = questions;
        }

        public void ProgresoAddPreguntaFallada(int index) 
        {
            this.progresoPreguntas.Add(index);
        }
        public void ProgresoDeletePreguntaFallada(int index)
        {
            this.progresoPreguntas.Remove(index);
        }
        public List<int> GetProgresoPreguntas() 
        {
            return progresoPreguntas;
        }
        public void CleanProgresoPreguntas()
        {
            this.progresoPreguntas.Clear();
        }

        public Pregunta QuestionServIndex(int index)
        {
            return QuestionServ[index];

        }
        #endregion

        #region Respuesta
        public List<Respuesta> AnswerShuffle(Pregunta Question){
            List<Respuesta> Answers = new List<Respuesta>();
            var random = new Random();
            List<Respuesta> NoMix = Question.getAllAnswers();

            //int pointer = 0;
            //while (pointer < 4)
            //{
            //    int index = random.Next(NoMix.Count);
            //    Answers.Add(NoMix.ElementAt(index));
            //    NoMix.RemoveAt(index);
            //    pointer++;

            //}

            for(int i = 0; i < 4; i++)
            {
                int index = random.Next(NoMix.Count);
                Answers.Add(NoMix.ElementAt(index));
                NoMix.RemoveAt(index);
            }


            return Answers;
        }

        public void AddRespuestas(ICollection<Respuesta> respuestas)
        {
            foreach(Respuesta respuesta in respuestas)
            {
                repository.Insert<Respuesta>(respuesta);
                Commit();
            }
        }

        public bool TestAnswer(String txt, Pregunta pregunta) {

            //if (pregunta.RespuestaCorrecta == txt)
            //{
            //    return true;
            //}
            //else {
            //    return false;
            //}

            return pregunta.RespuestaCorrecta == txt;
        }
        #endregion

        #region sonidos

        public void Play(string rutaSonido)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(rutaSonido);
            player.Play();
        }

        public string GetRutaSonido(string nombreSonido)
        {
            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProyectoPSW", "QQSSApp", "Resources","Sonidos");
            string rutaArchivo = Path.Combine(rutaCarpeta, nombreSonido + ".wav");
            return rutaArchivo;
        }
        #endregion
    }
}
