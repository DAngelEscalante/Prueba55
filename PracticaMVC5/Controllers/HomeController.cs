using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaMVC5.Models;



namespace PracticaMVC5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var peliculas = new List<Peliculas>
            {
                new Peliculas {Titulo = "TheGodFather", Director = "Francis Ford Copola", AutorPrincipal ="Al pacino", NumAutores =30, Duracion =2, Estreno =1994},
                 new Peliculas {Titulo = "TheShawShank", Director = "Frank Darabont", AutorPrincipal ="Morgan Freeman", NumAutores =15, Duracion =3, Estreno =1972},
                  new Peliculas {Titulo = "TheMatrix", Director = "Lana Wachowski ", AutorPrincipal ="Keanus Reves", NumAutores =15, Duracion =2.30, Estreno =1999},
                   new Peliculas {Titulo = "City Of God", Director = "Fernando Meirelles", AutorPrincipal ="Alexander Rodrigues", NumAutores =10, Duracion =3, Estreno =2002},
                    new Peliculas {Titulo = "Star Wars : Episode 5", Director = "George Lucas", AutorPrincipal ="Harrison Ford", NumAutores =20, Duracion =2.40, Estreno =2007}

            };
            //Codigo LinkQ para mostrar las peliculas con la Letra"The"
            var resulPeliculas = from Peliculas in peliculas
                                 where Peliculas.Titulo.Contains("%The")
                                 select Peliculas;
            return View(resulPeliculas);
        }
    }
}
