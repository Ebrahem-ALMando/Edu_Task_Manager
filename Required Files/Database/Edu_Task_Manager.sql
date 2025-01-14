USE [master]
GO
/****** Object:  Database [Edu_Task_Manager]    Script Date: 10/27/2024 1:54:14 AM ******/
CREATE DATABASE [Edu_Task_Manager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Edu_Task_Manager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Edu_Task_Manager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Edu_Task_Manager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Edu_Task_Manager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Edu_Task_Manager] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Edu_Task_Manager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Edu_Task_Manager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET ARITHABORT OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Edu_Task_Manager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Edu_Task_Manager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Edu_Task_Manager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Edu_Task_Manager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET RECOVERY FULL 
GO
ALTER DATABASE [Edu_Task_Manager] SET  MULTI_USER 
GO
ALTER DATABASE [Edu_Task_Manager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Edu_Task_Manager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Edu_Task_Manager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Edu_Task_Manager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Edu_Task_Manager] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Edu_Task_Manager] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Edu_Task_Manager', N'ON'
GO
ALTER DATABASE [Edu_Task_Manager] SET QUERY_STORE = ON
GO
ALTER DATABASE [Edu_Task_Manager] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Edu_Task_Manager]
GO
/****** Object:  Table [dbo].[Users_TB]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_TB](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[created_by_user_id] [int] NULL,
	[username] [varchar](50) NOT NULL,
	[password_hash] [varchar](255) NOT NULL,
	[role] [varchar](20) NOT NULL,
	[full_name] [varchar](100) NOT NULL,
	[phone_number] [varchar](15) NULL,
	[birth_date] [date] NULL,
	[address] [varchar](255) NULL,
	[created_at] [datetime] NULL,
	[last_login] [datetime] NULL,
	[is_active] [bit] NULL,
	[profile_picture] [varchar](255) NULL,
	[department] [varchar](50) NULL,
 CONSTRAINT [PK__Users_TB__B9BE370FED91D2A3] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__Users_TB__F3DBC5729D66906F] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Users_TB] ADD  CONSTRAINT [DF__Users_TB__create__403A8C7D]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Users_TB] ADD  CONSTRAINT [DF__Users_TB__is_act__412EB0B6]  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[Users_TB]  WITH CHECK ADD  CONSTRAINT [FK_Users_TB_Users_TB] FOREIGN KEY([created_by_user_id])
REFERENCES [dbo].[Users_TB] ([id])
GO
ALTER TABLE [dbo].[Users_TB] CHECK CONSTRAINT [FK_Users_TB_Users_TB]
GO
ALTER TABLE [dbo].[Users_TB]  WITH CHECK ADD  CONSTRAINT [CK__Users_TB__role__3F466844] CHECK  (([role]='Admin' OR [role]='Teacher' OR [role]='Student'))
GO
ALTER TABLE [dbo].[Users_TB] CHECK CONSTRAINT [CK__Users_TB__role__3F466844]
GO
/****** Object:  StoredProcedure [dbo].[checkUserState]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[checkUserState]
@idUser int
as
begin
select is_active from Users_TB 
where id=@idUser
end
GO
/****** Object:  StoredProcedure [dbo].[createInitUser]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[createInitUser]
    @passwordHash VARCHAR(255)
AS
BEGIN

    IF NOT EXISTS (SELECT 1 FROM Users_TB WHERE username = 'admin')
    BEGIN

        INSERT INTO Users_TB 
            (username, password_hash, role, full_name)
        VALUES 
            ('admin', @passwordHash, 'Admin', 'admin');
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[deleteUser]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteUser]
@id int
as
begin
BEGIN TRY
    delete from Users_TB
where id =@id
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH

	end
GO
/****** Object:  StoredProcedure [dbo].[getDataCheckUserName]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[getDataCheckUserName]
@userName nvarchar(50)
as
begin
BEGIN TRY


select username from Users_TB
where username=@userName
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH

	end
GO
/****** Object:  StoredProcedure [dbo].[getDataIsCanDeleteUser]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[getDataIsCanDeleteUser]
    @id INT
AS
BEGIN
    DECLARE @userCount INT;

    SELECT @userCount = COUNT(id) 
    FROM Users_TB
    WHERE created_by_user_id = @id

  IF (@userCount=0)
    BEGIN
        SELECT CAST(1 AS BIT) AS result;  -- True
    END
    ELSE
    BEGIN
        SELECT CAST(0 AS BIT) AS result;  -- False
    END
END
GO
/****** Object:  StoredProcedure [dbo].[getDataUsers]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getDataUsers]
as
BEGIN
  SELECT   U.id AS 'المعرف',
         U.full_name AS 'الاسم',
         U.birth_date AS 'تاريخ الميلاد',
         U.phone_number AS 'رقم الهاتف',
         U.address AS 'العنوان',
         U.username AS 'اسم الحساب',
         CASE 
             WHEN U.role = 'Admin' THEN 'مسؤول'
             WHEN U.role = 'Teacher' THEN 'مدرس'
             WHEN U.role = 'Student' THEN 'طالب'
             ELSE U.role 
         END AS 'نوع الحساب',
         U.last_login AS 'آخر عملية تسجيل دخول',
		 CASE
		 WHEN U.is_active=1 THEN 'نشط' 
		 WHEN U.is_active=0 THEN 'غير نشط' 
		 ELSE  'غير معرّف'
		 END AS 'الحالة',
		 U2.full_name 'أُضيف بواسطة',

         U.created_at AS 'تاريخ الإضافة'
FROM     Users_TB U
Left join Users_TB U2
on U.created_by_user_id=U2.id
ORDER BY U.id DESC;

END
GO
/****** Object:  StoredProcedure [dbo].[getDataUsersAdmin]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getDataUsersAdmin]
as
BEGIN
  SELECT   U.id AS 'المعرف',
         U.full_name AS 'الاسم',
         U.birth_date AS 'تاريخ الميلاد',
         U.phone_number AS 'رقم الهاتف',
         U.address AS 'العنوان',
         U.username AS 'اسم الحساب',
         CASE 
             WHEN U.role = 'Admin' THEN 'مسؤول'
             WHEN U.role = 'Teacher' THEN 'مدرس'
             WHEN U.role = 'Student' THEN 'طالب'
             ELSE U.role 
         END AS 'نوع الحساب',
         U.last_login AS 'آخر عملية تسجيل دخول',
		 CASE
		 WHEN U.is_active=1 THEN 'نشط' 
		 WHEN U.is_active=0 THEN 'غير نشط' 
		 ELSE  'غير معرّف'
		 END AS 'الحالة',

		 U2.full_name 'أُضيف بواسطة',

         U.created_at AS 'تاريخ الإضافة'
FROM     Users_TB U
Left join Users_TB U2
on U.created_by_user_id=U2.id
where U.role='Admin'
ORDER BY U.id DESC;


END
GO
/****** Object:  StoredProcedure [dbo].[getDataUsersByTeacher]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getDataUsersByTeacher]
@idTeacher int
as
BEGIN
  SELECT   U.id AS 'المعرف',
         U.full_name AS 'الاسم',
         U.birth_date AS 'تاريخ الميلاد',
         U.phone_number AS 'رقم الهاتف',
         U.address AS 'العنوان',
         U.username AS 'اسم الحساب',
         CASE 
             WHEN U.role = 'Admin' THEN 'مسؤول'
             WHEN U.role = 'Teacher' THEN 'مدرس'
             WHEN U.role = 'Student' THEN 'طالب'
             ELSE U.role 
         END AS 'نوع الحساب',
         U.last_login AS 'آخر عملية تسجيل دخول',
		 CASE
		 WHEN U.is_active=1 THEN 'نشط' 
		 WHEN U.is_active=0 THEN 'غير نشط' 
		 ELSE  'غير معرّف'
		 END AS 'الحالة',
         U.created_at AS 'تاريخ الإضافة'
FROM     Users_TB U

where U.created_by_user_id=@idTeacher
and U.role='Student'
ORDER BY U.id DESC;

END
GO
/****** Object:  StoredProcedure [dbo].[getDataUsersStudents]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getDataUsersStudents]
as
BEGIN
  SELECT   U.id AS 'المعرف',
         U.full_name AS 'الاسم',
         U.birth_date AS 'تاريخ الميلاد',
         U.phone_number AS 'رقم الهاتف',
         U.address AS 'العنوان',
         U.username AS 'اسم الحساب',
         CASE 
             WHEN U.role = 'Admin' THEN 'مسؤول'
             WHEN U.role = 'Teacher' THEN 'مدرس'
             WHEN U.role = 'Student' THEN 'طالب'
             ELSE U.role 
         END AS 'نوع الحساب',
         U.last_login AS 'آخر عملية تسجيل دخول',
		 CASE
		 WHEN U.is_active=1 THEN 'نشط' 
		 WHEN U.is_active=0 THEN 'غير نشط' 
		 ELSE  'غير معرّف'
		 END AS 'الحالة',

		 U2.full_name 'أُضيف بواسطة',

         U.created_at AS 'تاريخ الإضافة'
FROM     Users_TB U
Left join Users_TB U2
on U.created_by_user_id=U2.id
where U.role='Student'
ORDER BY U.id DESC;


END
GO
/****** Object:  StoredProcedure [dbo].[getDataUsersTeachers]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getDataUsersTeachers]
as
BEGIN
  SELECT   U.id AS 'المعرف',
         U.full_name AS 'الاسم',
         U.birth_date AS 'تاريخ الميلاد',
         U.phone_number AS 'رقم الهاتف',
         U.address AS 'العنوان',
         U.username AS 'اسم الحساب',
         CASE 
             WHEN U.role = 'Admin' THEN 'مسؤول'
             WHEN U.role = 'Teacher' THEN 'مدرس'
             WHEN U.role = 'Student' THEN 'طالب'
             ELSE U.role 
         END AS 'نوع الحساب',
         U.last_login AS 'آخر عملية تسجيل دخول',
		 CASE
		 WHEN U.is_active=1 THEN 'نشط' 
		 WHEN U.is_active=0 THEN 'غير نشط' 
		 ELSE  'غير معرّف'
		 END AS 'الحالة',

		 U2.full_name 'أُضيف بواسطة',

         U.created_at AS 'تاريخ الإضافة'
FROM     Users_TB U
Left join Users_TB U2
on U.created_by_user_id=U2.id
where U.role='Teacher'
ORDER BY U.id DESC;


END
GO
/****** Object:  StoredProcedure [dbo].[insertUsers]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertUsers]
@created_by_user_id int,
@username VARCHAR (50),
@password_hash varchar(255),
@role varchar(20),
@full_name varchar(100),
@phone_number varchar(15),
@birth_date date,
@address varchar(255)
AS
BEGIN
    INSERT  INTO Users_TB(created_by_user_id,username,password_hash,role,full_name
					      ,phone_number,birth_date,address)
    VALUES              (@created_by_user_id,@username,@password_hash,@role,@full_name
						,@phone_number,@birth_date,@address);
END
GO
/****** Object:  StoredProcedure [dbo].[loginUser]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[loginUser]
@username  VARCHAR(50)
as
begin
select * from Users_TB 
where username=@username
end
GO
/****** Object:  StoredProcedure [dbo].[updateLastLoginUser]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateLastLoginUser]
@idUser int
as
begin
update Users_TB 
set
last_login=GETDATE()
where id=@idUser

end
GO
/****** Object:  StoredProcedure [dbo].[updateUsers]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateUsers]
    @id INT,
    @username NVARCHAR(50),
    @password_hash NVARCHAR(255),
    @role NVARCHAR(20),
    @full_name NVARCHAR(100),
    @phone_number NVARCHAR(15),
    @birth_date DATE,
    @address NVARCHAR(255)

AS
BEGIN
    BEGIN TRY
        UPDATE Users_TB 
        SET 
            username = @username,
            password_hash = CASE WHEN @password_hash !='********' THEN @password_hash ELSE password_hash END,
			
            role = @role,
            full_name = @full_name,
            phone_number = @phone_number,
            birth_date = @birth_date,
            address = @address

        WHERE id = @id; 
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[updateUserState]    Script Date: 10/27/2024 1:54:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateUserState]
@idUser int,
@isActive bit
as 
begin
update Users_TB set 
is_active=@isActive
where id=@idUser
end
GO
USE [master]
GO
ALTER DATABASE [Edu_Task_Manager] SET  READ_WRITE 
GO
