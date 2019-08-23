use TransportDB
go
insert into KORISNIK(ID, Ime, Prezime) values('1','Nenad','Nedic')
insert into KORISNIK(ID, Ime, Prezime) values('2','Pera','Peric')
insert into KORISNIK(ID, Ime, Prezime) values('3','Zika','Zikic')

insert into DRZAVA(ID, Ime)
 values('1','Francuska')
insert into DRZAVA(ID, Ime)
 values('2','Amerika')
insert into DRZAVA(ID, Ime)
 values('3','Srbija')

insert into SERVIS(ID, Cena, IdDrzave, IdKorisnika, Ime)
 values('1','12356','2','1','Motori')
insert into SERVIS(ID, Cena, IdDrzave, IdKorisnika, Ime)
 values('2','342','3','2','Vagoni')
insert into SERVIS(ID, Cena, IdDrzave, IdKorisnika, Ime)
 values('3','7853','1','3','Secer')
 