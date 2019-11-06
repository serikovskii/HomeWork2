namespace WebApplication3.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebApplication3.Models;

    public class ReserveContext : DbContext
    {
        // Контекст настроен для использования строки подключения "ReserveContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WebApplication3.DataAccess.ReserveContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ReserveContext" 
        // в файле конфигурации приложения.
        public ReserveContext()
            : base("name=ReserveContext")
        {
        }

        public DbSet<Reserve> Reserves { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}