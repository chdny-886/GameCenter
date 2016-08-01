﻿using GameCenter.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameCenter.GameWeb.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            ViewBag.News1 = NewsService.GetListByTypeId(1, 10);
            ViewBag.News2 = NewsService.GetListByTypeId(2, 10);
            ViewBag.News3 = NewsService.GetListByTypeId(3, 10);
            ViewBag.News4 = NewsService.GetListByTypeId(4, 10);
            return View();
        }

        public ActionResult Info(int id)
        {
            var info = NewsService.GetOneById(id);
            return View(info);
        }
    }
}