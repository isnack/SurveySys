using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySysDAO
{
   public interface ICrud<T>
    {
          void Insert(T pEntity);
   
          void Delete(T pEntity);
   
          void Update(T pEntity);       
   
          T get(int id);



    }
}
