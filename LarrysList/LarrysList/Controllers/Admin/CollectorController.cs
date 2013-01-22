﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LarrysList.Auth;
using LarrysList.Models;

namespace LarrysList.Controllers.Admin
{
    public class CollectorController : BaseController
    {

        [AuthClient]
        public string index(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collector_get");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }


        [AuthClient]
        public string create(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collector_create");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

    }
}