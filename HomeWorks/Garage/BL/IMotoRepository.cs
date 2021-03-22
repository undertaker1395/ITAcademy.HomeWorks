using Garage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garage.BL
{
    interface IMotoRepository
    {
        #region CRUD
        List<Moto> GetMotorcycles();

        void CreateMotorcycle(Moto moto);
        void DeleteMotorcycle(Moto moto);
        void UpdateMotorcycle(Moto moto);

        #endregion
    }
}
