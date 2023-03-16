using HtmlAgilityPack;
using System;
using System.Collections.Generic;

namespace WebScrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("W E B  S C R A P P E R");
            Console.WriteLine(@"
                      #####
     #    #######                    #######
   ###          ####                ##      #####
   #               ##              #             ###
    #                #            #                ###
    #                 #          #                   ##
    #        ###      #         #                     #
    #   ######  #     #         #        #####         #
   ##   # ##### #     #         #       # ### #        ##
   #   #   #### #     #         #       #######         #
  ##   ### #####     #          ##       ######         #
 ##       ###       ##            #                     #
##                  #              ###                  #
##                 #                  ##               ##
 #              ###                     ####           #
  ##         ###                           ############
    #########

");

            /*
             Crea una instancia de la clase HtmlWeb y usa el método Load() 
             para cargar la página web que quieres scrapear:
             */
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://github.com/M4rquinhos?tab=repositories");
            /*
             Utiliza la clase HtmlNode para buscar los elementos que deseas extraer de la página. 
             Puedes hacerlo a través del método SelectNodes() pasándole un XPath que identifique los elementos 
             que te interesan:
             */
            HtmlNodeCollection nodos = doc.DocumentNode.SelectNodes("//h3[@class='wb-break-all']//a");
            /*
             Recorre la colección de nodos y extrae la información que necesitas. 
             Por ejemplo, si quieres extraer el texto de un nodo de texto:
             */
            Console.WriteLine("¿Quiere guardar la lista de repositorios? Si / No");
            string opc = Console.ReadLine();
            bool op = true;
            try
            {
                if (!opc.ToLower().Equals("si"))
                {
                    op = false;
                }

                foreach (var nodo in nodos)
                {
                    Console.WriteLine(nodo.InnerText);
                }

                if (op)
                {
                    Funciones.GuardarLista(nodos);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
