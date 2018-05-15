use Sandbox

--Create members table
Create table Members
( FirstName varchar (35),
  LastName varchar (35),
  BirthDate varchar(75),
  City  varchar (35),
  [State]  varchar (35),
  JoinedDate varchar(75))

  --Create another table and format the date
  Create table MembersSort
( FirstName varchar (35),
  LastName varchar (35),
  BirthDate varchar(35),
  City  varchar (35),
  [State]  varchar (35),
  JoinedDate varchar(35)
 )
 
------------------------------------------------------------------------------- 
  --Bulk insert from csv file
  BULK INSERT Members
    FROM 'C:\Users\MTCStudent\Desktop\membersort\MemberSort.txt'
    WITH
    (
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n'   --Use to shift the control to next row
    )
   GO

   --Check the contents of the table
     select * from Members

--------------------------------------------------------------------
---------Create a function------------------------------------------
GO
	create FUNCTION fnDateFormat
	
	(@inputDate VARCHAR(255)) 
	
RETURNS date

BEGIN
         DECLARE @output DATE = null;
		 DECLARE @result date = null;
		 DECLARE @r_input varchar(255) = '';
		 DECLARE @y_length INT = 0;
		 DECLARE @y_value INT = 0;
		 DECLARE @reverseIn varchar(255) = '';
		 DECLARE @yearLength int = 0;
		 DECLARE @yearValue INT = 0;
  
 IF LEN(@inputDate) > 0 BEGIN
 
 -- Trim leading spaces
    SET @inputDate = LTRIM(RTRIM(@inputDate))
 
 -- Trim starting 0 if there is one.
 IF LEFT(@inputDate, 1) = '0' BEGIN
 	SET @inputDate = RIGHT(@inputDate, LEN(@inputDate) - 1); 
 END
 
 -- Replace dashes and periods
 
    SET @inputDate = REPLACE(@inputDate, '-', '/');
 	SET @inputDate = REPLACE(@inputDate, '.', '/');
 
 	 -- Isolate and process year value
 	 -- First, get year string by reversing string and finding first (last) separator.
	 SET @r_input = REVERSE(@inputDate);
	 SET @y_length = CHARINDEX('/', @r_input) - 1;

	 SET @reverseIn = REVERSE(@inputDate);
	 SET @yearLength = CHARINDEX('/', @reverseIn) - 1;
 
 	 -- Get the year value from the last two digits ...
	 SET @y_value = CONVERT(INT, REVERSE(LEFT(@r_input, 2)));
	 SET @yearValue = CONVERT(INT, REVERSE(LEFT(@reverseIn, 2)));
 
 	 -- If the year value is greater than or equal to the current year, assume last century, else this century.
	 IF @y_length > 0 AND @y_length < 4
	 IF @yearLength > 0 AND @yearLength < 4
 	 BEGIN
	   IF @y_value < 10
	   IF @yearValue < 10
 	BEGIN
		 SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@y_length)), '200', @y_value);
	    
 	END

       ELSE if @y_value >=  YEAR(GETDATE()) % 100 

       SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@y_length)), '19', @y_value); 
	   
	   ELSE if @yearValue >=  YEAR(GETDATE()) % 100

BEGIN
	 SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@y_length)), '20', @y_value);
	
END
END
 
 	 SET @inputDate = REPLACE(@inputDate, '/0', '/');

	 DECLARE @first VARCHAR(5) = SUBSTRING(@inputDate, 1, CHARINDEX('/', @inputDate, 0) - 1)
	 DECLARE @second VARCHAR(5) = SUBSTRING(@inputDate, CHARINDEX('/', @inputDate, 0) + 1, 
	 (CHARINDEX('/', @inputDate, CHARINDEX('/', @inputDate, CHARINDEX('/', @inputDate, 0) + 1)) - CHARINDEX ('/', @inputDate, 0)  - 1))
			
	 IF ISNUMERIC(@second) = 1 AND ISNUMERIC(@first) = 1
		BEGIN		
	 IF @first > 12 AND @second <= 12
	 BEGIN
			SET @inputDate = STUFF(@inputDate, 1, 2, @second)
			SET @inputDate = STUFF(@inputDate, CHARINDEX('/', @inputDate, 0) + 1, LEN(@second), @first)
	 END

	 END

 	 SET @result = CONVERT(DATE, @inputDate, 101);
  
	 IF @result IS NOT NULL
	   SET @output = @result;
	 ELSE
	   SET @output = '00-00-0000';

 END
  
 RETURN @output;

 RETURN @result;

 end
		
GO

	---------------------------------------------------------------------------
	--Inserting data into from members table to membersSort table
	INSERT INTO  dbo.MembersSort (FirstName, LastName,BirthDate,City,State, JoinedDate)
	SELECT FirstName, LastName,dbo.fnDateFormat(BirthDate), City, State, dbo.fnDateFormat(JoinedDate)
	FROM dbo.Members

	--check the contents of the table
	select * from MembersSort

	