USE CarRental;

DROP TABLE Cars;
DROP TABLE DriverInformation;
DROP TABLE Schedule;

SELECT * FROM Cars;
SELECT * FROM DriverInformation;
SELECT * FROM Schedule;
-----------------------------------------------------------------------
USE CarRental;
CREATE TABLE Cars
(
	CarID INT IDENTITY(1,1) PRIMARY KEY,
	ImgPath NVARCHAR(100)NOT NULL,--1
	CarName NVARCHAR(50)NOT NULL,--2
	Brand NVARCHAR(20)NOT NULL,--3
	BodyType VARCHAR(20)NOT NULL,--4
	Transmission VARCHAR(10)NOT NULL,--5
	FuelType  VARCHAR(10)NOT NULL,--6
	SeatingCapacity TINYINT NOT NULL,--7
	Doors TINYINT NOT NULL,--8
	Description NVARCHAR(1000) NULL,--9
	Price DECIMAL(10,2)NOT NULL, --	10digits 2decimals
	PlateNumber NVARCHAR(8) UNIQUE NOT NULL,
	Available VARCHAR(5)NOT NULL,
	CONSTRAINT CHK_Available CHECK (Available IN ('Yes', 'No')),
	CONSTRAINT CHK_PlateNumber CHECK (PlateNumber LIKE '[A-Z][A-Z][A-Z]-[0-9][0-9][0-9][0-9]')
)
-----------------------------------------------------------------------
USE CarRental;
CREATE TABLE DriverInformation 
(
	DriverID INT IDENTITY(1,1) PRIMARY KEY, 
    FirstName NVARCHAR(30) NOT NULL,
    LastName NVARCHAR(30) NOT NULL,
    Email NVARCHAR(254) NOT NULL,
    Country NVARCHAR(40) NOT NULL,
    Address NVARCHAR(255) NOT NULL,
    City NVARCHAR(50) NULL,
    StateProvince NVARCHAR(50) NULL,
    PostalZip NVARCHAR(20) NULL,
    Landline NVARCHAR(15) NULL, 
    MobileNumber NVARCHAR(15) NOT NULL,
    Note NVARCHAR(1000) NULL,
)	
-----------------------------------------------------------------------
USE CarRental;
CREATE TABLE Schedule
(
    ScheduleID INT IDENTITY(1,1) PRIMARY KEY,
    DriverID INT NOT NULL,
	CarID INT NOT NULL,
    PickUpLocation NVARCHAR(50) NOT NULL,
    PickUpDate DATE NOT NULL,
    PickUpTime TIME NOT NULL,
    DropOffLocation NVARCHAR(50) NOT NULL,
    DropOffDate DATE NOT NULL,
    DropOffTime TIME NOT NULL,
    Status NVARCHAR(20) NOT NULL DEFAULT 'To Be Approved',
    TimeUntilDropOff NVARCHAR(50)DEFAULT NULL,
	CONSTRAINT CHK_Status CHECK (Status IN ('To Be Approved', 'Active', 'Completed', 'Cancelled')),
    CONSTRAINT FK_Schedule_Driver FOREIGN KEY (DriverID) REFERENCES DriverInformation(DriverID),
	CONSTRAINT FK_Schedule_Car FOREIGN KEY (CarID) REFERENCES Cars(CarID)
);
DROP TABLE Schedule;


-----------------------------------------------------------------------
-----------------------------------------------------------------------
USE CarRental;
INSERT INTO Cars (ImgPath, CarName, Brand, BodyType, Doors, Transmission, FuelType, SeatingCapacity, Description, Price, PlateNumber, Available)
VALUES
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\1.png', 'Honda Civic', 'Honda', 'Sedan', 4, 'Manual', 'Gasoline', 5, 'A stylish and sporty compact sedan known for its performance and reliability.', 2240.00,'TUV-1235', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\3.png', 'Toyota Yaris', 'Toyota', 'Sedan', 4, 'Manual', 'Gasoline', 5, 'A fuel-efficient and comfortable vehicle with advanced safety features.', 2240.00,'QRS-7891', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\5.png', 'Suzuki Kizashi', 'Suzuki', 'Sedan', 4, 'Manual', 'Electric', 5, 'A Suzuki premium sedan offering, emphasizing performance and luxury.', 2240.00,'NOP-3567', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\7.png', 'Nissan Versa', 'Nissan', 'Sedan', 4, 'Manual', 'Gasoline', 5, 'A budget-friendly sedan with modern features and spacious interiors.', 2240.00,'KLM-0124', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\9.png', 'Honda BR-V', 'Honda', 'SUV', 5, 'Manual', 'Diesel', 7, 'A family-friendly SUV with a rugged look and versatile seating.', 2800.00,'HIJ-5789', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\11.png', 'Toyota LC', 'Toyota', 'SUV', 5, 'Automatic', 'Diesel', 7, 'A premium off-road vehicle with unparalleled durability and luxury.', 5600.00,'EFG-2346', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\13.png', 'Suzuki Ignis', 'Suzuki', 'SUV', 5, 'Manual', 'Gasoline', 5, 'A quirky, urban-focused hatchback with a crossover-inspired design.', 2800.00,'BCD-8901', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\15.png', 'Nissan Kicks', 'Nissan', 'SUV', 5, 'Manual', 'Diesel', 5, 'A stylish and feature-packed crossover ideal for urban and highway use.', 2800.00,'YZA-4567', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\17.png', 'Honda Odyssey', 'Honda', 'Van', 5, 'Automatic', 'Gasoline', 7, 'A luxurious and spacious minivan ideal for families, featuring advanced safety systems.', 3360.00,'VWX-0123', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\19.png', 'Toyota Innova', 'Toyota', 'Van', 5, 'Manual', 'Diesel', 7, 'A robust MPV known for reliability and comfort in family and commercial use.', 3360.00,'STU-6789', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\21.png', 'Suzuki APV', 'Suzuki', 'Van', 5, 'Manual', 'Gasoline', 7, 'A no-frills people mover aimed at utility and practicality.', 3360.00,'PQR-2345', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\23.png', 'Nissan NV', 'Nissan', 'Van', 5, 'Automatic', 'Diesel', 10, 'A versatile van suitable for cargo or passenger transport.', 7280.00,'MNO-7890', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\25.png', 'Honda Ridgeline', 'Honda', 'Pickup', 4, 'Automatic', 'Gasoline', 5, 'Known for its car-like handling and innovative features like the in-bed trunk and dual-action tailgate.', 3920.00,'JKL-3456', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\27.png', 'Toyota Tundra', 'Toyota', 'Pickup', 4, 'Automatic', 'Gasoline', 6, 'A rugged and powerful truck designed for heavy-duty work and off-road capability.', 5040.00,'GHI-9012', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle ental\\Properties\\CarPictures\\29.png', 'Suzuki Equator', 'Suzuki', 'Pickup', 4, 'Manual', 'Gasoline', 5, 'A durable and practical pickup truck developed in collaboration with Nissan.', 3920.00,'DEF-5678', 'Yes'),
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\31.png', 'Nissan Frontier', 'Nissan', 'Pickup', 4, 'Manual', 'Diesel', 5, 'A tough and dependable pickup truck with off-road capabilities.', 3920.00,'ABC-1234', 'Yes');

-----------------------------------------------------------------------

INSERT INTO DriverInformation (FirstName, LastName, Email, Country, Address, City, StateProvince, PostalZip, Landline, MobileNumber, Note)
VALUES 
('John', 'Doe', 'john.doe@example.com', 'Philippines', '123 Main St', 'Manila', 'Metro Manila', '1000', '02-1234-5678', '0917-123-4567', 'Prefers contact via mobile.'),
('Maria', 'Garcia', 'maria.garcia@example.com', 'Philippines', '456 Elm St', 'Quezon City', 'Metro Manila', '1100', '02-8765-4321', '0918-987-6543', 'No landline. Available after 6 PM.'),
('James', 'Smith', 'james.smith@example.com', 'Philippines', '789 Oak St', 'Makati', 'Metro Manila', '1200', '02-5678-1234', '0919-765-4321', 'Works in Makati. Contact during office hours.');
-----------------------------------------------------------------------

INSERT INTO Schedule (DriverID, CarID, PickUpLocation, PickUpDate, PickUpTime, DropOffLocation, DropOffDate, DropOffTime, Status)
VALUES
(1, 1, 'Quezon City', '2024-12-15', '08:00:00', 'Makati', '2024-12-15', '18:00:00', 'To Be Approved'),
(2, 5, 'Manila', '2024-12-16', '09:00:00', 'Taguig', '2024-12-16', '17:00:00', 'To Be Approved'),
(3, 10, 'Pasig', '2024-12-17', '10:00:00', 'Mandaluyong', '2024-12-17', '16:00:00', 'To Be Approved');

SELECT * FROM Schedule;








-----------------------------------------------------------------------
-----------------------------------------------------------------------
---------SmartShit
USE CarRental;
GO
CREATE PROCEDURE UpdateSchedule
AS
BEGIN
    -- Update TimeUntilDropOff
    UPDATE Schedule
    SET TimeUntilDropOff = CONCAT(
        FLOOR(DATEDIFF(MINUTE, CURRENT_TIMESTAMP, 
            DATEADD(DAY, DATEDIFF(DAY, 0, DropOffDate), CAST(DropOffTime AS DATETIME))) / (60 * 24 * 7)), ' Week(s), ',
        FLOOR((DATEDIFF(MINUTE, CURRENT_TIMESTAMP, 
            DATEADD(DAY, DATEDIFF(DAY, 0, DropOffDate), CAST(DropOffTime AS DATETIME))) % (60 * 24 * 7)) / (60 * 24)), ' Day(s), ',
        FLOOR((DATEDIFF(MINUTE, CURRENT_TIMESTAMP, 
            DATEADD(DAY, DATEDIFF(DAY, 0, DropOffDate), CAST(DropOffTime AS DATETIME))) % (60 * 24)) / 60), ' Hour(s), ',
        DATEDIFF(MINUTE, CURRENT_TIMESTAMP, 
            DATEADD(DAY, DATEDIFF(DAY, 0, DropOffDate), CAST(DropOffTime AS DATETIME))) % 60, ' Minute(s)'
    )
    WHERE CURRENT_TIMESTAMP <= DATEADD(DAY, DATEDIFF(DAY, 0, DropOffDate), CAST(DropOffTime AS DATETIME))
    AND Status = 'Active';
END;
GO





-------- Run Procedure
EXEC UpdateSchedule;
----------
DROP PROCEDURE UpdateSchedule;
SELECT * FROM Schedule;



--------------------------------------------AFTER PAYMENT
UPDATE Cars
SET Available = 'No'
WHERE CarID = 3;---------frm.currentCarID
--dapat sa day lang na iyon






--------------------ADMIN ACCOUNT
CREATE TABLE AdminAccounts
(
	AdminID INT IDENTITY(1,1) PRIMARY KEY,
	AdminName NVARCHAR(50)NOT NULL,
	AdminUser NVARCHAR(20)UNIQUE NOT NULL,
	AdminPassword NVARCHAR(50)NOT NULL,
);

INSERT INTO AdminAccounts (AdminName, AdminUser, AdminPassword)
VALUES 
('@AdminName', '@AdminUser', '@AdminPassword');
INSERT INTO AdminAccounts (AdminName, AdminUser, AdminPassword)
VALUES ('Marcus Jerremy Gonzaga', 'admin', 'admin123');

SELECT * FROM AdminAccounts;
DROP TABLE AdminAccounts;



------------------------------------UPDATE TABLE
CREATE TABLE UpdateLog
(
	UpdateID INT IDENTITY(1,1) PRIMARY KEY,
	AdminID INT NOT NULL,
	TableName NVARCHAR(30) NOT NULL,
	RecordID INT NOT NULL,
	ActionType VARCHAR(10) NOT NULL,
	OldValues NVARCHAR(MAX)NULL,
	NewValues NVARCHAR(MAX)NULL,
	ChangedColumns VARCHAR(MAX)NULL,
	UpdateDate DATETIME NOT NULL,
	UpdateNote NVARCHAR(255)NULL,
	CONSTRAINT CHK_UpdateLog_TableName CHECK(TableName IN ('AdminAccounts','Cars','DriverInformation','Schedule')),--currently available tables in the database
	CONSTRAINT CHK_UpdateLog_ActionType CHECK(ActionType IN ('ADD', 'UPDATE', 'DELETE')),--
	CONSTRAINT FK_UpdateLog_AdminID FOREIGN KEY (AdminID) REFERENCES AdminAccounts(AdminID)
);
SELECT * FROM UpdateLog;
DROP TABLE UpdateLog;

---------------------------------------------------
CREATE TRIGGER trg_Insert_Cars
ON Cars
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO UpdateLog (AdminID, TableName, RecordID, ActionType, OldValues, NewValues, UpdateDate)
    SELECT 
        1 AS AdminID, -- Replace with your application's admin tracking
		'Cars' AS TableName,
        CAST(Inserted.CarID AS VARCHAR) AS RecordID,
        'ADD' AS ActionType,
        NULL AS OldValues,  -- No old values for insert
		(SELECT * FROM Inserted FOR JSON PATH, WITHOUT_ARRAY_WRAPPER) AS NewValues,
        GETDATE() AS UpdateDate
    FROM Inserted;
END;
DROP TRIGGER trg_Update_Cars

INSERT INTO Cars (ImgPath, CarName, Brand, BodyType, Doors, Transmission, FuelType, SeatingCapacity, Description, Price, PlateNumber, Available) VALUES
('C:\\VisualStudioForms\\Vehicle Rental\\Vehicle Rental\\Properties\\CarPictures\\31.png', 'Nissan Frontier', 'Nissan', 'Pickup', 4, 'Manual', 'Diesel', 5, 'A tough and dependable pickup truck with off-road capabilities.', 3920.00,'ABD-1224', 'Yes');
---------------------------------------------------
CREATE TRIGGER trg_Update_Cars
ON Cars
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert a record into the UpdateLog table
    INSERT INTO UpdateLog (AdminID, TableName, RecordID, ActionType, OldValues, NewValues, ChangedColumns, UpdateDate)
    SELECT 
        1 AS AdminID,  -- Replace with your application's admin tracking
        'Cars' AS TableName,
        CAST(Deleted.CarID AS INT) AS RecordID,
        'UPDATE' AS ActionType,
        -- Capture OldValues (from the Deleted table)
        (SELECT * FROM Deleted FOR JSON PATH, WITHOUT_ARRAY_WRAPPER) AS OldValues,
        -- Capture NewValues (from the Inserted table)
        (SELECT * FROM Inserted FOR JSON PATH, WITHOUT_ARRAY_WRAPPER) AS NewValues,
        -- Detect changed columns
        STRING_AGG(
            CASE
                WHEN Inserted.ImgPath <> Deleted.ImgPath THEN 'ImgPath'
                WHEN Inserted.CarName <> Deleted.CarName THEN 'CarName'
                WHEN Inserted.Brand <> Deleted.Brand THEN 'Brand'
                WHEN Inserted.BodyType <> Deleted.BodyType THEN 'BodyType'
                WHEN Inserted.Transmission <> Deleted.Transmission THEN 'Transmission'
                WHEN Inserted.FuelType <> Deleted.FuelType THEN 'FuelType'
                WHEN Inserted.SeatingCapacity <> Deleted.SeatingCapacity THEN 'SeatingCapacity'
                WHEN Inserted.Doors <> Deleted.Doors THEN 'Doors'
                WHEN Inserted.Description <> Deleted.Description THEN 'Description'
                WHEN Inserted.Price <> Deleted.Price THEN 'Price'
                WHEN Inserted.PlateNumber <> Deleted.PlateNumber THEN 'PlateNumber'
                WHEN Inserted.Available <> Deleted.Available THEN 'Available'
                ELSE NULL
            END, 
            ', '
        ) AS ChangedColumns,  -- List of changed columns
        GETDATE() AS UpdateDate  -- Current timestamp
    FROM 
        Deleted
    JOIN Inserted ON Deleted.CarID = Inserted.CarID
    WHERE
        Inserted.ImgPath <> Deleted.ImgPath
        OR Inserted.CarName <> Deleted.CarName
        OR Inserted.Brand <> Deleted.Brand
        OR Inserted.BodyType <> Deleted.BodyType
        OR Inserted.Transmission <> Deleted.Transmission
        OR Inserted.FuelType <> Deleted.FuelType
        OR Inserted.SeatingCapacity <> Deleted.SeatingCapacity
        OR Inserted.Doors <> Deleted.Doors
        OR Inserted.Description <> Deleted.Description
        OR Inserted.Price <> Deleted.Price
        OR Inserted.PlateNumber <> Deleted.PlateNumber
        OR Inserted.Available <> Deleted.Available
    GROUP BY Deleted.CarID;  -- Group by CarID to match the non-aggregated columns
END;
---------------------------------------------------
CREATE TRIGGER trg_Delete_Cars
ON Cars
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert a record into the UpdateLog table when a car is deleted
    INSERT INTO UpdateLog (AdminID, TableName, RecordID, ActionType, OldValues, UpdateDate)
    SELECT 
        1 AS AdminID,  -- Replace with your application's admin tracking
        'Cars' AS TableName,
        CAST(Deleted.CarID AS INT) AS RecordID,
        'DELETE' AS ActionType,
        (SELECT * FROM Deleted FOR JSON PATH, WITHOUT_ARRAY_WRAPPER) AS OldValues,

        GETDATE() AS UpdateDate  -- Capture the current timestamp of the delete operation
    FROM Deleted;
END;


DELETE FROM Cars WHERE CarID = 23;

-------------------------------------SCHEDULE TABLE
DROP TRIGGER trg_Update_Schedule;
CREATE TRIGGER trg_Update_Schedule
ON Schedule
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert a record into the UpdateLog table when a schedule is updated
    INSERT INTO UpdateLog (AdminID, TableName, RecordID, ActionType, OldValues, NewValues, ChangedColumns, UpdateNote, UpdateDate)
    SELECT 
        1 AS AdminID,  -- Replace with your application's admin tracking
        'Schedule' AS TableName,
        CAST(Deleted.ScheduleID AS INT) AS RecordID,
        'UPDATE' AS ActionType,
        -- Capture OldValues (from the Deleted table)
        (SELECT * FROM Deleted FOR JSON PATH, WITHOUT_ARRAY_WRAPPER) AS OldValues,
        -- Capture NewValues (from the Inserted table)
        (SELECT * FROM Inserted FOR JSON PATH, WITHOUT_ARRAY_WRAPPER) AS NewValues,
        -- List of changed columns
        CASE
            WHEN Inserted.Status <> Deleted.Status THEN 'Status'
            WHEN Inserted.PickUpLocation <> Deleted.PickUpLocation THEN 'PickUpLocation'
            WHEN Inserted.PickUpDate <> Deleted.PickUpDate THEN 'PickUpDate'
            WHEN Inserted.PickUpTime <> Deleted.PickUpTime THEN 'PickUpTime'
            WHEN Inserted.DropOffLocation <> Deleted.DropOffLocation THEN 'DropOffLocation'
            WHEN Inserted.DropOffDate <> Deleted.DropOffDate THEN 'DropOffDate'
            WHEN Inserted.DropOffTime <> Deleted.DropOffTime THEN 'DropOffTime'
            WHEN Inserted.DriverID <> Deleted.DriverID THEN 'DriverID'
            WHEN Inserted.CarID <> Deleted.CarID THEN 'CarID'
            ELSE NULL
        END AS ChangedColumns,
        -- Custom update note based on status change
        CASE 
            WHEN Deleted.Status = 'To Be Approved' AND Inserted.Status = 'Active' 
            THEN 'Payment Confirmed, Status Active'
            WHEN Deleted.Status = 'Active' AND Inserted.Status = 'Completed' 
            THEN 'Rent Complete, Car Claimed'
            WHEN Deleted.Status = 'Active' AND Inserted.Status = 'Cancelled' 
            THEN 'Refund Payment'
            WHEN Deleted.Status = 'To Be Approved' AND Inserted.Status = 'Cancelled' 
            THEN 'Customer Cancelled Booking'
            ELSE 'To Be Approved'
        END AS UpdateNote,
        GETDATE() AS UpdateDate  -- Capture the timestamp of the update
    FROM 
        Inserted
    INNER JOIN Deleted ON Inserted.ScheduleID = Deleted.ScheduleID
    WHERE 
        Inserted.Status <> Deleted.Status
        OR Inserted.PickUpLocation <> Deleted.PickUpLocation
        OR Inserted.PickUpDate <> Deleted.PickUpDate
        OR Inserted.PickUpTime <> Deleted.PickUpTime
        OR Inserted.DropOffLocation <> Deleted.DropOffLocation
        OR Inserted.DropOffDate <> Deleted.DropOffDate
        OR Inserted.DropOffTime <> Deleted.DropOffTime
        OR Inserted.DriverID <> Deleted.DriverID
        OR Inserted.CarID <> Deleted.CarID;
	EXEC UpdateSchedule;
END;




UPDATE Schedule
SET Status = 'Active'
WHERE ScheduleID = 3;

SELECT * FROM Schedule;









--------------------------------------------ADMIN SIDE -- CONFIRM PAYMENT

--Scenario 1 goods yung payment
UPDATE Schedule
SET Status = 'Active'
WHERE ScheduleID = 3;---------tbScheduleID.Text 
--THEN EXEC UpdateSchedule



----Scenario 2 hindi natuloy
UPDATE Schedule
SET Status = 'Cancelled'
WHERE ScheduleID = 3;---------tbScheduleID.Text


---Scenario 3 after successful payment and rental
UPDATE Schedule
SET Status = 'Completed'
WHERE ScheduleID = 1;---------tbScheduleID.Text


----completed or cancelled will use this
UPDATE Cars
SET Available = 'Yes'
WHERE CarID = 5;---------tbCarID.Text
