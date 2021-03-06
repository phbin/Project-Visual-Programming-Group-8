create database RapChieuPhim
go
--drop database RapChieuPhim
use RapChieuPhim
go

set dateformat DMY
go

create table InfoStaff  -- Nhân viên
(
	ID varchar(50) primary key,
	FullName nvarchar(100) not null,
	DoB smalldatetime not null,
	Sex nvarchar(10) not null,
	Addr nvarchar(100),
	Phone VARCHAR(100),
	Email nvarchar(100),
	Avatar image,
	IDPersonal int not null unique, --cmnd/cccd
	stt int default 1

)
go

create table Account  -- Tài khoản
(
	UserName nvarchar(100) primary key,
	Pass nvarchar(1000) not null default 1,
	ID varchar(50) not null ,
	AccType int not null default 0, --1: admin, 0: staff
	constraint FK_Account_ID foreign key (ID) references dbo.InfoStaff(ID)
)
go

create table InfoCustomer  -- Khách hàng
(
	ID varchar(50) primary key,
	FullName nvarchar(100) not null,
	DoB smalldatetime not null,
	Addr nvarchar(100),
	Phone VARCHAR(100),
	IDPersonal bigint not null unique, --cmnd/cccd
	Points int -- điểm tích lũy
)
go

create table Movie  --Phim
(
	ID varchar(50) primary key,
	NameFilm nvarchar(100) not null,
	Descript nvarchar(1000), --mô tả
	TimeLimit int not null, --thời lượng
	DatePublic smalldatetime not null, 
	DateOut smalldatetime not null,
	Country nvarchar(50) not null,
	Director nvarchar(100),
	YearFilm int not null,
	Poster image
)
go


create table Room  --Phòng chiếu
(
	ID varchar(50) primary key,
	NameRoom nvarchar(100) not null
)
go

create table MovieKind  -- Thế loại/Genre
(
	ID varchar(50) primary key,
	TypeName nvarchar(100) not null,
	Descript nvarchar(100)
)
go

create table Classify -- Phân loại phim
(
	IDMovie varchar(50) not null,
	IDKind varchar(50) not null, --id thể loại
	constraint FK_Classify_IDMovie foreign key (IDMovie) references dbo.Movie(ID),
	constraint FK_Classify_IDKind foreign key (IDKind) references dbo.MovieKind(ID),
	constraint PK_Classify primary key(IDMovie,IDKind)
)
go


create table ShowTime  -- Lịch chiếu
(
	ID varchar(50) primary key,
	IDMovie varchar(50) not null,
	shTime smalldatetime not null, --thời gian chiếu
	IDRoom varchar(50) not null, -- phòng chiếu
	TicketPrice int not null,
	constraint FK_ShowTime_IDRoom foreign key (IDRoom) references dbo.Room(ID),
	constraint FK_ShowTime_IDMovie foreign key (IDMovie) references dbo.Movie(ID),
)
go

create table Seat  -- Ghế
(
	IDShowtime varchar(50),
	SeatName varchar(50),
	stt int default 0, --0: chưa đặt|1: đặt rồi|2: đang chọn
	IDCustomer varchar(50) default null,
	constraint FK_Seat_IDShowtime foreign key (IDShowtime) references dbo.ShowTime(ID),
	constraint FK_Seat_IDCustomer foreign key (IDCustomer) references dbo.InfoCustomer(ID),
)
go
create table FDCategory
(
	ID int identity primary key,
	NameCategory varchar(100) not null default N'No name'
)
go

create table FoodDrink
(
	ID int primary key,
	NameFD nvarchar(1000) not null default N'No name',
	IDCategory int not null,
	Price float not null default 0,
	Picture image,
	constraint FK_FoodDrink_IDCategory foreign key (IDCategory) references FDCategory(ID)
)
go

create table Bill
(
	ID int primary key,
	DateBooking smalldatetime not null default getdate(),
	stt int not null default 0 --1: Paid, 0: Unpaid
)
go

alter table bill 
add total int
go

alter table bill 
add IDStaff varchar(50)
go

alter table Bill with nocheck
add constraint FK_BillInfo_IDStaff foreign key (IDStaff) references InfoStaff(ID)
on delete cascade
go

create table TicketBill
(
	ID int identity primary key,
	IDStaff varchar(50),
	DateBooking smalldatetime not null default getdate(),
	price int,
)
go

alter table TicketBill with nocheck
add constraint FK_TikcetBill_IDStaff foreign key (IDStaff) references InfoStaff(ID)
on delete cascade
go
create table BillInfo
(
	ID int identity primary key,
	IDBill int not null,
	IDFoodDrink int not null,
	Num int not null default 0,
	constraint FK_BillInfo_IDBill foreign key (IDBill) references Bill(ID),
	constraint FK_BillInfo_IDFoodDrink foreign key (IDFoodDrink) references FoodDrink(ID)
)
go

---------------------------------------------------------------------------------------------------------------------
--auto id

--Đăng nhập
CREATE PROC USP_Login
@userName varchar(1000), @password varchar(1000)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND Pass = @password
END
GO

--Đổi mật khẩu
CREATE PROC USP_ChangePassword
@username varchar(100), @password varchar(1000), @newPass varchar(1000)
AS
BEGIN
	DECLARE @CheckPass int = 0
	SELECT @CheckPass = COUNT(*) FROM dbo.Account WHERE UserName = @username AND Pass = @password

	IF (@CheckPass = 1)
	BEGIN
		UPDATE dbo.Account SET Pass = @newPass WHERE UserName = @username
    END
END
GO

-- FORM ADMIN
CREATE PROC USP_InfoStaff -- thông tin nhân viên
AS
BEGIN
	SELECT acc.UserName AS [Username], acc.AccType AS [Loại tài khoản], info.ID AS [Mã nhân viên], info.FullName AS [Họ và tên], 
	info.DoB AS [Ngày sinh], info.Sex as [Giới tính], info.Phone AS [Số điện thoại], info.Email as [Email], info.IDPersonal AS [CMND/CCCD], info.Addr[Địa chỉ]
	FROM dbo.Account acc, dbo.InfoStaff info
	WHERE info.ID = acc.ID
END
GO



CREATE PROC USP_InsertAccount -- thêm tài khoản
@username NVARCHAR(100), @type INT, @id VARCHAR(50)
AS
BEGIN
	INSERT dbo.Account( UserName, Pass, AccType, ID )
	VALUES ( @username, '1', @type, @id )
END
GO

CREATE PROC USP_UpdateAccount  -- cập nhật tài khoản
@username NVARCHAR(100), @type INT
AS
BEGIN
	UPDATE dbo.Account 
	SET AccType = @type
	WHERE UserName = @username
END
GO

CREATE FUNCTION UF_ConvertFullName ( @strInput NVARCHAR(4000) ) -- chuyển đổi kí tự 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL 
		RETURN @strInput 
	IF @strInput = '' 
		RETURN @strInput 
	DECLARE @RT NVARCHAR(4000) 
	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) 
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
	DECLARE @COUNTER int 
	DECLARE @COUNTER1 int 
	SET @COUNTER = 1 
	WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN 
		SET @COUNTER1 = 1 
		WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
			BEGIN 
				IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
				BEGIN 
					IF @COUNTER=1 
						SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
					ELSE 
						SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
					BREAK 
				END 
				SET @COUNTER1 = @COUNTER1 +1 
			END 
		SET @COUNTER = @COUNTER +1 
	END 
		SET @strInput = replace(@strInput,' ','-') 
		RETURN @strInput 
END
GO

CREATE PROC USP_SearchStaff -- Tìm kiếm nhân viên theo tên
@fullname NVARCHAR(100)
AS
BEGIN
	SELECT acc.UserName AS [Username], acc.AccType AS [Loại tài khoản], info.ID AS [Mã nhân viên], info.FullName AS [Họ và tên], 
	info.DoB AS [Ngày sinh], info.Sex as [Giới tính], info.Phone AS [Số điện thoại], info.Email as [Email], info.IDPersonal AS [CMND/CCCD], info.Addr[Địa chỉ]
	FROM dbo.Account acc, dbo.InfoStaff info
	WHERE info.ID = acc.ID AND dbo.UF_ConvertFullName(info.FullName) LIKE N'%' + dbo.UF_ConvertFullName(@fullname) + N'%'
END
GO

 -- Doanh thu


--KHÁCH HÀNG
CREATE PROC USP_GetCustomer  -- lấy thông tin khách hàng
AS
BEGIN
	SELECT ID AS [Mã khách hàng], FullName AS [Họ và tên], DoB AS [Ngày sinh], Addr AS [Địa chỉ], Phone AS [Số điện thoại], IDPersonal AS [CMND/CCCD], Points AS [Điểm tích lũy]
	FROM dbo.InfoCustomer
END
GO

CREATE PROC USP_InsertCustomer  -- thêm khách hàng
@id VARCHAR(50), @name NVARCHAR(100), @dob smalldatetime, @addr NVARCHAR(100), @num VARCHAR(100), @idpersonal INT
AS
BEGIN
	INSERT dbo.InfoCustomer(ID, FullName, DoB, Addr, Phone, IDPersonal, Points)
	VALUES (@id, @name, @dob, @addr, @num, @idpersonal, 0)
END
GO

CREATE PROC USP_SearchCustomer  -- tìm kiếm khách hàng theo tên
@name NVARCHAR(100)
AS
BEGIN
	SELECT ID AS [Mã khách hàng], FullName AS [Họ và tên], DoB AS [Ngày sinh], Addr AS [Địa chỉ], Phone AS [Số điện thoại], IDPersonal AS [CMND/CCCD], Points AS [Điểm tích lũy]
	FROM dbo.InfoCustomer
	WHERE dbo.UF_ConvertFullName(FullName) LIKE N'%' + dbo.UF_ConvertFullName(@name) + N'%'
END
GO

--THỂ LOẠI
CREATE PROC USP_InsertGenre  
@id VARCHAR(50), @name NVARCHAR(100), @des NVARCHAR(100)
AS
BEGIN
	INSERT dbo.MovieKind(id, TypeName, Descript)
	VALUES  (@id, @name, @des)
END
GO


--PHIM
CREATE PROC USP_GetMovie 
AS
BEGIN
	SELECT id AS [ID], NameFilm AS [Tên phim], Descript AS [Mô tả], TimeLimit AS [Thời lượng], DatePublic AS [Ngày khởi chiếu], DateOut AS [Ngày kết thúc], Country AS [Sản xuất], Director AS [Đạo diễn], YearFilm AS [Năm sản xuất], Poster AS [Poster]
	FROM dbo.Movie
END
GO

CREATE PROC USP_GetGenreByMovie --thể loại theo từng phim
@id VARCHAR(50)
AS
BEGIN
SELECT distinct  ( SELECT  A.TypeName +', ' AS [text()]
            FROM (
	SELECT dbo.MovieKind.id, TypeName, dbo.MovieKind.Descript
	FROM dbo.Classify, dbo.MovieKind
	WHERE IDMovie = @id AND dbo.Classify.IDKind = dbo.MovieKind.ID) as A
            FOR XML PATH(''))[TypeName]
    , dbo.MovieKind.id, dbo.MovieKind.Descript
	FROM (
	SELECT dbo.MovieKind.id, TypeName, dbo.MovieKind.Descript
	FROM dbo. Classify, dbo.MovieKind
	WHERE IDMovie = @id AND dbo.Classify.IDKind = dbo.MovieKind.ID) as B, dbo.Classify, dbo.MovieKind
	WHERE IDMovie = @id AND dbo.Classify.IDKind = dbo.MovieKind.ID
END
GO

CREATE PROC USP_GetGenre --thể loại theo từng phim
@id VARCHAR(50)
AS
BEGIN
	SELECT dbo.MovieKind.id, TypeName, dbo.MovieKind.Descript
	FROM dbo. Classify, dbo.MovieKind
	WHERE IDMovie = @id AND dbo.Classify.IDKind = dbo.MovieKind.ID
END
GO

CREATE PROC USP_InsertMovie  -- Thêm phim
@id VARCHAR(50), @name NVARCHAR(100), @des NVARCHAR(1000), @time int, @dpublic smalldatetime, @dout smalldatetime, @country NVARCHAR(50), @dir NVARCHAR(100), @year INT, @poster IMAGE
AS
BEGIN
	INSERT dbo.Movie (id , NameFilm , Descript , TimeLimit , DatePublic , DateOut , Country , Director , YearFilm, Poster)
	VALUES (@id , @name , @des , @time , @dpublic , @dout , @country , @dir , @year, @poster)
END
GO

CREATE PROC USP_UpdateMovie  -- Cập nhật lại phim
@id VARCHAR(50), @name NVARCHAR(100), @des NVARCHAR(1000), @time int, @dpublic smalldatetime, @dout smalldatetime, @country NVARCHAR(50), @dir NVARCHAR(100), @year INT, @poster IMAGE
AS
BEGIN
	UPDATE dbo.Movie SET NameFilm = @name, Descript = @des, TimeLimit = @time, DatePublic = @dpublic, DateOut = @dout, Country = @country, Director = @dir, YearFilm = @year, Poster = @poster WHERE id = @id
END
GO


--LỊCH CHIẾU
CREATE PROC USP_GetShowtime
AS
BEGIN
	SELECT LC.id, P.NameFilm ,  LC.shTime ,  LC.IDRoom ,LC.TicketPrice 
	FROM dbo.ShowTime AS LC, Movie AS P
	where lc.idmovie=p.id
END
GO

CREATE PROC USP_GetShowtimeByRoom
@idPC varchar(50)
AS
BEGIN
	SELECT LC.id, P.NameFilm ,  LC.shTime ,  LC.IDRoom ,LC.TicketPrice 
	FROM dbo.ShowTime AS LC, Movie AS P
	where lc.idmovie=p.id and lc.IDRoom=@idPC
END
GO

GO
CREATE PROC USP_InsertShowtime -- thêm lịch chiếu
@id VARCHAR(50),@idmovie varchar(50), @thoiGianChieu smalldatetime, @idPhong VARCHAR(50), @price int
AS
BEGIN
	INSERT dbo.ShowTime( id , idmovie, shTime  , IDRoom , TicketPrice  )
	VALUES  ( @id , @idmovie , @thoiGianChieu  ,@idPhong, @price)
END
GO


CREATE PROC USP_UpdateShowtime -- cập nhật lịch chiếu
@id VARCHAR(50),@idmovie varchar(50), @thoiGianChieu smalldatetime, @idPhong VARCHAR(50)
AS
BEGIN
	UPDATE dbo.ShowTime 
	SET IDRoom = @idPhong,shTime = @thoiGianChieu, IDMovie=@idmovie
	WHERE id = @id
END
GO

CREATE PROC USP_SearchShowtimeByMovieName -- tìm các suất chiếu phim theo tên phim
@tenPhim NVARCHAR(100)
AS
BEGIN
	SELECT LC.id AS [Mã lịch chiếu], LC.IDRoom AS [Mã phòng], P.NameFilm AS [Tên phim], LC.shTime AS [Thời gian chiếu], LC.TicketPrice AS [Giá vé]
	FROM dbo.ShowTime AS LC, Movie AS P
	WHERE  lc.IDMovie = P.id  AND dbo.UF_ConvertFullName(P.NameFilm) LIKE N'%' + dbo.UF_ConvertFullName(@tenPhim) + N'%'
END
GO

CREATE PROC USP_InsertSeat
@id VARCHAR(50)
AS
BEGIN
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'A00')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'A01')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'A02')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'A03')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'A04')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'A05')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'A06')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'A07')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'A08')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'A09')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'A10')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'A11')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'B00')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'B01')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'B02')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'B03')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'B04')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'B05')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'B06')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'B07')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'B08')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'B09')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'B10')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'B11')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'C00')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'C01')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'C02')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'C03')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'C04')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'C05')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'C06')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'C07')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'C08')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'C09')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'C10')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'C11')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'D00')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'D01')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'D02')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'D03')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'D04')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'D05')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'D06')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'D07')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'D08')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'D09')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'D10')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'D11')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'E00')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'E01')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'E02')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'E03')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'E04')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'E05')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'E06')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'E07')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'E08')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'E09')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'E10')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'E11')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'F00')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'F01')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'F02')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'F03')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'F04')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'F05')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'F06')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'F07')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'F08')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'F09')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'F10')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'F11')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'G00')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'G01')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'G02')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'G03')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'G04')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'G05')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'G06')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'G07')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'G08')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'G09')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'G10')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'G11')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'H00')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'H01')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'H02')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'H03')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'H04')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'H05')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'H06')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'H07')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'H08')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'H09')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'H10')
	insert dbo.Seat([idshowtime],[SeatName]) values (@id,'H11')
END
GO
-- STAFF
CREATE PROC USP_GetStaff
AS
BEGIN
	SELECT id AS [Mã nhân viên], FullName AS [Họ tên], DoB AS [Ngày sinh], Sex as [Giới tính], Addr AS [Địa chỉ], Phone AS [SĐT], Email as [Email], IDPersonal AS [CMND]
	FROM dbo.InfoStaff
END
GO

CREATE PROC USP_InsertStaff
@idStaff VARCHAR(50), @hoTen NVARCHAR(100), @ngaySinh smalldatetime, @sex nvarchar(10), @diaChi NVARCHAR(100), @sdt VARCHAR(100), @email nvarchar(100), @cmnd INT
AS
BEGIN
	INSERT dbo.InfoStaff(id, FullName, DoB, Sex, Addr, Phone, Email, IDPersonal)
	VALUES (@idStaff, @hoTen, @ngaySinh, @sex, @diaChi, @sdt, @email, @cmnd)
END
GO

CREATE PROC USP_SearchStaffAsStaff -- tìm kiếm nhân viên với tư cách nhân viên (Form Main)
@hoTen NVARCHAR(100)
AS
BEGIN
	SELECT id AS [Mã nhân viên], FullName AS [Họ tên], DoB AS [Ngày sinh], Sex as [Giới tính], Addr AS [Địa chỉ], Phone AS [SĐT], Email as [Email], IDPersonal AS [CMND]
	FROM dbo.InfoStaff
	WHERE dbo.UF_ConvertFullName(FullName) LIKE N'%' + dbo.UF_ConvertFullName(@hoTen) + N'%'
END
GO

CREATE TRIGGER UTG_INSERT_CheckDateShowTime
ON dbo.ShowTime
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @ThoiGianChieu smalldatetime, @NgayKhoiChieu smalldatetime, @NgayKetThuc smalldatetime

	SELECT @ThoiGianChieu = CONVERT(smalldatetime, shTime) from INSERTED

	SELECT @NgayKhoiChieu = P.DatePublic, @NgayKetThuc = P.DateOut
	FROM dbo.Movie P, dbo.ShowTime 
	WHERE P.ID=ShowTime.IDMovie

	IF ( @ThoiGianChieu > @NgayKetThuc or @ThoiGianChieu < @NgayKhoiChieu)
	BEGIN
		ROLLBACK TRAN
		Raiserror('Lịch Chiếu lớn hơn hoặc bằng Ngày Khởi Chiếu và nhỏ hơn hoặc bằng Ngày Kết Thúc',16,1)
		Return
    END
END
GO
CREATE TRIGGER UTG_CheckTimeShowTime
ON dbo.ShowTime
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @count INT = 0, @count2 INT = 0, @ThoiGianChieu smalldatetime, @idPhong VARCHAR(50)

	SELECT @idPhong = IDRoom, @ThoiGianChieu = shTime from INSERTED

	SELECT @count = COUNT(*)
	FROM dbo.ShowTime LC, dbo.Movie P
	WHERE LC.IDRoom = @idPhong  AND IDMovie = P.id AND (@ThoiGianChieu >= LC.shTime AND @ThoiGianChieu <= DATEADD(MINUTE, P.TimeLimit, LC.shTime))

	SELECT @count2 = COUNT(*)
	FROM dbo.ShowTime LC,  dbo.Movie P
	WHERE @idPhong = LC.IDRoom AND IDMovie = P.id AND (LC.shTime >= @ThoiGianChieu AND LC.shTime <= DATEADD(MINUTE, P.TimeLimit, @ThoiGianChieu))

	IF (@count > 1 OR @count2 > 1)
	BEGIN
		ROLLBACK TRAN
		Raiserror('Thời Gian Chiếu đã trùng với một lịch chiếu khác cùng Phòng Chiếu',16,1)
		Return
	END
END
GO
-- BILL
CREATE PROC USP_InsertBill
@idBill INT, @idStaff VARCHAR
AS
BEGIN
	INSERT dbo.Bill (DateBooking , stt, Total, IDStaff)
	VALUES  (GETDATE(), 0, 0, @idStaff)
END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFD INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	DECLARE @price FLOAT
	DECLARE @value INT	

	SELECT @isExitsBillInfo = b.ID, @foodCount = b.num
	FROM dbo.BillInfo AS b
	WHERE idBill = @idBill AND IDFoodDrink = @idFD

	SELECT @price = FD.Price
	FROM dbo.FoodDrink FD
	WHERE FD.ID = @idFD

	SELECT @value = Total
	FROM dbo.Bill
	WHERE ID = @idBill

	IF (@isExitsBillInfo > 0)
	BEGIN
		UPDATE dbo.BillInfo	SET num = @foodCount + @count WHERE IDFoodDrink = @idFD
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo (idBill, IDFoodDrink, num) VALUES  (@idBill, @idFD, @count)
	END

	UPDATE dbo.Bill SET Total = @value + @price * @count WHERE ID = @idBill
END
GO

CREATE PROC USP_DeleteBillInfo
@idBill INT, @idFD INT
AS
BEGIN
	DECLARE @count INT
	DECLARE @price FLOAT
	DECLARE @value INT	
	DECLARE @isExitsFD INT = 0

	SELECT @isExitsFD = b.IDFoodDrink, @count = b.num
	FROM dbo.BillInfo AS b
	WHERE idBill = @idBill AND IDFoodDrink = @idFD

	SELECT @price = FD.Price
	FROM dbo.FoodDrink FD
	WHERE FD.ID = @idFD

	SELECT @value = Total
	FROM dbo.Bill
	WHERE ID = @idBill

	IF (@isExitsFD > 0)
	BEGIN
	DELETE FROM BillInfo WHERE IDBill = @idBill AND IDFoodDrink = @idFD
	UPDATE dbo.Bill SET Total = @value - @price * @count WHERE ID = @idBill
	END
END
GO

CREATE TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = idBill FROM Inserted
	
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill
	
	IF (@count > 0)
	BEGIN
	
		PRINT @idBill
		PRINT @count
			
	END		
	ELSE
	BEGIN
		PRINT @idBill
		PRINT @count
	end
	
END
GO


CREATE TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	
	SELECT @idBill = id FROM Inserted	
END
GO

-- thêm category
INSERT dbo.FDCategory
        ( NameCategory )
VALUES  ( N'Fastfood' ) 
INSERT dbo.FDCategory
        ( NameCategory )
VALUES  ( N'Drink' )
INSERT dbo.FDCategory
        ( NameCategory )
VALUES  ( N'Combo' )
GO


INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL01', N'Hành động', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL02', N'Hoạt hình', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL03', N'Hài kịch', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL04', N'Khoa học viễn tưởng', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL05', N'Phiêu lưu', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL06', N'Gia đình', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL07', N'Tình cảm', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL08', N'Trinh thám', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL09', N'Tâm lý', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL10', N'Siêu nhiên', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL11', N'Tài liệu', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL12', N'Kinh dị', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL13', N'Thể thao', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL14', N'Âm nhạc và nhạc kịch', NULL)
GO

INSERT dbo.InfoStaff ([id], [FullName], [DoB], [Sex], [Addr], [Phone], [Email], [IDPersonal]) VALUES (N'AD00', N'Admin', N'03/02/2002',N'Nữ', N'Q3, HCM', N'0393751403',N'renyuiko.hamyana@gmail.com', 272907024)
GO

INSERT dbo.Account ([UserName], [Pass], [id], [AccType]) VALUES ('admin', 'CnGLPo9sFdg=', 'AD00', 1)
GO



INSERT dbo.Room VALUES (N'PC01', N'CINEMA 01')
INSERT dbo.Room VALUES (N'PC02', N'CINEMA 02')
INSERT dbo.Room VALUES (N'PC03', N'CINEMA 03')
Go
