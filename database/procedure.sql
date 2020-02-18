use thiTracNghiem
go

-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

-- tai khoan dang nhap
CREATE PROCEDURE checkLoginSv
	-- Add the parameters for the stored procedure here
	@username nvarchar(20),
	@password nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select count(*) from sinhVien where ma = @username and matkhau = @password
END
GO

CREATE PROCEDURE checkLoginGv
	-- Add the parameters for the stored procedure here
	@username nvarchar(20),
	@password nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select count(*) from giaoVien where ma = @username and matkhau = @password
END
GO

-- thao tac voi cau hoi

CREATE PROCEDURE delQuiz
	@idQuiz int
AS
BEGIN
	delete from cauHoi where mach = @idQuiz
END
GO

CREATE PROCEDURE addQuiz
	@nd nvarchar(1000),
	@level nvarchar(10),
	@dateCre date,
	@idThem int,
	@idTeach varchar(20),
	@a nvarchar(100),
	@b nvarchar(100),
	@c nvarchar(100),
	@d nvarchar(100),
	@dapan nvarchar(100)
AS
BEGIN
	insert into cauHoi (noidung,dokho,ngaytao,machude,magv,a,b,c,d,dapan)
	values(@nd ,@level ,@dateCre ,@idThem ,@idTeach ,@a ,@b ,@c ,@d , @dapan)

END
GO

CREATE PROCEDURE addExam
	@mkt int,
	@mamon varchar(15),
	@socau int
AS
BEGIN
	insert into dethi(makythi, mamon,socau)
	values(@mkt ,@mamon ,@socau);

	insert into ctdethi(mach,madethi)
	select top 30 mach,'2',dokho from cauHoi 
	where mach in (select top 20 mach from cauHoi where dokho = 'easy' order by newid()) 
	or mach in (select top 8 mach from cauHoi where dokho = 'medium' order by newid()) 
	or mach in (select top 2 mach from cauHoi where dokho = 'hard' order by newid())
END
GO

--sinhVien
CREATE PROCEDURE addsinhVien
	@ma varchar(20),
	@tensv nvarchar(100),
	@matkhau varchar(20),
	@ngaysinh date,
	@email varchar(50),
	@lop varchar(25)
AS
BEGIN
	insert into sinhVien values(@ma,@tensv,@matkhau,@ngaysinh,@email,@lop)
END
GO

CREATE PROCEDURE delsinhVien
	@ma varchar(20)
AS
BEGIN
	delete from sinhVien where masv = @ma
END
GO

CREATE PROCEDURE editsinhVien
	@ma varchar(20),
	@tensv nvarchar(100),
	@matkhau varchar(20),
	@ngaysinh date,
	@email varchar(50),
	@lop varchar(25)
AS
BEGIN
	update sinhVien set ten_sv=@tensv,mat_khau=@matkhau,ngay_sinh=@ngaysinh,email_sv=@email,lop_sv=@lop where masv=@ma
END
GO

--khoa
CREATE PROCEDURE addkhoa
	@makhoa varchar(15),
	@tenkhoa nvarchar(100)
AS
BEGIN
	insert into khoa values(@makhoa,@tenkhoa)
END
GO

CREATE PROCEDURE delkhoa
	@makhoa varchar(15)
AS
BEGIN
	delete from khoa where ma_khoa = @makhoa
END
GO

CREATE PROCEDURE editkhoa
	@makhoa varchar(15),
	@tenkhoa nvarchar(100)
AS
BEGIN
	update khoa set ten_khoa=@tenkhoa where  ma_khoa=@makhoa
END
GO

--giaoVien
CREATE PROCEDURE addgiaoVien
	@ma varchar(20),
	@tengv nvarchar(100),
	@matkhau varchar(20),
	@ngaysinh date,
	@email varchar(50),
	@makhoa varchar(15)
AS
BEGIN
	insert into giaoVien values(@ma,@tengv,@matkhau,@ngaysinh,@email,@makhoa)
END
GO

CREATE PROCEDURE delgiaoVien
	@ma varchar(20)
AS
BEGIN
	delete from giaoVien where magv = @ma
END
GO	

CREATE PROCEDURE editgiaoVien
	@ma varchar(20),
	@tengv nvarchar(100),
	@matkhau varchar(20),
	@ngaysinh date,
	@email varchar(50),
	@makhoa varchar(15)
AS
BEGIN
	update giaoVien set ten_gv=@tengv, mat_khau=@matkhau, ngay_sinh=@ngaysinh, email_gv=@email, ma_khoa=@makhoa where magv=@ma
END
GO

--monHoc
CREATE PROCEDURE addmonHoc
	@mamon varchar(15),
	@makhoa varchar(15),
	@tenmon varchar(50)
AS
BEGIN
	insert into monHoc values(@mamon,@makhoa,@tenmon)
END
GO

CREATE PROCEDURE delmonHoc
	@mamon varchar(15)
AS
BEGIN
	delete from monHoc where ma_mon=@mamon
END
GO

CREATE PROCEDURE editmonHoc
	@mamon varchar(15),
	@makhoa varchar(15),
	@tenmon varchar(50)
AS
BEGIN
	update monHoc set ma_khoa=@makhoa,ten_mon=@tenmon where ma_mon=@mamon
END
GO

