using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySysDAO
{
    public class AlternativaDAO :ICrud<Alternativa>
    {
        public void Insert(Alternativa pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {

                    ctx.AlternativaSet.Add(pEntity);
                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(Alternativa pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    ctx.AlternativaSet.Remove(pEntity);
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Alternativa pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    ctx.AlternativaSet.Attach(pEntity);
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Alternativa get(int id)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    Alternativa alternativa = ctx.AlternativaSet.Where(alt => alt.id == id).FirstOrDefault();
                    return alternativa;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Alternativa> getAlternativas(int perguntaId)
        {
            try
            {
                using(surveySysEntities ctx= new surveySysEntities())
                {
                   return ctx.AlternativaSet.Where(alt => alt.pergunta_id == perguntaId).ToList();
                }

            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }
    }
}
