using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Website
{
   public class Global : System.Web.HttpApplication
   {
      protected void Application_Start(object sender, EventArgs e)
      {
         
      }

      protected void Session_Start(object sender, EventArgs e)
      {

      }

      protected void Application_BeginRequest(object sender, EventArgs e)
      {

      }

      protected void Application_AuthenticateRequest(object sender, EventArgs e)
      {

      }

      protected void Application_Error(object sender, EventArgs e)
      {

      }

      protected void Session_End(object sender, EventArgs e)
      {

      }

      protected void Application_End(object sender, EventArgs e)
      {

      }
   
      #region
      // la seguente patch serve ad abilitare l'oggetto Session in HttpContext che altrimenti sarebbe null
      // preso da http://stackoverflow.com/questions/11478244/asp-net-web-api-session-or-something
      public override void Init()
      {
          this.PostAuthenticateRequest += MvcApplication_PostAuthenticateRequest;
          base.Init();
      }

      void MvcApplication_PostAuthenticateRequest(object sender, EventArgs e)
      {
          System.Web.HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Required);
      }
      #endregion
   }
}