namespace HelpingHands.Tests

open System
open System.IO
open NUnit.Framework
open SteamedHLBs.Core.HelpingHands.AsyncHands

type CoolRecord = {
    Name  : string
    Value : int
}
    

[<TestFixture>]
type AsyncHandsTests () =
    
    [<Test>]
    member this.PrintSyncOutputsResult () =
        let expected = "{\n  \"Name\": \"test\",\n  \"Value\": 42\n}\n"
        let work = async {
            return { Name="test"; Value=42 }
        }
        use sw = new StringWriter ()
        Console.SetOut sw
        printSync work
        Assert.That(sw.ToString(), Is.EqualTo(expected))
