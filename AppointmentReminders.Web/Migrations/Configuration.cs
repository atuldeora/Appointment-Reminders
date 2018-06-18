namespace AppointmentReminders.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AppointmentReminders.Web.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AppointmentReminders.Web.Models.AppointmentRemindersContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppointmentReminders.Web.Models.AppointmentRemindersContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Appointments.AddOrUpdate(
              p => p.Id,
              new Appointment{Name="Bill Pay",PhoneNumber="805-404-1596",Time=System.DateTime.Now,Timezone="PST",CreatedAt= System.DateTime.Now }
            );
            //
        }
    }
}
