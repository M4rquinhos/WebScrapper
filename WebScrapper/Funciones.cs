using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WebScrapper
{
    class Funciones
    {
        public static void GuardarLista(HtmlNodeCollection nodos)
        {
            string path = @"C:\Users\Marco Carrillo\Desktop\C#\WebScrapper\WebScrapper\lista.txt";
            if (!File.Exists(path))
            {
                StreamWriter sw = File.CreateText(path);
                foreach (var nodo in nodos)
                {
                    sw.WriteLine(nodo.InnerText);
                }
                sw.Dispose();
            }
            else
            {
                StreamWriter sw = new StreamWriter(path, false);
                foreach (var nodo in nodos)
                {
                    sw.WriteLine(nodo.InnerText);
                }
                sw.Dispose();
            }
        }
    }
}
