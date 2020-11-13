using System;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace ListaCircularEjemplo
{
    class Graficador
    {
        string ruta;
        StringBuilder grafo;
        public Graficador()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        private void GenerarDot(String rdot, String rpng)
        {
            File.WriteAllText(rdot, grafo.ToString());
            String comandoDot = "dot.exe -Tpng " + rdot + " -o " + rpng + " ";
            var comando = string.Format(comandoDot);
            var proStar = new ProcessStartInfo("cmd", "/C" + comando);
            var proc = new Process();
            proc.StartInfo = proStar;
            proc.Start();
            proc.WaitForExit();
        }
        public void Graficar(string texto)
        {
            grafo = new StringBuilder();
            String rdot = ruta + "\\Graphviz\\imagen.dot";
            String rpng = ruta + "\\Graphviz\\imagen.png";
            //grafo.Append("Ejemplo 6 {");
            //grafo.Append(texto);
            grafo.Append("digraph ejemplo1{            Nodo0[shape = egg];              Nodo1[shape = box];             Nodo2[label = \"texto\"];           }" );
            GenerarDot(rdot, rpng);
            AbrirGrafo();
        }

        public void AbrirGrafo()
        {
            if (File.Exists(ruta))
            {
                try
                {
                    Process.Start(ruta + "\\Graphviz\\imagen.png");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR" + ex);
                }
            }
            else
            {

            }
        }
    }
}
