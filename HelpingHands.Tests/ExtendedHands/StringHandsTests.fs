namespace HelpingHands.Tests.ExtendedHands

open NUnit.Framework
open SteamedHLBs.Core.HelpingHands.ExtendedHands.String

[<TestFixture>]
type StringHandsTests () =
    
    [<Test>]
    member this.ToOptionEmptyStringReturnsNone () =
        Assert.That(None, Is.EqualTo(toOption ""))
        
    [<Test>]
    member this.ToOptionWhitespaceStringReturnsNone () =
        Assert.That(None, Is.EqualTo(toOption "       "))
        
    [<Test>]
    member this.ToOptionValueStringReturnsSome () =
        Assert.That(Some "Cool String", Is.EqualTo(toOption "Cool String"))
