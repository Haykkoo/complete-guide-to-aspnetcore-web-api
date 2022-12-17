using my_books.Data.ViewModels;

namespace my_books.Data.Services
{
    public class PublishersService
    {
        private readonly AppDbContext _context;

        public PublishersService(AppDbContext context)
        {
            _context = context;
        }
        public void AddPublisher(PublishersVM publishersVM)
        {
            var publisher = new Publisher()
            {
                Name = publishersVM.Name

            };
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
        }

        public void DeletePublisherById(int id)
        {
            var _publisher = _context.Publishers.FirstOrDefault(x=>x.Id==id);
            if (_publisher != null)
            {
                _context.Publishers.Remove(_publisher);
                _context.SaveChanges();
            }            
        }
    }
}
