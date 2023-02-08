using proiectDaw.Data.UitOfWork;
using proiectDaw.Helper.JwUtils;
using proiectDaw.Repositories.BookRepository;
using proiectDaw.Repositories.ReviewRepository;
using proiectDaw.Repositories.SubscriptionRepository;
using proiectDaw.Repositories.UserBookRelationRepository;
using proiectDaw.Repositories.UserRepository;
using proiectDaw.Services.BookService;
using proiectDaw.Services.ReviewService;
using proiectDaw.Services.UserService;

namespace proiectDaw.Helper.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserBookRelationRepository, UserBookRelationRepository>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IReviewRepository, ReviewRepository>();
            services.AddTransient<ISubscriptionRepository, SubscriptionRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IBookService, BookService>();
            services.AddTransient<IReviewService, ReviewService>();

            return services;
        }

        public static IServiceCollection AddJwtUtils(this IServiceCollection services)
        {
            services.AddScoped<IJwtUtils, JwtUtils>();

            return services;
        }

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }

    }
}
