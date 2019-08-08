Create Database CsgDataCenter

use  CsgDataCenter

CREATE TABLE [dbo].[Routes] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [RouteId]      NVARCHAR (80)  NOT NULL,
    [Name]         NVARCHAR (250) NOT NULL,
    [AliasName]    NVARCHAR (250) NULL,
    [PartialStops] NVARCHAR(max)  NOT NULL,
    [InService]    BIT            NULL,
    PRIMARY KEY CLUSTERED ([RouteId] ASC)
);

CREATE TABLE [dbo].[Stops] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [StopCode]    NVARCHAR (80)  NULL,
    [Name]        NVARCHAR (250) NOT NULL,
    [AliasName]   NVARCHAR (250) NULL,
    [StationType] NVARCHAR (100) NULL,
    [InService]   BIT            NOT NULL
);

CREATE TABLE [dbo].[RouteItemStopItems] (
    [id]         INT IDENTITY (1, 1) NOT NULL,
    [RouteId]   INT NOT NULL,
    [StationId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

select * from Stops
select * from Routes
select * from RouteItemStopItems

-------------Store Procedure for Route ------------------

create procedure spInsertUpdateRoutes  
(  
   @RouteId INT,  
   @Name nVARCHAR(250),  
   @AliasName nVARCHAR(250),
   @PartialStops Nvarchar(max),  
   @InService bit,  
   @StatementType nvarchar(20) = ''  
)  
AS  
BEGIN  
IF @StatementType = 'Insert'  
BEGIN  
insert into Routes(RouteId,Name,AliasName,PartialStops,InService) values(@RouteId,@Name,@AliasName,@PartialStops,@InService)  
END  
IF @StatementType = 'Select'  
BEGIN  
select RouteId,Name,AliasName,@PartialStops,InService from Routes  
END  
IF @StatementType = 'Update'  
BEGIN  
UPDATE Routes SET  
Name=@Name,AliasName=@AliasName,PartialStops=@PartialStops,InService=@InService
  
WHERE RouteId = @RouteId  
END  
end

exec spInsertUpdateRoutes 1,'ITPL','',0,0,'Select'

---------------------------STOPS --------------------------------------------
Create procedure spInsertUpdateStops  
(  
    
   @StopCode nVARCHAR(80),
   @Name nVARCHAR(250),  
   @AliasName nVARCHAR(250),
   @StationType nvarchar(100),  
   @InService bit,  
   @StatementType nvarchar(20) = ''  
)  
AS  
BEGIN  
IF @StatementType = 'Insert'  
BEGIN  
insert into Stops(StopCode,Name,AliasName,StationType,InService) values(@StopCode,@Name,@AliasName,@StationType,@InService)  
END  
IF @StatementType = 'Select'  
BEGIN  
select StopCode,Name,AliasName,StationType,InService from Stops  
END  
IF @StatementType = 'Update'  
BEGIN  
UPDATE Stops SET  
Name=@Name,AliasName=@AliasName,StationType=@StationType,InService=@InService
  
WHERE StopCode = @StopCode
END  
end


select * from Routes

-------------------------------------------------------------------------------

----------------Select STOP from ROUTE---------------------------------

CREATE PROCEDURE [dbo].SelectStopS
	@RouteId NVARCHAR(80)
AS
begin 

	SELECT S.StopCode,S.Name FROM Stops S JOIN RouteItemStopItems R ON R.StationId=S.StopCode where R.RouteId= @RouteId
end
---------------------------------------------------------------------------------------------
