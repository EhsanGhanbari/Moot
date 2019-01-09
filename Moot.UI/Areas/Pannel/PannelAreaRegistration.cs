using System.Web.Mvc;

namespace Moot.UI.Areas.Pannel
{
    public class PannelAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Pannel";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Pannel_default",
                "Pannel/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[]{"Moot.UI.Areas.Pannel.Controllers"}
               
            );
        }
    }
}
