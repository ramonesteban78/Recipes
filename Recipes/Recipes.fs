 
module Recipe

open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms

type Model = {
    name : string;
    photo : byte[] option
    tags : Tags.Model option
}
type Msg =
    | DisplayRecipe
    
let init() =
    { name = "Carne con tomate"
      photo = None
      tags = Some { tags = ["Almuerzo";"Carne";"Salsa"] }
      }, Cmd.none
    
let update msg model =
    match msg with
    | DisplayRecipe -> { model with name = model.name; photo = model.photo} , Cmd.none 

let view (model : Model) (dispatch:Msg -> unit) =
    let tagsView = match model.tags with
                    | Some tags -> Tags.view tags
                    | None -> View.Button(text="Add some tags")
    View.ContentPage(
        //created = ControlExtensions.applyRecipePagePlatformSpecifics,
        hasNavigationBar = false,
        backgroundColor = Xamarin.Forms.Color.White,
        content = View.Grid(
            rowdefs=[Dimension.Stars 33.; Dimension.Stars 66.],
            children = [
               View.Image(backgroundColor = Xamarin.Forms.Color.Gray,
                          margin = Thickness(0.,-50.,0.,0.)).Row(0);
               View.Frame(content =
                               View.StackLayout(orientation = StackOrientation.Vertical,
                                    children = [
                                    View.Label(text=model.name,
                                              style = Styles.titleLabelStyle);
                                    tagsView
                               ]),
                        padding = Thickness(25.,25.,25.,25.),    
                        hasShadow = true,
                        backgroundColor = Xamarin.Forms.Color.White,
                        height=200.,
                        cornerRadius=20.,    
                        margin=Thickness(15.,-120.,15.,0.),
                        verticalOptions=LayoutOptions.Start,
                        horizontalOptions=LayoutOptions.FillAndExpand).Row(1)
            ]))

    
