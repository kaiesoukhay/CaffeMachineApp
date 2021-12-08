using DataAcess.Models;
using DataAcess.Interface;
using System.Linq;
using System.Threading.Tasks;

namespace DataAcess.Repositories
{
    public class ClientRepository : IClientRepository

    {
        private readonly MachineAppContext _dbContext;

        public ClientRepository(MachineAppContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Clients CreateClient(Clients entity)
        {
            try
            {
                var x = _dbContext.Clients.Add(entity);
                _dbContext.SaveChanges();
                return x.Entity;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }

        }


        public Clients GetClietById(int id)
        {
            var c = _dbContext.Clients.Where(p => p.Id == id).FirstOrDefault();
            return c;
        }



    }
}
