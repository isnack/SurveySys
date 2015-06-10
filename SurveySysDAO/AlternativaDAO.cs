using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySysDAO
{
    public class AlternativaDAO :ICrud<Alternativa>
    {
        private surveySysEntities ctx;
        public AlternativaDAO(surveySysEntities ctx)
        {
            this.ctx = ctx;
        }

        public void Insert(Alternativa pEntity)
        {
            try
            {
                
                    ctx.Configuration.ValidateOnSaveEnabled = false;
                    ctx.AlternativaSet.Add(pEntity);
                    

                
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
                
                    ctx.AlternativaSet.Remove(pEntity);
                    

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
                
                    ctx.AlternativaSet.Attach(pEntity);
                    

                
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
                
                    Alternativa alternativa = ctx.AlternativaSet.Where(alt => alt.id == id).FirstOrDefault();
                    return alternativa;
                
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
                
                   return ctx.AlternativaSet.Where(alt => alt.pergunta_id == perguntaId).ToList();
                

            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }
    }
}
