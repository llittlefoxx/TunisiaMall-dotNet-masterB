using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TunisiaMall.Service;


namespace TunisiaMall.Service.Pattern
{
    public interface IService<T> where T: class
    {
        void Create(T e);
        void Update(T e);
        void Delete(T e);
        T FindById(long id);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null, Expression<Func<T, bool>> orderBy = null);
        // L'expression lamda est de type "Expression<Func<T, bool>>" comme par exemple 5 est de type int
        //une expression lamda peut retourner soit true or false d'ou le type bool 
        //"x=>x.nom" remplacera Func<T,bool>  
        // si on met les 2 parametres null ça devient la methode findAll() ==> donc on enleve la methode findAll

        void Delete(Expression<Func<T, bool>> condition);
        void Commit();
        void Dispose();
    }
}
