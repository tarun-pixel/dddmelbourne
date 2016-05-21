﻿using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using DevDevDev.Infrastructure;
using DevDevDev.Models;
using DevDevDev.Services;

namespace DevDevDev.Controllers
{
    /*public class VotingController : Controller
    {
        private readonly VoteService _voteService = new VoteService();
        private readonly SubmittedSessionsService _submittedSessionsService = new SubmittedSessionsService();
        
        public ActionResult SessionsToVoteFor()
        {
            var model = new SubmittedSessionsViewModel()
            {
                ValidateWithEventbrite = FeatureFlags.ValiateEventbriteVotes
            };

            return View(model);
        }

        [OutputCache(Duration = 3600)]
        public ActionResult GetSessionsAsJson()
        {
            var model = _submittedSessionsService.GetSessionsForVoting();

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [Throttle(Name = "ThrottleVote", Message = "Request throttled", Seconds = 5)]
        [HttpPost]
        public ActionResult SubmitVote(string[] sessionIds, string orderNumber = "", string orderEmail = "")
        {
            if (sessionIds.Length != EventConfig.TotalVotes)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            var votes = new List<Vote>();
            for (var i = 0; i < EventConfig.TotalVotes; i++)
            {
                votes.Add(new Vote(sessionIds[i], System.Web.HttpContext.Current.Request.UserHostAddress, orderNumber, orderEmail));
            }

            _voteService.AddVotes(votes);

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        public ActionResult VotedSuccessfully()
        {
            return View();
        }

        public ActionResult VotingFailure()
        {
            return View();
        }
    }*/
}
