namespace HelpingHands.Tests.ExtendedHands

open NUnit.Framework
open SteamedHLBs.Core.HelpingHands.ExtendedHands.Seq

[<TestFixture>]
type SeqHandsTests () =
    
    [<Test>]
    member this.FilterOnDoesNotFilterCollection () =
        let expected = seq{1..4}
        let actual = filterOn
                        <| None
                        <| (fun _ _ -> false)
                        <| expected
        Assert.That(actual, Is.EqualTo<int seq>(expected))
        
    [<Test>]
    member this.FilterOnFiltersCollectionBySomeValue () =
        let expected = seq{2;4;6}
        let actual = filterOn
                        <| Some 2
                        <| (fun v i -> i % v = 0)
                        <| seq{1..6}
        Assert.That(actual, Is.EqualTo<int seq>(expected))
        
    [<Test>]
    member this.TakeOnDoesNotTakeAny () =
        let expected = seq{1..10}
        let actual = takeOn
                        <| None
                        <| expected
        Assert.That(actual, Is.EqualTo<int seq>(expected))
        
    [<Test>]
    member this.TakeOnTakesTopSome () =
        let expected = seq{1..3}
        let actual = takeOn
                        <| Some 3
                        <| seq{1..10}
        Assert.That(actual, Is.EqualTo<int seq>(expected))
                        