using HW11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW11.BL
{
    public class MotorcycleListRepository : IMotorcycleRepository
    {
        private static List<Moto> _motos = new List<Moto>();

       

        public void CreateMotorcycle(Moto moto)
        {
            if (moto != null)
            {
                _motos.Add(moto);
            }
        }

       

        public void DeleteMotorcycle(Moto moto)
        {
            
            _motos.Remove(moto);
            
        }

        public List<Moto> Get()
        {
            return _motos;
        }

        public List<Moto> GetMotorcycleByID()
        {
            throw new NotImplementedException();
        }

        public List<Moto> GetMotorcycles()
        {
            throw new NotImplementedException();
        }

        public void UpdateMotorcycle(Moto moto)
        {
            throw new NotImplementedException();
        }
    }
}
