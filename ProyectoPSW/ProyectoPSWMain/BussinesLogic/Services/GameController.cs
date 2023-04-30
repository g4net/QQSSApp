using ProyectoPSWMain.Entities;
using ProyectoPSWMain.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ProyectoPSWMain.Services
{
    public class GameController : IGameController
    {
        private String[] enlaces = { "https://www.un.org/sustainabledevelopment/es/poverty/", "https://www.un.org/sustainabledevelopment/es/hunger/",
        "https://www.un.org/sustainabledevelopment/es/health/", "https://www.un.org/sustainabledevelopment/es/education/", "https://www.un.org/sustainabledevelopment/es/gender-equality/",
        "https://www.un.org/sustainabledevelopment/es/water-and-sanitation/", "https://www.un.org/sustainabledevelopment/es/energy/", "https://www.un.org/sustainabledevelopment/es/economic-growth/",
        "https://www.un.org/sustainabledevelopment/es/infrastructure/", "https://www.un.org/sustainabledevelopment/es/inequality/", "https://www.un.org/sustainabledevelopment/es/cities/",
        "https://www.un.org/sustainabledevelopment/es/sustainable-consumption-production/", "https://www.un.org/sustainabledevelopment/es/climate-change-2/",
        "https://www.un.org/sustainabledevelopment/es/oceans/", "https://www.un.org/sustainabledevelopment/es/biodiversity/", "https://www.un.org/sustainabledevelopment/es/peace-justice/",
        "https://www.un.org/sustainabledevelopment/es/globalpartnerships/"};
        public GameController() 
        {
            retos = new List<Reto>();
            retosAcertados= new List<Reto>();
        }

        private Partida partida;
        private int error;
        private bool consolidado;
        private int index;
        private int pistasDisponibles;
        private List<Reto> retos;
        private List<Reto> retosAcertados;

        public void UpdateError()
        {
            this.error = index;
        }

        public int GetError() { return error; }
        public bool IsConsolidado() { return consolidado; }
        public void Consolidar()
        {
            this.consolidado = true;
            this.partida.PuntuacionConsolidada = this.partida.PuntuacionPartida;
        }
        public void CrearPartida(int nivel)
        {
            if (nivel < 0 || nivel > 4) throw new ServiceException("The level is not within the possible ones");
            Reset();
            partida = new Partida(nivel);
        }

        public Partida GetPartidaActual()
        {
            return partida;
        }
        public void SetPartidaActual(Partida partida)
        {
            this.partida = partida;
        }
        public int[] GetDifficultyArray()
        {
            int level = partida.Nivel;
            if (level > 4) throw new ServiceException("Difficulty level does not exist!");
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

        public bool GetConsolidado()
        {
            return this.consolidado;
        }

        public int GetIndex()
        {
            return this.index;
        }

        public String EnlaceInteres(int ods)
        {
            return enlaces.ElementAt(ods - 1);
        }

        private void Reset()
        {
            this.index = 0;
            this.consolidado = false;
            this.error = -1;
            this.partida = null;
            this.pistasDisponibles = 3;
        }

        public void SetRetos(List<Reto> retos)
        {
            this.retos = retos;
        }



        protected void NextReto()
        {
            this.index++;
        }

        public Reto GetReto()
        {
            return retos[this.index];
        }

        public void RetoAcertado()
        {
            Reto reto = this.retos[this.index];
            NextReto();
            partida.PuntuacionPartida += reto.Puntuacion_acierto;
            retosAcertados.Add(reto);
        }

        public void RetoFallado()
        {
            Reto reto = this.retos[this.index];
            int nuevaPuntuacionConsolidada = partida.PuntuacionConsolidada - reto.Puntuacion_acierto * 2;
            partida.PuntuacionConsolidada = nuevaPuntuacionConsolidada < 0 ? 0 : nuevaPuntuacionConsolidada;

            int nuevaPuntuacionActual = partida.PuntuacionPartida - reto.Puntuacion_acierto * 2;
            partida.PuntuacionPartida = nuevaPuntuacionActual < 0 ? 0 : nuevaPuntuacionActual;
            PreguntaExtra();
        }

        protected void PreguntaExtra()
        {
            this.error = this.index;
            int dificultad = GetDifficultyArray()[this.index];
            Random random = new Random();
            List<Pregunta> questions = QQSS.service.LoadUndoneQuestionsByDifficulty(dificultad);
            int idx = random.Next(questions.Count);
            retos[index] = questions[idx];
        }

        public List<Respuesta> AnswerShuffle()
        {
            Pregunta Question = (Pregunta)retos[this.index];
            List<Respuesta> Answers = new List<Respuesta>();
            var random = new Random();
            List<Respuesta> NoMix = Question.getAllAnswers();

            for (int i = 0; i < 4; i++)
            {
                int index = random.Next(NoMix.Count);
                Answers.Add(NoMix.ElementAt(index));
                NoMix.RemoveAt(index);
            }
            return Answers;
        }

        public bool TestAnswer(string txt)
        {
            return ((Pregunta)this.retos[this.index]).RespuestaCorrecta.Equals(txt);
        }

        public List<Reto> GetRetosAcertados()
        {
            return retosAcertados;
        }

    }
}
