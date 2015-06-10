using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveySysDAO
{
    public class ClienteDAO : ICrud<Cliente>
    {
        private surveySysEntities ctx;

        public ClienteDAO(surveySysEntities ctx)
        {
            this.ctx = ctx;
        }

        public void Insert(Cliente pEntity)
        {
            try
            {


                this.ctx.ClienteSet.Add(pEntity);
                   

                
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

                this.ctx.ClienteSet.Remove(pEntity);
                    

                
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

                this.ctx.ClienteSet.Attach(pEntity);
                    

               

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
               
                   Cliente  cliente = ctx.ClienteSet.Where(cl => cl.id == id).FirstOrDefault();
                     return cliente;
               
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public Cliente getByEmail(string email)
        {

            try
            {
               
                    Cliente cliente = ctx.ClienteSet.Where(cl => cl.email == email).FirstOrDefault();
                    return cliente;

                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public Cliente login(string login, string senha)
        {
            try
            {
               return ctx.ClienteSet.Where(cl => cl.usuario == login && cl.senha == senha).FirstOrDefault();

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

    }
}
