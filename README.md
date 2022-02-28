# Programowanie internetowych aplikacji biznesowych

Opis: Semestr 6, mgr Artur Kornatka  

## Założenia

1. Każde zajęcia są w oddzielnym branch'u, po sprawdzeniu są merge'owane z main przed kolejnymi zajęciami
2. Branch'e są opisywane zgodnie z informacjami i punktami na zajeciach
3. Oznaczenia branch'ów
   1. `bm1-branch-name` - branch merge'owany z main
   2. `bn1-branch-name` - branch nie merge'owany z main, np. przykłady z pierwszego wykładu, lub jakieś testy
4. Przydatne polecenia git
   1. `git checkout branch-name` - przełączenie się na wybraną gałąź, git automatycznie zmienia pliki w projekcie
   2. `git checkout -` - przełączenie się na poprzednią gałąź, najczęściej wrócimy do main i uaktualnią się pliki w projekcie

## Dokumentacja

1. [Strona z dokumentacją ASV.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0)

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
   1. Znacznik `@RenderBody()` w treści pliku oznacza miejsce, gdzie będzie wklejana treść poszczególnych stron
   2. Odpowiednikiem `_Layout.cshtml` w aplikacjach desktopowych jest `generic.xaml`
   3. W `generic.xaml` odpowiednikiem `@RenderBody()` jest `<ContentPresenter>`
   4. Jeśli jest jeden layout to jest domyślny, jeśli jest więcej to można decydować, która strona korzysta z którego layoutu
5. Zmodyfikuj plik `site.css` - który odpowiada za style CSS całego projektu

#### Procedura tworzenia projektu zgodnie ze wzorcem MVC

1. Model MVC to model projektowy `Model > View > Controler`
   1. `Model` zawiera klasy do zarządzania bazą danych oraz klasy logiki biznesowej
   2. `Widok` zawiera strony napisane w html'u raz z wstrzykiwanym kodem C#'owym i są renderowane za pomocą silnika `Razor`
   3. `Kontroler` zawiera klasy pośredniczące między modelem a widokiem
   4. We wzorcu projektowym MVVM jednemu View-Model'owi odpowiadał jeden Widok. We wzorcu projektowym MVC jednemu Kontrolerowi odpowiada wiele Widoków
   5. Każdy Widok na ogół ma osobną funkcję w Kontrolerze. Jeden Kontroler działa na rzecz wielu widoków.
2. Dodaj nowy projekt `ASP.NET Core Web App (Model-VIew-Controller)`, pozostałe opcje domyślne
3. Główne elementy projektu `ASP.NET Core Web App (Model-VIew-Controller)`
   1. `Views > Home > Index.cshtml` - strona otwierająca się jako pierwsza
   2. `Views > Shared > _Layout.cshtml` - szablon domyślny dla wszystkich stron
   3. `wwwroot > css > site.css` - główny plik styli CSS
   4. `Controllers > HomeController.cs > funkcja Index()` - główny kontroler sterujący widokiem `Index.cshtml`