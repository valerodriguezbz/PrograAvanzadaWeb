CREATE PROCEDURE Update_People
    @Id int OUTPUT,
    @Name VARCHAR(100),
    @City VARCHAR(100),
    @Address VARCHAR(255),
    @PhoneNumber INT,
    @Email VARCHAR(255)
AS
BEGIN
    BEGIN TRY
        UPDATE People
        SET 
            Name = @Name,
            City = @City,
            Address = @Address,
            PhoneNumber = @PhoneNumber,
            Email = @Email
        WHERE Id = @Id;
        SELECT @Id;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;
