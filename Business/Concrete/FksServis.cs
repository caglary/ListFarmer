using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Business.Concrete
{
    public class FksServis
    {
        Database.Operations.Fks2018Dal _fks2018Dal;
        Database.Operations.Fks2019Dal _fks2019Dal;
        Database.Operations.Fks2017Dal _fks2017Dal;
      
        public FksServis()
        {
            _fks2018Dal = new Database.Operations.Fks2018Dal();
            _fks2019Dal = new Database.Operations.Fks2019Dal();
            _fks2017Dal = new Database.Operations.Fks2017Dal();
     
        }
        public Fks CiftciFksGetir(string listeYili, string tc)
        {
            if (listeYili == "2019") return _fks2019Dal.Get(I => I.isletmeNo == tc);
            else if (listeYili == "2018") return _fks2018Dal.Get(I => I.isletmeNo == tc);
            else if (listeYili == "2017") return _fks2017Dal.Get(I=>I.isletmeNo==tc);
            else return null;
        }
    }
  
}
