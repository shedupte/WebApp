﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class GigController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}