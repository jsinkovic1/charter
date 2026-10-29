# [Naziv aplikacije]

Web-aplikacija za upravljanje poslovanjem charter tvrtke koja iznajmljuje plovila: klijenti pretražuju plovila prema terminu i karakteristikama, vide ukupnu cijenu najma i šalju zahtjev za rezervaciju, dok djelatnici tvrtke na jednom mjestu upravljaju flotom, rezervacijama i rasporedom preuzimanja i povrata.

**Projekt na kolegiju:** Ovu je aplikaciju razvio studentski tim u sklopu kolegija [Programsko inženjerstvo](https://www.fer.unizg.hr/predmet/proinz) na Fakultetu elektrotehnike i računarstva Sveučilišta u Zagrebu (FER).

<!--
## Opis aplikacije

[U dvije ili tri rečenice objasnite problem, ciljane korisnike i glavnu korist svoje aplikacije. Trenutačne funkcionalnosti navedite odvojeno od planiranih; opišite stvarni opseg umjesto obećanih mogućnosti.]

**Ključne funkcionalnosti**

- [Reprezentativna funkcionalnost koju korisnici mogu isprobati]
- [Druga reprezentativna funkcionalnost]
- [Po želji dodatna funkcionalnost; nemojte kopirati cijeli popis zahtjeva]

Za potpuni opseg, zahtjeve, oblikovanje i dokaze ispitivanja pogledajte [docs](docs/Home.md).

<a id="deployment"></a>
## Postavljanje (engl. deployment)
-->
<!-- UPUTA: Ovaj odjeljak opisuje već postavljenu aplikaciju koju se  može otvoriti i isprobati bez lokalnog pokretanja izvornog koda.
Za Iteraciju 1 i Završni pregled navedite konkretne podatke. Provjerite vodi li URL na javno dostupnu pokrenutu aplikaciju i radi li navedeni tijek uporabe. Nikada ne objavljujte lozinke ni pristupne tokene. -->

<!--
**Javno dostupna aplikacija:** [Javni URL]

**Isprobajte:** [Jedna ili dvije kratke radnje koje pokazuju funkcionalan korisnički tijek.]

**Demonstracija:** [Objasnite kako dobiti potreban ograničeni pristup ako je prijava obavezna; u suprotnom napišite „Korisnički račun nije potreban.” Ovdje ne objavljujte lozinke ni pristupne tokene.]

**Ograničenja:** [Kratko navedite ograničenja postavljene inačice ili postavite poveznicu na jedinstveno mjerodavno mjesto u dokumentaciji s poznatim problemima.]

[Vodič za postavljanje i pokretanje](docs/6-Postavljanje-instalacija-i-konfiguracija.md) opisuje smještaj aplikacije (engl. hosting) koji tim stvarno koristi. Tim može koristiti Render ili drugu platformu koju ste dogovorili s asistentom/demonstratorom.
-->

<!--
<a id="quick-start"></a>
## Brzi početak / instalacija
-->

<!-- Obavezno od Demo 1 nadalje. Zamijenite mjesta za unos naredbama koje je drugi član tima uspješno provjerio nakon čistog kloniranja repozitorija. Detaljne upute za administraciju držite u projektnoj dokumentaciji u direktoriju docs/. -->

<!--
**Preduvjeti:** [Navedite potrebno izvršno okruženje (engl. runtime) i verzija, upravitelj paketa (engl. package manager), baza podataka ili vanjska usluga ako je nužna.]

```bash
git clone [repository URL]
cd [repository directory]
[install dependencies]
[run the application]
```

**Adresa:** [Stvarna adresa koju aplikacija ispiše nakon pokretanja.]

**Konfiguracija:** [Navedite potrebne varijable okruženja (engl. environment variables) ili uputite na sigurnu datoteku `.env.example`; objasnite gdje se dobivaju vrijednosti. Nikada ne stavljajte stvarne pristupne podatke u ovu datoteku, primjer konfiguracije, snimke zaslona, zapise ni zapise promjena (engl. commits).]

[Dodajte kratak korak provjere, primjerice koja se stranica treba otvoriti ili koja naredba pokreće osnovnu provjeru.] Za detaljno postavljanje pogledajte [projektnu dokumentaciju](docs/Home.md).
-->



## Tehnologije
 
| Tehnologija ili alat | Uloga u ovom projektu | Razlog uporabe ili važno ograničenje |
| --- | --- | --- |
| React (Vite) | Prikazuje katalog plovila, pretragu, rezervacije te sučelja za djelatnike, voditelja i administratora u pregledniku. | Sučelje mora biti responzivno za računala, tablete i mobilne uređaje; Vite se koristi za razvojni poslužitelj i izradu produkcijske inačice. |
| C# (ASP.NET) | Poslužiteljska strana: provodi poslovna pravila (statusi i prijelazi rezervacija, izračun iznosa), prijavu putem AAI@EduHr, slanje e-pošte i pozive vanjskih servisa. | Ovlasti se moraju provjeravati na poslužitelju, a ne samo skrivanjem elemenata u sučelju. |
| PostgreSQL | Pohranjuje korisnike, plovila, rezervacije, opremu, usluge i termine zauzetosti. | Preklapanje termina istog plovila sprječava se ograničenjem u bazi (`EXCLUDE` uz proširenje `btree_gist`), pa vrijedi i pri istodobnim zahtjevima; potrebno je proširenje `btree_gist`. |
| AAI@EduHr (OAuth 2.0) | Jedini način prijave korisnika. | Zahtjev kolegija: aplikacija ne pohranjuje lozinke, a uloge i specijalnosti djelatnika vodi sama. |
| Gmail API | Šalje klijentu e-poštu s potvrdom rezervacije i obavijest o otkazivanju ili odbijanju. | Ovisi o vanjskoj usluzi; neuspjelo slanje ne poništava promjenu statusa rezervacije i evidentira se. |
| [Kartografski servis] | Prikazuje položaj matične luke (mjesta preuzimanja) na karti. | Ovisi o vanjskoj usluzi; kada nije dostupna, prikazuje se obavijest, a ostale funkcionalnosti rade. |
| [Meteorološki servis] | Dohvaća vremensku prognozu za matičnu luku i razdoblje najma. | Prognoza je dostupna samo za raspon koji servis nudi; izvan njega prikazuje se obavijest. |
| [Platforma za smještaj, npr. Render] | Smješta aplikaciju na internet. | [Ograničenja besplatne kvote ili hladnog pokretanja, ako postoje.] |

<a id="team-members"></a>
## Članovi tima

| Član | Glavna uloga ili doprinos |
| --- | --- |
| [Jakov Gregurić](https://github.com/jgreguric) | DevOps, Frontend |
| [Borna Lončar](https://github.com/SuperWahara) | Frontend |
| [Fabijan Radat](https://github.com/Fabijan9999) | Backend, baza podataka |
| [Josip Sinković](https://github.com/jsinkovic1) | Voditelj, testiranje, dokumentacija |
| [Ivan Tačković](https://github.com/IvanTackovic) | Backend, baza podataka, testiranje |
| [Toni Travica](https://github.com/ttravica) | Baza podataka, dokumentacija |
| [Ivana Žukina](https://github.com/Ivana-Zukina) | Frontend |


Uloge se tijekom projekta mogu mijenjati. Repozitorij i dogovoreni alat za praćenje zadataka (engl. task tracker) služe kao dodatni dokazi timskog rada.

## Doprinos projektu

Cijeli tim sastaje se jednom tjedno radi dogovora o prioritetima i pregleda napretka, a članovi koji rade na srodnim funkcionalnostima češće se međusobno usklađuju. Zadaci i nedostaci vode se u [GitHub Issues](https://github.com/jsinkovic1/programsko-inzenjerstvo/issues).
 
Izravni `push` na granu `main` nije dopušten. Sve promjene izrađuju se na zasebnim granama i predaju kao pull requestovi. Prije spajanja na `main` svaki pull request mora imati odobrenje (engl. approval) barem jednog drugog člana tima koji je pregledao kod.

<a id="license"></a>
## Licenca
 
**Status licence:** Projekt je licenciran licencom [Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International (CC BY-NC-SA 4.0)](https://creativecommons.org/licenses/by-nc-sa/4.0/). Puni tekst nalazi se u datoteci [LICENCE.md](LICENCE.md).
 

<a id="ai-usage"></a>
## Uporaba umjetne inteligencije [![AI Usage: Disclosed](https://img.shields.io/badge/AI%20Usage-Disclosed-blue.svg)](https://www.fer.unizg.hr/_download/repository/Policy%20on%20the%20appropriate%20use%20of%20artificial%20intelligence%20at%20the%20faculty%20of%20electrical%20engineering%20and%20computing%5B1%5D.pdf)

Ovaj projekt slijedi FER-ova [pravila o primjerenoj uporabi umjetne inteligencije](https://www.fer.unizg.hr/_download/repository/Policy%20on%20the%20appropriate%20use%20of%20artificial%20intelligence%20at%20the%20faculty%20of%20electrical%20engineering%20and%20computing%5B1%5D.pdf).

**Izjava:** [Navedite jesu li korišteni alati umjetne inteligencije. Ako jesu, navedite alate i njihove glavne namjene te objasnite kako je tim pregledao nastali kod ili tekst i kako može objasniti vlastiti doprinos. Ako nisu korišteni, to jasno navedite. U alate umjetne inteligencije nemojte unositi privatne podatke, pristupne podatke ni tuđe zaštićene materijale.]

[Ako je za ovaj projekt potreban detaljniji zapis uporabe umjetne inteligencije, postavite poveznicu na njegovo jedinstveno mjerodavno mjesto u dokumentaciji.]

<a id="code-of-conduct-and-support"></a>
## Kodeks ponašanja i podrška [![Contributor Covenant](https://img.shields.io/badge/Contributor%20Covenant-2.1-4baaaa.svg)](CODE_OF_CONDUCT.md)

Od članova tima očekuje se pridržavanje **Kodeksa ponašanja studenata** Fakulteta elektrotehnike i računarstva Sveučilišta u Zagrebu, pravila timskog rada na kolegiju i [Etičkog kodeksa IEEE-a](https://www.ieee.org/about/corporate/governance/p7-8.html). Pravila ponašanja u projektu opisana su u datoteci [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md).

---

Struktura dokumentacije prilagođena je predlošku kolegija Programsko inženjerstvo FER-a autora [Vlade Sruka](https://www.fer.unizg.hr/vlado.sruk), licenciranom pod [CC BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/). Aplikaciju i njezin sadržaj izradio je gore navedeni studentski tim.
