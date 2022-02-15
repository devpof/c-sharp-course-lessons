CREATE PROCEDURE [dbo].[spRoomTypes_GetAvailableTypes]
	@startDate date,
	@endDate date
AS
BEGIN
	set nocount on;

	select t.Id, t.Title, t.Description, t.Price
	from dbo.Rooms r
	inner join dbo.RoomTypes t on t.Id = r.RoomTypeId
	where r.Id not in (
	select b.RoomId
	from dbo.Bookings b
	where (b.StartDate > @startDate and b.EndDate < @endDate)
		or (b.StartDate <= @endDate and b.EndDate > @endDate)
		or (b.StartDate <= @startDate and b.EndDate > @startDate)
	)
	group by t.Id, t.Title, t.Description, t.Price
END