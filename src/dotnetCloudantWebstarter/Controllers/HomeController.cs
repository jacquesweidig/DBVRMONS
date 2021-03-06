﻿using CloudantDotNet.Models;

namespace CloudantDotNet.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
        public IActionResult Index()
        {
            int[] tabCote = new int[4];
            ListVote liste = new ListVote();
            for(int i=0; i < 4; i++)
            {
                int valeur = 0;
                int j = 0;
                List<Vote> votes = liste.DisplayListe("case"+i);
                foreach (var v in votes)
                {
                    j++;
                    valeur += v.note;
                }
                valeur = valeur / j;
                tabCote[i] = valeur;
            }

            ViewBag.coteGeneral = tabCote;
            return View();
        }

        public IActionResult AfficherCas(string id)
        {
            ListVote liste = new ListVote();
            List<Vote> votes = liste.DisplayListe(id);
            return View(votes);
        }
    }
}