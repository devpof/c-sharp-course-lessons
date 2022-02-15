using HotelAppLibrary.Databases;
using HotelAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAppLibrary.Data
{
    public class SqliteData : IDatabaseData
    {
        private const string connectionStringName = "SQLiteDb";
        private readonly ISqliteDataAccess db;

        public SqliteData(ISqliteDataAccess db)
        {
            this.db = db;
        }

        public void BookGuest(string firstName, string lastName, DateTime startDate, DateTime endDate, int roomTypeId)
        {
            string sql = @"select 1 from Guests where FirstName = @firstName and LastName = @lastName";
            int results = db.LoadData<dynamic, dynamic>(sql, new { firstName, lastName }, connectionStringName).Count();

            if (results == 0)
            {
                sql = @"insert into Guests (FirstName, LastName) values (@firstName, @lastName);";
                db.SaveData(sql, new { firstName, lastName }, connectionStringName);
            }

            sql = @"select [Id], [FirstName], [LastName]
	                from Guests
	                where FirstName = @firstName and LastName = @lastName LIMIT 1;";

            GuestModel guest = db.LoadData<GuestModel, dynamic>(sql,
                                                    new { firstName, lastName },
                                                    connectionStringName).First();

            RoomTypeModel roomType = db.LoadData<RoomTypeModel, dynamic>("select * from RoomTypes where Id = @Id",
                                                                         new { Id = roomTypeId },
                                                                         connectionStringName).First();

            TimeSpan timeStaying = endDate.Date.Subtract(startDate.Date);

            sql = @"select [r].[Id], [r].[RoomNumber], [r].[RoomTypeId]
	                from Rooms r
	                inner join RoomTypes t on t.Id = r.RoomTypeId
	                where
	                r.RoomTypeId = @roomTypeId
	                and r.Id not in (
	                select b.RoomId
	                from Bookings b
	                where (b.StartDate > @startDate and b.EndDate < @endDate)
		                or (b.StartDate <= @endDate and b.EndDate > @endDate)
		                or (b.StartDate <= @startDate and b.EndDate > @startDate)
	                );";

            List<RoomModel> availableRooms = db.LoadData<RoomModel, dynamic>(sql,
                                                                             new { startDate, endDate, roomTypeId },
                                                                             connectionStringName);

            sql = @"insert into Bookings (RoomId, GuestId, StartDate, EndDate, TotalCost)
	                values (@roomId, @guestId, @startDate, @endDate, @totalCost);";

            db.SaveData(sql,
                        new
                        {
                            roomID = availableRooms.First().Id,
                            guestId = guest.Id,
                            startDate = startDate,
                            endDate = endDate,
                            totalCost = roomType.Price * timeStaying.Days
                        },
                        connectionStringName);
        }

        public void CheckInGuest(int bookingId)
        {
            string sql = @"update Bookings
	                        set CheckedIn = 1
	                        where Id = @id;";

            db.SaveData(sql, new { Id = bookingId }, connectionStringName);
        }

        public List<RoomTypeModel> GetAvailableRoomTypes(DateTime startDate, DateTime endDate)
        {
            string sql = @"select t.Id, t.Title, t.Description, t.Price
	                        from Rooms r
	                        inner join RoomTypes t on t.Id = r.RoomTypeId
	                        where r.Id not in (
	                        select b.RoomId
	                        from Bookings b
	                        where (b.StartDate > @startDate and b.EndDate < @endDate)
		                        or (b.StartDate <= @endDate and b.EndDate > @endDate)
		                        or (b.StartDate <= @startDate and b.EndDate > @startDate)
	                        )
	                        group by t.Id, t.Title, t.Description, t.Price;";

            var output = db.LoadData<RoomTypeModel, dynamic>(sql,
                                                     new { startDate, endDate },
                                                     connectionStringName);

            output.ForEach(x => x.Price = x.Price / 100);

            return output;
        }

        public RoomTypeModel GetRoomTypeById(int id)
        {
            string sql = @"SELECT [Id], [Title], [Description], [Price]
	                        FROM RoomTypes
	                        WHERE Id = @id;";

            return this.db.LoadData<RoomTypeModel, dynamic>(sql,
                                                            new { id },
                                                            connectionStringName).FirstOrDefault();
        }

        public List<BookingFullModel> SearchBookings(string lastName)
        {
            String sql = @"select [b].[Id], [b].[RoomId], [b].[GuestId], [b].[StartDate], [b].[EndDate],
		                        [b].[CheckedIn], [b].[TotalCost], [g].[FirstName], [g].[LastName],
		                        [r].[RoomNumber], [r].[RoomTypeId], [rt].[Title], [rt].[Description], [rt].[Price]
	                        from Bookings b
	                        inner join Guests g on g.Id = b.GuestId
	                        inner join Rooms r on r.Id = b.RoomId
	                        inner join RoomTypes rt on rt.Id = r.RoomTypeId
	                        where b.startDate = @startDate
	                        and g.LastName = @lastName;";

            var output = db.LoadData<BookingFullModel, dynamic>(sql,
                                                   new { lastName, startDate = DateTime.Now.Date },
                                                   connectionStringName);

            output.ForEach(x => {
                x.Price = x.Price / 100;
                x.TotalCost = x.TotalCost / 100;
            });

            return output;
        }
    }
}
