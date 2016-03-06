using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImdbDAL;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.IISPlatformHandler;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Core;
using Microsoft.AspNet.Mvc.Formatters;
using Microsoft.AspNet.Routing;
using Microsoft.AspNet.StaticFiles;
using Microsoft.AspNet.StaticFiles.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace WebApplication2
{
	public class Startup
	{
		public Startup(IHostingEnvironment env)
		{
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			app.UseDeveloperExceptionPage();

			app.Run(async (context) =>
			{
				await context.Response.WriteAsync("Hello World!");
			});
		}

		// Entry point for the application.
		public static void Main(string[] args) => WebApplication.Run<Startup>(args);
	}
}
