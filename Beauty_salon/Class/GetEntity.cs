using Beauty_salon.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beauty_salon.Entity;

namespace Beauty_salon.Class
{
    internal class GetEntity: IGetEntity
    {
        private GetEntity(){}

        private static GetEntity instance;

        private BeautySalonEntities _db;

        public static GetEntity GetInstance()
        {
            if (instance == null)
            {
                instance = new GetEntity();
            }
            return instance;
        }

        public  BeautySalonEntities GetDB()
        {
            if (_db == null)
            {
                _db = new BeautySalonEntities();
            }
            return _db;
        }
    }
}
