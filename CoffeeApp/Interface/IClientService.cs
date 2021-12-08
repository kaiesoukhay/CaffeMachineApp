using DataAcess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
   public interface IClientService
    {
        public Clients AddClient(Clients c); 
        public Clients GetClintById(int Id); 

    }
}
