# 2. Analiza zahtjeva

Cilj analize zahtjeva je definirati funkcionalnosti i svojstva kvalitete aplikacije za podršku charter poslovanju i iznajmljivanju plovila. Zahtjevi proizlaze iz izvornog zadatka, uputa kolegija i odabranih projektnih odluka. Svaki zahtjev ima jedinstvenu oznaku, prioritet, izvor i kriterije prema kojima se može provjeriti njegova realizacija.

**Terminologija.** U cijeloj dokumentaciji koriste se sljedeći pojmovi: *vrsta plovila* (jedrilica, motorni brod, katamaran i sl.; ujedno kategorija plovila i tip iz zadatka), *kapacitet* (najveći broj osoba na plovilu), *matična luka* (ujedno mjesto preuzimanja i povrata plovila, ujedno polazna lokacija pri pretrazi), *dodatna usluga* (usluga ili dodatna oprema koju klijent može odabrati uz najam, npr. skiper, završno čišćenje), *klijent* (prijavljeni korisnik koji rezervira plovilo) i *posjetitelj* (neprijavljeni korisnik).


## 2.1 Funkcijski zahtjevi

Funkcijski zahtjevi opisuju mogućnosti koje aplikacija mora pružiti korisnicima i djelatnicima charter tvrtke.

## 2.1 Funkcijski zahtjevi
 
Funkcijski zahtjevi opisuju mogućnosti koje aplikacija mora pružiti korisnicima i djelatnicima charter tvrtke. Prioritet određuje redoslijed isporuke: svi su zahtjevi dio odobrenog opsega, a „Srednji" označava zahtjeve koji ne blokiraju osnovni tijek pretrage i rezervacije. Prijava putem AAI@EduHr nije funkcijski zahtjev nego projektno ograničenje (C-01).
 
| ID | Opis | Prioritet | Izvor | Kriteriji prihvaćanja |
|---|---|---|---|---|
| F-001 | Administrator upravlja korisničkim računima: pregledava ih, dodjeljuje ulogu (klijent, djelatnik, voditelj, administrator) te deaktivira i ponovno aktivira račune. | Visok | Odobreni zadatak, odluka tima | Promjena uloge mijenja dostupne funkcionalnosti korisnika pri sljedećem zahtjevu. Deaktivirani korisnik ne može pristupiti sustavu ni nakon uspješne AAI@EduHr autentifikacije. Sustav ne dopušta deaktivaciju ni uklanjanje uloge zadnjem aktivnom administratoru. |
| F-002 | Posjetitelji bez prijave pregledavaju katalog plovila i dodatne usluge. | Visok | Odobreni zadatak | Katalog prikazuje aktivna plovila s osnovnim podacima i dodatne usluge s cijenama. Za izradu rezervacije potrebna je prijava. |
| F-003 | Sustav omogućuje pretraživanje i filtriranje plovila prema nazivu, terminu najma, matičnoj luci, vrsti plovila i potrebnom kapacitetu. | Visok | Odobreni zadatak | Kriteriji se mogu kombinirati. Prikazuju se samo plovila koja zadovoljavaju kriterije i slobodna su tijekom cijelog traženog razdoblja (bez zahtjeva za rezervaciju, potvrđenih rezervacija i nedostupnosti). Kada je termin zadan, uz plovilo se prikazuje cijena najma za to razdoblje. Neispravno razdoblje se odbija uz poruku, a prazan rezultat prikazuje odgovarajuću poruku. |
| F-004 | Sustav prikazuje detalje plovila i kalendar njegove raspoloživosti. | Visok | Odobreni zadatak | Detalji uključuju naziv, vrstu, proizvođača i model, godinu proizvodnje, kapacitet, broj kabina i ležajeva, opremu, fotografije, matičnu luku i cijenu najma po noćenju. Kalendar prikazuje zauzeta i nedostupna razdoblja bez podataka o klijentima. |
| F-005 | Sustav prikazuje položaj matične luke, koja je ujedno mjesto preuzimanja plovila, na karti. | Srednji | Odobreni zadatak | Na stranici plovila i u izradi rezervacije prikazuje se oznaka luke na karti. Ako kartografski servis nije dostupan, prikazuje se obavijest, a ostale funkcionalnosti rade. |
| F-006 | Sustav prikazuje vremensku prognozu za matičnu luku i razdoblje planiranog najma. | Srednji | Odobreni zadatak | Prikazuju se dostupni podaci o temperaturi, vjetru i vremenskim uvjetima. Za razdoblje izvan raspona servisa ili pri nedostupnosti servisa prikazuje se obavijest, a ostale funkcionalnosti rade. |
| F-007 | Klijent izrađuje rezervaciju plovila za odabrano razdoblje s brojem osoba i dodatnim uslugama. | Visok | Odobreni zadatak | Klijent odabire plovilo, datume, broj osoba (najviše koliko iznosi kapacitet plovila) i usluge. Prije slanja prikazuje se izračun ukupnog iznosa. Datum povrata mora biti nakon datuma preuzimanja, a preuzimanje ne smije biti u prošlosti. Nakon slanja rezervacija ima status „zahtjev za rezervaciju". |
| F-008 | Sustav sprječava preklapanje rezervacija istog plovila i vodi jednoznačnu evidenciju zauzetosti. | Visok | Odobreni zadatak | Razdoblje najma tretira se kao [preuzimanje, povrat): nova rezervacija smije početi na dan povrata prethodne. Nije moguća rezervacija koja se preklapa sa zahtjevom, potvrđenom rezervacijom ili razdobljem nedostupnosti. Provjera vrijedi i pri istodobnim zahtjevima više korisnika. |
| F-009 | Sustav vodi status rezervacije i dopušta samo definirane prijelaze između statusa. | Visok | Odobreni zadatak | Statusi: „zahtjev za rezervaciju", „potvrđena", „otkazana", „završeni najam". Dopušteni prijelazi i izvršitelji: zahtjev → potvrđena (administrator); zahtjev → otkazana (klijent povlačenjem ili administrator odbijanjem); potvrđena → otkazana (klijent do početka najma ili administrator); potvrđena → završeni najam (djelatnik evidentiranjem povrata). Ostali prijelazi se odbijaju. Svaka promjena statusa bilježi se s datumom i korisnikom. |
| F-010 | Klijent pregledava vlastite rezervacije i pripadajuće iznose. | Visok | Odobreni zadatak | Prikazuju se statusi, plovila, razdoblja, dodatne usluge i ukupni iznosi rezervacija. Klijent nema pristup rezervacijama drugih klijenata. |
| F-011 | Klijent mijenja i otkazuje vlastite rezervacije. | Srednji | Odluka tima | Izmjena razdoblja, broja osoba i usluga dopuštena je samo dok je rezervacija u statusu „zahtjev", uz ponovnu provjeru raspoloživosti i izračun iznosa. Otkazivanje je moguće do početka najma, mijenja status u „otkazana" i oslobađa termin. Naknade za otkazivanje se ne obračunavaju. |
| F-012 | Sustav klijentu šalje e-poštu: potvrdu rezervacije i obavijest o otkazivanju ili odbijanju. | Visok | Odobreni zadatak, odluka tima | Nakon potvrde rezervacije klijent prima poruku s podacima o plovilu, razdoblju, uslugama, ukupnom iznosu i mjestu preuzimanja. Pri prijelazu u status „otkazana" klijent prima obavijest. |
| F-013 | Djelatnik pregledava raspored preuzimanja i povrata plovila. | Visok | Odobreni zadatak | Za odabrani dan ili razdoblje prikazuju se potvrđene rezervacije s plovilom, klijentom (ime i e-pošta), mjestom preuzimanja odnosno povrata i odabranim uslugama. |
| F-014 | Djelatnik evidentira preuzimanje i povrat plovila. | Visok | Odobreni zadatak | Za potvrđenu rezervaciju djelatnik evidentira preuzimanje, a zatim povrat. Povrat nije moguće evidentirati prije preuzimanja. Nakon evidentiranog povrata rezervacija prelazi u status „završeni najam". |
| F-015 | Administrator upravlja plovilima, lukama, vrstama plovila, opremom i fotografijama. | Visok | Odobreni zadatak | Moguće je dodavati, uređivati i deaktivirati plovila te unositi luke (naziv i koordinate) i vrste plovila. Izmjene su vidljive u katalogu. Plovilo povezano s rezervacijama ne može se trajno obrisati; deaktivirano plovilo nije u katalogu i ne može se rezervirati, a postojeće rezervacije ostaju vidljive administratoru i djelatnicima. |
| F-016 | Administrator definira cijene najma i upravlja dodatnim uslugama. | Visok | Odobreni zadatak | Cijena najma određuje se po noćenju. Usluga ima naziv, opis, cijenu i način obračuna (jednokratno ili po noćenju) te se može deaktivirati. Promjena cijene ne mijenja iznose već izrađenih rezervacija. |
| F-017 | Administrator pregledava i upravlja rezervacijama. | Visok | Odobreni zadatak | Moguće je pregledavati i filtrirati rezervacije (status, plovilo, razdoblje, klijent), potvrditi zahtjev te odbiti ili otkazati rezervaciju prema pravilima iz F-009. Potvrda pokreće slanje e-pošte (F-012). |
| F-018 | Administrator evidentira razdoblja nedostupnosti plovila. | Visok | Odobreni zadatak | Unosi se razdoblje i razlog (servis, održavanje, drugo); unos se može uređivati i brisati. U tom razdoblju plovilo se ne prikazuje kao raspoloživo. Ako se razdoblje preklapa sa zahtjevom ili potvrđenom rezervacijom, unos se odbija dok se sukob ne riješi otkazivanjem rezervacije. |
| F-019 | Voditelj i administrator pregledavaju statistiku poslovanja i izvoze izvještaje u CSV formatu. | Srednji | Odobreni zadatak, odluka tima | Za odabrano razdoblje prikazuju se broj rezervacija, zauzetost plovila, ugovoreni iznosi te najtraženije kategorije plovila i dodatne usluge, izračunati prema AS-09. Izvezena CSV datoteka sadrži podatke prikazane u izvještaju i otvara se u uobičajenom programu za proračunske tablice. |
 
## 2.2 Nefunkcijski zahtjevi
 
Nefunkcijski zahtjevi definiraju svojstva kvalitete, sigurnosne uvjete i uvjete rada aplikacije.
 
| ID | Opis | Prioritet | Izvor | Način provjere |
|---|---|---|---|---|
| NF-01 | Sučelje mora biti responzivno i prilagođeno računalima, tabletima i mobilnim uređajima. | Visok | Odobreni zadatak | Provjeriti ključne funkcionalnosti na širinama zaslona od 360, 768 i 1280 px te na mobilnom uređaju. |
| NF-02 | Pristup podacima i funkcionalnostima mora biti ograničen prema korisničkim ovlastima, a provjera se mora provoditi na poslužitelju, a ne samo skrivanjem elemenata u sučelju. | Visok | Odobreni zadatak | Izravnim pozivima zaštićenih adresa bez prijave i s ulogama bez ovlasti provjeriti da su zahtjevi odbijeni. |
| NF-03 | Sustav mora podržavati istodobni rad više korisnika bez narušavanja konzistentnosti podataka. | Visok | Odobreni zadatak | Pri istodobnim zahtjevima za isto plovilo i preklapajući termin smije uspjeti najviše jedan zahtjev. |
| NF-04 | Nedostupnost vanjskih servisa (meteorološki, kartografski, e-pošta) ne smije onemogućiti osnovne funkcionalnosti. Za kartu i prognozu prikazuje se obavijest. Neuspjelo slanje e-pošte ne poništava promjenu statusa rezervacije i evidentira se tako da ga administrator može uočiti. | Srednji | Odobreni zadatak, odluka tima | Simulirati nedostupnost svakog servisa i provjeriti prikaz obavijesti, nastavak rada ostalih funkcionalnosti te očuvanje potvrde rezervacije uz evidentiran neuspjeh slanja. |
| NF-05 | Sustav ne pohranjuje lozinke korisnika: autentifikacija se provodi isključivo putem AAI@EduHr, promet je zaštićen HTTPS-om, a ulazni se podaci provjeravaju na poslužitelju. | Visok | Upute kolegija, odluka tima | Pregledom baze potvrditi da nema lozinki, provjeriti da se pristup preko HTTP-a preusmjerava ili odbija te unijeti neispravne i zlonamjerne vrijednosti u obrasce i provjeriti da su odbijene. |
| NF-06 | Sustav pohranjuje samo osobne podatke potrebne za rad (ime i e-pošta iz AAI@EduHr te podaci o rezervacijama). Podaci klijenta vidljivi su samo njemu te djelatniku i administratoru, a javni prikaz raspoloživosti ne otkriva podatke klijenata. | Visok | Dionici (zaštita osobnih podataka), odluka tima | Pregledati pohranjene podatke te odgovore sustava za svaku ulogu i za posjetitelja. |
 
## 2.3 Dionici i akteri
 
Dionici su osobe ili organizacije koje imaju interes u sustavu, dok su akteri oni koji izravno komuniciraju s aplikacijom ili vanjski sustavi s kojima aplikacija razmjenjuje podatke. Dionici koji nisu akteri (vlasnik ili uprava tvrtke, nadležna tijela za zaštitu podataka) opisani su u odjeljku 1.2, a njihovi se interesi odražavaju u zahtjevima NF-02, NF-05 i NF-06.
 
| ID aktera | Uloga | Odnos prema sustavu | Relevantni zahtjevi |
|---|---|---|---|
| A-01 | Posjetitelj | Pregledava katalog, raspoloživost, kartu i prognozu te se prijavljuje putem AAI@EduHr. | F-002–F-006 |
| A-02 | Klijent | Pretražuje plovila, izrađuje, mijenja i otkazuje vlastite rezervacije te ih pregledava. | F-002–F-012 |
| A-03 | Djelatnik | Pregledava katalog i raspored preuzimanja i povrata te evidentira realizaciju najma. | F-002–F-006, F-013, F-014 |
| A-04 | Voditelj charter tvrtke | Pregledava statističke podatke i izvozi izvještaje. | F-019 |
| A-05 | Administrator sustava | Upravlja korisnicima, plovilima, lukama, cijenama, uslugama, rezervacijama i nedostupnošću te pregledava statistiku. | F-001, F-015–F-019 |
| A-06 | AAI@EduHr (pružatelj identiteta) | Autentificira korisnike putem OAuth 2.0. | C-01, NF-05 |
| A-07 | Meteorološki servis | Isporučuje podatke o vremenskoj prognozi. | F-006, NF-04 |
| A-08 | Kartografski servis | Omogućuje prikaz karte i lokacije matične luke. | F-005, NF-04 |
| A-09 | Servis za slanje e-pošte | Omogućuje slanje potvrda i obavijesti klijentima. | F-012, NF-04 |
 
## 2.4 Ograničenja i pretpostavke
 
Ovaj odjeljak navodi projektna ograničenja i pretpostavke na kojima se temelji oblikovanje sustava.
 
| ID | Tip | Opis ograničenja ili pretpostavke | Izvor | Inženjerska posljedica / provjera |
|---|---|---|---|---|
| C-01 | Ograničenje | AAI@EduHr (OAuth 2.0) jedini je dopušteni način prijave u sustav. | Upute kolegija | Nema vlastite registracije ni lozinki. Pri prvoj uspješnoj prijavi automatski se stvara račun s ulogom klijenta, a uloge se vode u aplikaciji. Odustajanje od prijave ili neuspjela prijava ostavlja radnje za prijavljene korisnike nedostupnima, a nakon odjave zaštićene stranice nisu dostupne. Provjeriti prijavu, odjavu i odbijanje neautoriziranih zahtjeva. |
| C-02 | Ograničenje | Sustav mora biti povezan s meteorološkim servisom. | Odobreni zadatak | Integraciju je potrebno implementirati i provjeriti ponašanje pri nedostupnosti servisa. |
| C-03 | Ograničenje | Sustav mora koristiti kartografski servis za prikaz položaja matične luke i mjesta preuzimanja. | Odobreni zadatak | Potrebno je osigurati prikaz lokacije i obradu pogrešaka vanjskog servisa. |
| C-04 | Ograničenje | Potvrda rezervacije dostavlja se elektroničkom poštom. | Odobreni zadatak | Potrebna je integracija sa servisom za slanje e-pošte (odabran Gmail API). |
| C-05 | Ograničenje | Izvještaji se moraju moći izvesti u najmanje jednom standardnom formatu. | Odobreni zadatak | Odabran je CSV format. |
| C-06 | Ograničenje | Aplikacija mora podržavati računala, tablete i mobilne uređaje. | Odobreni zadatak | Korisničko sučelje mora biti responzivno. |
| C-07 | Ograničenje | Projekt mora imati dokumentaciju propisanu uputama kolegija. | Upute kolegija | Pregledati potpunost i usklađenost dokumentacije sa stvarnom implementacijom. |
| C-08 | Ograničenje | Projekt mora imati plan implementacije koji omogućuje postavljanje i pokretanje aplikacije u novom okruženju. | Upute kolegija | Slijediti dokumentirane korake na čistom okruženju i provjeriti ispravnost pokretanja. |
| AS-01 | Pretpostavka | Zahtjeve za rezervaciju ručno potvrđuje administrator. | Odluka tima | Potvrda mijenja status rezervacije i pokreće slanje e-pošte. |
| AS-02 | Pretpostavka | Zahtjev za rezervaciju i potvrđena rezervacija zauzimaju termin, dok otkazana rezervacija oslobađa termin. Zahtjev ne istječe automatski; neobrađene zahtjeve rješava administrator. | Odluka tima | Pravilo se primjenjuje u pretrazi, kalendaru i provjeri novih rezervacija. Rizik: dugo neobrađen zahtjev blokira termin. |
| AS-03 | Pretpostavka | Najam se obračunava prema broju noćenja. Datum preuzimanja uključen je u razdoblje najma, a datum povrata označava njegov kraj i ne obračunava se kao noćenje, pa nova rezervacija smije početi na dan povrata prethodne. Rezervacije se vode po datumima, bez sata preuzimanja i povrata. | Odluka tima | Broj noćenja je razlika datuma povrata i preuzimanja (najmanje 1). Provjeriti rubne slučajeve preklapanja u testovima. |
| AS-04 | Pretpostavka | Online plaćanje nije dio opsega. Sustav prikazuje ukupni ugovoreni iznos, ali ne obrađuje transakcije ni evidenciju uplata. | Odluka tima | Nije potrebno implementirati platni sustav. |
| AS-05 | Pretpostavka | Cijena najma jedinstvena je po noćenju za plovilo (bez sezonskih cjenika i popusta). Svaka dodatna usluga (uključujući dodatnu opremu) ima unaprijed definiranu cijenu i način obračuna: jednokratno ili po noćenju. | Odluka tima | Ukupni iznos = noćenja × cijena najma + usluge prema načinu obračuna. Provjeriti izračun za oba načina obračuna. |
| AS-06 | Pretpostavka | Jedna rezervacija odnosi se na jedno plovilo i jedno razdoblje najma. | Odluka tima | Model rezervacije vezan je uz jedno plovilo. |
| AS-07 | Pretpostavka | Klijent može mijenjati rezervaciju samo u statusu „zahtjev", a otkazati je do početka najma. Potvrđenu rezervaciju koju treba izmijeniti klijent otkazuje i izrađuje novu. Naknade za otkazivanje nisu dio opsega. | Odluka tima | Izmjena zahtijeva ponovnu provjeru raspoloživosti i izračun iznosa. Provjeriti s mentorom ili na pregledu je li pojednostavljenje prihvatljivo. |
| AS-08 | Pretpostavka | Dostupnost vremenske prognoze ovisi o mogućnostima i vremenskom rasponu odabranog meteorološkog servisa. | Odluka tima | Za nedostupne podatke sustav prikazuje obavijest. |
| AS-09 | Pretpostavka | Prihod se ne prikazuje kao stvarno naplaćen iznos jer sustav ne evidentira plaćanja. Statistika broji rezervacije u statusima „potvrđena" i „završeni najam"; ugovoreni iznos je zbroj njihovih ukupnih iznosa, a iznosi završenih najmova prikazuju se zasebno. Zauzetost plovila je udio noćenja tih rezervacija u broju dana odabranog razdoblja. Najtraženije kategorije i usluge rangiraju se prema broju takvih rezervacija. | Odluka tima | Provjeriti izračune na poznatom skupu testnih rezervacija. Odstupanje od pojma „ostvareni prihod" iz zadatka obrazložiti na pregledu. |
| AS-10 | Pretpostavka | Matična luka plovila ujedno je mjesto njegova preuzimanja i povrata i polazna lokacija pri pretrazi. | Odluka tima | Nije potrebno zasebno evidentirati alternativne lokacije. |
| AS-11 | Pretpostavka | Svi korisnici, uključujući djelatnike, voditelja i administratore, imaju AAI@EduHr identitet. Prvog administratora određuje tim pri postavljanju sustava, a svi novi korisnici dobivaju ulogu klijenta dok im administrator ne dodijeli drugu. | Odluka tima | Provjeriti da je moguće prijaviti sve potrebne testne korisnike i da je prvi administrator dostupan prije prve isporuke. |
| AS-12 | Pretpostavka | Vanjske usluge (hosting, baza podataka, Gmail API, kartografski i meteorološki servis) koriste se unutar svojih besplatnih kvota i uvjeta. | Odluka tima | Provjeriti ograničenja odabranih servisa prije implementacije integracija. |

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
|  |  |  |  |

## 2.7 Pregled zahtjeva

Pregled zahtjeva provodi se tijekom važnih kontrolnih točaka projekta radi provjere usklađenosti implementacije s izvornim zadatkom i dogovorenim opsegom.

| Kontrolna točka | Povratna informacija ili nalaz | Odluka o zahtjevu ili opsegu |
|---|---|---|
| Iteracija 1 | — | — |
| Demo 2 | — | — |
| Završni pregled | — | — |
