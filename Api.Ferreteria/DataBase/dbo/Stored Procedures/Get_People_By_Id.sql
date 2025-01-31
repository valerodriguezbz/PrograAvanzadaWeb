CREATE PROCEDURE Get_People_By_Id
    @Id int
AS
BEGIN
    BEGIN TRY
        SELECT 
            Id, 
            Name, 
            City, 
            Address, 
            PhoneNumber, 
            Email,
            created_at
        FROM People
        WHERE Id = @Id;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END;