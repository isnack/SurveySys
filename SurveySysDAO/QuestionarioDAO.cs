using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySysDAO
{
    public class QuestionarioDAO
    {
        public void Insert(Questionario pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {

                    ctx.QuestionarioSet.Add(pEntity);
                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(Questionario pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    ctx.QuestionarioSet.Remove(pEntity);
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Questionario pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    ctx.QuestionarioSet.Attach(pEntity);
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Questionario get(int id)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    Questionario questionario = ctx.QuestionarioSet.Where(qt => qt.id == id).FirstOrDefault();
                    return questionario;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
