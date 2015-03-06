using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAccount.DataAccessLayer.Secuirty
{
    public class UserGroupCommand :DataBase
    {
        /// <summary>
        /// هذه الدالة لحفظ السجل في جدول مجموعات المستخدمين
        /// </summary>
        /// <param name="UG">متغير من النوع مجموعات المستخدمين</param>
        /// <returns></returns>
        public static bool Save(UserGroup UG)
        {
            bool st = false;

            db.UserGroups.InsertOnSubmit(UG);
            db.SubmitChanges();
            st = true;


            return st;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="o"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static bool Edit(UserGroup o, Guid ID)
        {
            bool st = false;
            var q = db.UserGroups.Where(p => p.ID == ID).SingleOrDefault();
            q.GroupName = o.GroupName;
            q.GroupDescription = o.GroupDescription;
            db.SubmitChanges();
            st = true;
            return st;
        }

        public static bool Delete(Guid o)
        {
            bool st = false;
            var q = db.UserGroups.Where(p => p.ID == o).SingleOrDefault();
            db.UserGroups.DeleteOnSubmit(q);
            db.SubmitChanges();
            return st;
        }

        public static List<UserGroup> GetAll()
        {
            return db.UserGroups.ToList();
        }
    }
}
