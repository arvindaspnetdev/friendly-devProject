using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using System.Web.Mvc;

namespace EMRFacade
{
    public class RestSharpHandler

    {
        public T RestRequest<T>(bool withAuth, string url, string methodType, List<NameValuePair> lstParameters, List<object> lstObjParameter = null) where T : new()
        {
            var restUrl = Common.URLServicePath + url;

            var client = new RestClient(restUrl);

            RestRequest request = null;
            switch (methodType.ToUpper())
            {
                case "GET":
                    request = new RestRequest("", Method.GET);
                    break;
                case "POST":
                    request = new RestRequest("", Method.POST);
                    break;
                case "DELETE":
                    request = new RestRequest("", Method.DELETE);
                    break;
                default:
                    request = new RestRequest("", Method.GET);
                    break;
            }

            if (withAuth)
            {
            }
            
            if (lstParameters != null)
            {
                foreach (NameValuePair param in lstParameters)
                {
                    request.AddParameter(param.Name, param.Value);
                }
            }

            if (lstObjParameter != null)
            {
                foreach (object obj in lstObjParameter)
                {
                    request.AddParameter("application/json; charset=utf-8", JsonConvert.SerializeObject(obj), ParameterType.RequestBody);
                }
            }

            request.Timeout = 1200000;
            client.Timeout = 1200000;
            var response = client.Execute<T>(request);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                var context = new HttpContextWrapper(HttpContext.Current);
                if (context.Request.IsAjaxRequest())
                {
                    context.Response.Clear();
                    context.Response.Write("UnAuthorized");
                    context.Response.End();
                }
                else
                {
                    HttpContext.Current.Response.Redirect("~/Account/Login");
                }
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                var badRequestMessage = JsonConvert.DeserializeObject<APIMessage>(response.Content);
                if (badRequestMessage != null)
                    throw new Exception(badRequestMessage.Message);
                else
                    throw new Exception(response.Content);
            }
            else if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.ErrorMessage);
            }

            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}