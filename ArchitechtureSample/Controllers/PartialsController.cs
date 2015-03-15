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
using FloraLimitedTest.Models.EntityModel;

namespace FloraLimitedTest.Controllers {
    [OutputCache(CacheProfile = "YearNoParam")]
    public class PartialsController : GenericController<TestDatabaseEntities> {


        #region Constructors

        public PartialsController()
            : base(true) {

        }

        #endregion

        #region EmployeesController : DropDowns to paste into the partial

        // [DonutOutputCache(CacheProfile = "YearNoParam")]
        public JsonResult GetCategoryID() {
            var data = db.Categories.Select(n => new { id = n.CategoryID, display = n.CategoryName }).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        #endregion
    }

}
