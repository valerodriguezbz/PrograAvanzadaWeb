CREATE PROCEDURE Get_Users_By_Roles
	@Email VARCHAR(50)
AS
BEGIN
    BEGIN TRY
        SELECT 
        UR.IdUser,
        UR.IdRole
        FROM UsersRoles AS UR
        INNER JOIN Users AS U ON UR.IdUser=U.Id
        WHERE U.Email = @Email;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;