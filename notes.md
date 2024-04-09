# Functional programing in c#

## Timetable

## Outline

### What is functional programming 
- Focus on functions instead of classes that encapsulate logic
    - Splitting data and logic
    - Small reusable functions are way to go
    - We can also do something like higher order functions to enrich existing functions
    - And by functions I mean methods that return value, not void, because values can be chained
- Expression over statements
    - Expression is something that returns a value (not void)
    - This is good because we can chain functions on values
    - You can even return a function as a value
- Immutable state
    - State doesn't change, instead its copies are getting passed around 
    - This makes reasoning about code much easier, you don't need to find all the place where you mutate code
    - This can be extremely beneficial when building UI like with Blazor
    - Since it's immutable, you can chain calls on it
    - Thread safe-ish

### Why functional in c#
- It's already there
    - And has been since the earliest c# version 
    - We show some examples further down
- You're already using it
    - We will also show some examples further down
- Not hard at all
    - Since you're already using it you will be familiar with some of the concepts already
    - The key point here is not to dive deep down into mathematical definitions that functional programming is often described with
    - You can use your own names as you will implement new code, to make it more understantable for you and your team
    - Some people say that learning functional first and OOP later made more sense for them
    - Oposite direction seems less intuitive
- More power
    - You can write more robust and testable code, when you focus on more smaller functions, testing becomes easy and fast
    - You will also find yourself writing more reusable code, and it will be more easy to reuse, since you should split your data (types) and behaviour (functions)
- Cleaner Code
    - Smaller functions, less boilerplate, more reusable code, what more do you want from cleaner code

### LINQ - It's already there & you're using it
- The whole library has functional design, mostly based on higher order functions
- You're just saying what you want to be done, instead of how to do it
- I think we all agree that this library is one of the most powerfull features of the .net ecosystem

### `Func<>` type - It's already there & you're using it
- Since you're already using LINQ, youre already treating functions as values that can be passed around
- You're therefore using something called higher order functions, which we will show later

### Expressions over statements - It's already there & you're using it
- For sure you've written at least one ternary operator
- And with new c# syntax, you might have even encountered pattern matching, which is (tada) an expression

### Immutability - It's already there & maybe you're using it
- Some things are immutable in c# already, like `int` `string` and `DateTime`, others unfortunatelly, are not.
- Classes/objects are unfortunatelly, mutable
- But in newer c#, there is more support for immutable types

### So what should we do more ?
- But Tom, if we're already using so much functional concept in c#, what can we do more ?

### Use More LINQ
- It's there and it's very powerfull, rethink if you rewrite your code using LINQ

### Start focusing on expressions and chaining
- You can do better than just ifs and elses, use expressions and split your functions as well
- Show example and explain

### Start writing your own, small HOFs
- Once again mentioning LINQ, you can learn from it, and write methods similar to it
- Show example and explain
- Surprise question 

### Data is fine, but what if there's none
- Introducing void
- Void makes our life miserable when being more functional in c#
- You cannot chain methods that return `void`
- You cannot create `void`
