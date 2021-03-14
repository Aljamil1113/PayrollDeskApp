CREATE PROCEDURE [dbo].[spIsUserDetailsValid]
	@UserName AS NVARCHAR(50),
	@Password AS NVARCHAR (50),
	@Roles AS NVARCHAR(50)
AS
	BEGIN
		DECLARE @IsUserValid BIT
		SET @IsUserValid = 0

		IF EXISTS(SELECT * FROM tblUsers WHERE UserName = @UserName
										AND [Password] = @Password
										AND Roles = @Roles)
										
		BEGIN
			SET @IsUserValid = 1
		END

		SELECT @IsUserValid
	END