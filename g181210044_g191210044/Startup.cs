//using g181210044_g191210044.Data;
//using Microsoft.EntityFrameworkCore;

//namespace g181210044_g191210044
//{
//    public class Startup
//    {
//        public void ConfigurationServices(IServiceCollection services)
//        {
//            services.AddDbContext<SporContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

//        }
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddDbContext<SporContext>();
//        }

//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public IConfiguration Configuration { get; }

//        // This method gets called by the runtime. Use this method to add services to the container.
//        //public void ConfigureServices(IServiceCollection services)
//        //{
//        //    services.AddControllersWithViews();
//        //}

//        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }
//            else
//            {
//                app.UseExceptionHandler("/Home/Error");
//                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//                app.UseHsts();
//            }
//            app.UseHttpsRedirection();
//            app.UseStaticFiles();

//            app.UseRouting();

//            app.UseAuthorization();

//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapControllerRoute(
//                    name: "default",
//                    pattern: "{controller=Home}/{action=Index}/{id?}");
//            });
//        }
//    }
//}
