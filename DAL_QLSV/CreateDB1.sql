USE [QuanLySinhVien]
GO
/****** Object:  StoredProcedure [dbo].[qlsv_AddNewUser]    Script Date: 06-Dec-19 9:13:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[qlsv_AddNewUser]
	(
		@Usertype bit ,
		@Username nvarchar(50),
		@Pass nvarchar(50)
	)
AS
begin
	/* SET NOCOUNT ON */
	Insert into tb_User(  Username,Pass,Usertype) Values( @Username, @Pass,@Usertype)
	RETURN
end

