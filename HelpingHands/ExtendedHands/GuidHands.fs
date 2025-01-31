namespace SteamedHLBs.Core.HelpingHands.ExtendedHands

open System

module Guid =

    (*******
     * Given a string, attempt to parse it to a GUID.
     * Returns Some if successful.
     * Returns None if failed.
     *)
    let possiblyParse (str:string) =
        let mutable parsed = ref Guid.Empty
        match Guid.TryParse (str, parsed) with
        | true -> Some parsed.Value
        | _    -> None
    