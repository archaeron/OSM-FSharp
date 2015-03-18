#I @"..\packages\FSharp.Data.2.1.1\lib\net40"

#r "System.Xml.Linq.dll"
#r "FSharp.Data.dll"

open FSharp.Data

let file = @".\Data\map.osm"

type Map = XmlProvider<".\Data\map.osm">

let map = Map.Load(file)

for node in map.Nodes do
    if node.Tags.Length > 0 then
        printfn "%A" node.Tags
    