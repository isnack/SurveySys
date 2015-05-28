using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySysDAO
{
   public class PerguntaDAO :ICrud<Pergunta>
    {
        public void Insert(Pergunta pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {

                    ctx.PerguntaSet.Add(pEntity);
                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(Pergunta pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    ctx.PerguntaSet.Remove(pEntity);
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Pergunta pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    ctx.PerguntaSet.Attach(pEntity);
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Pergunta get(int id)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    Pergunta pergunta = ctx.PerguntaSet.Where(pg => pg.id == id).FirstOrDefault();
                    return pergunta;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
