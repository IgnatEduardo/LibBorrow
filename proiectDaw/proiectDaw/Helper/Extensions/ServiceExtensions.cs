using proiectDaw.Repositories.BookRepository;
using proiectDaw.Repositories.ReviewRepository;
using proiectDaw.Services.BookService;
using proiectDaw.Services.ReviewService;

namespace proiectDaw.Helper.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IReviewRepository, ReviewRepository>();
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IBookService, BookService>();
            services.AddTransient<IReviewService, ReviewService>();
            

            return services;
        }




    }
}
