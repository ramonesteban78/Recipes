module ControlExtensions

open Xamarin.Forms
open Xamarin.Forms.PlatformConfiguration
open Xamarin.Forms.PlatformConfiguration.iOSSpecific

let applyRecipePagePlatformSpecifics (page: ContentPage) =
    do page.On<iOS>()
           .SetPreferredStatusBarUpdateAnimation(UIStatusBarAnimation.Fade)
           .SetPrefersHomeIndicatorAutoHidden(true)
           .SetPrefersStatusBarHidden(StatusBarHiddenMode.True) |> ignore


//type RecipeContentPage() =
//    inherit CustomContentPage()
//    do base.On<iOS>().SetPreferredStatusBarUpdateAnimation(UIStatusBarAnimation.Fade) |> ignore
//    do base.On<iOS>().SetPrefersHomeIndicatorAutoHidden(true) |> ignore
//    //do base.On<iOS>().SetPrefersStatusBarHidden(StatusBarHiddenMode.True) |> ignore
//        
//       
//
//type Fabulous.XamarinForms.View with
//    static member inline RecipeContentPage(?content: ViewElement,
//                                           ?backgroundImage: Fabulous.XamarinForms.InputTypes.Image,
//                                           ?icon: Fabulous.XamarinForms.InputTypes.Image,
//                                           ?isBusy: bool,
//                                           ?padding: Xamarin.Forms.Thickness,
//                                           ?title: string,
//                                           ?toolbarItems: ViewElement list,
//                                           ?useSafeArea: bool,
//                                           ?hasNavigationBar: bool,
//                                           ?anchorX: float,
//                                           ?anchorY: float,
//                                           ?backgroundColor: Xamarin.Forms.Color,
//                                           ?behaviors: ViewElement list,
//                                           ?flowDirection: Xamarin.Forms.FlowDirection,
//                                           ?height: float,
//                                           ?inputTransparent: bool,
//                                           ?isEnabled: bool,
//                                           ?isTabStop: bool,
//                                           ?isVisible: bool,
//                                           ?minimumHeight: float,
//                                           ?minimumWidth: float,
//                                           ?opacity: float,
//                                           ?resources: (string * obj) list,
//                                           ?rotation: float,
//                                           ?rotationX: float,
//                                           ?rotationY: float,
//                                           ?scale: float,
//                                           ?scaleX: float,
//                                           ?scaleY: float,
//                                           ?styles: Xamarin.Forms.Style list,
//                                           ?styleSheets: Xamarin.Forms.StyleSheets.StyleSheet list,
//                                           ?tabIndex: int,
//                                           ?translationX: float,
//                                           ?translationY: float,
//                                           ?visual: Xamarin.Forms.IVisual,
//                                           ?width: float,
//                                           ?style: Xamarin.Forms.Style,
//                                           ?styleClasses: string list,
//                                           ?shellBackButtonBehavior: ViewElement,
//                                           ?shellBackgroundColor: Xamarin.Forms.Color,
//                                           ?shellDisabledColor: Xamarin.Forms.Color,
//                                           ?shellForegroundColor: Xamarin.Forms.Color,
//                                           ?shellFlyoutBehavior: Xamarin.Forms.FlyoutBehavior,
//                                           ?shellNavBarIsVisible: bool,
//                                           ?shellSearchHandler: ViewElement,
//                                           ?shellTabBarBackgroundColor: Xamarin.Forms.Color,
//                                           ?shellTabBarDisabledColor: Xamarin.Forms.Color,
//                                           ?shellTabBarForegroundColor: Xamarin.Forms.Color,
//                                           ?shellTabBarIsVisible: bool,
//                                           ?shellTabBarTitleColor: Xamarin.Forms.Color,
//                                           ?shellTabBarUnselectedColor: Xamarin.Forms.Color,
//                                           ?shellTitleColor: Xamarin.Forms.Color,
//                                           ?shellTitleView: ViewElement,
//                                           ?shellUnselectedColor: Xamarin.Forms.Color,
//                                           ?automationId: string,
//                                           ?classId: string,
//                                           ?effects: ViewElement list,
//                                           ?menu: ViewElement,
//                                           ?styleId: string,
//                                           ?ref: ViewRef,
//                                           ?tag: obj,
//                                           ?sizeAllocated: System.Tuple<System.Double,System.Double> -> unit,
//                                           ?appearing: unit -> unit,
//                                           ?disappearing: unit -> unit,
//                                           ?focused: Xamarin.Forms.FocusEventArgs -> unit,
//                                           ?unfocused: Xamarin.Forms.FocusEventArgs -> unit,
//                                           ?created: obj -> unit) =
//        
//        let create () = new RecipeContentPage()
//        let update (prev: ViewElement voption) (source: ViewElement) (target: RecipeContentPage) =
//            ViewBuilders.UpdateContentPage (prev, source, target)
//        let attributes = ViewBuilders.BuildContentPage(0, ?content=content, ?backgroundImage=backgroundImage, ?icon=icon, ?isBusy=isBusy, ?padding=padding, 
//                                                            ?title=title, ?toolbarItems=toolbarItems, ?useSafeArea=useSafeArea, ?hasNavigationBar=hasNavigationBar, ?anchorX=anchorX, 
//                                                            ?anchorY=anchorY, ?backgroundColor=backgroundColor, ?behaviors=behaviors, ?flowDirection=flowDirection, ?height=height, 
//                                                            ?inputTransparent=inputTransparent, ?isEnabled=isEnabled, ?isTabStop=isTabStop, ?isVisible=isVisible, ?minimumHeight=minimumHeight, 
//                                                            ?minimumWidth=minimumWidth, ?opacity=opacity, ?resources=resources, ?rotation=rotation, ?rotationX=rotationX, 
//                                                            ?rotationY=rotationY, ?scale=scale, ?scaleX=scaleX, ?scaleY=scaleY, ?styles=styles, 
//                                                            ?styleSheets=styleSheets, ?tabIndex=tabIndex, ?translationX=translationX, ?translationY=translationY, ?visual=visual, 
//                                                            ?width=width, ?style=style, ?styleClasses=styleClasses, ?shellBackButtonBehavior=shellBackButtonBehavior, ?shellBackgroundColor=shellBackgroundColor, 
//                                                            ?shellDisabledColor=shellDisabledColor, ?shellForegroundColor=shellForegroundColor, ?shellFlyoutBehavior=shellFlyoutBehavior, ?shellNavBarIsVisible=shellNavBarIsVisible, ?shellSearchHandler=shellSearchHandler, 
//                                                            ?shellTabBarBackgroundColor=shellTabBarBackgroundColor, ?shellTabBarDisabledColor=shellTabBarDisabledColor, ?shellTabBarForegroundColor=shellTabBarForegroundColor, ?shellTabBarIsVisible=shellTabBarIsVisible, ?shellTabBarTitleColor=shellTabBarTitleColor, 
//                                                            ?shellTabBarUnselectedColor=shellTabBarUnselectedColor, ?shellTitleColor=shellTitleColor, ?shellTitleView=shellTitleView, ?shellUnselectedColor=shellUnselectedColor, ?automationId=automationId, 
//                                                            ?classId=classId, ?effects=effects, ?menu=menu, ?styleId=styleId, ?ref=ref, 
//                                                            ?tag=tag, ?appearing=appearing, ?disappearing=disappearing, ?focused=focused, ?unfocused=unfocused, 
//                                                            ?created=created)
//        ViewElement.Create<RecipeContentPage>(create, update, attributes)