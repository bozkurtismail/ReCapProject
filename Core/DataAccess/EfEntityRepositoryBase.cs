using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity>
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            // IDısposable pattern implemantation of c#
            //using bittiği anda carbage collectore buraları topla belleği temizle
            using (TContext context = new TContext())
            {
                //alanları aynı bir car gönderilse bile listeden silmeye çalışsan bile silemezsin çünkü referansına ulaşman gerekir.
                var addedEntity = context.Entry(entity);// git veri kaynağından metoda gönderilen entity TEntity dan bir tane nesneye eşleştir.
                addedEntity.State = EntityState.Added; //gelen referans aslında eklenecek bir nesne
                context.SaveChanges();//ve şimdi ekle .bütün işlemleri gerçekleştirir.
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context=new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
