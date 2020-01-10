using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace InsightBenchmark
{
	internal class Program
	{
		private static string ConnectionString;

		private static void Main(string[] args)
		{
			var builder = new ConfigurationBuilder()
		   .SetBasePath(Directory.GetCurrentDirectory())
		   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

			IConfigurationRoot configuration = builder.Build();

			ConnectionString = configuration.GetConnectionString("Default");

			//DbSetup();

			//DbCleanup();
		}

		[GlobalSetup]
		private static void DbSetup()
		{
			using var cn = new SqlConnection(ConnectionString);

			cn.Open();
			var cmd = cn.CreateCommand();

			cmd.CommandText = @"
					SET NOCOUNT ON;
					IF (OBJECT_ID('Post') IS NULL)
					BEGIN
						CREATE TABLE Post
						(
							Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
							[Text] VARCHAR(MAX) NOT NULL,
							CreationDate DATETIME NOT NULL,
							LastChangeDate DATETIME NOT NULL,
							Counter1 INT,
							Counter2 INT,
							Counter3 INT,
							Counter4 INT,
							Counter5 INT,
							Counter6 INT,
							Counter7 INT,
							Counter8 INT,
							Counter9 INT
						);
					END;
					IF (OBJECT_ID('Comment') IS NULL)
					BEGIN
						CREATE TABLE Comment
						(
							Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
							PostId INT NOT NULL,
							[CommentText] VARCHAR(MAX) NOT NULL,
							CreationDate DATETIME NOT NULL
						);
					END;
					
					DELETE FROM dbo.Post;
					DELETE FROM dbo.Comment;
					
					DECLARE @i INT = 0;
					WHILE (@i <= 5000)
					BEGIN
						DECLARE @PostId INT;

						INSERT INTO	Post([Text], CreationDate, LastChangeDate) 
						VALUES (REPLICATE('x', 2000), SYSDATETIME(), SYSDATETIME());
						SET @i = @i + 1;

						SELECT @PostId = SCOPE_IDENTITY();

						INSERT INTO	Comment([CommentText], CreationDate, PostId)
						SELECT REPLICATE('x', 2000), SYSDATETIME(), @PostId UNION ALL
						SELECT REPLICATE('x', 2000), SYSDATETIME(), @PostId 
					END;
                ";

			cmd.Connection = cn;
			cmd.ExecuteNonQuery();
		}

		[GlobalCleanup]
		private static void DbCleanup()
		{
			using var cn = new SqlConnection(ConnectionString);

			cn.Open();
			var cmd = cn.CreateCommand();

			cmd.CommandText = @"DROP TABLE Post; DROP TABLE Comment;";

			cmd.Connection = cn;
			cmd.ExecuteNonQuery();
		}
	}
}