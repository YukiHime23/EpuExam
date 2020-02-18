-- 1
create database thiTracNghiem
go
-- 2
use thiTracNghiem
go
-- 3

create table sinhVien(
	ma varchar(20) primary key,
	tensv nvarchar(100),
	matkhau varchar(20) default 123456789,
	ngaysinh date,
	email varchar(50),
	lop varchar(25)
)
go

insert into sinhVien values('SV1681310038',N'Nguyen Trong Kien','1234','19980925','kimidattara.1412@gmail.com','D11-CNPM')
go
create table khoa(
	makhoa varchar(15) primary key,
	tenkhoa nvarchar(100)
)
go
insert into khoa values ('CNTT',N'Cong nghe thong tin')
go
create table giaoVien(
	ma varchar(20) primary key,
	tengv nvarchar(100),
	matkhau varchar(20) default 'GV00001',
	ngaysinh date,
	email varchar(50),
	makhoa varchar(15),
	constraint pk_mk_gv foreign key (makhoa) references  khoa(makhoa)
)
go
insert into giaoVien values('GV1681310038',N'Nguyen Trong Kien','GV00001','19980925','kimidattara.1412@gmail.com','CNTT')
go
create table monHoc(
	mamon varchar(15) primary key,
	makhoa varchar(15),
	tenmon varchar(50),
	constraint pk_mk_mh foreign key (makhoa) references khoa(makhoa)
)
go

create table chuDe(
	machude int primary key identity(1,1),
	mamon varchar(15),
	tenchude nvarchar(50)
)
go

create table cauHoi(
	mach int primary key identity(1,1),
	noidung  nvarchar(1000),
	dokho nvarchar(10),
	ngaytao date,
	machude  int,
	magv varchar(20),
	solanrade int default 0,
	a nvarchar(100),
	b nvarchar(100),
	c nvarchar(100),
	d nvarchar(100),
	dapan nvarchar(100),
	constraint pk_mc_ch foreign key (machude) references chuDe(machude),
	constraint pk_gv_ch foreign key (magv) references giaoVien(ma)
)
go

create table kyThi(
	makythi int primary key identity(1,1),
	tenkythi nvarchar(25),
	thoigianlam int,
	trinhdo varchar(20),
	hedaotao varchar(20)
)
go


create table dethi(
	madethi int primary key identity(1,1),
	makythi int,
	mamon varchar(15),
	socau int default 30,
	ngaytao date,
	constraint pk_dt_kt foreign key (makythi) references kyThi(makythi),
	constraint pk_dt_mh foreign key (mamon) references monHoc(mamon)
)
go

create table ctdethi(
	madethi int,
	mach int,
	primary key(madethi,mach),
	constraint pk_ctdt_ch foreign key (mach) references cauHoi(mach),
	constraint pk_ctdt_dt foreign key (madethi) references dethi(madethi)
)
go

create table bailam(
	mabailam varchar(30) primary key,
	madethi int,
	masv varchar(20),
	ngaylam datetime,
	diem int,
	constraint pk_bl_sv foreign key(masv) references sinhVien(ma),
	constraint pk_bl_dt foreign key(madethi) references dethi(madethi)
)
go

create table ctbailam(
	mabailam varchar(30),
	mach int,
	thutuch int,
	traloi char,
	constraint pk_ctbl_bl foreign key(mabailam) references bailam(mabailam),
	constraint pk_ctbl_ch foreign key(mach) references cauHoi(mach)
)
go

-- 4
