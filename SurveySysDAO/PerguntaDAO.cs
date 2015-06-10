using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySysDAO
{
   public class PerguntaDAO :ICrud<Pergunta>
    {
       private surveySysEntities ctx;
       public PerguntaDAO(surveySysEntities ctx)
       {
           this.ctx = ctx;

       }
        public void Insert(Pergunta pEntity)
        {
            try
            {


                this.ctx.PerguntaSet.Add(pEntity);
                    

                
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
               
                   this.ctx.PerguntaSet.Remove(pEntity);
                   

               
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
                
                    this.ctx.PerguntaSet.Attach(pEntity);
                   

                
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
               
                    Pergunta pergunta = ctx.PerguntaSet.Where(pg => pg.id == id).FirstOrDefault();
                    return pergunta;
                
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<Pergunta> Lista(int id)
        {
            try
            {
                
                    List<Pergunta> pergunta = ctx.PerguntaSet.Include("AlternativaSet").ToList();
                    return pergunta;
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Pergunta> perguntaQuestionario(int questionarioId)
        {
            try
            {
                return null;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
