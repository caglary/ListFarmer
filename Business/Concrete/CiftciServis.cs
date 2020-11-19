using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Database.Operations;
using Entity.Concrete;
using FluentValidation;
using Newtonsoft.Json;
using StaticClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
namespace Business.Concrete
{
    public class CiftciServis : IOrtakIslemler<Ciftci>
    {
        CiftciDal ciftciDal;
        int ReturnValue;
        public CiftciServis()
        {
            ciftciDal = new CiftciDal();
        }
        public int Add(Ciftci Entity)
        {
            Validation(Entity);
            bool Kontrol = TCKontrol(Entity.Tc);
            if (!Kontrol)//kayıt yoksa
                return ciftciDal.Add(Entity);
            else
                throw new Exception("Aynı Tc No ile kayıt mevcuttur.");
        }
        private bool TCKontrol(string TCKimlikNo)
        {
            bool ReturnBool = false;
            var result = ciftciDal.GetAll().Where(I => I.Tc == TCKimlikNo).SingleOrDefault();
            if (result != null)
                ReturnBool = true;
            return ReturnBool;
        }
        public int Delete(Ciftci Entity)
        {
            ReturnValue = 0;
            var _ciftci = ciftciDal.Get(I => I.Id == Entity.Id);
            if (_ciftci != null)
            {
                ReturnValue = ciftciDal.Delete(I => I.Id == Entity.Id);
            }
            return ReturnValue;
        }
        public int Update(Ciftci Entity)
        {
            return ciftciDal.Update(Entity);
        }
        private void Validation(Ciftci Entity)
        {
            CiftciValidator validationRules = new CiftciValidator();
            var result = validationRules.Validate(Entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
        public List<Ciftci> GetAll()
        {
            return ciftciDal.GetAll().OrderByDescending(I => I.KayitTarih).ToList();
        }
        public Ciftci Get(Expression<Func<Ciftci, bool>> predicate)
        {
            return ciftciDal.Get(predicate);
        }
        public void BackupJson()
        {
            var liste = GetAll();
            FolderBrowserDialog _folder = new FolderBrowserDialog();
            DialogResult result = _folder.ShowDialog();
            if (result == DialogResult.OK)
            {
                string _folderPath = _folder.SelectedPath;
                string jsonObject = JsonOperation.JsonSerialize(liste);
                string SavePath = _folderPath + "\\" + "Ciftciler" + ".json";
                File.WriteAllText(SavePath, jsonObject);
                MessageBoxOperation.MessageBoxInformation($"{_folderPath} adresine backup işlemi yapıldı.");
            }
        }
    }
}
