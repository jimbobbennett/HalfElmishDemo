namespace HalfElmishDemo

open Elmish.XamarinForms
open Xamarin.Forms

type App() =
    inherit Application()

    do
        let page = Program.mkSimple MainPage.init MainPage.update MainPage.view
                    |> Program.withConsoleTrace
                    |> Program.withStaticView
                    |> Program.run

        base.MainPage <- page.InitialMainPage
