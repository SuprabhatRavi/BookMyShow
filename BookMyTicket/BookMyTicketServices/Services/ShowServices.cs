using AutoMapper;
using BookMyTicketServices.Modals;

namespace BookMyTicketServices.Services
{
    public class ShowServices : IShowServices
    {
        private PetaPoco.Database db;
        private IMapper Mapper;

        public ShowServices(IMapper mapper, PetaPoco.Database dbo)
        {
            Mapper = mapper;
            db = dbo;
        }
        public IEnumerable<ShowDTO> GetShowList()
        {
            var ShowList = db.Query<Show>("Select * from Show");
            return Mapper.Map<IEnumerable<ShowDTO>>(ShowList);
        }

        public ShowDTO GetShowById(int id)
        {
            var ShowDetails = db.Single<Movie>($"Select * from Show where ShowId = {id}");
            return Mapper.Map<ShowDTO>(ShowDetails);
        }

        public ShowDTO AddShow(ShowDTO show)
        {
            db.Insert("Show", "ShowId", true, show);
            return show;
        }

        public ShowDTO UpdateShowDetails(int id, ShowDTO show)
        {
            if (id == show.ShowId)
            {
                db.Update("Show", "ShowId", show);
            }
            return show;
        }

        public void DeleteShow(int id)
        {
            var ShowDetails = db.Single<Movie>($"Select * from Show where ShowId = {id}");
            db.Delete("Show", "ShowId", ShowDetails);
        }
    }
}
