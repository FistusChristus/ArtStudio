using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtStudio.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ArtStudio
{

    public class ApplicationDBContext : IdentityDbContext<ApplicationUser,ApplicationRole, string>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
       
        }
        //with CRUD
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Package> Packages { get; set; }


        //without CRUD
        public DbSet<PaymentInfo> PaymentInfos { get; set; }
        public DbSet<UserCartContent> UserCartContents { get; set; }
        public DbSet<ResourceFile> ResourceFiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Package>().HasData(
                new Package[]
                {
                new Package { Id=Guid.NewGuid(), CountOfDownlaods=10, Enabled=true, Order=1, DisplayAlias="Начальный", Description="Пакет с минимальными возможностями", Price=3},
                new Package { Id=Guid.NewGuid(), CountOfDownlaods=25, Enabled=true, Order=2, DisplayAlias="Продвинутый", Description="Средний пакет", Price=6},
                new Package { Id=Guid.NewGuid(), CountOfDownlaods=35, Enabled=true, Order=3, DisplayAlias="Профи", Description="Пакет с максимальными возможностями", Price=8}
                });
            modelBuilder.Entity<Category>().HasData(
                new Category[]
                {
                new Category { Id=Guid.NewGuid(), Enabled=true, Description="Цвет — все, но черно-белый — еще больше", DisplayAlias="Черно-белая"},
                new Category { Id=Guid.NewGuid(), Enabled=true, Description="Вы наполняете кадр чувствами, энергией, жаждой открытий и риском и оставляете достаточно места, чтобы туда мог попасть кто-нибудь еще", DisplayAlias="Рекламная"},
                new Category { Id=Guid.NewGuid(), Enabled=true, Description="Еще одна невероятная революция произошла в фотографии, но и на нее оказало влияние Концептуальное Искусство", DisplayAlias="Концептуальная"},
                new Category { Id=Guid.NewGuid(), Enabled=true, Description="Мою жизнь формирует неудержимая потребность странствовать и наблюдать, а мой фотоаппарат — это паспорт", DisplayAlias="Туристическая"},
                new Category { Id=Guid.NewGuid(), Enabled=true, Description="Пейзажная фотография переступает все политические и национальные границы, выходит за рамки языковых и культурных ограничений", DisplayAlias="Пейзажная"},
                new Category { Id=Guid.NewGuid(), Enabled=true, Description="Фотография — это кнопка паузы, на которую поставлена жизнь", DisplayAlias="Свадебная"},
                new Category { Id=Guid.NewGuid(), Enabled=true, Description="Фотография уловила факт из жизни, и этот факт будет жить вечно", DisplayAlias="Уличная"},
                new Category { Id=Guid.NewGuid(), Enabled=true, Description="Фотография - обьяснение вещам", DisplayAlias="Спортивная"},
                new Category { Id=Guid.NewGuid(), Enabled=true, Description="Одно дело — сфотографировать, как человек выглядит, и совсем другое, отобразить, что он из себя представляет", DisplayAlias="Портретная"},
                new Category { Id=Guid.NewGuid(), Enabled=true, Description="Не каждый верит картинам, но фотографиям верят все", DisplayAlias="HDR"},
                new Category { Id=Guid.NewGuid(), Enabled=true, Description="Важнее вызвать отклик у людей, чем нажать на кнопку затвора", DisplayAlias="Фэшн-фотография"},
                new Category { Id=Guid.NewGuid(), Enabled=true, Description="Фотография — это искусство созерцания. Ее суть в том, чтобы найти что-то интересное в обычном месте", DisplayAlias="Предметная"},
                new Category { Id=Guid.NewGuid(), Enabled=true, Description="Существуют вещи, которые никто никогда никто не увидел , если бы их не сфотографировали", DisplayAlias="Аэрофотография"},
                });
        }
    }
}
