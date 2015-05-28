using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySysDAO
{
    public class RespostaDAO :ICrud<Resposta>
    {
        public void Insert(Resposta pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {

                    ctx.RespostaSet.Add(pEntity);
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        public void Delete(Resposta pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    ctx.RespostaSet.Remove(pEntity);
                    ctx.SaveChanges();

                }

            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        public void Update(Resposta pEntity)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    ctx.RespostaSet.Attach(pEntity);
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {
                
                throw;
            }
          
        }

        public Resposta get(int id)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    Resposta resposta = ctx.RespostaSet.Where(rs => rs.id == id).FirstOrDefault();
                    return resposta;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        public Resposta getRespostaClienteAlternativa(int clienteId, int alternativaId)
        {
            try
            {
                using (surveySysEntities ctx = new surveySysEntities())
                {
                    Resposta resposta = ctx.RespostaSet.Where(rs => rs.cliente_id == clienteId && rs.alternativa_id == alternativaId).FirstOrDefault();
                    return resposta;

                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
