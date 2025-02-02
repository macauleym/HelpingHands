namespace HelpingHands.Tests.ExtendedHands

open System
open NUnit.Framework
open SteamedHLBs.Core.HelpingHands.ExtendedHands.Guid

[<TestFixture>]
type GuidHandsTests () =

    [<Test>]
    member this.PossiblyParseReturnsNoneOnEmptyString () =
       Assert.That(None, Is.EqualTo(possiblyParse ""))
       
    [<Test>]
    member this.PossiblyParseReturnsNoneOnMalformedString ()=
        Assert.That(None, Is.EqualTo(possiblyParse "blah-blah_blah"))
        
    [<Test>]
    member this.PossibleParseReturnsSomeOnSuccess () =
        Assert.That(Some <| Guid.Parse "37aa5d1f-3ded-4ca9-a51b-aca8101b7500", Is.EqualTo(possiblyParse "37aa5d1f-3ded-4ca9-a51b-aca8101b7500"))
    