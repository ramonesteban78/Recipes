module Styles

open Xamarin.Forms

let addSetter property value (style : Style) =
    let setter = Setter()
    setter.Property <- property
    setter.Value <- value
    style.Setters.Add(setter)
    style

// Labels
let titleLabelStyle =
    Style(typedefof<Label>)
        |> addSetter Label.FontSizeProperty 22.
        |> addSetter Label.FontAttributesProperty FontAttributes.Bold


// FontAwesome Icons
let fontAwesomeName =
        match Device.RuntimePlatform with
        | Device.iOS -> "FontAwesome5Pro-Regular"
        | _ -> "FontAwesome5Regular.otf#Regular"

let fontAwesomeRegularFont =
    Style(typedefof<Label>)
        |> addSetter Label.FontFamilyProperty fontAwesomeName
        
let iconText icon =
    fontAwesomeRegularFont
        |> addSetter Label.TextProperty icon