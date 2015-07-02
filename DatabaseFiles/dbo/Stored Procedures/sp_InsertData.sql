CREATE PROCEDURE sp_InsertData
	@id int,
	@name varchar(250),
	@dateofbirth Date,
	@gradepointavg Decimal(4,2),
	@active bit
AS
BEGIN
	SET NOCOUNT ON;

	SET IDENTITY_INSERT Registration ON
	INSERT INTO Registration (StudentID, Name , [Date Of Birth], [Grade Point Average], Active)
	VALUES(@id, @name, @dateofbirth, @gradepointavg, @active)
	SET IDENTITY_INSERT Registration ON
END