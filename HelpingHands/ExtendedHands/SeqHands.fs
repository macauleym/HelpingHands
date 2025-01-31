namespace SteamedHLBs.Core.HelpingHands.ExtendedHands

module Seq =
    
    (*******
     * Given some optional value to filter on:
     * if it is Some, pass it to the filter function.
     * if it is None, simply return the given collection.
     *
     * I looked all over for a pre-existing function somewhere that
     * does this sort of conditional filtering. Where I want to
     * filter a collection if I have some value, otherwise just return
     * the collection as-is if I don't.
     * I couldn't find anything, so here we are.
     *)
    let filterOn optional f collection =
        match optional with
        | Some v ->
            collection
            |> Seq.filter (f v)
        | None   ->
            collection
   
    (*******
     * Similar to `filterOn`, but instead applies the `take` function.
     * If `cond` is Some, apply `take` to the desired amount.
     * Otherwise, just return the collection as-is.
     *) 
    let takeOn me (*How could I not?*) collection =
        match me with
        | Some amount -> 
            collection
            |> Seq.take amount
        | None        -> collection
    