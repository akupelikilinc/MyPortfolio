﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DataAccessLayer.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {

        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Skills.ToList();

            return View(values);
        }
    }
}
