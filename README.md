# Console Statistics App

Prosta aplikacja konsolowa napisana w C# do obliczania statystyk ze zbioru liczb całkowitych (suma, średnia, itp.). 

Projekt ten służy głównie do ćwiczeń z podstaw systemów kontroli wersji Git oraz platformy GitHub.

## Jak uruchomić

Aby skompilować i uruchomić projekt, otwórz terminal w katalogu z aplikacją i użyj poniższych komend:

```bash
dotnet build
dotnet run
```

## Notatki z ćwiczenia Git

**Dlaczego merge gałęzi `feature-max` do `main` nie był fast-forward?**
Merge nie mógł zostać wykonany w trybie fast-forward, ponieważ po utworzeniu gałęzi `feature-max`, na gałęzi `main` pojawił się niezależny commit (historia commitów się rozeszła). Z tego powodu Git musiał połączyć te dwie ścieżki zmian, tworząc domyślnie nowy commit scalający (merge commit).
