module ListComp

// Basic list comprehension
let basicList x y = [for i in x..y do if i % 2 = 0 then yield i]

// Basic mapping
let multiply factor nums = List.map (fun i -> i * factor) nums

// Pipeing
let findAverage nums =
    let add x y = x + y
    let mean count sum = sum / count

    List.fold add 0 nums
    |> mean (List.length nums)

// Composition
let findSuperAverage = multiply 10 >> findAverage