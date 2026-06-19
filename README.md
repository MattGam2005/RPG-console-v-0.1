# Jądro Ciemności – Wersja Tekstowa (Demo)

Jądro Ciemności to klasyczna, tekstowa gra RPG (Interactive Fiction) zrealizowana jako aplikacja konsolowa w języku C#. Gracz może wybrać czterech dostępnych bohaterów do antycznego więzienia, aby odnaleźć mesjasza, pomszczenie lub cel zlecenia – Le'Alighilera. Projekt stanowi demonstrację mechanik RPG, takich jak eksploracja oparta na wyborach, system walki z przeciwnikami w czasie rzeczywistym. Gra jest wzorowana na tematyce i meachnikach Fear & Hungry.

---
##OPis
Aplikacja przenosi gracza do histri 4 bohaterów który jednoczy jeden człowiek, z których każda posiada unikalne tło fabularne (lore) wpływające na motywację bohatera oraz odmienne statystyki początkowe (Punkty Życia, Siła, Mana). 

Rozgrywka polega na eksploracji kolejnych lokacji ("Poziom 1") poprzez podejmowanie decyzji w menu konsoli. Gracz musi zdobyć  klucze, aby otworzyć główne drzwi prowadzące do finałowego bossa poziomu. Gra oferuje dynamiczny system walki oparty na losowości.

##Lista funkcji
*Kreator Postaci (wybór swojej postaci z historią)
Rycerz (Wysokie HP i Siła, brak magii)
Mag (Ogromny zapas many, potężne czary ofensywne i leczące)
Barbarzyńca (Wysoka siła, magii używa do samoleczenia i wzmocnień)
Najemnik (Zbalansowane statystyki, ryzykowne, ale potężne czary)
*Rozbudowana fabuła i tło fabularne
*System Eksploracji pół zamknietej lokalizacji
*System Walki
*Bezlitosny system któy automatycznie kończy gre
*Punkty zapisu tylko w niektórych miejscach

## Instrukcja

Wymagania wstępne
Zainstalowane środowisko **.NET SDK** (zalecana wersja 6.0 lub nowsza).
Dowolne IDE obsługujące C# (np. **Visual Studio 2022**, **Visual Studio Code** lub **JetBrains Rider**).

Uruchomienie przez Visual Studio (Metoda 1)
1. Pobierz lub sklonuj to repozytorium na swój dysk lokalny.
2. Otwórz plik rozwiązania `JadroCiemnosci.sln` (lub odpowiednik `.sln` w folderze) za pomocą Visual Studio.
3. Upewnij się, że projekt jest ustawiony jako projekt startowy.
4. Kliknij przycisk **"Uruchom" (F5)** lub zieloną strzałkę na górnym pasku narzędzi.

Uruchomienie przez konsolę / terminal 
1. Otwórz terminal (Wiersz polecenia, PowerShell lub Bash) i przejdź do folderu zawierającego plik `.csproj`.
2. Wykonaj polecenie kompilacji:
