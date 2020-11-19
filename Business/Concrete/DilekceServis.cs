using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Database.Operations;
using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
namespace Business.Concrete
{
    public class DilekceServis : IOrtakIslemler<Dilekce>
    {
        DilekceDal dilekceDal;
        int ReturnValueInt = 0;
        public DilekceServis()
        {
            dilekceDal = new DilekceDal();
        }
        private void Validation(Dilekce Entity)
        {
            DilekceValidator validationRules = new DilekceValidator();
            var result = validationRules.Validate(Entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
        public int Add(Dilekce Entity)
        {
            Validation(Entity);
            ReturnValueInt = dilekceDal.Add(Entity);
            return ReturnValueInt;
        }
        public int Update(Dilekce Entity)
        {
            Validation(Entity);
            ReturnValueInt = dilekceDal.Update(Entity);
            return ReturnValueInt;
        }
        public List<Dilekce> GetAll()
        {
            return dilekceDal.GetAll().ToList();
        }
        public List<Dilekce> GetAllByCiftciId(Guid ciftciID)
        {
            List<Dilekce> gelenListe = GetAll();
            var updatedliste = from I in gelenListe
                               where I.CiftciId == ciftciID
                               orderby Convert.ToInt32(I.UretimYili) descending
                               select I;
            return updatedliste.ToList();
        }
        public Dilekce Get(Expression<Func<Dilekce, bool>> delegeparameter)
        {
            //bir tane kayıt dönderecek.
            return dilekceDal.Get(delegeparameter);
        }
        public List<Liste> DilekceGetirByUretimYili(string uretimYili)
        {
            return dilekceDal.DilekceGetirByUretimYili(uretimYili);
        }
        public int Delete(Dilekce Entity)
        {
            Validation(Entity);
            return dilekceDal.Delete(I => I.DilekceId == Entity.DilekceId);
        }
    }
}
