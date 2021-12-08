using DataAcess.Models;
using DataAcess.Interface;
using DataAcess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Interface
{
    public interface IClientRepository 
    {
        public Clients GetClietById(int id);
       public Clients CreateClient(Clients entity);

    }
   

}
