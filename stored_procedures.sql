GO
/****** Object:  StoredProcedure [dbo].[CompanyMst_ADD]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CompanyMst_ADD] 
@cid as int,	
@cname as nvarchar(256),
@person as nvarchar(256),
@address as nvarchar(256),
@contact as nvarchar(256)
AS
BEGIN
 	 Insert into CompanyMst values(@cid,@cname,@person,@address,@contact,getdate())

  
	
END





GO
/****** Object:  StoredProcedure [dbo].[SALES_INSERT_STOCK]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SALES_INSERT_STOCK] 
@PID as int,	
@PNAME as nvarchar(256),
@NAME as nvarchar(256),
@PRICE as float,
@QNT as int,
@TPRICE as float
AS
BEGIN
 	 Insert into SalesMst values(@PID,@PNAME,@NAME,@PRICE,@QNT,@TPRICE,getdate())

  
	
END

GO
CREATE PROCEDURE insertIntoClient(
@CU_Id  int,
@CU_Name  nvarchar(250),
@CU_Surname  nvarchar(250),
@CU_Mobile_No  float,
@CU_Address  nvarchar(250),
@CU_City  nvarchar(250))

AS
BEGIN

	Insert into ClientMst values(@CU_Id,@CU_Name,@CU_Surname,@CU_Mobile_No,@CU_Address,@CU_City)	

END