using proiectDaw.Repositories.BookRepository;
using proiectDaw.Repositories.ReviewRepository;
using proiectDaw.Repositories.SubscriptionRepository;
using proiectDaw.Repositories.UserBookRelationRepository;
using proiectDaw.Repositories.UserRepository;

namespace proiectDaw.Data.UitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBookRepository BookRepository { get; set; }
        public IReviewRepository ReviewRepository { get; set; }
        public IUserBookRelationRepository UserBookRelationRepository { get; set; }
        public ISubscriptionRepository SubscriptionRepository { get; set; }
        public IUserRepository UserRepository { get; set; }

        private Context _context { get; set; }

        public UnitOfWork(IBookRepository bookRepository, IReviewRepository reviewRepository, IUserBookRelationRepository userBookRelationRepository, ISubscriptionRepository subscriptionRepository, IUserRepository userRepository, Context context)
        {
            BookRepository = bookRepository;
            ReviewRepository = reviewRepository;
            UserBookRelationRepository = userBookRelationRepository;
            SubscriptionRepository = subscriptionRepository;
            UserRepository = userRepository;

            _context = context;
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() != 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
