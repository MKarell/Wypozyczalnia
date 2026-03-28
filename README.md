# Uczelniana Wypożyczalnia Sprzętu (Console App)

Projekt to konsolowa aplikacja w języku C# służąca do zarządzania wypożyczeniami sprzętu na uczelni. Umożliwia rejestrację sprzętu i użytkowników, obsługę wypożyczeń i zwrotów, naliczanie kar za opóźnienia oraz generowanie podstawowych raportów.

## Struktura i Podział Projektu

Kod został zorganizowany z myślą o czytelności i łatwości utrzymania. Zamiast wrzucać wszystko do jednego pliku `Program.cs`, projekt opiera się na podziale na logiczne warstwy:

1. **Warstwa Domenowa (Modele):** Definiuje, czym są obiekty w naszym systemie (np. `Equipment`, `User`, `Rental`). Klasy te posiadają stan i podstawowe zachowania modyfikujące ten stan (np. zmiana statusu sprzętu), ale nie wiedzą nic o bazie danych czy interfejsie użytkownika.
2. **Warstwa Serwisów (Logika Biznesowa):** Zawiera zasady działania wypożyczalni (np. `RentalService`). Tutaj odbywa się sprawdzanie limitów, weryfikacja dostępności i spinanie modeli ze sobą.
3. **Warstwa Prezentacji (UI):** Klasa `Program` odpowiada **wyłącznie** za interakcję z użytkownikiem (wypisywanie tekstu, wczytywanie komend).

Taki podział uznałem za sensowny, ponieważ pozwala w przyszłości łatwo podmienić interfejs konsolowy na aplikację webową (np. ASP.NET API) bez konieczności przepisywania logiki biznesowej.

## Uzasadnienie Decyzji Projektowych

W kodzie starałem się zachować równowagę między dobrymi praktykami programowania obiektowego a pragmatyzmem. 

### 1. Kohezja (Spójność) i Odpowiedzialność Klas (SRP)
Każda klasa w systemie ma jeden główny powód do zmiany, co zapewnia wysoką kohezję:
* `EquipmentRegistry` i `UserRegistry` odpowiadają **tylko** za przechowywanie i wyszukiwanie obiektów w pamięci. Nie zajmują się wypożyczaniem.
* `RentalService` to orkiestrator – zarządza procesem wypożyczenia, ale nie zajmuje się interfejsem tekstowym.

### 2. Coupling (Luźne Powiązania) i Dependency Injection
Aby uniknąć silnego sprzężenia (tight coupling), klasy nie tworzą swoich zależności wewnątrz za pomocą słówka `new` (z wyjątkiem modeli domenowych).
* `RentalService` nie tworzy kalkulatora kar. Otrzymuje go w konstruktorze jako interfejs `IPenaltyCalculator`. Dzięki temu, jeśli w przyszłości zasady naliczania kar się zmienią (np. dla wykładowców będzie inna stawka), wystarczy napisać nową klasę implementującą ten interfejs, bez modyfikowania kodu `RentalService`.
* Główna klasa `Program` otrzymuje gotowe serwisy z zewnątrz (wstrzykiwane w `Program.cs`), zajmuje się tylko wyświetlaniem podstawowego menu i przechowywaniem obiektów do klas, które obsługują cały proces.

### 3. Dziedziczenie vs Kompozycja (Model Domenowy)
* **Dziedziczenie** zostało użyte tam, gdzie występuje naturalna relacja "jest czymś" (IS-A). `Laptop` i `Projector` dziedziczą po abstrakcyjnej klasie bazowej `Equipment`. Podobnie `Student` i `Employee` dziedziczą po `User`, nadpisując właściwość określającą limit wypożyczeń (`maxHire`).
* **Kompozycja** została użyta w klasie `Rental`. Wypożyczenie nie dziedziczy po użytkowniku ani sprzęcie. Zamiast tego **zawiera** w sobie referencje do obiektu `Equipment` oraz obiektu `User`. 
