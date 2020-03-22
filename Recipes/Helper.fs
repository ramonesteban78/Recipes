

module Helper
open System

let numAndText num text =
    if num > 0 then num.ToString() + text
    else ""

let timeSpanToString (time:TimeSpan option) =
    match time with
    | Some time -> numAndText time.Hours "hrs" + numAndText time.Minutes "min." 
    | None -> "-"