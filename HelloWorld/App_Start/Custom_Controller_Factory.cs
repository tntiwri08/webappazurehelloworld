﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.App_Start
{
    public class Custom_Controller_Factory : DefaultControllerFactory
    {
        public override IController CreateController
        (System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            string controllername = requestContext.RouteData.Values
            ["controller"].ToString();
            // Debug.WriteLine(string.Format("Controller Name : {0}", controllername));            
            Type controllerType = Type.GetType(string.Format
             (/*need to set full qualifiere name*/"HelloWorld.Controllers.{0}", controllername+"Controller"));
            //typeof(Home);
            IController controller = Activator.CreateInstance(controllerType) as IController;
            return controller;
        }
        public override void ReleaseController(IController controller)
        {
            IDisposable dispose = controller as IDisposable; if (dispose != null)
            {
                dispose.Dispose();
            }
        }
    }
}