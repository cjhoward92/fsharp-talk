module Eval

let evalTrueFalse a t f = if a then t else f

let evalFnTrueFalse a t f = if a then t() else f()

let evalLazyTrueFalse a (t: Lazy<'a>) (f: Lazy<'a>) = if a then t.Force() else f.Force()

// How can we delay evaluation?
let testEval () =
    do printfn "Test Eval"
    do evalTrueFalse true (printfn "True")  (printfn "False")
    ()

let testDelayed () =
    do printfn "Test Delayed"
    let t = fun () -> printfn "True"
    let f = fun () -> printfn "False"

    do evalFnTrueFalse false t f

let testLazy () =
    do printfn "Test Lazy"
    let r = evalLazyTrueFalse false (lazy (fun () -> printfn "True")) (lazy (fun () -> printfn "False"))
    r()