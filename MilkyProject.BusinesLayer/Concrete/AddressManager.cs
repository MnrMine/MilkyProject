using MilkyProject.BusinesLayer.Abstract;
using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinesLayer.Concrete
{
    public class AddressManager : IAddressService
    {

        private readonly IAdressDal _adressDal;

        public AddressManager(IAdressDal adressDal)
        {
            _adressDal = adressDal;
        }

        public void TDelete(int id)
        {
            _adressDal.Delete(id);
        }

        public Address TGetById(int id)
        {
            return _adressDal.GetById(id);
        }

        public List<Address> TGetListAll()
        {
            return _adressDal.GetListAll();
        }

        public void TInsert(Address entity)
        {
            _adressDal.Insert(entity);
        }

        public void TUpdate(Address entity)
        {
            _adressDal.Update(entity);
        }
    }
}
