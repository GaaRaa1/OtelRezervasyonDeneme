namespace OtelRezervasyon_DadasTurizm.Migrations
{
    using OtelRezervasyon_DadasTurizm.DadasDB.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OtelRezervasyon_DadasTurizm.DadasDB.DadasDBEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OtelRezervasyon_DadasTurizm.DadasDB.DadasDBEntities";
        }

        protected override void Seed(OtelRezervasyon_DadasTurizm.DadasDB.DadasDBEntities context)
        {
            context.Users.AddOrUpdate(x => x.UserID, new User() { UserName = "fatih", UserPassword = "fatih123" });
            context.Users.AddOrUpdate(x => x.UserID, new User() { UserName = "hilal", UserPassword = "hilal123" });
            context.Users.AddOrUpdate(x => x.UserID, new User() { UserName = "ömer", UserPassword = "ömer123" });

            context.RoomDetails.AddOrUpdate(x=>x.RoomTypeID, new RoomDetail() { RoomTypeID = 1, RoomTypeDetails = "Standart", RoomCapacity=2, RoomPrice=125 });
            context.RoomDetails.AddOrUpdate(x=>x.RoomTypeID, new RoomDetail() { RoomTypeID = 2, RoomTypeDetails = "Deluxe", RoomCapacity=2, RoomPrice=250 });
            context.RoomDetails.AddOrUpdate(x=>x.RoomTypeID, new RoomDetail() { RoomTypeID = 3, RoomTypeDetails = "FamilySuit", RoomCapacity=4, RoomPrice=400});
            context.RoomDetails.AddOrUpdate(x=>x.RoomTypeID, new RoomDetail() { RoomTypeID = 4, RoomTypeDetails = "KingSuit", RoomCapacity=4, RoomPrice=800 });

            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 101, RoomTypeID =  1 });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 102, RoomTypeID = 1 });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 103, RoomTypeID = 1 });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 104, RoomTypeID = 1 });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 105, RoomTypeID = 2 });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 106, RoomTypeID = 2 });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 201, RoomTypeID = 3 });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 202, RoomTypeID = 3 });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 203, RoomTypeID = 3 });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 204, RoomTypeID = 3 });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 205, RoomTypeID = 3 });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 206, RoomTypeID = 3 });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 301, RoomTypeID = 4 });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 302, RoomTypeID = 4 });
            context.Rooms.AddOrUpdate(x=>x.RoomNumber,new Room() { RoomNumber = 303, RoomTypeID = 4 });



        }
    }
}
