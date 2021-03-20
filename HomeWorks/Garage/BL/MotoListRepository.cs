using Garage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage.BL
{
    public class MotoListRepository : IMotoRepository
    {
        private static List<Moto> _motos = new List<Moto>();

        public void CreateMotorcycle(Moto moto)
        {
            if (moto != null)
            {
                _motos.Add(moto);
            }
        }

        public void DeleteMotorcycle()
        {
            _motos.Remove(_motos.Last());
        }

        public List<Moto> GetMotorcycles()
        {
            return _motos;
        }

        public void UpdateMotorcycle(Moto moto)
        {
            
        }
    }
}
