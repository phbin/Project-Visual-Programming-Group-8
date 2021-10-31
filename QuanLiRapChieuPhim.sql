create database QuanLiRapChieuPhim
go

use QuanLiRapChieuPhim
go

set dateformat DMY
go
--Account
--Movie
--Ticket
--FDCategory
--Food&Drink
--Bill


create table Account  -- Tài khoản
(
	UserName nvarchar(100) primary key,
	Pass nvarchar(1000) not null default 1,
	ID varchar(50) not null ,
	AccType int not null default 0, --1: admin, 0: staff
	constraint FK_Account_ID foreign key (ID) references dbo.InfoStaff(ID)
)
go

create table InfoStaff  -- Nhân viên
(
	ID varchar(50) primary key,
	FullName nvarchar(100) not null,
	DoB date not null,
	Addr nvarchar(100),
	Phone VARCHAR(100),
	IDPersonal int not null unique --cmnd/cccd
)
go

create table InfoCustomer  -- Khách hàng
(
	ID varchar(50) primary key,
	FullName nvarchar(100) not null,
	DoB date not null,
	Addr nvarchar(100),
	Phone VARCHAR(100),
	IDPersonal int not null unique, --cmnd/cccd
	Points int -- điểm tích lũy
)
go

create table Movie  --Phim
(
	ID varchar(50) primary key,
	NameFilm nvarchar(100) not null,
	Descript nvarchar(1000), --mô tả
	TimeLimit float not null, --thời lượng
	DatePublic date not null, 
	DateOut date not null,
	Country nvarchar(50) not null,
	Director nvarchar(100),
	YearFilm int not null,
	Poster image
)
go

create table ScreenType -- loại màn hình
(
	ID varchar(50) primary key,
	ScreenName nvarchar(100) --2D || 3D || 4D
)
go

create table Room  --Phòng chiếu
(
	ID varchar(50) primary key,
	NameRoom nvarchar(100) not null,
	IDScreen varchar(50),
	NumOfSeat int not null,
	Stt int not null default 1, -- 0: không hoạt động, 1: đang hoạt động
	RowOfSeat int not null, --số hàng ghế 
	SeatOfRow int not null, --số ghế của 1 hàng
	constraint FK_Room_IDScreen foreign key (IDScreen) references dbo.ScreenType(ID)
)
go

create table FormatFilm --Định dạng phim | hỗ trợ 3D hay không?
(
	ID varchar(50) not null primary key,
	IDMovie varchar(50) not null,
	IDScreenType varchar(50) not null,
	constraint FK_FormatFilm_IDMovie foreign key (IDMovie) references dbo.Movie(ID),
	constraint FK_FormatFilm_IDScreenType foreign key (IDScreenType) references dbo.ScreenType(ID)
)
go

create table MovieKind  -- Thế loại
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
	shTime datetime not null, --thời gian chiếu
	IDRoom varchar(50) not null, -- phòng chiếu
	IDFormat varchar(50) not null, --định dạng phim
	TicketPrice money not null,
	stt int not null default '0', --0: Chưa tạo vé cho lịch chiếu || 1: Đã tạo vé
	constraint FK_ShowTime_IDKind foreign key (IDRoom) references dbo.Room(ID),
	constraint FK_ShowTime_IDFormat foreign key (IDFormat) references dbo.FormatFilm(ID)
)
go

create table Ticket -- Vé
(
	ID int identity(1,1) primary key,
	TicketType int default '0', --0: Vé người lớn || 1: Vé học sinh - sinh viên || 2: vé trẻ em
	IDShowTime varchar(50),
	SeatCode varchar(50),
	IDCustomer varchar(50),
	stt int not null default '0', --0: 'Chưa Bán' || 1: 'Đã Bán'
	TicketPrice money default '0',
	constraint FK_Ticket_IDShowTime foreign key (IDShowTime) references dbo.ShowTime(ID),
	constraint FK_Ticket_IDCustomer foreign key (IDCustomer) references dbo.InfoCustomer(ID)
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
	ID int identity primary key,
	NameFD nvarchar(1000) not null default N'No name',
	IDCategory int not null,
	Price float not null default 0,
	Picture image,
	constraint FK_FoodDrink_IDCategory foreign key (IDCategory) references FDCategory(ID)
)
go

create table Bill
(
	ID int identity primary key,
	DateBooking date not null default getdate(),
	stt int not null default 0 --1: Paid, 0: Unpaid
)
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
	info.DoB AS [Ngày sinh], info.Phone AS [Số điện thoại], info.IDPersonal AS [CMND/CCCD], info.Addr[Địa chỉ]
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
	info.DoB AS [Ngày sinh], info.Phone AS [Số điện thoại], info.IDPersonal AS [CMND/CCCD], info.Addr[Địa chỉ]
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
@id VARCHAR(50), @name NVARCHAR(100), @dob date, @addr NVARCHAR(100), @num VARCHAR(100), @idpersonal INT
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


--LOẠI MÀN HÌNH
CREATE PROC USP_InsertScreenType
@id VARCHAR(50), @name NVARCHAR(100)
AS
BEGIN
	INSERT dbo.ScreenType( id, ScreenName )
	VALUES  (@id, @name)
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

CREATE PROC USP_GetClassify 
@id VARCHAR(50)
AS
BEGIN
	SELECT dbo.MovieKind.id, TypeName, dbo.MovieKind.Descript
	FROM dbo. Classify, dbo.MovieKind
	WHERE ID = @id AND dbo. Classify.IDKind = dbo.MovieKind.ID
END
GO

CREATE PROC USP_InsertMovie  -- Thêm phim
@id VARCHAR(50), @name NVARCHAR(100), @des NVARCHAR(1000), @time FLOAT, @dpublic DATE, @dout DATE, @country NVARCHAR(50), @dir NVARCHAR(100), @year INT, @poster IMAGE
AS
BEGIN
	INSERT dbo.Movie (id , NameFilm , Descript , TimeLimit , DatePublic , DateOut , Country , Director , YearFilm, Poster)
	VALUES (@id , @name , @des , @time , @dpublic , @dout , @country , @dir , @year, @poster)
END
GO

CREATE PROC USP_UpdateMovie  -- Cập nhật lại phim
@id VARCHAR(50), @name NVARCHAR(100), @des NVARCHAR(1000), @time FLOAT, @dpublic DATE, @dout DATE, @country NVARCHAR(50), @dir NVARCHAR(100), @year INT, @poster IMAGE
AS
BEGIN
	UPDATE dbo.Movie SET NameFilm = @name, Descript = @des, TimeLimit = @time, DatePublic = @dpublic, DateOut = @dout, Country = @country, Director = @dir, YearFilm = @year, Poster = @poster WHERE id = @id
END
GO

--ĐỊNH DẠNG PHIM
CREATE PROC USP_GetFormatMovie 
AS
BEGIN
	SELECT dbo.FormatFilm.ID AS [Mã định dạng], dbo.Movie.id AS [Mã phim], dbo.Movie.NameFilm AS [Tên phim], dbo.ScreenType.id AS [Mã màn hình], dbo.ScreenType.ScreenName AS [Tên màn hình]
	FROM dbo.FormatFilm, dbo.Movie, dbo.ScreenType
	WHERE dbo.FormatFilm.IDMovie = dbo.Movie.id AND dbo.FormatFilm.IDScreenType = dbo.ScreenType.id
END
GO

CREATE PROC USP_InsertFormatMovie  -- Thêm định dạng
@id VARCHAR(50), @idmovie VARCHAR(50), @idscr VARCHAR(50)
AS
BEGIN
	INSERT dbo.FormatFilm( id, IDMovie, IDScreenType )
	VALUES  ( @id, @idmovie, @idscr )
END
GO


--LỊCH CHIẾU
CREATE PROC USP_GetListShowTimesByFormatMovie
@ID varchar(50), @Date Datetime
AS
BEGIN
	select sched.id, rm.NameRoom, mv.NameFilm, sched.shTime, fmat.id as idFormat, sched.TicketPrice, sched.stt
	from Movie mv ,FormatFilm fmat, ShowTime sched, Room rm
	where mv.id = fmat.IDMovie and fmat.id = sched.IDFormat and sched.IDRoom = rm.id
	and fmat.id = @ID and CONVERT(DATE, @Date) = CONVERT(DATE, sched.shTime)
	order by sched.shTime
END
GO

CREATE PROC USP_GetShowtime
AS
BEGIN
	SELECT LC.id AS [Mã lịch chiếu], LC.IDRoom AS [Mã phòng], P.NameFilm AS [Tên phim], MH.ScreenName AS [Màn hình], LC.shTime AS [Thời gian chiếu], LC.TicketPrice AS [Giá vé]
	FROM dbo.ShowTime AS LC, dbo.FormatFilm AS DD, Movie AS P, dbo.ScreenType AS MH
	WHERE LC.IDFormat = DD.id AND DD.IDMovie = P.id AND DD.IDScreenType = MH.id
END
GO

CREATE PROC USP_InsertShowtime -- thêm lịch chiếu
@id VARCHAR(50), @idPhong VARCHAR(50), @idDinhDang VARCHAR(50), @thoiGianChieu DATETIME, @giaVe FLOAT
AS
BEGIN
	INSERT dbo.ShowTime( id , IDRoom , IDFormat, shTime  , TicketPrice , stt )
	VALUES  ( @id , @idPhong , @idDinhDang, @thoiGianChieu  , @giaVe , 0 )
END
GO

CREATE PROC USP_UpdateShowtime -- cập nhật lịch chiếu
@id VARCHAR(50), @idPhong VARCHAR(50), @idDinhDang VARCHAR(50), @thoiGianChieu DATETIME, @giaVe FLOAT
AS
BEGIN
	UPDATE dbo.ShowTime 
	SET IDRoom = @idPhong, IDFormat = @idDinhDang, shTime = @thoiGianChieu , TicketPrice = @giaVe
	WHERE id = @id
END
GO

CREATE PROC USP_SearchShowtimeByMovieName -- tìm các suất chiếu phim theo tên phim
@tenPhim NVARCHAR(100)
AS
BEGIN
	SELECT LC.id AS [Mã lịch chiếu], LC.IDRoom AS [Mã phòng], P.NameFilm AS [Tên phim], MH.ScreenName AS [Màn hình], LC.shTime AS [Thời gian chiếu], LC.TicketPrice AS [Giá vé]
	FROM dbo.ShowTime AS LC, dbo.FormatFilm AS DD, Movie AS P, dbo.ScreenType AS MH
	WHERE LC.IDFormat = DD.id AND DD.IDMovie = P.id AND DD.IDScreenType = MH.id AND dbo.UF_ConvertFullName(P.NameFilm) LIKE N'%' + dbo.UF_ConvertFullName(@tenPhim) + N'%'
END
GO

CREATE PROC USP_GetAllListShowTimes -- hiển thị danh sách lịch chiếu
AS
BEGIN
	select l.id, pc.NameRoom, p.NameFilm, l.shTime, d.id as idFormat, l.TicketPrice, l.stt
	from Movie p , FormatFilm d, ShowTime l, Room pc
	where p.id = d.IDMovie and d.id = l.idFormat and l.IDRoom = pc.id
	order by l.shTime
END
GO

CREATE PROC USP_GetListShowTimesNotCreateTickets -- hiển thị danh sách lịch chiếu chưa tạo vé để bán
AS
BEGIN
	select l.id, pc.NameRoom, p.NameFilm, l.shTime, d.id as idFormat, l.TicketPrice, l.stt
	from Movie p ,FormatFilm d, ShowTime l, Room pc
	where p.id = d.IDMovie and d.id = l.idFormat and l.IDRoom = pc.id and l.stt = 0
	order by l.shTime
END
GO

create PROC USP_UpdateStatusShowTimes -- cập nhật lịch chiếu
@idLichChieu NVARCHAR(50), @status int
AS
BEGIN
	UPDATE dbo.ShowTime
	SET stt = @status
	WHERE id = @idLichChieu
END
GO

-- STAFF
CREATE PROC USP_GetStaff
AS
BEGIN
	SELECT id AS [Mã nhân viên], FullName AS [Họ và tên], DoB AS [Ngày sinh], Addr AS [Địa chỉ], Phone AS [Số điện thoại], IDPersonal AS [CMND/CCCD]
	FROM dbo.InfoStaff
END
GO

CREATE PROC USP_InsertStaff
@idStaff VARCHAR(50), @hoTen NVARCHAR(100), @ngaySinh date, @diaChi NVARCHAR(100), @sdt VARCHAR(100), @cmnd INT
AS
BEGIN
	INSERT dbo.InfoStaff(id, FullName, DoB, Addr, Phone, IDPersonal)
	VALUES (@idStaff, @hoTen, @ngaySinh, @diaChi, @sdt, @cmnd)
END
GO

CREATE PROC USP_SearchStaffAsStaff -- tìm kiếm nhân viên với tư cách nhân viên (Form Main)
@hoTen NVARCHAR(100)
AS
BEGIN
	SELECT id AS [Mã nhân viên], FullName AS [Họ tên], DoB AS [Ngày sinh], Addr AS [Địa chỉ], Phone AS [SĐT], IDPersonal AS [CMND]
	FROM dbo.InfoStaff
	WHERE dbo.UF_ConvertFullName(FullName) LIKE N'%' + dbo.UF_ConvertFullName(@hoTen) + N'%'
END
GO


--PHÒNG CHIẾU
CREATE PROC USP_GetRoom 
AS
BEGIN
	SELECT PC.id AS [Mã phòng], NameRoom AS [Tên phòng], ScreenName AS [Tên màn hình], PC.NumOfSeat AS [Số chỗ ngồi], PC.stt AS [Tình trạng], PC.RowOfSeat AS [Số hàng ghế], PC.SeatOfRow AS [Ghế mỗi hàng]
	FROM dbo.Room AS PC, dbo.ScreenType AS MH
	WHERE PC.IDScreen = MH.id
END
GO

CREATE PROC USP_InsertCinema
@idCinema VARCHAR(50), @tenPhong NVARCHAR(100), @idMH VARCHAR(50), @soChoNgoi INT, @tinhTrang INT, @soHangGhe INT, @soGheMotHang INT
AS
BEGIN
	INSERT dbo.Room( id , NameRoom , IDScreen , NumOfSeat , Stt , RowOfSeat , SeatOfRow)
	VALUES (@idCinema , @tenPhong , @idMH , @soChoNgoi , @tinhTrang , @soHangGhe , @soGheMotHang)
END
GO


--VÉ
CREATE PROC USP_InsertTicketByShowTimes
@idlichChieu VARCHAR(50), @maGheNgoi VARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Ticket
	(
		id,
		SeatCode,
		IDCustomer
	)
	VALUES
	(
		@idlichChieu,
		@maGheNgoi,
		NULL
	)
END
GO

CREATE PROC USP_DeleteTicketsByShowTimes -- xóa vé sau khi bán
@idlichChieu VARCHAR(50)
AS
BEGIN
	DELETE FROM dbo.Ticket
	WHERE ID = @idlichChieu
END
GO

CREATE TRIGGER UTG_INSERT_CheckDateShowTime
ON dbo.ShowTime
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idDinhDang VARCHAR(50), @ThoiGianChieu DATE, @NgayKhoiChieu DATE, @NgayKetThuc DATE

	SELECT @idDinhDang = IDFormat, @ThoiGianChieu = CONVERT(DATE, shTime) from INSERTED

	SELECT @NgayKhoiChieu = P.DatePublic, @NgayKetThuc = P.DateOut
	FROM dbo.Movie P, dbo.FormatFilm DD
	WHERE @idDinhDang = DD.id AND DD.IDMovie = P.id

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
	DECLARE @count INT = 0, @count2 INT = 0, @ThoiGianChieu DATETIME, @idPhong VARCHAR(50), @idDinhDang VARCHAR(50)

	SELECT @idPhong = IDRoom, @ThoiGianChieu = shTime, @idDinhDang = Inserted.IDFormat from INSERTED

	SELECT @count = COUNT(*)
	FROM dbo.ShowTime LC, dbo.FormatFilm DD, dbo.Movie P
	WHERE LC.IDRoom = @idPhong AND LC.IDFormat = DD.id AND DD.IDMovie = P.id AND (@ThoiGianChieu >= LC.shTime AND @ThoiGianChieu <= DATEADD(MINUTE, P.TimeLimit, LC.shTime))

	SELECT @count2 = COUNT(*)
	FROM dbo.ShowTime LC, dbo.FormatFilm DD, dbo.Movie P
	WHERE @idPhong = LC.IDRoom AND @idDinhDang = DD.id AND DD.IDMovie = P.id AND (LC.shTime >= @ThoiGianChieu AND LC.shTime <= DATEADD(MINUTE, P.TimeLimit, @ThoiGianChieu))

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
@idTable INT
AS
BEGIN
	INSERT dbo.Bill 
	        ( DateBooking,
	          stt
	        )
	VALUES  ( GETDATE() , 
	          0
	        )
END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFD INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.num 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND IDFoodDrink = @idFD

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET num = @foodCount + @count WHERE IDFoodDrink = @idFD
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND IDFoodDrink = @idFD
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, IDFoodDrink, num )
		VALUES  ( @idBill, -- idBill - int
          @idFD, -- idFood - int
          @count  -- count - int
          )
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

-- thêm món ăn
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'BỎNG CARAMEL NHỎ', -- name - nvarchar(100)
          1, -- idCategory - int
          35000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'BỎNG CARAMEL LỚN', 1, 45000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'BỎNG THƯỜNG NHỎ', 1, 30000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'BỎNG THƯỜNG LỚN', 1, 40000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'BỎNG PHÔ MAI NHỎ', 1, 35000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'BỎNG PHÔ MAI LỚN', 1, 45000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'HAMBURGER GÀ', 1, 35000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'HAMBURGER BÒ', 1, 40000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'KHOAI TÂY CHIÊN', 1, 25000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'MÌ Ý BÒ BẰM', 1, 58000)
-- thêm nước
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'PEPSI/MIRINDA/7UP', 2, 25000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'MILO', 2, 30000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'NESTEA', 2, 25000)
GO
-- combo
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'1 PEPSI 1 BỎNG LỚN TÙY CHỌN', 3, 49000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'2 PEPSI 1 BỎNG LỚN TÙY CHỌN', 3, 69000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'1 MILO 1 BỎNG LỚN TÙY CHỌN', 3, 53000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'1 PEPSI 1 KHOAI', 3, 39000)
INSERT dbo.FoodDrink
        ( NameFD, idCategory, price )
VALUES  ( N'1 PEPSI 1 HAMBURGER 1 KHOAI', 3, 73000)
GO

-- thêm bill
INSERT	dbo.Bill
        ( DateBooking ,
          stt
        )
VALUES  ( GETDATE() , -- date
		  0 -- status - int
        )

INSERT	dbo.Bill
        ( DateBooking ,
          stt
        )
VALUES  ( GETDATE() , -- date
		  1 -- status - int
        )
GO

-- thêm bill info
INSERT	dbo.BillInfo
        ( idBill, IDFoodDrink, num )
VALUES  ( 2, -- idBill - int
          1, -- idFood - int
          1  -- num - int
          )
INSERT	dbo.BillInfo
        ( idBill, IDFoodDrink, num )
VALUES  ( 2, -- idBill - int
          11, -- idFood - int
          2  -- count - int
          )
GO


INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL01', N'Hành động', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL02', N'Hoạt hình', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL03', N'Hài kịch', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL04', N'Khoa học viễn Tưởng', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL05', N'Phiêu lưu', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL06', N'Gia đình', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL07', N'Tình cảm', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL08', N'Trinh thám', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL09', N'Tâm Lý', NULL)
INSERT dbo.MovieKind ([id], [TypeName], [Descript]) VALUES (N'TL10', N'Siêu nhiên', NULL)

INSERT dbo.InfoStaff ([id], [FullName], [DoB], [Addr], [Phone], [IDPersonal]) VALUES (N'AD00', N'Admin', CAST(N'2002-02-03' AS Date), N'Q3, HCM', 0393751400, 23232323)
INSERT dbo.InfoStaff ([id], [FullName], [DoB], [Addr], [Phone], [IDPersonal]) VALUES (N'NV00', N'Staff 1', CAST(N'2002-02-03' AS Date), N'Q3, HCM', 0393751111, 11111111)
INSERT dbo.InfoStaff ([id], [FullName], [DoB], [Addr], [Phone], [IDPersonal]) VALUES (N'NV01', N'Staff 2', CAST(N'2000-04-11' AS Date), N'Đồng Nai', 097971210, 22222222)

INSERT dbo.Account ([UserName], [Pass], [id], [AccType]) VALUES ('admin', '123456', 'AD00', 1)
INSERT dbo.Account ([UserName], [Pass], [id], [AccType]) VALUES ('bin', '1', 'NV00', 0)
INSERT dbo.Account ([UserName], [Pass], [id], [AccType]) VALUES ('neyu', '1', 'NV01', 0)

INSERT dbo.InfoCustomer ([id], [FullName], [DoB], [Addr], [Phone], [IDPersonal], [Points]) VALUES (N'KH01', N'Huỳnh Thế Vĩ', CAST(N'2002-03-23' AS Date),N'HCM', N'0922135412', 123456789, 10)
INSERT dbo.InfoCustomer ([id], [FullName], [DoB], [Addr], [Phone], [IDPersonal], [Points]) VALUES (N'KH02', N'Nguyễn Minh', CAST(N'1999-05-11' AS Date),N'HCM', N'0210521423', 987654321, 0)
INSERT dbo.InfoCustomer ([id], [FullName], [DoB], [Addr], [Phone], [IDPersonal], [Points]) VALUES (N'KH03', N'Lê Đặng Phương Uyên', CAST(N'2002-02-03' AS Date),N'HCM', N'0379345121', 01245789, 0)

INSERT dbo.ScreenType ([id], [ScreenName]) VALUES (N'MH01', N'2D')
INSERT dbo.ScreenType ([id], [ScreenName]) VALUES (N'MH02', N'3D')
INSERT dbo.ScreenType ([id], [ScreenName]) VALUES (N'MH03', N'4D')
INSERT dbo.ScreenType ([id], [ScreenName]) VALUES (N'MH04', N'4DX')

INSERT dbo.Room VALUES (N'PC01', N'CINEMA 01', N'MH01', 180, 1, 12, 15)
INSERT dbo.Room VALUES (N'PC02', N'CINEMA 02', N'MH01', 180, 1, 12, 15)
INSERT dbo.Room VALUES (N'PC03', N'CINEMA 03', N'MH02', 130, 1, 10, 13)
INSERT dbo.Room VALUES (N'PC04', N'CINEMA 04', N'MH03', 104, 1, 8, 13)

INSERT dbo.Movie ([id], [NameFilm], [Descript], [TimeLimit], [DatePublic], [DateOut], [Country], [Director], [YearFilm]) VALUES (N'MV01', N'HARRY POTTER VÀ BẢO BỐI TỬ THẦN',N'Chưa có', 133, CAST(N'2021-04-10' AS Date), CAST(N'2021-05-31' AS Date), N'Anh', N'David Yates', 2021)
INSERT dbo.Movie ([id], [NameFilm], [Descript], [TimeLimit], [DatePublic], [DateOut], [Country], [Director], [YearFilm]) VALUES (N'MV02', N'THÁM TỬ LỪNG DANH CONAN: VIÊN ĐẠN ĐỎ', N'Chưa có', 111, CAST(N'2021-04-23' AS Date), CAST(N'2021-06-01' AS Date), N'Nhật Bản', N'Tomoka Nagaoka', 2021)
INSERT dbo.Movie ([id], [NameFilm], [Descript], [TimeLimit], [DatePublic], [DateOut], [Country], [Director], [YearFilm]) VALUES (N'MV03', N'VENOM: ĐỐI MẶT TỬ THÙ', N'Chưa có', 120, CAST(N'2021-11-12' AS Date), CAST(N'2021-12-31' AS Date), N'Mỹ', N'Andy Serkis', 2021)

INSERT dbo.Classify ([IDMovie], [IDKind]) VALUES (N'MV01', N'TL01')
INSERT dbo.Classify ([IDMovie], [IDKind]) VALUES (N'MV01', N'TL04')
INSERT dbo.Classify ([IDMovie], [IDKind]) VALUES (N'MV01', N'TL05')
INSERT dbo.Classify ([IDMovie], [IDKind]) VALUES (N'MV01', N'TL06')
INSERT dbo.Classify ([IDMovie], [IDKind]) VALUES (N'MV02', N'TL01')
INSERT dbo.Classify ([IDMovie], [IDKind]) VALUES (N'MV02', N'TL02')
INSERT dbo.Classify ([IDMovie], [IDKind]) VALUES (N'MV02', N'TL07')
INSERT dbo.Classify ([IDMovie], [IDKind]) VALUES (N'MV02', N'TL08')
INSERT dbo.Classify ([IDMovie], [IDKind]) VALUES (N'MV03', N'TL01')
INSERT dbo.Classify ([IDMovie], [IDKind]) VALUES (N'MV03', N'TL04')
INSERT dbo.Classify ([IDMovie], [IDKind]) VALUES (N'MV03', N'TL05')

INSERT dbo.FormatFilm([id], [IDMovie], [IDScreenType]) VALUES (N'F01', N'MV01', N'MH01')
INSERT dbo.FormatFilm([id], [IDMovie], [IDScreenType]) VALUES (N'F02', N'MV01', N'MH04')
INSERT dbo.FormatFilm([id], [IDMovie], [IDScreenType]) VALUES (N'F03', N'MV02', N'MH01')
INSERT dbo.FormatFilm([id], [IDMovie], [IDScreenType]) VALUES (N'F04', N'MV02', N'MH03')
INSERT dbo.FormatFilm([id], [IDMovie], [IDScreenType]) VALUES (N'F05', N'MV02', N'MH01')
INSERT dbo.FormatFilm([id], [IDMovie], [IDScreenType]) VALUES (N'F06', N'MV03', N'MH02')
INSERT dbo.FormatFilm([id], [IDMovie], [IDScreenType]) VALUES (N'F07', N'MV03', N'MH01')

INSERT dbo.ShowTime([id], [shTime], [IDRoom], [IDFormat], [TicketPrice], [stt]) VALUES (N'ST01', CAST(N'2021-12-02T15:20:00' AS DateTime), N'PC01', N'F07', 110000, 1)
INSERT dbo.ShowTime([id], [shTime], [IDRoom], [IDFormat], [TicketPrice], [stt]) VALUES (N'ST02', CAST(N'2021-12-02T13:00:00' AS DateTime), N'PC02', N'F06', 110000, 0)

SET IDENTITY_INSERT [dbo].[Ticket] ON
GO

INSERT dbo.Ticket ([id], [TicketType], [IDShowTime], [SeatCode], [IDCustomer], [stt], [TicketPrice]) VALUES (1, 0, N'ST01', N'A1', NULL, 0, 110000)
INSERT dbo.Ticket ([id], [TicketType], [IDShowTime], [SeatCode], [IDCustomer], [stt], [TicketPrice]) VALUES (2, 0, N'ST01', N'A2', NULL, 0, 110000)
INSERT dbo.Ticket ([id], [TicketType], [IDShowTime], [SeatCode], [IDCustomer], [stt], [TicketPrice]) VALUES (3, 0, N'ST01', N'A3', NULL, 0, 110000)
INSERT dbo.Ticket ([id], [TicketType], [IDShowTime], [SeatCode], [IDCustomer], [stt], [TicketPrice]) VALUES (4, 0, N'ST01', N'A4', NULL, 0, 110000)
INSERT dbo.Ticket ([id], [TicketType], [IDShowTime], [SeatCode], [IDCustomer], [stt], [TicketPrice]) VALUES (5, 0, N'ST01', N'A5', NULL, 0, 110000)
INSERT dbo.Ticket ([id], [TicketType], [IDShowTime], [SeatCode], [IDCustomer], [stt], [TicketPrice]) VALUES (6, 0, N'ST01', N'A6', NULL, 0, 110000)
INSERT dbo.Ticket ([id], [TicketType], [IDShowTime], [SeatCode], [IDCustomer], [stt], [TicketPrice]) VALUES (7, 0, N'ST01', N'A7', NULL, 0, 0.0000)
INSERT dbo.Ticket ([id], [TicketType], [IDShowTime], [SeatCode], [IDCustomer], [stt], [TicketPrice]) VALUES (8, 0, N'ST01', N'A8', NULL, 0, 110000)
INSERT dbo.Ticket ([id], [TicketType], [IDShowTime], [SeatCode], [IDCustomer], [stt], [TicketPrice]) VALUES (9, 0, N'ST01', N'A9', NULL, 0, 110000)
GO

SET IDENTITY_INSERT [dbo].[Ticket] OFF
GO
