module Statements

let num = 10
let str = "Hello, this is a string!"
let numToString (x: int) = x.ToString()

let bigFunction () =
    let myNumStr = numToString 10
    printfn "The result is %s\n" myNumStr

    // basic for-loop
    for i in 0..10 do
        printfn "%d" i

    // First show what happens when j is not mutable
    // let j = 0
    // while j < 10 do
    //     printfn "While Loop: %d" j
    //     let j = j + 1
    //     printfn "While Loop after shadow: %d" j

    // basic mutable assignment
    // let mutable j = 0
    // while j < 10 do
    //     printfn "While Loop: %d" j
    //     j <- j + 1

    // nested sequences
    // let buildSeq x = seq {
    //     for i in [0..x] do
    //         printfn "In seq: %d" i
    //         yield i
    // }

    // // Sequences
    // let iterSeq = seq {
    //     for i in 1..10 do
    //         yield! buildSeq i
    // }

    // let enumerator = iterSeq.GetEnumerator()
    // while enumerator.MoveNext() do
    //     printfn "We are iterating"