module ExampleTypes

// Union Type
type Career =
      Teacher
    | Cashier
    | Construction
    | Accountant
    | Unemployed

// Type Alias
type Hours = int

// Generalized Algebraic Data Type - GADT
type Income =
      Hourly of decimal * Hours
    | Salary of decimal
    | Zero

// Record Type
type Person = {
    name: string;
    age: int;
    isCool: bool;
    career: Career;
    income: Income;
}

let makePerson name age = {
    name = name;
    age = age;
    isCool = false;
    career = Unemployed;
    income = Zero;
}

// Match with records
let getJob person job = 
    let personWithJob = {
        person with career = job;
    }

    match job with
    | Teacher -> { personWithJob with isCool = true; income = Salary (40000M) }
    | Accountant -> { personWithJob with isCool = true; income = Salary (90000M) }
    | Construction -> { personWithJob with isCool = true; income = Hourly (20M, 2400) }
    | Cashier -> { personWithJob with isCool = true; income = Hourly (10M, 1000) }
    | Unemployed -> { personWithJob with isCool = false; }
