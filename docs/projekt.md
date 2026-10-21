# 1. Opseg projekta

## 1.1 Problem i cilj projekta

Cilj projekta je razvoj web-aplikacije za upravljanje poslovanjem charter tvrtke koja se bavi iznajmljivanjem plovila. Aplikacija treba omogućiti korisnicima jednostavno pronalaženje odgovarajućeg plovila i slanje rezervacija, dok zaposlenicima tvrtke pruža jedinstveno mjesto za upravljanje flotom, rezervacijama, dodatnom opremom i uslugama.

Trenutačno se postupci poput provjere dostupnosti plovila, dogovaranja termina, evidentiranja dodatnih usluga i praćenja rezervacija mogu voditi odvojeno što može otežati pregled poslovanja i povećati mogućnost pogrešaka. Predložena aplikacija objedinjuje te postupke u jednom sustavu i omogućuje da se jednostavno vode dostupnost plovila i podaci o rezervacijama.

Očekivana korist za korisnike jest jednostavnije pretraživanje ponude, pregled cijene najma i slanje rezervacije. Za charter tvrtku očekivane su koristi lakše upravljanje plovilima i rezervacijama, smanjenje mogućnosti dvostrukog rezerviranja istog plovila u preklapajućim terminima i jednostavnije praćenje poslovnih podataka.

Očekivane koristi nisu predstavljene kao već izmjereni rezultati. Npr., aplikacija bi trebala smanjiti mogućnost pogrešaka pri evidentiranju rezervacija, ali stvarno smanjenje njihova broja moglo bi se potvrditi tek nakon uporabe sustava i usporedbe s prethodnim postupkom.

## 1.2 Ciljani korisnici i dionici

Ciljani korisnici i dionici razlikuju se prema tome koriste li aplikaciju izravno ili utječu na zahtjeve i ograničenja sustava.

| Skupina korisnika ili dionika | Potreba ili interes relevantan za ovaj projekt |
| --- | --- |
| Korisnik koji želi unajmiti plovilo | Pregledati ponudu plovila, pretraživati prema željenom terminu i karakteristikama, vidjeti cijenu i poslati, pregledati ili otkazati vlastitu rezervaciju u skladu s pravilima sustava. |
| Djelatnik charter tvrtke | Pregledati rezervacije i raspored plovila te imati pristup podacima potrebnima za organizaciju preuzimanja i povratka plovila. |
| Administrator | Upravljati podacima o plovilima, lukama, vrstama plovila, fotografijama, opremi, uslugama i nedostupnim terminima te održavati ispravnost podataka sustava. |
| Voditelj charter tvrtke | Pregledati podatke o rezervacijama i poslovanju, pratiti ukupne iznose rezervacija i dobiti izvještaje koji olakšavaju procjenu poslovnih rezultata. |
| Vlasnik ili uprava charter tvrtke (dionik) | Osigurati da aplikacija podržava poslovne potrebe tvrtke, olakšava organizaciju najma i omogućuje kontrolu pristupa podacima prema njihovim ulogama. |
| Pružatelji vanjskih usluga (dionici) | Omogućiti korištenje vanjskih usluga koje aplikacija treba za slanje e-pošte, prikaz karte ili dohvat vremenske prognoze, ovisno o dostupnosti i uvjetima tih usluga. |
| Korisnici čiji se osobni podaci obrađuju i nadležna tijela za zaštitu podataka (dionici) | Očekuju odgovarajuću zaštitu osobnih podataka, sigurnu obradu korisničkih računa i ograničavanje pristupa podacima samo na ovlaštene osobe. |

Navedene skupine imaju različite potrebe i ovlasti. Korisnik koji unajmljuje plovilo ne treba imati iste mogućnosti kao administrator ili voditelj, a djelatnik treba pristupati samo funkcionalnostima potrebnima za njegov posao. Aplikacija zato mora razlikovati korisničke uloge i kontrolirati pristup odgovarajućim funkcionalnostima.

Neobavezna persona: Baltazar, korisnik koji planira ljetovanje s prijateljima, želi pronaći plovilo dovoljnog kapaciteta u odgovarajućem terminu i unaprijed znati koliko će najam koštati. Ovaj primjer pokazuje zašto su pretraživanje prema kapacitetu i terminu te prikaz ukupne cijene važni za korisničko sučelje. Persona služi za pojašnjenje projektne odluke, nije tvrdnja o stvarnom korisniku.

## 1.3 Granice projekta

Granice projekta određuju funkcionalnosti koje pripadaju prvoj inačici aplikacije, funkcionalnosti koje su izostavljene te vanjske usluge o kojima sustav ovisi.

**Uključeno:**

- Registracija i prijava korisnika te upravljanje pristupom prema korisničkim ulogama.
- Pregled i pretraživanje plovila prema kriterijima kao što su termin najma, luka, vrsta plovila i kapacitet.
- Prikaz osnovnih podataka o plovilu, njegovih fotografija, opreme, matične luke i cijene najma.
- Slanje, pregled, potvrđivanje i otkazivanje rezervacija u skladu s pravilima sustava.
- Evidentiranje termina rezervacija i nedostupnosti plovila te provjera preklapanja termina.
- Odabir dodatnih usluga i dodatne opreme te izračun ukupnog iznosa rezervacije.
- Upravljanje plovilima, lukama, vrstama plovila, fotografijama, opremom, uslugama i nedostupnošću.
- Slanje e-pošte povezane s rezervacijama, uključujući obavijesti o njihovu statusu.
- Pregled poslovnih podataka, osnovne statistike i izvoz odgovarajućih podataka u CSV formatu.
- Prilagodba korisničkog sučelja različitim veličinama zaslona.
- Prikaz lokacija na karti i vremenske prognoze putem vanjskih usluga, u granicama projektnog zadatka i mogućnosti tih usluga.

**Izvan opsega ili odgođeno:**

- **Online plaćanje:** aplikacija prikazuje izračunati iznos najma i odabranih dodataka, ali ne provodi naplatu niti obrađuje podatke o platnim karticama.
- **Zaseban sustav dodjele radnih zadataka djelatnicima:** aplikacija ne uključuje upravljanje zadacima, njihovu dodjelu i praćenje izvršenja kroz poseban modul.
- **Automatsko upravljanje plovilima:** aplikacija evidentira podatke i omogućuje organizaciju poslovanja, ali ne upravlja fizičkim plovilima.
- **Neograničena vremenska prognoza:** prikaz prognoze ovisi o razdoblju za koje odabrani vanjski pružatelj usluge (meteorološki servis) nudi podatke.

**Vanjske ovisnosti:**

- **Neon PostgreSQL:** pruža pohranu podataka o korisnicima, plovilima, rezervacijama, opremi, uslugama i ostalim poslovnim podacima.
- **Gmail API i OAuth 2.0:** omogućuju autorizirani pristup Gmail računu aplikacije radi slanja e-pošte. Prijava korisnika u samu aplikaciju zasebno se rješava kroz OAuth sustav, preko AAI@EduHr identiteta.
- **Kartografska usluga:** omogućuje prikaz lokacija i karte, ovisno o mogućnostima i uvjetima korištenja odabranog kartografskog servisa.
- **Meteorološka usluga:** omogućuje dohvat vremenske prognoze za relevantnu lokaciju i termin, ovisno o mogućnostima i uvjetima korištenja meteorološkog servisa.
- **Hosting aplikacije:** aplikacija se postavlja na hosting platformu kako bi joj korisnici mogli pristupati putem interneta.

Vanjske usluge odgovorne su za vlastite podatke i dostupnost. Aplikacija ostaje odgovorna za ispravnost vlastitih poslovnih podataka i pravila rezerviranja. Npr., prikaz vremenske prognoze ne predstavlja jamstvo vremenskih uvjeta, a prikaz plovila kao dostupnog mora se temeljiti na podacima o rezervacijama i nedostupnosti u aplikaciji.

## 1.4 Postojeći pristupi i opravdanost projekta

Pri organizaciji najma plovila informacije o ponudi, raspoloživim terminima, korisnicima i dodatnim uslugama mogu se razmjenjivati putem e-pošte ili različitih evidencija. Takav postupak može zahtijevati ručno uspoređivanje termina i zasebno ažuriranje podataka, osobito kada više osoba sudjeluje u upravljanju rezervacijama. Predložena aplikacija objedinjuje te informacije i omogućuje pregled dostupnosti plovila, evidentiranje rezervacija i automatski izračun ukupnog iznosa. Time se nastoji olakšati rad korisnicima i zaposlenicima te smanjiti mogućnost pogrešaka uzrokovanih nepovezanim evidencijama.

---

**Završna provjera**

- Opis problema i cilj projekta odgovaraju potrebama korisnika i charter tvrtke.
- Navedene su glavne skupine korisnika i dionika i njihovi interesi.
- Uključene funkcionalnosti odgovaraju odobrenom projektnom zadatku.
- Izostavljene su funkcionalnosti koje nisu dio dogovorenog opsega, uključujući online plaćanje, pakete popusta i zaseban sustav dodjele zadataka.
- Vanjske ovisnosti navedene su bez pretpostavke da aplikacija može kontrolirati njihovu dostupnost ili jamčiti točnost njihovih podataka.
- Očekivane koristi predstavljene su kao ciljevi projekta, a ne kao već izmjereni rezultati.
