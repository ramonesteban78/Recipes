 
module Recipe

open System
open Fabulous
open Fabulous.XamarinForms
open Xamarin.Forms

type Model = {
    name : string;
    photo : byte[] option
    tags : Tags.Model option
    time : TimeSpan option
    favs : int option
    cooked : int
}
type Msg =
    | DisplayRecipe
    
let init() =
    { name = "Carne con tomate"
      photo = None
      tags = Some { tags = ["Almuerzo";"Carne";"Salsa"] }
      time = Some(TimeSpan(0,15,0))
      favs = Some 15
      cooked = 9
      }, Cmd.none
    
let update msg model =
    match msg with
    | DisplayRecipe -> { model with name = model.name; photo = model.photo} , Cmd.none 

let view (model : Model) (dispatch:Msg -> unit) =
    let tagsView = match model.tags with
                    | Some tags -> Tags.view tags
                    | None -> View.Button(text="Add some tags")
    let iconsList =
        View.StackLayout(orientation = StackOrientation.Horizontal,
                         spacing = 20.,
                         children=[
                             IconLabel.view
                                { icon = Icons.clock; text = Helper.timeSpanToString model.time }
                                Xamarin.Forms.Color.Gray
                                (20.,17.);
                             IconLabel.view
                                { icon = Icons.heart;
                                  text = match model.favs with
                                         | Some favs -> favs.ToString()
                                         | None -> "0" }
                                Xamarin.Forms.Color.Gray
                                (20.,17.);
                             IconLabel.view
                                { icon = Icons.hatchef;
                                  text = Helper.numAndText 9 " cooked" }
                                Xamarin.Forms.Color.Gray
                                (20.,17.)
                             
                         ])
    View.ContentPage(
        //created = ControlExtensions.applyRecipePagePlatformSpecifics,
        hasNavigationBar = false,
        backgroundColor = Xamarin.Forms.Color.White,
        content = View.Grid(
            rowdefs=[Dimension.Stars 33.; Dimension.Stars 66.],
            children = [
               View.Image(backgroundColor = Xamarin.Forms.Color.Gray,
                          margin = Thickness(0.,-50.,0.,0.)).Row(0);
               View.Frame(content = View.Grid(
                                            rowdefs=[Dimension.Star; Dimension.Auto;],
                                            children=[
                                                 View.StackLayout(
                                                        orientation = StackOrientation.Vertical,
                                                        spacing = 15.,
                                                        children = [
                                                            View.Label(text=model.name,style = Styles.titleLabelStyle);
                                                            iconsList
                                                            ]).Row(0)
                                                 tagsView.Row(1)]),
                        padding = Thickness(25.,25.,25.,25.),    
                        hasShadow = true,
                        backgroundColor = Xamarin.Forms.Color.White,
                        height=200.,
                        cornerRadius=20.,    
                        margin=Thickness(15.,-120.,15.,0.),
                        verticalOptions=LayoutOptions.Start,
                        horizontalOptions=LayoutOptions.FillAndExpand).Row(1)
            ]))

    
