using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ListManager : IListService
    {
        IListDal _listDal;
        public ListManager(IListDal listDal)
        {
            _listDal = listDal;
        }

        public void ListAdd(List list)
        {
            _listDal.Insert(list); 
        }

        public void ListDelete(List list)
        {
            _listDal.Delete(list);
        }

        public void ListUpdate(List list)
        {
            _listDal.Update(list);
        }
        
        public List GetById(int id)
        {
            return _listDal.GetById(id);
        }

        public List<List> GetListAll()
        {
            return _listDal.GetListAll();
        }

    }
}
