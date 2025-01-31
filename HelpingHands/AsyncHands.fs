namespace SteamedHLBs.Core.HelpingHands

open FSharp.Json

module AsyncHands =
   
    (*******
     * Synchronizes, Serializes, and Sends to standard out.
     *) 
    let printSync (toPrint:Async<'a>) =
        printfn "%s" << Json.serialize << Async.RunSynchronously
        <| toPrint
