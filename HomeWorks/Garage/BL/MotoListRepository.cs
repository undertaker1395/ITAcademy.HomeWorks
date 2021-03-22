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

        public void DeleteMotorcycle(Moto moto)
        {
            _motos.Remove(moto);
        }

        public List<Moto> GetMotorcycles()
        {
            return _motos;
        }

        public void UpdateMotorcycle(Moto moto)
        {
            _motos.Remove(moto);
            if (moto != null)
            {
                _motos.Add(moto);
            }
        }
    }
}
