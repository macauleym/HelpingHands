namespace SteamedHLBs.Core.HelpingHands.ExtendedHands

open System

module String =
   
    (*******
     * Simply wraps the given string in an Option.
     * Returns Some if the string is not null or white space.
     * Returns None otherwise.
     *) 
    let toOption source =
        match String.IsNullOrWhiteSpace source with
        | false -> Some source
        | _     -> None
        