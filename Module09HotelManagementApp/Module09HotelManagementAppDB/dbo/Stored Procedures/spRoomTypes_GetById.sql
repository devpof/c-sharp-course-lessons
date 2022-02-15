CREATE PROCEDURE [dbo].[spRoomTypes_GetById]
	@id int
AS
begin
	set nocount on;

	SELECT [Id], [Title], [Description], [Price]
	FROM dbo.RoomTypes
	WHERE Id = @id;

end
RETURN 0
