CREATE PROCEDURE [dbo].[spUpdateUser]
	@UserName AS NVARCHAR(50),
	@Password AS NVARCHAR(50),
	@Roles AS NVARCHAR(50),
	@Description AS NVARCHAR(MAX)
AS
	BEGIN
		UPDATE tblUsers SET
			UserName = @UserName, [Password] = @Password, Roles = @Roles, [Description] = @Description
			WHERE UserName = @UserName
	END

