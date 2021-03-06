using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>//ben buradaki girilecek parametreyi sınırlamak isterim. Yazılımcı yanlışlıkla int yazmasın.
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    //    List<T> GetAllByCategory(int categoryId); yukarıdaki expression yapısından dolayı artık bu koda ihtiyacım yok.
    //    Linq yazabilmemi sağlayan yapıdır. örneğin e-ticarette filtre yapabilmemi sağlıyor.
    }
}
