namespace Recipes.iOS

open UIKit
open Xamarin.Forms
open Xamarin.Forms.Platform.iOS

type RendererNavigationPage() =
    inherit NavigationRenderer()
    
    override this.ViewDidLoad() =
        base.ViewDidLoad()
        UINavigationBar.Appearance.SetBackgroundImage(new UIImage(), UIBarMetrics.Default)
        UINavigationBar.Appearance.ShadowImage <- new UIImage()
        UINavigationBar.Appearance.BackgroundColor <- UIColor.Clear
        UINavigationBar.Appearance.TintColor <- UIColor.White
        UINavigationBar.Appearance.BarTintColor <- UIColor.Clear
        UINavigationBar.Appearance.Translucent <- true

//[<assembly: Xamarin.Forms.ExportRendererAttribute (typeof<NavigationPage>, typeof<RendererNavigationPage>)>] do ()
        
