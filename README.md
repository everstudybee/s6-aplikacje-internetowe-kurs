# Programowanie internetowych aplikacji biznesowych

Opis: Semestr 6, mgr Artur Kornatka  

## Założenia

1. Każde zajęcia są w oddzielnym branch'u, po sprawdzeniu są merge'owane z main przed kolejnymi zajęciami
2. Branch'e są opisywane zgodnie z informacjami i punktami na zajeciach
3. Oznaczenia branch'ów
   - `bm1-branch-name` - branch merge'owany z main
   - `bn1-branch-name` - branch nie merge'owany z main, np. przykłady z pierwszego wykładu, lub jakieś testy
4. Przydatne polecenia git
   - `git checkout branch-name` - przełączenie się na wybraną gałąź, git automatycznie zmienia pliki w projekcie
   - `git checkout -` - przełączenie się na poprzednią gałąź, najczęściej wrócimy do main i uaktualnią się pliki w projekcie

## Dokumentacja

1. [Strona z dokumentacją ASV.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0)
2. [Material Design - strona projektu](https://material.io/)
   1. [Material Design - Web Develop](https://material.io/develop/web)
3. [Mateerialize - CSS framework oparty na Material Design](https://materializecss.com/)

## bn1-proste-przyklady

#### Znaczniki html w ASP.NET Core

1. Dodaj nowy projekt `ASP.NET Core Web App`, pozostałe opcje domyślne
2. Zmodyfikuj kod widoku `Index.cshtml` - treść strona startowa
   - Dodanie kilku znaczników html

#### Modyfikowanie styli CSS

1. Dodaj nowy projekt `ASP.NET Core Web App`, pozostałe opcje domyślne
2. Zmodyfikuj kod widoku `Index.cshtml` - treść strony startowej
3. Style, js i dodatkowe biblioteki takie jak Bootstrap są w folderze `wwwroot`
4. Plik `_Layout.schtml` odpowiada za szablon strony
   - Znacznik `@RenderBody()` w treści pliku oznacza miejsce, gdzie będzie wklejana treść poszczególnych stron
   - Odpowiednikiem `_Layout.cshtml` w aplikacjach desktopowych jest `generic.xaml`
   - W `generic.xaml` odpowiednikiem `@RenderBody()` jest `<ContentPresenter>`
   - Jeśli jest jeden layout to jest domyślny, jeśli jest więcej to można decydować, która strona korzysta z którego layoutu
5. Zmodyfikuj plik `site.css` - który odpowiada za style CSS całego projektu

#### Procedura tworzenia projektu zgodnie ze wzorcem MVC

1. Model MVC to model projektowy `Model > View > Controler`
   - `Model` zawiera klasy do zarządzania bazą danych oraz klasy logiki biznesowej
   - `Widok` zawiera strony napisane w html'u raz z wstrzykiwanym kodem C#'owym i są renderowane za pomocą silnika `Razor`
   - `Kontroler` zawiera klasy pośredniczące między modelem a widokiem
   - We wzorcu projektowym MVVM jednemu View-Model'owi odpowiadał jeden Widok. We wzorcu projektowym MVC jednemu Kontrolerowi odpowiada wiele Widoków
   - Każdy Widok na ogół ma osobną funkcję w Kontrolerze. Jeden Kontroler działa na rzecz wielu widoków.
2. Dodaj nowy projekt `ASP.NET Core Web App (Model-VIew-Controller)`, pozostałe opcje domyślne
3. Główne elementy projektu `ASP.NET Core Web App (Model-VIew-Controller)`
   - `Views > Home > Index.cshtml` - strona otwierająca się jako pierwsza
   - `Views > Shared > _Layout.cshtml` - szablon domyślny dla wszystkich stron
   - `wwwroot > css > site.css` - główny plik styli CSS
   - `Controllers > HomeController.cs > funkcja Index()` - główny kontroler sterujący widokiem `Index.cshtml`


## bm1-aplikacja-od-poczatku

#### feat: przygotuj nowa solucje z projektami

1. Dodaj do projektu `Blank Solution` - solucja to zbiór projektów
2. Dodaj nowy projekt `ASP.NET Core Web App (Model-VIew-Controller)` - nazwa `Firma.PortalWWW`
   1. Projekt ten jest aplikacją internetową dedykowaną klientom
3. Dodaj nowy projekt `ASP.NET Core Web App (Model-VIew-Controller)` - nazwa `Firma.Intranet`
   1. Projekt ten jest aplikacją internetową dedykowaną pracownikom
4. `PPM na Firma.Intranet > Set as Startup Project` - ustaw `Firma.Intranet` jako projekt startowy
   1. Nazwa aktywnego projektu będzie pogrubiona w Solution Explor