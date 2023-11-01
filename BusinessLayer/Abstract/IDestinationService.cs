using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
    {
        //void TAdd(global::DocumentFormat.OpenXml.Wordprocessing.Destination destination);

        //Bunu sonrandan düzelttim.. _destinationService.Tadd olmadı ben de buraya gelip işlem yaptım.
        public Destination TGetDestinationWithGuide(int id);
        public List<Destination> TGetLast4Destinations();
    }
}
