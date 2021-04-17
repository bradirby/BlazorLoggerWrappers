using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorLoggerWrappers.Shared;
using Serilog;
using Serilog.Events;
using Serilog.Formatting.Compact;

namespace BlazorLoggerWrappers.Server
{
    public class Startup
    {

        private IMessageLogger MsgLogger ;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddRazorPages();
            AddSerilogLogger(services);

        }

        private void AddSerilogLogger(IServiceCollection services)
        {
            var cfg = new LoggerConfiguration().Enrich.FromLogContext().WriteTo.Debug();
            cfg.WriteTo.Console();
            cfg = cfg.WriteTo.File(new CompactJsonFormatter(), LogFileLocation, LogEventLevel.Debug, rollingInterval: RollingInterval.Day);

            cfg = cfg.MinimumLevel.Debug();

            Log.Logger = cfg.CreateLogger();
            MsgLogger = new SerilogLogger();

            MsgLogger.Debug("App is starting up");

            services.AddTransient<IMessageLogger, SerilogLogger>();
        }

        private string LogFileLocation => "logs\\MyLogFile.log";

        /// <summary>
        /// I dev, I like to clean out the log file on each run to focus on just the current items
        /// </summary>
        private void DeleteLogFileInDev()
        {
            try
            {
                File.Delete(LogFileLocation);
            }
            catch (Exception)
            {
                //ignore any errors - file is sometimes locked
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
                DeleteLogFileInDev();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
