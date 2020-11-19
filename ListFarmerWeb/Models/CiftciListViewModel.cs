using Entity.Concrete;
using System.Collections.Generic;
namespace ListFarmerWeb.Models
{
    public class CiftciListViewModel
    {
        public CiftciListViewModel()
        {
        }
        public List<Ciftci> Ciftciler { get; set; }
        public List<Entity.Concrete.Mgd> MgdTutar  { get; set; }
    }
}