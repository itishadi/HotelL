--visa tabel guest
select * from Guests

--visar den som jag anget id
select * from Guests where GuestId = 'Johan';

--Lägger till
INSERT INTO Guests(GuestId,Name, Age)
VALUES ('Alf','Alfred', 42) 

--Visar i ordning
SELECT * FROM Guests ORDER BY GuestId desc;

--raderar
DELETE FROM Guests WHERE GuestId ='Alf';

--uppdaterar
UPDATE Guests
SET Name = 'Johan', Age= 26
WHERE GuestId = 'Johan';
-------------------------------------------------------
select * from Rooms

select * from Rooms where RoomId = 'A';

INSERT INTO Rooms(RoomId ,Type,Description,ExtraBed)
VALUES ('H','Twin', 'SingelRoom', 'YES');

SELECT * FROM Rooms ORDER BY RoomId desc;

DELETE FROM Rooms WHERE RoomId = 'H';

UPDATE Rooms
SET Type = 'Triple', Description = 'Singelroom', ExtraBed = 'YES'
WHERE RoomId = 'A';

