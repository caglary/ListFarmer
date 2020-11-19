using System.Collections.Generic;
namespace Business.Abstract
{
    public interface IOrtakIslemler<T>
    {
        int Add(T Entity);
        int Update(T Entity);
        int Delete(T Entity);
        List<T> GetAll();
     
    }
}
