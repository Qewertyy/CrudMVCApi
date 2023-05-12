--Table Employee

CREATE TABLE EMP(
	EmpID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Empname varchar(50) NOT NULL,
	EmpSal decimal(18, 2) NOT NULL,
	Gender varchar(10) NULL
)

-- STORED PROCEDURES
-- GET ALL EMPLOYEES
CREATE PROCEDURE GetAllEmployees
AS
  BEGIN
  SELECT * FROM EMP
  END
GO

-- GET EMP WITH ID
CREATE PROCEDURE GetEmp
(
  @EmpID int
)
AS
  BEGIN
    if @EmpID>0
      BEGIN
      SELECT * FROM EMP WHERE EmpID=@EmpID
      END
    ELSE
      BEGIN
      SELECT * FROM Emp
      END
  END
GO

-- UPDATE EMPLOYEE
CREATE PROCEDURE UpdateEmp
(
  @EmpID int,
  @Empname varchar (100),
  @EmpSal decimal (18,2),
  @Gender varchar (50)
)
AS
  BEGIN
  UPDATE Emp SET Empname=@EmpName, EmpSal=@EmSal, Gender=@Gender WHERE EmpID=@EmpID
  END
GO

-- DELETE EMPLOYEE
CREATE PROCEDURE DelEmp
(
  @EmpID int
)
AS
 BEGIN
 DELETE FORM Emp WHERE EmpID=@EmpID
 END
GO

-- ADD EMPLOYEE
CREATE PROCEDURE AddEmp
(
  @Empname varchar (100),
  @EmpSal decimal (18,2),
  @Gender varchar (50)
)
AS
  BEGIN
  INSERT INTO Emp(Empname, EmpSaL, Gender) VALUES (@Empname, @EmpSal, @Gender)
  END
GO
