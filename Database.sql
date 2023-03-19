CREATE DATABASE SE_Ticket_Vendor_Machine
GO
USE SE_Ticket_Vendor_Machine
GO
CREATE TABLE Ticket (
	idTicket nvarchar(10),
	vehicle nvarchar(100),
	destination nvarchar(100),
	price float
)

INSERT INTO Ticket VALUES('t001', N'Xe buýt', N'Hồ Chí Minh', 100000)
INSERT INTO Ticket VALUES('t002', N'Xe buýt', N'Hà Nội', 200000)
INSERT INTO Ticket VALUES('t003', N'Xe buýt', N'Bình Dương', 50000)

INSERT INTO Ticket VALUES('t004', N'Xe lửa', N'Hồ Chí Minh', 50000)
INSERT INTO Ticket VALUES('t005', N'Xe lửa', N'Hà Nội', 100000)
INSERT INTO Ticket VALUES('t006', N'Xe lửa', N'Bình Dương', 25000)

INSERT INTO Ticket VALUES('t007', N'Xe buýt điện', N'Hồ Chí Minh', 200000)
INSERT INTO Ticket VALUES('t008', N'Xe buýt điện', N'Hà Nội', 400000)
INSERT INTO Ticket VALUES('t009', N'Xe buýt điện', N'Bình Dương', 100000)

SELECT * FROM Ticket

