using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NLH_DAL.EF;
using NLH_DAL.Repositories;
using NLH_DAL.Services;


namespace NHL_SERVICES
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<NLHContext>(opt=>opt.UseSqlServer(Configuration.GetConnectionString("NHLConnection")));
            services.AddScoped<ICommodite_Admission, Commodite_AdmissionRepository>();
            services.AddScoped<ICommodites_Extra, Commodites_ExtraRepository>();
            services.AddScoped<IAssurance, Compagnie_AssuranceRepository>();
            services.AddScoped<IDepartement, DepartementRepository>();
            services.AddScoped<IDossier_Admission, Dossier_AdmissionRepository>();
            services.AddScoped<IFacture, FactureRepository>();
            services.AddScoped<ILit, LitRepository>();
            services.AddScoped<IMedecin, MedecinRepository>();
            services.AddScoped<IParent, ParentRepository>();
            services.AddScoped<IPatient, PatientRepository>();
            services.AddScoped<IType_Lit, Type_LitRepository>();

            services.AddSwaggerDocument();


            //    services.AddSwaggerGen(s =>
            //    {
            //        s.SwaggerDoc("v1", new Info
            //        {
            //            Title = "NHL Api",
            //            Version = "v1",
            //            Description = "Application de gestion d'un hopital",
            //            TermsOfService = "none",
            //            Contact = new Contact
            //            {
            //                Name = "Tchoupo Guy",
            //                Email = string.Empty,
            //                Url = string.Empty
            //            },
            //            License = new License
            //            {
            //                Name = "Use under LICX",
            //                Url = string.Empty
            //            }
            //        });
            //        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            //        var xmlpath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            //        s.IncludeXmlComments(xmlpath);
            //    });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            //});

            // app.UseSwaggerUI(typeof(Startup).GetTypeInfo().Assembly);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseSwagger();
            app.UseSwaggerUi3();

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
