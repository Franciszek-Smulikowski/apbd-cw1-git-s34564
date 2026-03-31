# Ćwiczenie 1 - APBD (Git i GitHub)

Niniejszy projekt to prosta aplikacja konsolowa w języku C#, stworzona na potrzeby realizacji ćwiczenia z obsługi systemu kontroli wersji Git. Program przyjmuje od użytkownika zbiór liczb i oblicza na ich podstawie podstawowe wartości statystyczne (sumę, średnią, minimum oraz docelowo maksimum).

## Uruchomienie
Aby skompilować i uruchomić projekt, należy otworzyć terminal w katalogu głównym projektu i wykonać następujące polecenia:
```bash
dotnet build
dotnet run
```

## Odpowiedzi na pytania z ćwiczenia

**1. Kiedy Git wykonuje fast-forward, a kiedy powstaje merge commit?**
Scalanie typu *fast-forward* zachodzi, gdy od momentu utworzenia nowej gałęzi (brancha) gałąź docelowa (np. `main`) nie uległa zmianie. Git przesuwa w tej sytuacji wskaźnik do przodu. 
Z kolei *merge commit* powstaje w sytuacji, gdy w czasie prowadzenia prac na nowej gałęzi obok dokonano osobnych modyfikacji również na gałęzi głównej. W repozytorium miało to miejsce przy scalaniu gałęzi `feature-max`, gdzie konieczne było wygenerowanie dodatkowego commita łączącego obie rozwidlone ścieżki.

**2. Czym w praktyce różni się merge od rebase?**
Obydwie metody służą do integracji zmian, jednak różnią się sposobem ich rejestracji w historii:
* **Merge** (zastosowane przy gałęzi `feature-max`) łączy dwie gałęzie zachowując ich drzewiastą strukturę i moment rozwidlenia w historii commitów. Zazwyczaj wymaga też stworzenia dodatkowego *merge commita*.
* **Rebase** (zastosowane przy gałęzi `feature-min`) przenosi wybrane commity z gałęzi roboczej i aplikuje je jako nowe na samym szczycie najnowszej wersji gałęzi `main`. Dzięki temu historia wygląda na w pełni liniową, co znacznie zwiększa jej czytelność podczas audytu.

**3. W jaki sposób rozwiązano konflikt w repozytorium?**
Konflikt wywołano celowo w ramach gałęzi `feature-conflict` poprzez zmodyfikowanie w niej tego samego wiersza (końcowego komunikatu w powiadomieniu konsolowym pliku `Program.cs`), który wcześniej zmodyfikowano również na gałęzi `main`. Ponieważ Git nie dysponował jednoznaczną odpowiedzią na to, która wersja jest poprawna, zatrzymał proces scalania i poprosił o interwencję. Rozwiązanie konfliktu polegało na ręcznej edycji pliku poprzez wykasowanie znaczników Gita (np. `<<<<<<<` i `>>>>>>>`) oraz pozostawieniu spójnej, ostatecznej treści komunikatu z nowym commitem zamykającym proces *merge*.
