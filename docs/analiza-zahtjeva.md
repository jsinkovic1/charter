# 2. Analiza zahtjeva

Cilj analize zahtjeva je definirati funkcionalnosti i svojstva kvalitete aplikacije za podršku charter poslovanju i iznajmljivanju plovila. Zahtjevi proizlaze iz izvornog zadatka te odabranih projektnih odluka. Svaki zahtjev ima jedinstvenu oznaku, prioritet, izvor i kriterije prema kojima se može provjeriti njegova realizacija.

## 2.1 Funkcijski zahtjevi

Funkcijski zahtjevi opisuju mogućnosti koje aplikacija mora pružiti korisnicima i djelatnicima charter tvrtke.

| ID | Opis | Prioritet | Izvor | Kriteriji prihvaćanja |
|---|---|---|---|---|
| F-001 | Administrator može stvarati, uređivati i deaktivirati račune djelatnika i voditelja. | Visok | Odobreni zadatak, odluka tima | Administrator može upravljati računima i dodijeliti odgovarajuću ulogu. Deaktivirani korisnik ne može se prijaviti. |
| F-002 | Posjetiteljima je omogućen pregled plovila i dodatnih usluga. | Visok | Odobreni zadatak | Bez prijave moguće je pregledavati katalog plovila, njihove detalje i dostupne dodatne usluge. Za izradu rezervacije potrebna je prijava. |
| F-003 | Sustav omogućuje pretraživanje i filtriranje plovila prema nazivu, terminu najma, matičnoj luci, vrsti plovila i potrebnom kapacitetu. | Visok | Odobreni zadatak, odluka tima | Moguće je kombinirati kriterije pretrage. Prikazuju se samo plovila koja zadovoljavaju odabrane kriterije i raspoloživa su tijekom cijelog traženog razdoblja. Ako nema rezultata, prikazuje se odgovarajuća poruka. |
| F-004 | Sustav prikazuje detalje plovila, njegovu raspoloživost i lokaciju matične luke na karti. | Visok | Odobreni zadatak | Detalji uključuju naziv, vrstu, proizvođača i model, godinu proizvodnje, kapacitet, broj kabina i ležajeva, opremu, fotografije, matičnu luku i cijenu najma. Prikaz raspoloživosti obuhvaća rezervacije i razdoblja nedostupnosti, bez otkrivanja podataka drugih klijenata. |
| F-005 | Sustav prikazuje vremensku prognozu za mjesto i razdoblje planiranog najma. | Visok | Odobreni zadatak | Korisniku se prikazuju dostupni podaci o temperaturi, vjetru i vremenskim uvjetima. Ako prognoza nije dostupna, prikazuje se obavijest, a ostale funkcionalnosti aplikacije nastavljaju raditi. |
| F-006 | Prijavljeni klijent može izraditi rezervaciju plovila za odabrano razdoblje i odabrati dodatne usluge. | Visok | Odobreni zadatak | Klijent odabire raspoloživo plovilo, datume najma i željene dodatne usluge. Prije slanja zahtjeva prikazuje mu se izračun ukupnog iznosa. Nakon slanja rezervacija dobiva status „zahtjev za rezervaciju". |
| F-007 | Sustav sprječava preklapanje rezervacija istog plovila i vodi evidenciju zauzetosti. | Visok | Odobreni zadatak | Nije moguće izraditi rezervaciju koja se preklapa s postojećim zahtjevom za rezervaciju, potvrđenom rezervacijom ili razdobljem nedostupnosti istog plovila. Provjera se provodi i pri istodobnim zahtjevima više korisnika. |
| F-008 | Sustav vodi status rezervacije i dopušta samo definirane prijelaze između statusa. | Visok | Odobreni zadatak | Rezervacija može imati status „zahtjev za rezervaciju", „potvrđena", „otkazana" ili „završeni najam". Dopušteni su prijelazi: zahtjev → potvrđena, zahtjev → otkazana, potvrđena → otkazana i potvrđena → završeni najam. |
| F-009 | Sustav klijentu omogućuje pregled vlastitih rezervacija i pripadajućih iznosa. | Visok | Odobreni zadatak | Klijent vidi svoje rezervacije, statuse, odabrana plovila, razdoblja najma, dodatne usluge i ukupne iznose. Nije mu dopušten pristup rezervacijama drugih klijenata. |
| F-010 | Sustav šalje potvrdu rezervacije elektroničkom poštom. | Visok | Odobreni zadatak | Nakon potvrde rezervacije klijent prima poruku s podacima o plovilu, razdoblju najma, dodatnim uslugama, ukupnom iznosu i mjestu preuzimanja. |
| F-011 | Sustav omogućuje klijentu izmjenu i otkazivanje vlastite rezervacije. | Visok | Odluka tima | Do početka najma klijent može promijeniti razdoblje najma ili odabrane usluge, uz ponovnu provjeru raspoloživosti i izračun cijene. Otkazivanjem se mijenja status rezervacije, a termin postaje raspoloživ. |
| F-012 | Sustav klijentima i djelatnicima prikazuje raspored preuzimanja i povrata plovila. | Visok | Odobreni zadatak, odluka tima | Klijent vidi raspored vlastitih najmova. Djelatnik vidi raspored po danu s podacima o plovilu, klijentu, vremenu i mjestu preuzimanja odnosno povrata te odabranim uslugama. |
| F-013 | Sustav omogućuje djelatniku evidentiranje preuzimanja i povrata plovila. | Visok | Odobreni zadatak | Djelatnik može evidentirati preuzimanje i povrat plovila. Nakon evidentiranog povrata rezervacija prelazi u status „završeni najam". |
| F-014 | Administrator može dodavati, uređivati i deaktivirati plovila te upravljati njihovim podacima i opremom. | Visok | Odobreni zadatak | Administrator može unijeti osnovne podatke o plovilu, kategoriju, fotografije, matičnu luku i opremu. Izmjene su vidljive u katalogu. Plovilo povezano s rezervacijama ne može se trajno obrisati, ali se može deaktivirati. |
| F-015 | Administrator može definirati cijene najma i upravljati dodatnim uslugama. | Visok | Odobreni zadatak | Administrator može odrediti cijenu najma plovila te dodavati, uređivati i deaktivirati dodatne usluge i njihove cijene. Promjena cijene ne mijenja iznose već izrađenih rezervacija. |
| F-016 | Administrator može pregledavati i upravljati rezervacijama. | Visok | Odobreni zadatak | Administrator može pregledavati i filtrirati rezervacije, potvrđivati zahtjeve te otkazivati rezervacije u skladu s definiranim pravilima. Potvrda rezervacije pokreće slanje poruke klijentu. |
| F-017 | Administrator može evidentirati razdoblja nedostupnosti plovila zbog održavanja, servisa ili drugih razloga. | Visok | Odobreni zadatak | Administrator unosi razdoblje i razlog nedostupnosti. Plovilo se u tom razdoblju ne prikazuje kao raspoloživo. Ako razdoblje zahvaća potvrđenu rezervaciju, sustav odbija unos dok se sukob ne riješi. |
| F-018 | Sustav voditelju omogućuje pregled statističkih podataka o poslovanju. | Srednji | Odobreni zadatak | Za odabrano razdoblje voditelj može pregledati broj rezervacija, zauzetost plovila, ugovorene iznose rezervacija te najtraženije kategorije plovila i dodatne usluge. |
| F-019 | Sustav omogućuje izvoz izvještaja u standardnom formatu. | Srednji | Odobreni zadatak | Voditelj i administrator mogu izvesti odabrane izvještaje u CSV formatu. Izvezena datoteka sadrži podatke prikazane u izvještaju i može se otvoriti u uobičajenom programu za proračunske tablice. |

## 2.2 Nefunkcijski zahtjevi

Nefunkcijski zahtjevi definiraju svojstva kvalitete, sigurnosne uvjete i uvjete rada aplikacije.

| ID | Opis | Prioritet | Izvor | Način provjere |
|---|---|---|---|---|
| NF-01 | Sučelje mora biti responzivno i prilagođeno računalima, tabletima i mobilnim uređajima. | Visok | Odobreni zadatak | Provjeriti ključne funkcionalnosti na širinama zaslona od 360, 768 i 1280 px te na mobilnom uređaju. |
| NF-02 | Pristup podacima i funkcionalnostima mora biti ograničen prema korisničkim ovlastima. | Visok | Odobreni zadatak | Pokušaji pristupa zaštićenim stranicama i podacima bez odgovarajućih ovlasti moraju biti odbijeni. |
| NF-03 | Sustav mora podržavati istodobni rad više korisnika bez narušavanja konzistentnosti podataka. | Visok | Odobreni zadatak | Pri istodobnim zahtjevima za isto plovilo i preklapajući termin smije uspjeti najviše jedan zahtjev. |
| NF-04 | Lozinke se moraju pohranjivati u obliku sigurnog kriptografskog sažetka uz korištenje soli, a ne kao čitljiv tekst. | Visok | Odluka tima | Pregledati implementaciju autentifikacije i način pohrane podataka. |
| NF-05 | Nedostupnost vanjskih meteoroloških i kartografskih servisa ne smije onemogućiti osnovne funkcionalnosti aplikacije. | Srednji | Odobreni zadatak | Simulirati nedostupnost servisa i provjeriti prikaz obavijesti te nastavak rada ostalih funkcionalnosti. |
| NF-06 | Projekt mora imati dokumentaciju propisanu uputama kolegija. | Visok | Upute kolegija | Provjeriti potpunost i usklađenost dokumentacije sa stvarnom implementacijom. |
| NF-07 | Projekt mora sadržavati plan implementacije koji omogućuje postavljanje i pokretanje aplikacije u novom okruženju. | Visok | Upute kolegija | Slijediti dokumentirane korake na čistom okruženju i provjeriti ispravnost pokretanja sustava. |

## 2.3 Dionici i akteri

Dionici su osobe ili organizacije koje imaju interes u sustavu, dok su akteri oni koji izravno komuniciraju s aplikacijom ili vanjski sustavi s kojima aplikacija razmjenjuje podatke.

| ID aktera | Uloga | Odnos prema sustavu | Relevantni zahtjevi |
|---|---|---|---|
| A-01 | Posjetitelj | Pregledava plovila i usluge te se može registrirati. | F-002–F-005 |
| A-02 | Klijent | Pretražuje plovila, izrađuje i upravlja vlastitim rezervacijama te pregledava raspored najma. | F-003–F-012 |
| A-03 | Djelatnik | Pregledava raspored preuzimanja i povrata te evidentira realizaciju najma. | F-012, F-013 |
| A-04 | Voditelj charter tvrtke | Pregledava statističke podatke i izvozi izvještaje. | F-018, F-019 |
| A-05 | Administrator sustava | Upravlja korisnicima, plovilima, opremom, cijenama, uslugama, rezervacijama i nedostupnošću plovila. | F-001, F-014–F-017, F-019 |
| A-06 | Meteorološki servis | Isporučuje podatke o vremenskoj prognozi. | F-005, NF-05 |
| A-07 | Kartografski servis | Omogućuje prikaz karte i lokacija plovila. | F-004, NF-05 |
| A-08 | Servis za slanje e-pošte | Omogućuje slanje potvrda rezervacija klijentima. | F-010 |

## 2.4 Ograničenja i pretpostavke

Ovaj odjeljak navodi projektna ograničenja i pretpostavke na kojima se temelji oblikovanje sustava.

| ID | Tip | Opis ograničenja ili pretpostavke | Izvor | Inženjerska posljedica / provjera |
|---|---|---|---|---|
| C-01 | Ograničenje | Sustav mora biti povezan s meteorološkim servisom. | Odobreni zadatak | Integraciju je potrebno implementirati i provjeriti ponašanje pri nedostupnosti servisa. |
| C-02 | Ograničenje | Sustav mora koristiti kartografski servis za prikaz lokacije matične luke. | Odobreni zadatak | Potrebno je osigurati prikaz lokacije i obradu pogrešaka vanjskog servisa. |
| C-03 | Ograničenje | Potvrda rezervacije dostavlja se elektroničkom poštom. | Odobreni zadatak | Potrebna je integracija sa servisom za slanje e-pošte. |
| C-04 | Ograničenje | Izvještaji se moraju moći izvesti u najmanje jednom standardnom formatu. | Odobreni zadatak | Odabran je CSV format. |
| C-05 | Ograničenje | Aplikacija mora podržavati računala, tablete i mobilne uređaje. | Odobreni zadatak | Korisničko sučelje mora biti responzivno. |
| AS-01 | Pretpostavka | Zahtjeve za rezervaciju ručno potvrđuje administrator. | Odluka tima | Potvrda mijenja status rezervacije i pokreće slanje e-pošte. |
| AS-02 | Pretpostavka | Zahtjev za rezervaciju i potvrđena rezervacija zauzimaju termin, dok otkazana rezervacija oslobađa termin. | Odluka tima | Pravilo se primjenjuje u pretrazi, kalendaru i provjeri novih rezervacija. |
| AS-03 | Pretpostavka | Najam se obračunava prema broju noćenja. Datum preuzimanja uključen je u razdoblje najma, a datum povrata predstavlja završetak najma i ne obračunava se kao dodatno noćenje. | Odluka tima | Broj noćenja izračunava se kao razlika između datuma povrata i datuma preuzimanja. |
| AS-04 | Pretpostavka | Online plaćanje nije dio opsega projekta. Sustav prikazuje ukupni ugovoreni iznos rezervacije, ali ne obrađuje transakcije. | Odluka tima | Nije potrebno implementirati platni sustav ni evidenciju izvršenih uplata. |
| AS-05 | Pretpostavka | Cijena osnovnog najma određuje se po noćenju, a cijene odabranih dodatnih usluga prema unaprijed definiranim cijenama. | Odluka tima | Ukupni iznos izračunava se iz broja noćenja, cijene najma i odabranih usluga. |
| AS-06 | Pretpostavka | Jedna rezervacija odnosi se na jedno plovilo. | Odluka tima | Svaka rezervacija povezana je s jednim plovilom i jednim razdobljem najma. |
| AS-07 | Pretpostavka | Klijent može izmijeniti ili otkazati rezervaciju do početka najma. Posebne naknade za otkazivanje nisu dio opsega projekta. | Odluka tima | Izmjena zahtijeva ponovnu provjeru raspoloživosti i izračun ukupnog iznosa. |
| AS-08 | Pretpostavka | Dostupnost vremenske prognoze ovisi o mogućnostima i vremenskom rasponu odabranog meteorološkog servisa. | Odluka tima | Za nedostupne podatke sustav prikazuje odgovarajuću obavijest. |
| AS-09 | Pretpostavka | Prihod se ne prikazuje kao stvarno naplaćen iznos jer sustav ne evidentira plaćanja. Izvještaji prikazuju ugovorene iznose rezervacija i, prema potrebi, zasebno iznose završenih najmova. | Odluka tima | Izračuni izvještaja moraju jasno razlikovati statuse rezervacija. |
| AS-10 | Pretpostavka | Matična luka plovila ujedno je mjesto njegova preuzimanja i povrata. | Odluka tima | Nije potrebno zasebno evidentirati alternativne lokacije preuzimanja i povrata. |

## 2.5 Značajne promjene zahtjeva

Ovaj odjeljak služi za evidentiranje naknadnih promjena koje utječu na dogovoreni opseg projekta, prioritete ili kriterije prihvaćanja.

Promjene se evidentiraju tijekom razvoja projekta, uz datum, opis promjene, razlog i osobu ili kontrolnu točku na kojoj je promjena dogovorena.

| Datum | ID zahtjeva | Promjena i razlog | Dogovoreno s / dokaz |
|---|---|---|---|
| — | — | Nema evidentiranih promjena u početnoj verziji dokumenta. | — |

## 2.6 Sljedivost zahtjeva

Sljedivost povezuje zahtjeve s funkcionalnim cjelinama aplikacije, planiranom arhitekturnom realizacijom i načinima provjere. Arhitekturne komponente i konkretni testovi definirat će se tijekom projektiranja i implementacije.

| ID zahtjeva | Obrazac uporabe / modul | Arhitekturna realizacija | Ispitivanje / provjera |
|---|---|---|---|
| F-001 | Korisnici i autentifikacija | Modul korisnika, autentifikacija i autorizacija | Registracija, prijava, odjava i upravljanje računima |
| F-002–F-004 | Katalog i pretraga plovila | Modul plovila, opreme, pretrage i prikaza karte | Pregled detalja, kombiniranje filtera i provjera raspoloživosti |
| F-005 | Vremenska prognoza | Integracija s meteorološkim servisom | Provjera prikaza prognoze i ponašanja pri nedostupnosti servisa |
| F-006–F-008 | Rezervacije | Modul rezervacija, provjera preklapanja i upravljanje statusima | Izrada rezervacije, provjera preklapanja i dopuštenih prijelaza statusa |
| F-009–F-011 | Pregled i izmjena rezervacija | Modul rezervacija i obračuna cijena | Pregled vlastitih rezervacija, izmjena, otkazivanje i provjera iznosa |
| F-010 | Obavijesti | Integracija sa servisom za slanje e-pošte | Provjera slanja potvrde rezervacije |
| F-012–F-013 | Raspored i realizacija najma | Modul rasporeda i evidencije preuzimanja i povrata | Provjera prikaza rasporeda i evidentiranja događaja |
| F-014 | Upravljanje flotom | Modul plovila i opreme | Dodavanje, uređivanje i deaktivacija plovila |
| F-015 | Cijene i dodatne usluge | Modul cjenika i obračuna rezervacija | Provjera izračuna cijene i očuvanja iznosa postojećih rezervacija |
| F-016 | Administracija rezervacija | Administracijski modul rezervacija | Filtriranje, potvrđivanje i otkazivanje rezervacija |
| F-017 | Upravljanje raspoloživošću | Modul nedostupnosti plovila | Unos razdoblja nedostupnosti i provjera sukoba s rezervacijama |
| F-018–F-019 | Izvještavanje | Modul statistike i izvoza podataka | Provjera statističkih izračuna i sadržaja CSV datoteke |
| NF-01 | Sva korisnička sučelja | Responzivni klijentski dio aplikacije | Provjera sučelja na različitim širinama zaslona |
| NF-02, NF-04 | Sigurnost sustava | Autentifikacija, autorizacija i sigurna pohrana lozinki | Testovi pristupa i pregled pohrane podataka |
| NF-03 | Rezervacije | Transakcijska obrada i zaštita konzistentnosti podataka | Test istodobnih zahtjeva za isto plovilo i termin |
| NF-05 | Vanjske integracije | Obrada pogrešaka i izdvojeni moduli integracija | Simulacija nedostupnosti vanjskih servisa |
| NF-06 | Dokumentacija projekta | Projektna dokumentacija | Pregled dokumentacije |
| NF-07 | Plan implementacije | Konfiguracija i postupak postavljanja aplikacije | Postavljanje i pokretanje sustava u novom okruženju |

## 2.7 Pregled zahtjeva

Pregled zahtjeva provodi se tijekom važnih kontrolnih točaka projekta radi provjere usklađenosti implementacije s izvornim zadatkom i dogovorenim opsegom.

| Kontrolna točka | Povratna informacija ili nalaz | Odluka o zahtjevu ili opsegu |
|---|---|---|
| Iteracija 1 | Evidentirati nalaze pregleda osnovnih funkcionalnosti. | Ažurirati zahtjeve prema dogovorenim promjenama. |
| Demo 2 | Evidentirati nalaze pregleda implementiranih modula i integracija. | Utvrditi eventualne korekcije i preostale funkcionalnosti. |
| Završni pregled | Provjeriti ispunjenost zahtjeva i kriterija prihvaćanja. | Potvrditi završni opseg projekta i dokumentirati eventualna odstupanja. |
