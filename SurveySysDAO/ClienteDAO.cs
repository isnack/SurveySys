using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySysDAO
{
    public class ClienteDAO : ICrud<Cliente>
    {




        public void Insert(Cliente pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {

                    ctx.ClienteSet.Add(pEntity);
                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
           
        }

        public void Delete(Cliente pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    ctx.ClienteSet.Remove(pEntity);
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Update(Cliente pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    ctx.ClienteSet.Attach(pEntity);
                    ctx.SaveChanges();

                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }
                

        public Cliente get(int id)
        {
            
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                   Cliente  cliente = ctx.ClienteSet.Where(cl => cl.id == id).FirstOrDefault();
                     return cliente;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}
