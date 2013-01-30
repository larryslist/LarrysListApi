﻿using System;
using LarrysList.Auth;
using LarrysList.Models;

namespace LarrysList.Controllers.Admin
{
    public class CollectionController : BaseController
    {
  
        public string create(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collection_create");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        public string basicEdit(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collection_base_edit");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        public string artistEdit(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collection_artist_edit");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }
        public string communicationEdit(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collection_communication_edit");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }


        [AuthClient]
        public string document(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collection_document_assign");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

        [AuthClient]
        public string theme(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collection_theme_edit");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }
        [AuthClient]
        public string origin(Collector collector)
        {
            try
            {
                result = orm.execObject<Result>(collector, "api.admin_collection_origin_edit");
            }
            catch (Exception exp)
            {
                errorResult(exp);
            }
            return formattedResult(result);
        }

    }
}
