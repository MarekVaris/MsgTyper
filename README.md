# MsgTyper

Prosta aplikacja do wysyłania wiadomości z użyciem interfejsu użytkownika w technologii Windows Forms. Aplikacja obejmuje:

1. Zabezpieczenia na poziomie loginu:
* Admin: Pełen dostęp do funkcji aplikacji.
* Użytkownik: Dostęp do podstawowych funkcji.
* Gość: Ograniczony dostęp.

2. Zapis danych:
* Aplikacja zapisuje informacje o wysłanych wiadomościach, w tym:
  * Kto wysłał, komu, kiedy i treść wiadomości.
  * Dane logowania (login, hasło, ew. wskazówka) są przechowywane w formie pliku JSON i są zawsze dostępne dla admina.
* Aplikacja zapisuje dane ostatnich logowań oraz wszystkie loginy (adminów oraz userów).

3. Rozwijalność:
* Aplikacja została zaprojektowana z myślą o łatwej rozbudowie.
* W przypadku dodania nowych funkcji, struktura danych i logiki aplikacji są elastyczne.
