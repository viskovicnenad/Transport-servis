CREATE PROCEDURE [DajSveServise]
AS
select * from SERVIS
GO

CREATE PROCEDURE [DajServisePoID]
(
@ID nvarchar(10)
)
AS
select * from SERVIS where ID=@ID
GO

CREATE PROCEDURE [DodajNoviServis]
( 
@ID nvarchar(10),
@Ime nvarchar(30),
@Cena int,
@IdKorisnika nvarchar(10),
@IdDrzave nvarchar(10)
)
AS
BEGIN
Insert into SERVIS(ID, Ime, Cena, IdKorisnika, IdDrzave)
values (@ID, @Ime, @Cena, @IdKorisnika, @IdDrzave)
END
GO

CREATE PROCEDURE [DajSvekorisnike]
AS
select * from KORISNIK
GO

CREATE PROCEDURE [DajkorisnikePoID]
(
@ID nvarchar(10)
)
AS
select * from KORISNIK where ID=@ID
GO

CREATE PROCEDURE [DodajNovogKorisnika]
( 
@ID nvarchar(10),
@Ime nvarchar(30),
@Prezime nvarchar(30)
)
AS
BEGIN
Insert into KORISNIK(ID, Ime, Prezime) 
values (@ID, @Ime, @Prezime)
END
GO