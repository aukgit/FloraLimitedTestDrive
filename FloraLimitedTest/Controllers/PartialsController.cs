using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FloraLimitedTest.Controllers;
using FloraLimitedTest.Models.Context;
using DevTrends.MvcDonutCaching;

namespace FloraLimitedTest.Controllers {
    [OutputCache(CacheProfile = "YearNoParam")]
    public class PartialsController : GenericController<DevIdentityDbContext> {


        #region Constructors

        public PartialsController()
            : base(true) {

        }

        #endregion


    }

}
