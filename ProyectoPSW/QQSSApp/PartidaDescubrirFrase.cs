using ProyectoPSWMain.Entities;
using ProyectoPSWMain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQSSApp
{
    public partial class PartidaDescubrirFrase : Form
    {
        int retoindex;
        int error;
        Frase frase;
        private int currentImageIndex;
        private List<Image> images;
        private List<Image> ods;
        private int tiempoContador;
        private int tiempodeMostrarRta;
        Label clickedLabel;
        Label[] fraseConHuecos;
        Label[] letrasParaHuecos;
        char[] textoFrase;
        List<char> huecos;

        public PartidaDescubrirFrase()
        {
            InitializeComponent();
            InitializeImages();
            this.CenterToScreen();
            this.frase = (Frase) QQSS.service.GetReto();
            this.retoindex = QQSS.service.GetProgressIndex();
            this.error = QQSS.service.GetError();
            PistaBoton.Enabled = QQSS.service.GetNumPistas() > 0;
            QQSS.service.SetPuntosStrategy();
            this.labelPuntuacionAcumulada.Text = QQSS.service.GetPuntuacionPartida().ToString();
            this.puntuacionConsolidadaLabel.Text = QQSS.service.GetPuntuacionConsolidada().ToString();
            InitializeRetoFrase();
            MarcarProgreso();
            InitializeTimers();
            InitializeODS();
            HabilitarBotonAbandonar();
            if (QQSS.service.GetLoggedUser().Nombre != "Test") button1.Hide();
            QQSS.service.PlaySonido("musicaFondo" + GetRandomNumber(2) + "_2min");
            PistaLabel.Text = QQSS.service.GetNumPistas() + "/3";
        }


        public void InitializeRetoFrase()
        {
            fraseConHuecos = new Label[101];
            letrasParaHuecos = new Label[50];

            textoFrase = QQSS.service.QuitarLetras(out huecos).ToCharArray();

            enunciado.Text = frase.Descripcion;

            puntuacionPos.Text = QQSS.service.GetPuntuacionReto().ToString();
            puntuaciónNegativa.Text = (QQSS.service.GetPuntuacionReto() * 2).ToString();

            LabelInit();
        }

        private void LabelInit()
        {
            for (int i = 0; i <= 100; i++)
            {
                string nombreLabel = "letra" + i;
                Control[] controles = this.Controls.Find(nombreLabel, true);
                if (controles.Length == 0 || controles[0] == null) continue;
                Label b = (Label)controles[0];
                fraseConHuecos[i] = b;
                if (i >= textoFrase.Length) { b.Hide(); continue; }
                b.Text = "" + textoFrase[i];
                b.Click += (sender, _) =>
                {
                    if (b.Text != "_") return; //sustituir
                    if (movingLabel.Text != "?")
                    {
                        b.Text = movingLabel.Text;
                        movingLabel.Text = "?";
                        clickedLabel.Hide();
                    }
                };
            }

            for (int i = 0; i <= 49; i++)
            {
                string nombreLabel = "letraHueco" + i;
                Control[] controles = this.Controls.Find(nombreLabel, true);
                if (controles.Length == 0 || controles[0] == null) continue;
                Label b = (Label)controles[0];
                letrasParaHuecos[i] = b;
                if (i >= huecos.Count) { b.Hide(); continue; }
                b.Text = "" + huecos[i];
                b.Click += (sender, _) =>
                {
                    clickedLabel = b;
                    movingLabel.Text = b.Text;
                    movingLabel.Show();
                };
            }
        }

        private void LabelReset()
        {
            puntuacionPos.Text = QQSS.service.GetPuntuacionReto().ToString();
            puntuaciónNegativa.Text = (QQSS.service.GetPuntuacionReto() * 2).ToString();
            for (int i = 0; i < textoFrase.Length; i++)
            {
                fraseConHuecos[i].Text = "" + textoFrase[i];
            }

            for (int i = 0; i < huecos.Count; i++)
            {
                if (letrasParaHuecos[i].Text == "-") continue;
                letrasParaHuecos[i].Show();
                letrasParaHuecos[i].Text = "" + huecos[i];
            }
        }

        public string GetRandomNumber(int maxNumber)
        {
            Random random = new Random();
            return random.Next(maxNumber).ToString();
        }

        private void HabilitarBotonAbandonar()
        {
            botonAbandonar.Enabled = QQSS.service.GetConsolidado();
        }

        private void MarcarProgreso()
        {
            for (int i = 0; i <= (retoindex); i++)
            {
                string nombreBoton = "pos" + i;
                Control[] controles = this.Controls.Find(nombreBoton, true);
                if (controles.Length == 0 || controles[0] == null) continue;
                Button b = (Button)controles[0];
                if (i == retoindex)
                {
                    b.BackColor = Color.YellowGreen;
                }
                else b.BackColor = Color.DarkSeaGreen;
                if (i == error) { b.BackColor = Color.LightCoral; }
            }
        }

        public void InitializeImages()
        {
            images = new List<Image>();
            ods = new List<Image>();

            for (int i = 1; i <= 18; i++)
            {
                string image = "circulo" + i;
                Image imagen = (System.Drawing.Bitmap)QQSSApp.Properties.Resources.ResourceManager.GetObject(image);
                images.Add(imagen);
            }

            for (int i = 0; i <= 17; i++)
            {
                string image = "ODS_" + i;
                Image imagen = (System.Drawing.Bitmap)QQSSApp.Properties.Resources.ResourceManager.GetObject(image);
                ods.Add(imagen);
            }

        }

        public void InitializeODS()
        {
            ods_picture.Image = ods[0];
            if (frase.MuestraImagen) ods_picture.Image = ods[frase.Ods];
        }

        private void TimerTick(object sender, EventArgs e)
        {
            currentImageIndex++;

            if (currentImageIndex >= images.Count) currentImageIndex = 0;

            reloj_circular.Image = images[currentImageIndex];
        }

        private void Atras(object sender, EventArgs e)
        {
            Confirmar confirmarForm = new Confirmar(this);
            confirmarForm.ShowDialog();
        }

        public void CheckAnswer(string fraseFormada)
        {
            if (fraseFormada == frase.Enunciado)
            {
                Form respuestaAcertada;
                if (retoindex != 9) respuestaAcertada = new PuntuacionPositiva();
                else respuestaAcertada = new PartidaGanada();
                respuestaAcertada.Show();
                this.Close();
            }
            else
            {
                LabelReset();
                checkButton.Enabled = false;
                checkButton.BackColor = Color.FromArgb(231, 105, 105);
                
                timer3.Start();
            }
            
        }

        private void TimerTiempoTick(object sender, EventArgs e)
        {
            tiempoContador--;
            tiempo.Text = tiempoContador.ToString();
            if (tiempoContador == 0)
            {

                Form respuestaFallada;
                if (QQSS.service.GetError() != -1) respuestaFallada = new PartidaPerdida();
                else respuestaFallada = new PuntuacionNegativa();
                respuestaFallada.Show();
                this.Close();
            }
        }

        private void InitializeTimers()
        {
            timer1.Interval = 7058;
            timer1.Start();
            timer2.Interval = 1000;
            tiempoContador = 120;
            timer2.Start();
            tiempodeMostrarRta = 2;
            timer3.Interval = 1000;

        }


        private void CheckButtonOnClick(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Label l in fraseConHuecos)
            {
                if (l.Text == "A") break;
                sb.Append(l.Text);
            }
            CheckAnswer(sb.ToString());
        }

        private void TimerMostrarRespuestaTick(object sender, EventArgs e)
        {
            tiempodeMostrarRta--;

            if (tiempodeMostrarRta != 0) return;

            checkButton.Enabled = true;
            checkButton.BackColor = Color.FromArgb(127, 221, 130);
            tiempodeMostrarRta = 2;
        }

        private void PistaBoton_Click(object sender, EventArgs e)
        {
            PistaBoton.Enabled = false;
            QQSS.service.UsarPista();
            PistaLabel.Text = QQSS.service.GetNumPistas() + "/3";

            Random random = new Random();
            int indice = random.Next(0, letrasParaHuecos.Length);
            char letra = letrasParaHuecos[indice].Text[0];
            puntuacionPos.Text = (QQSS.service.GetPuntuacionReto() / 2).ToString();
            int puntNeg = -QQSS.service.GetPuntuacionReto() * 2;
            puntuaciónNegativa.Text = puntNeg.ToString();
            for (int i = 0; i < fraseConHuecos.Length; i++)
            {
                if (fraseConHuecos[i].Text != "_") continue;
                if (frase.Enunciado[i] != letra) continue;

                fraseConHuecos[i].Text = letra + "";
                textoFrase[i] = letra;

            }

            foreach (Label l in letrasParaHuecos)
            {
                if (l.Text == letra + "")
                {
                    l.Hide();
                    l.Text = "-";
                }
            }

        }

        private void Autocompletar(object sender, EventArgs e)
        {
            for (int i = 0; i < textoFrase.Length; i++)
            {
                fraseConHuecos[i].Text = "" + frase.Enunciado[i];
            }

            for (int i = 0; i < huecos.Count; i++)
            {
                letrasParaHuecos[i].Hide();
            }
            //CheckAnswer(frase.Enunciado);
        }
    }
}
