using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Transkodowanie
{
    public partial class Form1 : Form
    {
        private readonly string SciezkaProgramuVlc = "C:\\Program Files (x86)\\VideoLAN\\VLC\\vlc.exe";
        private readonly string OpcjeWyjsciowe = "access=file,mux=ts,dst="; // na końcu zostanie dopisana ścieżka pliku wyj.
        private Hashtable OpcjeWejsciowe = new Hashtable() // tworzone są w trakcie uzupełniania pól.
        {
            {"vcodec", "" },
            {"vb","" },
            {"scale","" },
            {"fps","" },
            {"width","" },
            {"height","" },
            {"acodec", "" },
            {"ab","" }
        };
        string SciezkaPlikuWej = string.Empty;
        string SciezkaPlikuWyj = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        private string UtworzArgumenty(string OpcjeWej, string OpcjeWyj)
        {
            return $"--sout=#transcode{{{OpcjeWej}}}:standard{{{OpcjeWyj}}} vlc://quit";
        }

        private void Transkoduj()
        {
            string OWyj = OpcjeWyjsciowe;
            string OWej = "";
            if(SciezkaPlikuWyj==string.Empty)
            {
                throw new Exception("Wybierz plik do zapisu.");
            }
            else
            {
                OWyj += '"' + Path.ChangeExtension(SciezkaPlikuWyj, ".ts") + '"';
            }
            if (SciezkaPlikuWej == string.Empty)
            {
                throw new Exception("Wybierz plik do odczytu.");
            }
            if(nudPrzeplywnoscAudio.Value > 0)
            {
                OpcjeWejsciowe["ab"] = nudPrzeplywnoscAudio.Value.ToString();
            }
            else
            {
                OpcjeWejsciowe["ab"] = "";
            }
            if (nudPrzeplywnoscWideo.Value > 0)
            {
                OpcjeWejsciowe["vb"] = nudPrzeplywnoscWideo.Value.ToString();
            }
            else
            {
                OpcjeWejsciowe["vb"] = "";
            }
            foreach (string key in OpcjeWejsciowe.Keys)
            {
                if ((string) OpcjeWejsciowe[key] != string.Empty)
                {
                    OWej += key + '=' + (string) OpcjeWejsciowe[key] + ',';
                }
            }
            OWej = OWej.TrimEnd(','); // usuwa nadmiarowy przecinek w opcjach.
            if (OWej == string.Empty) throw new Exception("Nie wprowadzono zmian.");
            string args = '"'+SciezkaPlikuWej+'"'+' '+UtworzArgumenty(OWej, OWyj);
            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = SciezkaProgramuVlc,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                Arguments = args
            };
            using Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
            process.WaitForExit(-1);
        }

        private void btnPlikWej_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.SciezkaPlikuWej = fd.FileName;
            }
            fd.Dispose();
        }

        private void PokazPolaWejsciowe(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if(cb.Text == "Skalowanie")
            {
                textBox1.Visible = true;
                textBox1.Text = "0";
                textBox2.Visible = false;
                labelXX.Visible = false;
                OpcjeWejsciowe["width"] = "";
                OpcjeWejsciowe["height"] = "";
            }
            else if(cb.Text == "Dokładne wymiary")
            {
                textBox1.Visible = true;
                textBox1.Text = "0";
                textBox2.Visible = true;
                textBox2.Text = "0";
                labelXX.Visible = true;
                OpcjeWejsciowe["scale"] = "";
            }
            else
            {
                textBox1.Visible = false;
                OpcjeWejsciowe["scale"] = "";
                OpcjeWejsciowe["width"] = "";
                OpcjeWejsciowe["height"] = "";
                textBox2.Visible = false;
                labelXX.Visible = false;
            }
        }

        private void btnPlikWyj_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.SciezkaPlikuWyj = fd.FileName;
            }
            fd.Dispose();
        }

        private void btnTranskoduj_Click(object sender, EventArgs e)
        {
            try {
                Transkoduj();
            }
            catch(Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void SprawdzWartoscTb1(object sender, EventArgs e)
        {
            if(cbWyborRozmiaruRamki.Text == "Skalowanie")
            {
                float value;
                if(float.TryParse(textBox1.Text.Replace('.',','), out value) && value != 0)
                {
                    OpcjeWejsciowe["scale"] = value.ToString().Replace(',', '.');
                }
                else
                {
                    OpcjeWejsciowe["scale"] = "";
                }
            }
            else if(cbWyborRozmiaruRamki.Text == "Dokładne wymiary")
            {
                int w;
                if (int.TryParse(textBox1.Text, out w) && w != 0)
                {
                    OpcjeWejsciowe["width"] = w.ToString();
                }
                else
                {
                    OpcjeWejsciowe["width"] = "";
                }
            }
            else
            {
                OpcjeWejsciowe["scale"] = "";
                OpcjeWejsciowe["width"] = "";
            }
        }

        private void SprawdzFPS(object sender, EventArgs e)
        {
            if (float.TryParse(tbKlatkiNaSekunde.Text.Replace('.', ','), out float value) && value > 1)
            {
                OpcjeWejsciowe["fps"] = value.ToString().Replace(',', '.');
            }
            else
            {
                OpcjeWejsciowe["fps"] = "";
            }
        }

        private void SprawdzWartoscTb2(object sender, EventArgs e)
        {
            if (cbWyborRozmiaruRamki.Text == "Dokładne wymiary")
            {
                int h;
                if (int.TryParse(textBox2.Text, out h) && h != 0)
                {
                    OpcjeWejsciowe["height"] = h.ToString();
                }
                else
                {
                    OpcjeWejsciowe["height"] = "";
                }
            }
            else
            {
                OpcjeWejsciowe["height"] = "";
            }
        }

        private void ZmianaKodekaWideo(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Text == (string) cb.Items[1]
                || cb.Text == (string) cb.Items[2]
                || cb.Text == (string) cb.Items[3])
            {
                OpcjeWejsciowe["vcodec"] = cb.Text;
            }
            else
            {
                OpcjeWejsciowe["vcodec"] = "";
            }
        }
        private void ZmianaKodekaAudio(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Text == (string)cb.Items[1]
                || cb.Text == (string)cb.Items[2])
            {
                OpcjeWejsciowe["acodec"] = cb.Text;
            }
            else
            {
                OpcjeWejsciowe["acodec"] = "";
            }
        }
    }
}
