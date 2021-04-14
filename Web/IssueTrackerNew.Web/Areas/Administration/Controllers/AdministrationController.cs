namespace IssueTrackerNew.Web.Areas.Administration.Controllers
{
    using IssueTrackerNew.Common;
    using IssueTrackerNew.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
