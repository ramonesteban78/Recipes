namespace Recipes

open Xamarin.Forms
open Xamarin.Forms.PlatformConfiguration
open Xamarin.Forms.PlatformConfiguration.iOSSpecific

type CustomContentPage() =
    inherit ContentPage()
    
    do
        base.On<iOS>().SetPreferredStatusBarUpdateAnimation(UIStatusBarAnimation.Fade) |> ignore