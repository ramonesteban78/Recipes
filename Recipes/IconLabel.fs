module IconLabel

open Fabulous.XamarinForms
open Xamarin.Forms

type Model = {
     icon : string
     text : string
 }

let view (model: Model) color (iconSize,textSize) =
     View.StackLayout(orientation = StackOrientation.Horizontal,
                      verticalOptions = LayoutOptions.Center,
                      children = [
                          View.Label(fontFamily = Styles.fontAwesomeName,
                                     textColor = color,
                                     fontSize = FontSize iconSize,
                                     text = model.icon)
                          View.Label(text = model.text,
                                     textColor = color, 
                                     fontSize = FontSize textSize)
                      ])
     
     