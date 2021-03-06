/*
   07 April 201715:13:38
   User: 
   Server: JO2WEB
   Database: MvcBeginnerDb
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Location
	(
	Id int NOT NULL IDENTITY (1, 1),
	Title nvarchar(255) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Location ADD CONSTRAINT
	PK_Location PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Location SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Location', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Location', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Location', 'Object', 'CONTROL') as Contr_Per 