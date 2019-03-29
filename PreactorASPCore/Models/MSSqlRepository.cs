using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PreactorASPCore.Models.PreactorData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreactorASPCore.Models
{
    public class MSSqlRepository
    {
        /// <summary>
        /// Метод выбора коллекции сущностей по указнному условию предиката
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate"></param>
        /// <returns></returns>
        internal static List<T> GetEntities<T>(Func<T, bool> predicate) where T : class
        {
            using (var context = new PreactorSDBContext())
            {
                var query = context.Set<T>();
                switch (typeof(T).Name)
                {
                    default: return context.Set<T>().Where(predicate).ToList();
                }

            }
        }
        /// <summary>
        /// Метод выбора коллекции сущностей
        /// </summary>
        /// <typeparam name="T">Тип сущности</typeparam>
        /// <returns></returns>
        public List<T> GetEntities<T>() where T : class
        {
            using (var context = new PreactorSDBContext())
            {
                var query = context.Set<T>();
                switch (typeof(T).Name)
                {
                    default: return context.Set<T>().ToList();
                }
            }
        }

        /// <summary>
        /// Метод добавления сущности в БД
        /// </summary>
        /// <typeparam name="T">Тип сущности</typeparam>
        /// <param name="entity">Объект сущности</param>
        public static EntityEntry<T> AddEntity<T>(T entity) where T : class
        {
            using (var context = new PreactorSDBContext())
            {
                var adedEntity = context.Set<T>().Add(entity);
                context.SaveChanges();

                return adedEntity;
            }
        }

        /// <summary>
        /// Удалить сущность
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool DeleteEntity<T>(T item) where T : class
        {
            using (var context = new PreactorSDBContext())
            {
                try
                {
                    context.Set<T>().Remove(item);
                    context.SaveChanges();
                    
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Обновление сущности
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static bool UpdateEntity<T>(T entity) where T : class
        {
            using (var context = new PreactorSDBContext())
            {
                context.Set<T>().Add(entity);

                var entry = context.Entry(entity);
                entry.State = EntityState.Modified;
                return context.SaveChanges() > 0;
            }
        }
    }
}
