module Tags

open Fabulous.XamarinForms
open Xamarin.Forms

type Model = {
    tags : string list
} 

let tagView (tag : string) =
    View.Frame(hasShadow=false,
               cornerRadius=15.,
               padding = Thickness(5.,5.,5.,5.),
               backgroundColor = Xamarin.Forms.Color.Orange,
               content = View.Label(text = tag,
                                    margin = Thickness(2.,0.,2.,0.),
                                    textColor = Xamarin.Forms.Color.White))
    
let view (model : Model) =
    let tagViews = model.tags |> List.map(fun(x) -> tagView x)
    View.StackLayout(orientation = StackOrientation.Horizontal,
                     children = tagViews)
    
