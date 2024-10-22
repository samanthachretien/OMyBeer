using API.Data;

namespace API.Services
{
    public class BeerService
    {
        public bool AjouterBeer(TBeer beer)
        {
            try
            {
                using (var context = new OmyBeerContext())
                {
                    context.TBeers.Add(beer);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public TBeer Search(int id)
        {
            using (var ctx = new OmyBeerContext())
            {
                 return ctx.TBeers.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
