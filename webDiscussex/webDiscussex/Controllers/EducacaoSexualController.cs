﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webDiscussex.Models;
using webDiscussex.DAO;

namespace webDiscussex.Controllers
{
    public class EducacaoSexualController : Controller
    {
        // GET: EducacaoSexual
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gravidez()
        {
            var dao = new GravidezDAO();
        
            IList<Imagem> listaImagens = new List<Imagem>();

            IList<Gravidez> lista = dao.Lista(ref listaImagens);

            ViewBag.ListaImagens = listaImagens;

            ViewBag.Tabela = lista;

            return View();
        }

        public ActionResult Prevencao()
        {
            var dao = new PrevencaoDAO();

            IList<Imagem> listaImagens = new List<Imagem>();

            IList<Prevencao> lista = dao.Lista(ref listaImagens);

            ViewBag.ListaImagens = listaImagens;

            ViewBag.Tabela = lista;

            return View();
        }

        public ActionResult Corpo()
        {
            var dao = new CorpoDAO();

            IList<Imagem> listaImagens = new List<Imagem>();

            IList<Corpo> lista = dao.Lista(ref listaImagens);
       
            ViewBag.ListaImagens = listaImagens;

            ViewBag.Tabela = lista;

            return View();
        }


        public ActionResult HIV()
        {
            var dao = new HivDAO();

            IList<Imagem> listaImagens = new List<Imagem>();

            IList<Hiv> lista = dao.Lista(ref listaImagens);

            ViewBag.ListaImagens = listaImagens;

            ViewBag.Tabela = lista;

            return View();
        }

        public ActionResult Infeccoes()
        {
            var dao = new DoencaDAO();

            IList<Imagem> listaImagens = new List<Imagem>();

            IList<Doenca> lista = dao.Lista(ref listaImagens);

            ViewBag.ListaImagens = listaImagens;

            ViewBag.Tabela = lista;

            return View();
        }
    }
}