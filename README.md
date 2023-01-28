# ASP-.NET-Web-App
ASP NET study project 

27.12
Początek projektu

Aplikacja została napisana w standardzie .NET 5.0

Każdy użytkownik po uruchomieniu strony ma dostęp do [linku] https://localhost:52967/Identity/Account/Login?ReturnUrl=%2F, na którym w formularzu
pozostawia swoje dane do logowania:

![image](https://user-images.githubusercontent.com/107003776/215272131-a7860a6d-6e8c-4c1f-bd3f-f107ea35c0ae.png)

Lub rejestacji:
[Link] https://localhost:52967/Identity/Account/Register

![image](https://user-images.githubusercontent.com/107003776/215272212-bd6c413e-ea99-41f3-aabf-7d5b27ad772d.png)


Przy logowaniu do strony dostępna jest opcja zapisania danych logowania, oraz dostęp do weryfikacji dwuetapowej podczas kofiguracji konta na stronie z opcją zapamiętania urządzenia
[LINK] https://localhost:52967/Identity/Account/LoginWith2fa?ReturnUrl=%2F&RememberMe=False
W przypadku tej aplikacji wykorzystuje aplikacje androidową Google Authenticator 

![image](https://user-images.githubusercontent.com/107003776/215272394-e135af1d-9830-4570-a9c4-85ff87b594a7.png)

Po wysłaniu formularza logowania aplikacja zwraca stronę główną dla użytkownika [LINK] https://localhost:52967 (home index) 

![image](https://user-images.githubusercontent.com/107003776/215272506-525b90e1-4132-433c-b986-2828b25b1c8e.png)

Użytkownik, posiadający konto w serwisie po zalogowaniu ma dostęp do:

• Strony z profilem, na której może edytować własne dane, tzn:
Nazwę użytkownika oraz nr telefonu (nieobowiązkowy)
[LINK] https://localhost:52967/Identity/Account/Manage
![image](https://user-images.githubusercontent.com/107003776/215272620-7fdf36f6-1cd3-4c03-a4f9-40f5ce038fbc.png)
Możliwość zmiany emailu (wykorzystywanej jako nazwa użytkownika) 
[LINK] https://localhost:52967/Identity/Account/Manage/Email
![image](https://user-images.githubusercontent.com/107003776/215272762-32f62188-93a6-4638-925f-e1d0027e869d.png)
Zmiany hasła do strony (z poprzedzeniem użycia obecnego hasła)
[LINK] https://localhost:52967/Identity/Account/Manage/ChangePassword
![image](https://user-images.githubusercontent.com/107003776/215272779-67dac57f-87aa-487c-b80f-821afeb238f8.png)
Weryfikację dwuetapową wymaganą przy logowaniu na skonfigurowanym koncie użytkownika (Google Authenticator app)
[LINK] https://localhost:52967/Identity/Account/Manage/TwoFactorAuthentication
![image](https://user-images.githubusercontent.com/107003776/215272812-d5167594-22c9-44f2-9a13-a84f208998fb.png)
Strona informująca o posiadanych danych, gdzie można je pobrać bezpośrednio z aplikacji, oraz opcja pełnego usinięcia konta 
[LINK] https://localhost:52967/Identity/Account/Manage/PersonalData
![image](https://user-images.githubusercontent.com/107003776/215272869-50247673-1159-43ca-8a76-1b98d82cbd93.png)



• Strony na której może dodawać oraz generować (poprzez przykładowy generator hasłowy) hasła do stron internetowych wymagających logowania i zapisywać je w bazie danych. Po utworzeniu hasła strona przekierowuje do banku haseł
[LINK] https://localhost:52967/PasswordModels/AddOrEdit
![image](https://user-images.githubusercontent.com/107003776/215273163-4b5b6399-7168-403c-80c7-3a8be45f73da.png)

• Wspomnianego wyżej banku haseł, który wyświetla wszystkie zapisane hasła dla użytkownika, wraz z możliwością ich edycji, bezpośredniego wglądu oraz usunięcia z bazy.
Na stronie znajduje się również przycisk który przekierowuje do utworzenia hasła.
[LINK] https://localhost:52967/PasswordModels
![image](https://user-images.githubusercontent.com/107003776/215273282-eec9c6ab-8b02-44b2-879b-718f794b1eb5.png)

W aplikacji nie występuje rozróżnienie na role logowania, ze względu na charakterystykę aplikacji. 

Aplikacja nie zezwala na przeglądanie zawartości bez posiadanego konta oraz zapisu własnych haseł ze względów bezpieczeństwa.

WALIDACJA:
W przypadku braku wpisanych danych podczas logowania lub rejestacji formularz informuje o błędzie 

![image](https://user-images.githubusercontent.com/107003776/215273568-7b2ff700-c68f-44e1-8669-39936f43cfaf.png)

![image](https://user-images.githubusercontent.com/107003776/215273579-10ac3dde-d499-40d8-aeda-b9838145fa0b.png)

W przypadku zmiany hasła strona zobowiązuje do podania obecnego hasła zwracając błąd

![image](https://user-images.githubusercontent.com/107003776/215273663-dc277d7f-2239-436e-acd5-4b530f8e0290.png)




W przypadku implementacji testów jednostkowych występuje błąd nieznanego pochodzenia
![image](https://user-images.githubusercontent.com/107003776/215273889-60d23787-a2cf-454f-8ca3-5b10d8b38849.png)






