﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using GreatFriends.ThaiBahtText;

namespace ThaiBahtText.Web.Controllers {
  public class HomeController : Controller {

    public ActionResult Index() {
      ViewBag.Min = ThaiBahtTextUtil.MinValue;
      ViewBag.Max = ThaiBahtTextUtil.MaxValue;
      return View();
    }

    [HttpPost]
    public ActionResult ToThaiBahtText(decimal? amount) {
      if (amount == null) {
        amount = 0m;
      }
      var result = new{
        AmountText = amount.Value.ToString("n2"),
        ThaiBahtText = amount.ThaiBahtText()
      };
      return Json(result);
    } 

  }
}