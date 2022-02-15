CREATE PROCEDURE [dbo].[spRooms_GetAvailableRooms]
	@startDate date,
	@endDate date,
	@roomTypeId int
AS
BEGIN
	set nocount on;

	select [r].[Id], [r].[RoomNumber], [r].[RoomTypeId]
	from dbo.Rooms r
	inner join dbo.RoomTypes t on t.Id = r.RoomTypeId
	where
	r.RoomTypeId = @roomTypeId
	and r.Id not in (
	select b.RoomId
	from dbo.Bookings b
	where (b.StartDate > @startDate and b.EndDate < @endDate)
		or (b.StartDate <= @endDate and b.EndDate > @endDate)
		or (b.StartDate <= @startDate and b.EndDate > @startDate)
	);
END
