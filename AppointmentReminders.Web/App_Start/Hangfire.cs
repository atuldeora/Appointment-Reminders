using Hangfire;
using Owin;

namespace AppointmentReminders.Web
{
    public class Hangfire
    {
        public static void ConfigureHangfire(IAppBuilder app)
        {
            GlobalConfiguration.Configuration
                .UseSqlServerStorage("DefaultConnection");

            app.UseHangfireDashboard("/jobs");
            app.UseHangfireServer();
        }

        public static void InitializeJobs()
        {
            //Runs the job every minute ==> Cron.Minutely
            RecurringJob.AddOrUpdate<Workers.SendNotificationsJob>(job => job.Execute(), Cron.Minutely);
        }
    }
}