use visprogw10

create TABLE tblmhs
(
nim varchar(10) primary key not null,
nama varchar(50)
);

CREATE TABLE MstDosen
(
KdDosen varchar(50) primary key not null,
NaDosen varchar(50) not null,
Alamat varchar(50) not null,
Notelp varchar(50) not null,
NoHp varchar(20) not null
);


--week11 LAB--
CREATE TABLE MstPelanggan
(
KodePelanggan varchar(4) primary key not null,
Nama varchar(50) not null,
Alamat varchar(50) not null,
Umur varchar(50) not null
);


SELECT * FROM tblmhs
SELECT * FROM MstDosen
--week11lab--
SELECT * FROM MstPelanggan

drop table MstDosen
drop table tblmhs

--week12 LAB--

drop table Teman

CREATE TABLE Teman
(
ID INT IDENTITY(1,1) PRIMARY KEY,
nama_orang VARCHAR(50) not null,
ulang_tahun date,
Jenis_kelamin VARCHAR(50) not null
);



INSERT INTO Teman
	(nama_orang, ulang_tahun, Jenis_kelamin)
VALUES
 ('Samuel','9/5/1993','Laki-Laki'),
 ('William','9/19/1993','Laki-Laki'),
 ('Ken','12/18/1993','Laki-Laki'),
 ('Gita','5/19/1993','Perempuan');

 select * from Teman