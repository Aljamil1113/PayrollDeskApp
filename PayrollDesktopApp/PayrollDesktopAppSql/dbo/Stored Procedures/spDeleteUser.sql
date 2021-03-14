CREATE PROCEDURE [dbo].[spDeleteUser]
	@UserName AS NVARCHAR(50)
AS
	 BEGIN
		DELETE FROM tblUsers WHERE UserName = @UserName
	 END
