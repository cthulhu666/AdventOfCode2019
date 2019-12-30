open System.IO

let calcFuel (mass: int): int = int (float (mass) / 3.0) - 2

//let calcFuel2 mass =
//    mass
//    |> float
//    |> (/) 3.0
//    |> int
//    |> (-) 2

let rec calcFuel2 (mass: int): int =
    let m = int (float (mass) / 3.0) - 2
    if m > 0 then m + calcFuel2 m
    else 0

//printfn "%i" (calcFuel2 1969)

let input = File.ReadLines("input.txt")

let fuel =
    input
    |> Seq.map int
    |> Seq.map calcFuel
    |> Seq.sum

printfn "%i" fuel

let fuel2 =
    input
    |> Seq.map int
    |> Seq.map calcFuel2
    |> Seq.sum

printfn "%i" fuel2
