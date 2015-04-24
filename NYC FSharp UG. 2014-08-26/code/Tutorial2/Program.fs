open System

open FSharp.Data
open System.Windows.Forms

open FSharp.Data

[<Literal>]
let topSalesQuery = "
    SELECT TOP(@TopN) FirstName, LastName, SalesYTD 
    FROM Sales.vSalesPerson
    WHERE CountryRegionName = @regionName AND SalesYTD > @salesMoreThan 
    ORDER BY SalesYTD
" 

type TopSalesQuery = SqlCommandProvider<topSalesQuery, "name=AdventureWorks2014">

[<STAThread>]
do   
    let form = new Form()
    let grid = new DataGridView(Dock = DockStyle.Fill, AutoGenerateColumns = true)
    form.Controls.Add( grid)
    let cmd = new TopSalesQuery()
    grid.DataSource <- 
        [|
            for x in cmd.Execute(TopN = 3L, regionName = "United States", salesMoreThan = 1000000M) ->
                sprintf "%s %s" x.FirstName x.LastName, x.SalesYTD
        |]
