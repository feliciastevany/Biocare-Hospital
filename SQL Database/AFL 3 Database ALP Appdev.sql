CREATE DATABASE IF NOT EXISTS biocare;
USE biocare;

DROP TABLE IF EXISTS Pasien;
CREATE TABLE Pasien (
  id_pasien varchar(6) PRIMARY KEY,
  nama_pasien varchar(30) not null,
  tgl_lhr date not null,
  alamat varchar(30) not null,
  kota varchar(15) not null,
  notelf varchar(15) not null,
  id_penanggungJawab varchar(4) not null,
  gender char(1) check (gender = 'F' or gender = 'M'),
  `remove` varchar(1) not null
);

INSERT INTO Pasien values
('C00001', 'Andi Pratama', '1990-06-25', 'Jl. Kenari No. 20', 'Denpasar', 081428915766, 'P009', 'M', 0),
('C00002', 'Budi Setiawan', '2013-03-14', 'Jl. Merpati No. 18', 'Manado', 082851973351, 'P027', 'M', 0),
('C00003', 'Cici Lestari', '1982-11-07', 'Jl. Anggrek Biru No. 22', 'Mojokerto', 08125357591, 'P005', 'F', 0),
('C00004', 'Denny Wibowo','1998-08-10', 'Jl. Melati Putih No. 40', 'Makassar', 08943689015, 'P018', 'M', 0),
('C00005', 'Elisa Permata','2011-12-28', 'Jl. Sawo Merah No. 30' ,'Jakarta', 08125674792, 'P030', 'F', 0),
('C00006', 'Ferry Anugrah','1987-02-18', 'Jl. Gatot Subroto No. 7', 'Jakarta', 08952854921, 'P014', 'M', 0),
('C00007', 'Gita Saraswati','2001-07-05', 'Jl. Mawar No. 18', 'Denpasar', 08482719563, 'P003', 'F', 0),
('C00008', 'Hadi Nugroho','1993-04-21', 'Jl. Pahlawan No. 6', 'Jakarta', 089876543211, 'P021', 'M', 0),
('C00009', 'Ika Kartika','1977-10-11', 'Jl. Kenanga Indah No. 9', 'Batam', 08809624371, 'P006', 'F', 0),
('C00010', 'Joko Pramono','1995-01-08', 'Jl. Gajah Mada No. 87', 'Surabaya', 087644321100, 'P012', 'M', 0),
('C00011', 'Kiki Amelia','1989-08-17', 'Jl. Setiabudi No. 29', 'Pontianak', 081153297846, 'P028', 'F', 0),
('C00012', 'Lina Putri','2006-05-04', 'Jl. Asia Afrika No. 57', 'Banjarmasin', 08690745283, 'P001', 'F', 0),
('C00013', 'Maman Sulaeman','1983-09-19', 'Jl. Riau No. 88', 'Manado', 08736192458, 'P010', 'M', 0),
('C00014', 'Budi Santoso','1996-02-27', 'Jl. Dahlia No. 20', 'Bogor', 08528416970, 'P025', 'M', 0),
('C00015', 'Siti Rahayu','2009-10-14', 'Jl. Mawar Merah No. 3', 'Jakarta', 08974583216, 'P007', 'F', 0),
('C00016', 'Joko Sutrisno','1991-07-22', 'Jl. Veteran No. 18', 'Pekanbaru', 08261908375, 'P019', 'M', 0),
('C00017', 'Desi Fitriani','1974-03-31', 'Jl. Sawo No. 6', 'Surabaya', 08837651429, 'P016', 'F', 0),
('C00018', 'Agus Prasetyo','2000-11-07', 'Jl. Jenderal Sudirman No. 30', 'Padang', 08495836712, 'P002', 'M', 0),
('C00019', 'Rina Indahsari','1985-06-13', 'Jl. Anggrek Biru No. 9', 'Jakarta', 08617245839, 'P012', 'F', 0),
('C00020', 'Hadi Kurniawan','1997-01-01', 'Jl. Meranti No. 15', 'Manado', 08328957164, 'P023', 'M', 0),
('C00021', 'Sari Dewi','2010-08-23', 'Jl. Melati Putih No. 40', 'Cimahi', 08879614523, 'P011', 'F', 0),
('C00022', 'Ari Susanto','2002-05-29', 'Jl. Flamboyan Indah No. 22', 'Malang', 08541638297, 'P029', 'M', 0),
('C00023', 'Olivia Parker','1971-12-16', 'Jl. Kenanga No. 7', 'Medan', 08963271845, 'P008', 'F', 0),
('C00024', 'Sophia Adams','1992-09-02', 'Jl. Merdeka No. 10', 'Jakarta', 08714829356, 'P004', 'F', 0),
('C00025', 'Ava Collins','1986-04-11', 'Jl. Pahlawan Raya No. 25', 'Bekasi', 08345782619, 'P017', 'F', 0),
('C00026', 'Mia Robinson','2014-11-20', 'Jl. Anggrek Blok C3 No. 7', 'Bandung', 08182639475, 'P022', 'F', 0),
('C00027', 'Harper Ramirez','1980-06-07', 'Jl. Diponegoro No. 55', 'Surabaya', 08256397814, 'P020', 'M', 0),
('C00028', 'Gabriel Gray','1999-01-25', 'Jl. Melati Indah No. 12', 'Semarang', 08673518942, 'P026', 'M', 0),
('C00029', 'Nathan Bennett','1973-10-09', 'Jl. Flamboyan No. 8', 'Tangerang', 08972504512, 'P015', 'M', 0),
('C00030', 'Ethan Price','2008-07-26', 'Jl. Meranti No. 15', 'Cirebon', 08987654321, 'P024', 'M', 0)
;

DROP TABLE IF EXISTS nota;
CREATE TABLE nota (
  id_nota varchar(5) primary key,
  id_pasien varchar(6),
  id_dokter varchar(4),
  id_kamar varchar(4),
  id_perawat varchar(4),
  id_useobat varchar(8) ,
  tgl_msk date,
  tgl_keluar date,
  total int,
  paid varchar(1) not null
);

INSERT INTO nota values
('N0001', 'C00001', 'D002', 'B001','B001','T0001201', '2023-07-23','2023-07-25', 0, 1),
('N0002', 'C00002', 'D008', 'A002','A002','T0002201','2023-01-12','2023-01-16', 0, 0),
('N0003', 'C00003', 'D006', 'A001','A001','T0003101','2022-02-16','2022-02-20', 0, 1),
('N0004', 'C00004', 'D004', 'E001','E001','T0004501','2023-03-30','2023-04-05', 0, 1),
('N0005', 'C00005', 'D008', 'D001','D001','T0005401','2019-10-27','2019-10-31', 0, 0),
('N0006', 'C00006', 'D005', 'B003','B003','T0006203','2022-05-25','2022-05-29', 0, 1),
('N0007', 'C00007', 'D009', 'E002','E002','T0007502','2022-08-14','2022-08-19', 0, 0),
('N0008', 'C00008', 'D004', 'C001','C001','T0008301','2022-02-16','2022-02-20', 0, 0),
('N0009', 'C00009', 'D010', 'D003','D003','T0009403','2020-01-26','2020-01-30', 0, 1),
('N0010', 'C00010', 'D003', 'E004','E004','T0010504','2012-11-04','2012-11-10', 0, 0),
('N0011', 'C00011', 'D004', 'D006','D002','T0011406','2020-12-26','2020-12-30', 0, 1),
('N0012', 'C00012', 'D002', 'B002','B002','T0012202','2021-01-01','2021-01-15', 0, 0),
('N0013', 'C00013', 'D005', 'D005','D004','T0013405','2022-09-16','2022-09-20', 0, 1),
('N0014', 'C00014', 'D004', 'A008','A004','T0014108','2019-02-07','2019-02-12', 0, 1),
('N0015', 'C00015', 'D008', 'A006','A003','T0015106','2019-06-29','2019-07-05', 0, 0),
('N0016', 'C00016', 'D003', 'A005','A004','T0016105','2023-07-21','2023-07-26', 0, 0),
('N0017', 'C00017', 'D010', 'E008','E001','T0017508','2023-07-12','2023-07-16', 0, 1),
('N0018', 'C00018', 'D002', 'D009','D004','T0018409','2022-05-22','2022-05-27', 0, 0),
('N0019', 'C00019', 'D007', 'C003','C004','T0019303','2020-04-19','2020-04-23', 0, 1),
('N0020', 'C00020', 'D004', 'E007','E001','T0020507','2019-07-27','2019-07-31', 0, 1),
('N0021', 'C00021', 'D008', 'C005','C003','T0021305','2020-09-18','2020-09-23', 0, 1),
('N0022', 'C00022', 'D002', 'C010','C002','T0022310','2019-07-15','2019-07-20', 0, 0),
('N0023', 'C00023', 'D005', 'E005','E002','T0023505','2023-10-23','2023-10-29', 0, 1),
('N0024', 'C00024', 'D004', 'D010','D001','T0024410','2020-05-07','2020-05-12', 0, 1),
('N0025', 'C00025', 'D004', 'B007','B004','T0025207','2019-10-27','2019-10-30', 0, 0),
('N0026', 'C00026', 'D002', 'D004','D001','T0026404','2023-04-17','2023-04-23', 0, 1),
('N0027', 'C00027', 'D010', 'E010','E004','T0027510','2022-09-05','2022-09-10', 0, 0),
('N0028', 'C00028', 'D002', 'D008','D002','T0028408','2022-12-12','2022-12-17', 0, 1),
('N0029', 'C00029', 'D007', 'B006','B001','T0029206','2020-12-25','2020-12-29', 0, 0),
('N0030', 'C00030', 'D006', 'C004','C001','T0030304','2019-09-24','2019-09-30', 0, 1)
;

DROP TABLE IF EXISTS Kamar;
CREATE TABLE Kamar (
  id_kamar varchar(4) primary key,
  no_kamar varchar(3) not null,
  available varchar(1) not null,
  id_jenis varchar(4) not null,
  lantai varchar(1) not null
);

INSERT INTO Kamar values
('A001', 101, 'N', 'V001', 1),
('A002', 102, 'N', 'V001', 1),
('A003', 103, 'Y', 'V001', 1),
('A004', 104, 'Y', 'V001', 1),
('A005', 105, 'N', 'P001', 1),
('A006', 106, 'N', 'P001', 1),
('A007', 107, 'Y', 'P001', 1),
('A008', 108, 'N', 'P001', 1),
('A009', 109, 'Y', 'P001', 1),
('A010', 110, 'Y', 'P002', 1),
('B001', 201, 'N', 'P002', 2),
('B002', 202, 'N', 'P002', 2),
('B003', 203, 'N', 'P002', 2),
('B004', 204, 'Y', 'I002', 2),
('B005', 205, 'Y', 'I002', 2),
('B006', 206, 'N', 'I002', 2),
('B007', 207, 'N', 'I002', 2),
('B008', 208, 'Y', 'I001', 2),
('B009', 209, 'Y', 'I001', 2),
('B010', 210, 'Y', 'I001', 2),
('C001', 301, 'N', 'S001', 3),
('C002', 302, 'Y', 'S001', 3),
('C003', 303, 'N', 'S001', 3),
('C004', 304, 'N', 'S001', 3),
('C005', 305, 'N', 'S001', 3),
('C006', 306, 'Y', 'S001', 3),
('C007', 307, 'N', 'S001', 3),
('C008', 308, 'Y', 'S001', 3),
('C009', 309, 'Y', 'S001', 3),
('C010', 310, 'N', 'S001', 3),
('D001', 401, 'N', 'S001', 4),
('D002', 402, 'Y', 'S001', 4),
('D003', 403, 'N', 'S001', 4),
('D004', 404, 'N', 'S001', 4),
('D005', 405, 'N', 'S001', 4),
('D006', 406, 'N', 'S001', 4),
('D007', 407, 'Y', 'S001', 4),
('D008', 408, 'N', 'S001', 4),
('D009', 409, 'N', 'S001', 4),
('D010', 410, 'N', 'S001', 4),
('E001', 501, 'N', 'S001', 5),
('E002', 502, 'N', 'S001', 5),
('E003', 503, 'Y', 'S001', 5),
('E004', 504, 'N', 'S001', 5),
('E005', 505, 'N', 'S001', 5),
('E006', 506, 'Y', 'S001', 5),
('E007', 507, 'Y', 'S001', 5),
('E008', 508, 'N', 'S001', 5),
('E009', 509, 'N', 'S001', 5),
('E010', 510, 'N', 'S001', 5)
; 

DROP TABLE IF EXISTS Penanggung_Jawab;
CREATE TABLE Penanggung_Jawab (
  id_penanggungJawab varchar(4) primary key,
  nama_PJ varchar(30) not null,
  notelf_PJ varchar(11) not null,
  hubungan varchar(10) not null
);

INSERT INTO Penanggung_Jawab values
('P001','Ahmad Syahrul', 08592831407, 'Kakek'),
('P002','Budi Santoso', 08206749853, 'Suami'),
('P003','Siti Rahayu', 08874293516, 'Istri'),
('P004','Dewi Ayu Pratiwi', 08876543210, 'Anak'),
('P005','Joko Setiawan', 08317845906, 'Saudara'),
('P006','Lina Nur Aini ', 08953168472, 'Saudara'),
('P007','Slamet Riyadi', 08136859247, 'Ayah'),
('P008','Retno Wulandari', 08901234567, 'Ibu'),
('P009','Yuni Mawarni', 08615738924, 'Nenek'),
('P010','Ade Santoso Pratama', 08492315876, 'Cucu'),
('P011','Dina Ayu Lestari', 08287643519, 'Cucu'),
('P012','Fajar Ali Akbar', 08754902183, 'Paman'),
('P013','Rina Sari Dewi', 08345678912, 'Tante'),
('P014','Eko Prasetyo', 08789012345, 'Anak'),
('P015','Maya Ratna Dewi', 08456789123, 'Tante'),
('P016','Ardi Nugroho', 08873249156, 'Paman'),
('P017','Tari Fitriyani', 08625431789, 'Ipar'),
('P018','Dani Cahyono', 08982564301, 'Mertua'),
('P019','Rini Widayanti', 08457809632, 'Suami'),
('P020','Andi Suryanto', 08719685240, 'Istri'),
('P021','Isabella Anderson', 08364820957, 'Ayah'),
('P022','Matthew Allen', 08546913278, 'Paman'),
('P023','Rizki Ramadhan', 08802746519, 'Ibu'),
('P024','Dedy Susanto', 08239187465, 'Tante'),
('P025','Iwan Setiawan', 08691508724, 'Saudara'),
('P026','Andi Cahyono', 08825976403, 'Istri'),
('P027','Amelia Johnson', 08140293857, 'Mertua'),
('P028','Dandy Wijaya', 08503697821, 'Suami'),
('P029','Maya Dewi', 08968571432, 'Ibu'),
('P030','Lucas Lee', 08318427569, 'Istri')
;

DROP TABLE IF EXISTS Obat;
CREATE TABLE Obat (
  id_obat varchar(4) primary KEY,
  nama_obat varchar(25) not null,
  jenis_obat varchar(60) not null,
  hargaPerBiji int not null
);

INSERT INTO Obat values 
('O001','Paracetamol', 'Analgesik dan antipiretik', 7000),
('O002','Amoxicilin','Antibiotik', 3200),
('O003','Omeprazole','Antasidem Proton pump inhibitor', 1670),
('O004','Aspirin','Analgesik, Antipiretik dan Antiinflamasi', 2440),
('O005','Ibuprofen','Antiinflamasi nonsteroid', 7500),
('O006','Loratadine','Antihistamin', 1300),
('O007','Cetirizine','Antihistamin', 3900),
('O008','Metformin','Antidiabetik Oral', 1990),
('O009','Artorvastatin','Statin', 173000),
('O010','Levothyroxine','Hormon tiroid sintetik', 1200),
('O011','Simvastatin','Statin', 4900),
('O012','Sertraline','Antidepresan golongan selektif reuptake inhibitor serotonin', 3190),
('O013','Citalopram','Antidepresan golongan selektif reuptake inhibitor serotonin', 2810),
('O014','Gabapentin','Antikonvulsan', 2200),
('O015','Alprazolam','Benzodiazepin', 1500),
('O016','Diazepam','Benzodiazepin',1900),
('O017','Warfarin','Antikoagulan', 1300),
('O018','Metoprolol','Beta-blocker', 4890),
('O019','Furosemide','Diuretik', 9500),
('O020','Losartan','Antagonis reseptor angiotensin II', 6500)
;

DROP TABLE IF EXISTS Jenis_Kamar;
CREATE TABLE Jenis_Kamar (
  id_jenis varchar (4) primary KEY,
  nama_jenis varchar(25) not null,
  jumlah INT not null,
  harga_perMalam int not null
);

insert into Jenis_Kamar values 
('I001','ICU', 4, 2500000),
('I002','Isolation', 3, 3500000),
('P001','Post-Operative', 5, 3500000),
('P002','Palliative Care', 4, 5000000),
('S001','Standard Private', 30, 1500000),
('V001','VIP', 4, 3000000)
;

DROP TABLE IF EXISTS Dokter;
CREATE TABLE Dokter (
  id_dokter varchar (4) PRIMARY KEY,
  nama_dokter varchar(60) not null,
  speciality varchar(30) not null,
  gender char(1) check (gender = 'F' or gender = 'M'),
  harga_perHari int not null,
  remove varchar(1) not null
);

insert into Dokter values
('D001','Dr. Adi Prasetyo, Sp. JP', 'Kardiolog', 'M', 600000, 0),
('D002','Dr. Ani Puspita, Sp. KK', 'Kulit dan kelamin', 'F', 430000, 0),
('D003','Dr. Budi Santoso, Sp. G', 'Gastroenterolog', 'M', 450000, 0),
('D004','Dr. Dewi Wijayanti, Sp. OG', 'Obstetri dan Ginekologi', 'F', 360000, 0),
('D005','Dr. Fauzi Maulana, Sp. S', 'Neurolog', 'M', 60000, 0),
('D006','Dr. Gina Arum, Sp. MK', 'Mata', 'F', 500000, 0),
('D007','Dr. Heru Widodo, Sp. Onk', 'Onkolog', 'M', 50000, 0),
('D008','Dr. Ida Wahyuni, Sp. A', 'Anak', 'F', 300000, 0),
('D009','Dr. David Thompson, Sp. OT', 'Orthopedi', 'M', 570000, 0),
('D010','Dr. Kusuma Indah, Sp. Rad', 'Radiolog', 'F', 600000, 0)
;

DROP TABLE IF EXISTS Perawat;
CREATE TABLE Perawat (
  id_perawat varchar(4) primary key,
  nama_perawat varchar(30) not null,
  gender char(1) check (gender = 'F' or gender = 'M'),
  `remove` varchar(1)
);

INSERT INTO Perawat values
('A001', 'Dian Septiani', 'F', 0),
('A002', 'Fanny Dewi', 'F', 0),
('A003', 'Ika Wijayanti', 'F', 0),
('A004', 'Rina Puspitasari', 'F', 0),
('B001', 'Ani Setiawati', 'F', 0),
('B002', 'Budi Suryanto', 'M', 0),
('B003', 'Hadi Santoso', 'M', 0),
('B004', 'Nita Astuti', 'F', 0),
('C001', 'Gina Pratiwi', 'F', 0),
('C002', 'Lina Kusuma', 'F', 0),
('C003', 'Putri Puspita', 'F', 0),
('C004', 'Tika Amalia', 'F', 0),
('D001', 'Eka Susanti', 'F', 0),
('D002', 'Mira Agustina', 'F', 0),
('D003', 'Sari Kusuma', 'F', 0),
('D004', 'Umi Salamah', 'F', 0),
('E001', 'Joko Nugroho', 'M', 0),
('E002', 'Kusuma Dewi', 'F', 0),
('E003', 'Oktavia Sari', 'F', 0),
('E004', 'Vina Ayu', 'F', 0)
;

DROP TABLE IF EXISTS UseObat;
CREATE TABLE UseObat (
  id_useobat varchar(8),
  id_obat varchar(4),
  qty int,
  id_nota varchar(5)
);

INSERT INTO UseObat values
('T0001201', 'O004', 3, 'N0001'),
('T0002102', 'O001', 2, 'N0002'),
('T0003101', 'O002', 3, 'N0003'),
('T0004501', 'O004', 3, 'N0004'),
('T0005401', 'O001', 2, 'N0005'),
('T0006203', 'O002', 3, 'N0006'),
('T0007502', 'O003', 5, 'N0007'),
('T0008301', 'O004', 5, 'N0008'),
('T0009403', 'O005', 4, 'N0009'),
('T0010504', 'O006', 3, 'N0010'),
('T0011406', 'O007', 4, 'N0011'),
('T0012202', 'O008', 4, 'N0012'),
('T0013405', 'O009', 3, 'N0013'),
('T0014108', 'O010', 2, 'N0014'),
('T0015106', 'O011', 2, 'N0015'),
('T0016105', 'O012', 3, 'N0016'),
('T0017508', 'O013', 4, 'N0017'),
('T0018409', 'O014', 3, 'N0018'),
('T0019303', 'O015', 3, 'N0019'),
('T0020507', 'O016', 4, 'N0020'),
('T0021305', 'O017', 2, 'N0021'),
('T0022310', 'O018', 3, 'N0022'),
('T0023505', 'O019', 4, 'N0023'),
('T0024410', 'O020', 3, 'N0024'),
('T0025207', 'O021', 2, 'N0025'),
('T0026404', 'O022', 2, 'N0026'),
('T0027510', 'O023', 3, 'N0027'),
('T0028408', 'O024', 2, 'N0028'),
('T0029206', 'O025', 3, 'N0029'),
('T0030304', 'O026', 3, 'N0030')
;