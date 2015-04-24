
//add ref in script
#r @"packages\FSharp.Data.SqlClient.1.3.2\lib\net40\FSharp.Data.SqlClient.dll"

//open namespace
open FSharp.Data

//connection string local
[<Literal>] 
let connectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=AdventureWorks2012;Integrated Security=True"

//azure connection string
//[<Literal>]
//let connectionString = @"Server=tcp:mhknbn2kdz.database.windows.net,1433;Database=AdventureWorks2012;User ID=sqlfamily;Password= sqlf@m1ly;Trusted_Connection=False;Encrypt=True;Connection Timeout=30"

//get 42
type Get42 = SqlCommandProvider<"SELECT 42 AS Value", connectionString, SingleRow = true>
let cmdGet42 = new Get42()
cmdGet42.Execute()

//get local databases after Jan 1, 2014
type GetLocalDatadases = SqlCommandProvider<"SELECT name, create_date FROM sys.databases", connectionString> 
let cmdGetLocalDatabases = new GetLocalDatadases()
cmdGetLocalDatabases.Execute() 
|> Seq.filter (fun x -> x.create_date > System.DateTime( 2014, 1, 1))
|> Seq.toList

//fuzz buzz
type GetFizzBuzzAnswer = SqlCommandProvider<"FizzBuzz.sql", connectionString, ResultType.Tuples>
let getFizzBuzzAnswer = new GetFizzBuzzAnswer()
[ for x, fizzBuzz in getFizzBuzzAnswer.Execute() do if fizzBuzz <> "" then yield x.Value ]

//get local databases after Jan 1, 2014 
//with sql param and query literal
//single column output
[<Literal>]
let getLocalDatadasesQuery = "
    SELECT name 
    FROM sys.databases
    WHERE create_date > @createdSince
"

type GetLocalDatadasesV2 = SqlCommandProvider<getLocalDatadasesQuery, connectionString> 
let cmdGetLocalDatabasesV2 = new GetLocalDatadasesV2()
cmdGetLocalDatabasesV2.Execute(createdSince = System.DateTime(2014, 1, 1)) |> Seq.toList

