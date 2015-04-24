
//conn str
[<Literal>] 
let connectionString = @"Data Source=(LocalDb)\v11.0;Initial Catalog=AdventureWorks2012;Integrated Security=True"

//typical raw ADO.NET solution

open System 
open System.Data.SqlClient

let conn = new SqlConnection (connectionString)
conn.Open()

let cmd = new SqlCommand ("
    SELECT COUNT(*) 
    FROM Purchasing.PurchaseOrderHeader 
    WHERE ShipDate > @shippedLaterThan AND ShipMethodID = @shipMethodId", conn)

cmd.Parameters.AddWithValue("@shippedLaterThan", DateTime(2008, 1, 1)) |> ignore
cmd.Parameters.AddWithValue("@shipMethodId", 4) |> ignore
cmd.ExecuteScalar() |> unbox<int>

//ref to both providers
#r @"packages\FSharp.Data.SqlEnumProvider.0.8.0-aplha\lib\net40\FSharp.Data.SqlEnumProvider.dll"
#r @"packages\FSharp.Data.SqlClient.1.3.2\lib\net40\FSharp.Data.SqlClient.dll"

//open namespaces
open FSharp.Data
open System

//by convention: first column is Name, second is Value
type ShipMethod = SqlEnumProvider<"SELECT Name, ShipMethodID AS UTC FROM Purchasing.ShipMethod ORDER BY ShipMethodID", connectionString, CLIEnum = true>

ShipMethod.Items

ShipMethod.``CARGO TRANSPORT 5``
ShipMethod.``OVERNIGHT J-FAST``

//Now combining 2 F# type providers: SqlEnum and SqlCommandProvider
type OrderHeader = 
    SqlCommandProvider<
        "SELECT * FROM Purchasing.PurchaseOrderHeader WHERE ShipDate > @shippedLaterThan", connectionString>

let cmd1 = new OrderHeader() 

//# of overnight orders after Jan 1, 2008
query {
    for x in cmd1.Execute( shippedLaterThan = DateTime( 2008, 1, 1)) do
    let shipMethod = ShipMethod.``OVERNIGHT J-FAST``
    where (x.ShipMethodID = shipMethod) 
    count
} 



