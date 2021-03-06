﻿module App.FizzBuzz.Tests

open FsUnit.Xunit
open global.Xunit

[<Theory>]
[<InlineData(1, "1")>]
[<InlineData(2, "2")>]
[<InlineData(3, "Fizz")>]
[<InlineData(5, "Buzz")>]
[<InlineData(6, "Fizz")>]
[<InlineData(10, "Buzz")>]
[<InlineData(15, "FizzBuzz")>]
[<InlineData(225, "FizzBuzz")>]
let ``Given number returns expected label`` inputNumber expectedLabel =
    FizzBuzz inputNumber |> should equal expectedLabel
