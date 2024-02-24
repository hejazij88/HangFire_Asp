using Hangfire.Dashboard;

namespace BackGroundTask_HangFire.HangFireSecurity
{
    public class MyAuthorizationFilter:IDashboardAuthorizationFilter
    {
        public bool Authorize(DashboardContext context)
        {
            var httpContext = context.GetHttpContext();
            return httpContext.User.Identity.IsAuthenticated;
        }
    }
}
