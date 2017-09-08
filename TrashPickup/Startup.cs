using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using TrashPickup.Models;

[assembly: OwinStartupAttribute(typeof(TrashPickup.Startup))]
namespace TrashPickup
{
    public partial class Startup
    {
        private IRoleStore<IdentityRole, string> content;

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRoleandUser();
        }
        private void createRoleandUser()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists("Customer"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Customer";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("Employee"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Employee";
                roleManager.Create(role);
            }
        }
    }
}
