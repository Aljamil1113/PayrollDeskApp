CREATE PROCEDURE [dbo].[spInsertUser]
	@UserName AS NVARCHAR(50),
	@Password AS NVARCHAR(50),
	@Roles AS NVARCHAR(50),
	@Description AS NVARCHAR(MAX)
AS
	 BEGIN
		INSERT INTO tblUsers(UserName, [Password], Roles, [Description])
		VALUES (@UserName, @Password, @Roles, @Description)
	 END
