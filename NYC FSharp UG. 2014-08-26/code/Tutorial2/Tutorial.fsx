
#r @"..\packages\FSharp.Data.SqlClient.1.6.2\lib\net40\FSharp.Data.SqlClient.dll"

open FSharp.Data

[<Literal>] 
let connectionString = @"Data Source=.;Initial Catalog=AdventureWorks2014;Integrated Security=True"
//let connectionString = @"Server=tcp:mhknbn2kdz.database.windows.net,1433;Database=AdventureWorks2012;User ID=sqlfamily;Password= sqlf@m1ly;Trusted_Connection=False;Encrypt=True;Connection Timeout=30"

type Get42 = SqlCommandProvider<"SELECT 42 as Value", connectionString, SingleRow = true>
let cmd = new Get42()
cmd.Execute()

[<Literal>] 
let getLocaldatabasesQuery = "
    SELECT name  
    FROM sys.databases
    WHERE create_date > @createDate
"
type GetLocaldatabases = SqlCommandProvider<getLocaldatabasesQuery, connectionString> 
let getLocalDbs = new GetLocaldatabases()
getLocalDbs.Execute(createDate = System.DateTime(2014, 1, 1)) 
|> Seq.toList |> List.length

type GetFizzBuzz = SqlCommandProvider<"FizzBuzz.sql", connectionString, ResultType.Tuples>
let getFizzBuzz = new GetFizzBuzz ()
[ for x, s in getFizzBuzz.Execute() do if s <> "" then yield x.Value ]

//get local databases after Jan 1, 2014 
//with sql param and query literal
//single column output

//winforms

//WPF

