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


insert into tblmhs
	(nim, nama)
	values
	('001','Darren'),
	('002','Jimmy'),
	('003','Abraham');

SELECT * FROM tblmhs
SELECT * FROM MstDosen
--week11lab--
SELECT * FROM MstPelanggan


CREATE TABLE anggota 
(
ID int IDENTITY(1,1) PRIMARY KEY,
nama_orang varchar(30),
ulang_tahun datetime
);

--WEEK 12--
INSERT INTO anggota 
    (nama_orang, ulang_tahun)
    VALUES
    ('Yohanes', '9/5/1991 12:00:00AM'),
    ('Agung', '9/19/1991 12:00:00AM'),
    ('Immanuel', '12/18/1991 12:00:00AM');

CREATE TABLE barang
(
ID int IDENTITY(1,1) PRIMARY KEY,
jenis_barang varchar(30),
nama_barang varchar(30),
banyak_barang int,
harga_barang int
);

INSERT INTO barang
    (jenis_barang , nama_barang ,banyak_barang ,harga_barang )
	VALUES
	('Notebook','Asus A46CM','5','499'),
	('Smartphone','Galaxy S4','30','749'),
	('Smartphone','Xperia Arc','7','699'),
	('Processor','Phenom II X4','5','135'),
	('Processor','Athlon II X4','12','80'),
	('Processor','Core I3','7','125'),
	('Processor','Core I5', '9','225'),
	('Processor','Core I7','4','499'),
	('Graphic Card','GTX 690','3','659'),
	('Graphic Card','HD 6970','1','799');

INSERT INTO barang
    (jenis_barang , nama_barang ,banyak_barang ,harga_barang )
	VALUES
	('Processor','Core I7','4','499');

select * from  anggota;
select * from  barang;

drop table barang


drop table MstDosen
drop table tblmhs

--Week13--
CREATE TABLE Teman
(
ID int IDENTITY(1,1) PRIMARY KEY,
nama_orang varchar(30),
ulang_tahun date,
Jenis_kelamin varchar(15)
);

INSERT INTO Teman
    (nama_orang, ulang_tahun, Jenis_kelamin)
	VALUES
	('Samuel','9/5/1993','Laki-Laki'),
	('William','9/19/1993','Laki-Laki'),
	('Ken','12/18/1993','Laki-Laki'),
	('Gita','5/19/1993','Perempuan');

select * from Teman 


--Week14--
CREATE TABLE pelanggan
(
id_pelanggan VARCHAR(5) PRIMARY KEY not null,
nama_pelanggan VARCHAR(30) not null
);

CREATE TABLE pemasok
(
id_pemasok VARCHAR(5) PRIMARY KEY not null,
nama_pemasok VARCHAR(30) not null,
);


select * from pelanggan
drop table pelanggan