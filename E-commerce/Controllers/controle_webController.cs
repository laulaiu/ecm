﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_commerce.Controllers
{
    public class controle_webController : Controller
    {

        // GET: controle_web
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Produto_categoria1()
        {
            return View();
        }

        public ActionResult Produto_categoria2()
        {
            return View();
        }

        public ActionResult Carrinho()
        {
            return View();
        }

    }
}