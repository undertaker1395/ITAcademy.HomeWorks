using HW11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW11.BL
{
    interface IMotorcycleRepository
    {
        #region CRUD

        List<Moto> GetMotorcycles();

        List<Moto> GetMotorcycleByID();
        void CreateMotorcycle(Moto moto);
        void UpdateMotorcycle(Moto moto);
        void DeleteMotorcycle(Moto moto);
        #endregion
    }
}
