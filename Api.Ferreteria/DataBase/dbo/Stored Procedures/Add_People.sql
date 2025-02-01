CREATE PROCEDURE Add_People
    @Name VARCHAR(100),
    @FirstLastName VARCHAR(100),
    @City VARCHAR(100),
    @Address VARCHAR(255),
    @PhoneNumber INT,
    @Created_At DateTime
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO People (Name, City, Address, PhoneNumber, created_at)
        VALUES (@Name, @City, @Address, @PhoneNumber, @Created_At);
        COMMIT TRANSACTION;
		SELECT SCOPE_IDENTITY() AS Id;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;