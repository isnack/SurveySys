using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySysDAO
{
    public class QuestionarioDAO :ICrud<Questionario>
    {
        private surveySysEntities ctx;
        public QuestionarioDAO(surveySysEntities ctx)
        {
            this.ctx = ctx;
        }
        public void Insert(Questionario pEntity)
        {
            try
            {
                

                    ctx.QuestionarioSet.Add(pEntity);
                    

                
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
                
                    ctx.QuestionarioSet.Remove(pEntity);
                   

               
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
                
                    ctx.QuestionarioSet.Attach(pEntity);
                    

                
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
               
                    Questionario questionario = ctx.QuestionarioSet.Where(qt => qt.id == id).FirstOrDefault();
                    return questionario;
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Questionario> getQuestionarioNaoRespondidos(int clienteId)
        {
           try {
                                
              // var questionariosNaoRespondidos = (from q in ctx.QuestionarioSet where
                                               //  !(from r in ctx.RespostaSet where r.cliente_id==clienteId select r).ToList().Contains(q.id) select q);
               List<Questionario> questionarios = (from q in ctx.QuestionarioSet
                                                  where !(from r in ctx.RespostaSet
                                                          where r.cliente_id == clienteId
                                                          select r.questionario_id)
                                                            .Contains(q.id)
                                                  select q).ToList();


               
                return questionarios;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
