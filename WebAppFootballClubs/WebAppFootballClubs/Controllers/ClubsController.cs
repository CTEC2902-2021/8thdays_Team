﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppFootballClubs.Controllers
{
    public class ClubsController : Controller
    {
        // GET: Clubs
        public ActionResult Index()
        {
            return View();
        }
    }
}