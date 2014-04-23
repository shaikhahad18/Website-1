// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Daniel15.Web.Controllers
{
    public partial class RedirectController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public RedirectController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult BlogPost()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.BlogPost);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult BlogUri()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.BlogUri);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public RedirectController Actions { get { return MVC.Redirect; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Redirect";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Redirect";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Css = "Css";
            public readonly string Js = "Js";
            public readonly string BlogPost = "BlogPost";
            public readonly string BlogUri = "BlogUri";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Css = "Css";
            public const string Js = "Js";
            public const string BlogPost = "BlogPost";
            public const string BlogUri = "BlogUri";
        }


        static readonly ActionParamsClass_BlogPost s_params_BlogPost = new ActionParamsClass_BlogPost();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_BlogPost BlogPostParams { get { return s_params_BlogPost; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_BlogPost
        {
            public readonly string month = "month";
            public readonly string year = "year";
            public readonly string day = "day";
            public readonly string slug = "slug";
        }
        static readonly ActionParamsClass_BlogUri s_params_BlogUri = new ActionParamsClass_BlogUri();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_BlogUri BlogUriParams { get { return s_params_BlogUri; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_BlogUri
        {
            public readonly string uri = "uri";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_RedirectController : Daniel15.Web.Controllers.RedirectController
    {
        public T4MVC_RedirectController() : base(Dummy.Instance) { }

        partial void CssOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Css()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Css);
            CssOverride(callInfo);
            return callInfo;
        }

        partial void JsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Js()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Js);
            JsOverride(callInfo);
            return callInfo;
        }

        partial void BlogPostOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int month, int year, int day, string slug);

        public override System.Web.Mvc.ActionResult BlogPost(int month, int year, int day, string slug)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.BlogPost);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "month", month);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "year", year);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "day", day);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "slug", slug);
            BlogPostOverride(callInfo, month, year, day, slug);
            return callInfo;
        }

        partial void BlogUriOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string uri);

        public override System.Web.Mvc.ActionResult BlogUri(string uri)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.BlogUri);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "uri", uri);
            BlogUriOverride(callInfo, uri);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
