# **Design Patterns**

## Object Pool (Pula obiektów)

### Cel:
- Trzymanie zainicjowanych obiektów w puli gotowych do użycia.
- Zwrócenie obiektu na którym klient wykonywał operacje z powrotem do puli.
- Nietworzenie wielokrotnie klas kosztownych do utworzenia, raz utworzone kosztowne obiekty są zwracane z powrotem do puli.

### Problem
Wzorzec Pula obiektów ma związek z cachowaniem, na zasadzie właśnie tej, że raz utworzony obiekt przez klienta, zostaje zwrócony z powrotem do puli, gdy znowu będzie klient go potrzebował znowu obiekt zostanie pobrany z puli, ale nie będzie tworzony znowu od początku bo został już wcześniej utworzony, można również w puli obiektów ustawić ilość obiektów jakie mogą być w tej puli przechowywane.

Odpowiednio wykorzystana pula może znacznie zwiekszyć wydajność aplikacji, Pula obiektów jest szczególnie użyteczna np, w **połaczeniach z bazą danych** albo w **wątkach**, ponieważ klasa Puli obiektów jest **singletonem**, czyli jest zabezpieczona przed dostępem z wielu wątków w jednej chwili.

Jednak działa to również w drugą stronę, niewłaściwe użycie Puli obiektów np w tworzeniu obiektów, które tylko zajmują pamięć, ale nie wskazują na inne zasoby, może znacznie zmniejszyć wydajność.

### Używać gdy:
- Trzeba tworzyć obiekty kosztowne w utowrzeniu
- Częstotoliwość tworzenia kolejnych obiektów jest również wysoka.
- Liczba obiektów będących w użyciu jest mała.
 

Trzeba pamiętać, że gdy zwracamy obiekt do puli obiektów, to jego stan musi być **zresetowany**, jeśli zwrócimy obiekt na którym klient wykonywał jakieś operacje, to po ponownej potrzebie wykorzystania go przez klienta, może wykonywać działania nie takie jakie byśmy chcieli. Pula obiektów, która nie resetuje stanów zwróconych obiektów jest antywzorcem. Mechanizm resetowania obiektów trzeba zaimplementować w Puli obiektów, klient nie powinien musieć resetować obiektów bo to nie klient jest odpowiedzialny za resetowanie obiektów, tylko Pula.
 

---


Wszystkie wymienione poniżej wzorce stosowane są w aplikacjach wielowątkowych i służą do zabezpieczania aplikacji przed jednoczesnym dostępem do zasobów przez wiele różnych wątków.

## Lock/Mutex

### Lock

- Najprostszy z mechanizmów, który pozwala na zapewnienie odpowiedniego dostępu do zasobów.
- Stosując lock na wybranym fragmencie kodu, mamy pewność że w danym momencie tylko jeden wątek uzyska do niego dostęp.
- Struktura:
    ```
    lock (x)
    {
        // Your code...
    }
    ```
    gdzie 'x' to warunek, który musi zostać spełniony by blokada została ściągnięta.
- Inne wątki muszą czekać aż blokada zostanie ściągnięta

### Mutex

- Jest bardzo podobny do Lock'a.
- Jego zasadniczą wadą jest to, że jego użycie kosztuje więcej pamięci oraz zasobów.
- Zaletą niedostępną dla Lock'a jest możliwość blokowania dostępu do określonego zasobu pomiędzy różnymi procesami działającymi w systemie. Mutex może mieć zatem swego rodzaju zasięg globalny w obszarze całego systemu - nie tylko w pojedynczej instancji aplikacji. Takie rozwiązanie może być bardzo przydatne np. w sytuacji gdy jedna aplikacja może mieć w systemie wiele instancji i każda z tych instancji może zapisywać dane do jednego pliku. W takim przypadku istnieje bardzo duże ryzyko, że w jednym momencie dostęp do pliku będzie chciało uzyskać kilka różnych procesów
- Struktura:
    ```
    Mutex mutex = new Mutex(false, MUTEX_GUID);
    mutex.WaitOne();
    {
        // Your code...
    }
    mutex.ReleaseMutex();
    ```



## Semafor

- Semafor to bardzo popularna forma limitowania liczby wątków, które mogą mieć dostęp do danego kodu.
- Semafor składa się z dwóch metod. Jedna zwiększa pewien licznik, druga zmniejsza. 
- Wejście do sekcji krytycznej jest możliwe tylko wtedy gdy licznik jest większy od zera. 
- W .NET semafor jest realizowany za pomocą jednej z dwóch klas: Semaphore i SemaphoreSlim (dla krótkich operacji.)
- Semaphore może służyć do synchronizacji wątków miedzy procesami. Wtedy należy skorzystać z tzw. named semaphores.  W takiej sytuacji warto zwrócić szczególną uwagę na bezpieczeństwo aby złośliwe oprogramowanie nie spowodowało deadlock.
- SemaphoreSlim to odchudzona wersja przeznaczona do synchronizacji wątków znajdujących się w tym samym procesie. Semaphore z kolei to wrapper na systemowy, niezarządzany semafor, który jest potężniejszy ale znacząco wolniejszy.

## Double check

- Wzorzec stworzony w celu redukcji czasu uzyskania blokady poprzez testowanie najpierw warunku blokady (ang. lock hint) w sposób niebezpieczny, a potem dopiero – tylko w razie sukcesu – przeprowadzanie całego procesu uzyskiwania blokady.
- Struktura:
  ```
    public static SingletonSimpleLazy getInstance() {
        if (instance == null) {
            synchronized (SingletonSimpleLazy.class) {
                if (instance == null) {
                    instance = new SingletonSimpleLazy();
                }
            }
        }
        return instance;
    }
    ```
- Teraz nawet jak kilka wątków przejdzie przez blokadę, to zostaną na nich skolejkowane i nie przejdą przez drugi warunek.
- **Problem z tym wzorcem: w** ramach optymalizacji zmienne w pamięci komputera przechowywane są w cache procesora. Dlatego może dojść do sytuacji, w której jeden wątek ustawi poprawnie wartość zmiennej, ale drugi podejmie próbę jej odczytania, zanim zostanie ona jeszcze zsynchronizowana.

## Produce-consumer

- Wątek producenta generuje nowe obiekty, które trafiają do tej kolejki i sygnalizuje konsumentowi, że może sobie pobrać obiekt z tej kolejki. 
- Wzorzec załatwia sprawę synchronizowania tych dwóch zadań w przypadku, gdy jeden z nich jest wolniejszy od drugiego, np. producent wolniej produkuje, niż konsument konsumuje.
- BlockingCollection (w C#) jest specjalną kolekcją danych, przygotowaną do implementacji wzorca producent-konsument. Nakład pracy do implementacji tego wzorca jest minimalny z BlockingCollection. Nie musimy martwić się o synchronizację, sekcję krytyczną czy deadlock. 
