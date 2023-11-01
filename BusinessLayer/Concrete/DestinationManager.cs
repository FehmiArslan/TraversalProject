﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class DestinationManager: IDestinationService
    {
        IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TAdd(Destination t)
        {
            _destinationDal.Insert(t);
        }

        public void TDelete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public Destination TGetByID(int id)
        {
             return _destinationDal.GetByID(id);
        }

        public Destination TGetDestinationWithGuide(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Destination> TGetLast4Destinations()
        {
            throw new System.NotImplementedException();
        }

        public List<Destination> TGetList()
        {
          return  _destinationDal.GetList();
        }

        public void TUpdate(Destination t)
        {
            _destinationDal.Update(t);
        }
    }
}
