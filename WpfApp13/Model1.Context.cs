﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp13
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PolzovateliEntities : DbContext
    {
        private static PolzovateliEntities _context;
        public PolzovateliEntities()
            : base("name=PolzovateliEntities")
        {
        }
        public static PolzovateliEntities GetContext() // 	Получение контекста из базы данных 
        {
            if (_context == null)
                _context = new PolzovateliEntities();

            return _context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Polzovateli> Polzovateli { get; set; }
    }
}