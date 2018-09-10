
# Create the Database name Auth
(add the database connection address in the appSettings.Json)

CREATE TABLE [dbo].[Users] (

		[Id]           INT             IDENTITY (1, 1) NOT NULL,

		[PasswordHash] VARBINARY (MAX) NULL,

		[PasswordSalt] VARBINARY (MAX) NULL,

		[Username]     NVARCHAR (MAX)  NULL

	);


CREATE TABLE	[dbo].[Values] (
    [Id]	 INT           NOT NULL,
    [Name]	NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


#  JWT Configuration JSON WEB TOKEN
Person who enter will be given a token
When he send request we will check that token for the authentication 

#For Register and Login we make Separate Dtos
	Reasons:
			-Because in Login we always may want password and Username
			-in Register there might be more informations

 #In startup.cs we need place a rule if program want IAuthRepository give AuthRepository


 #Enjoy the application in your auth services. 