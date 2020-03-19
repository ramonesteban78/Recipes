module Styles

open Xamarin.Forms

let addSetter property value (style : Style) =
    let setter = Setter()
    setter.Property <- property
    setter.Value <- value
    style.Setters.Add(setter)
    style

let titleLabelStyle =
    Style(typedefof<Label>)
        |> addSetter Label.FontSizeProperty 22.
        |> addSetter Label.FontAttributesProperty FontAttributes.Bold
