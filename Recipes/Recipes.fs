 
module Recipe

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms
open Xamarin.Forms
open Xamarin.Forms.PlatformConfiguration
open Xamarin.Forms.PlatformConfiguration.iOSSpecific

type Model = {
    name : string;
    photo : byte[] option;
}
type Msg =
    | DisplayRecipe
    
let init() =
    { name = "Carne con tomate"; photo = None  }, Cmd.none
    
let update msg model =
    match msg with
    | DisplayRecipe -> { model with name = model.name; photo = model.photo} , Cmd.none 

let view (model : Model) (dispatch:Msg -> unit) =
    let recipePage =
        View.ContentPage(
            backgroundColor = Xamarin.Forms.Color.Gold,
            content = View.Grid(
                rowdefs=[Dimension.Stars 33.; Dimension.Stars 66.],
                children = [
                   View.Image(backgroundColor = Xamarin.Forms.Color.Gray).Row(0);
                   View.Frame(content =
                                   View.StackLayout(children = [
                                        View.Label(text=model.name,
                                                  fontSize = FontSize.FontSize 22.,
                                                  fontAttributes = FontAttributes.Bold)    
                                   ]),
                            padding = Thickness(25.,25.,25.,25.),    
                            hasShadow = true,
                            backgroundColor = Xamarin.Forms.Color.White,
                            height=200.,
                            cornerRadius=20.,
                            margin=Thickness(30.,-120.,30.,0.),
                            verticalOptions=LayoutOptions.Start,
                            horizontalOptions=LayoutOptions.FillAndExpand).Row(1)
                ]))
    View.NavigationPage(pages = [
        recipePage
    ])
    
