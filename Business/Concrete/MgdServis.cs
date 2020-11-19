using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Business.Concrete
{
    public class MgdServis
    {
        Database.Operations.Mgd2018Dal _mgd2018Dal;
        Database.Operations.Mgd2019Dal _mgd2019Dal;
        Database.Operations.Mgd2017Dal _mgd2017Dal;
        public MgdServis()
        {
            _mgd2018Dal = new Database.Operations.Mgd2018Dal();
            _mgd2019Dal = new Database.Operations.Mgd2019Dal();
            _mgd2017Dal = new Database.Operations.Mgd2017Dal();
        }
        public Entity.Concrete.Mgd CiftciMgdGetir(string listeYili, string tc)
        {
            if (listeYili == "2019") return _mgd2019Dal.Get(I=>I.tc==tc);
            else if (listeYili == "2018") return _mgd2018Dal.Get(I => I.tc == tc);
            else if (listeYili == "2017") return _mgd2017Dal.Get(I => I.tc == tc);
            else return null;
        }
    }
}
