CREATE VIEW Get_CartService_View
AS
SELECT
CS.IdCart,
CS.IdService,
S.Name AS ServiceName,
S.Description AS ServiceDescription,
S.Schedule AS ServiceSchedule, 
S.Schedule AS ServicePrice
FROM CartService AS CS
INNER JOIN Services AS S ON CS.IdService=S.Id
