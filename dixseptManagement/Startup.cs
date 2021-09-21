using DixseptData;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using dixseptManagement.Service;

namespace dixseptManagement
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
            services.AddControllers();

            //services.AddSpaStaticFiles(options => options.RootPath = "clientapp/dist");

            // DB接続
            services.AddDbContext<DixseptContext>(options => options.
            UseSqlServer(Configuration.GetConnectionString("develop")));

            services.AddTransient<IUnitOfWork>(provider =>
            {
                return new UnitOfWork<DixseptContext>(provider.GetService<DixseptContext>());
            });

            // DIサービスコンテナに登録
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<IAwsService, AwsService>();

            // cors設定
            services.AddCors(options => {
                options.AddDefaultPolicy(
                    builder => builder.WithOrigins("http://localhost:8080").AllowAnyMethod().AllowAnyHeader());

                // contorollerごとに個別に設定も可能
                //options.AddPolicy("CorsPolicyName",
                //    builder => builder
                //       .AllowAnyMethod()
                //       .AllowAnyHeader()
                //       .WithOrigins(new string[] { "http://localhost:8080" })
                //   );
            });

            // 検証設定
            // エラーメッセージ日本語化
            //services.AddMvc(o =>
            //{
            //    o.ModelMetadataDetailsProviders.Add(new CustomValidationMetadataProvider(typeof(Resources)));
            //});
            //// カスタム検証属性のクライアント側検証
            //services.AddSingleton<IValidationAttributeAdapterProvider, CustomValidationAttributeAdapterProvider>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            // CORS設定
            app.UseCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
