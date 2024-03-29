# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

uspješno ste prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod potrebno je verzionirati u glavnoj **master** grani i **obvezno** smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva **master-docs** i smjestiti u mapu Documentation.

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Rent-A-Field


## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Petar Šemiga | psemiga@foi.hr | 0016141857 | petarsemiga
Leon Špiranec | lspiranec@foi.hr | 0016144710 | leonspiranec19
Tomislav Smetisko | tsmetisko@foi.hr | 0016143232 | tsmetisko
David Milanović | dmilanovi@foi.hr | 0016145536 | DavidMilanovic1

## Opis domene
Rent-A-Field je aplikacija koja omogućava rezervaciju i najam sportskih prostora. Rad aplikacije započinje registracijom korisnika u sustav. 
Nakon uspješne registracije, korisnik prijavom pristupa aplikaciji. 
Početni zaslon aplikacije prikazuje uvid u sve sportske prostore i odabirom pojedinog prostora moguće je pregledati dostupnost i raspored odvijanja aktivnosti u tom prostoru. 
Ukoliko korisnik želi iznajmiti ili rezervirati prostor, potrebno je ispuniti podatke za rezervaciju. 
Osim već navedenih mogućnosti korisnik se može priključiti aktivnostima koje su na raspolaganju u određenom prostoru. 
Korisniku se nudi pregled i pisanje recenzija za određene prostore. 
Aplikacija bi podržavala dvije uloge tj. zaposlenici i administracija .

## Specifikacija projekta
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Registracija i prijava| Prilikom registracije generira se "članska" iskaznica (QR/Barcode) preko koje će se korisnici moći prijaviti u sustav. | Leon Špiranec
F02 | Prijava za izradu vlastitih trening programa | Korisnik se može prijaviti za izradu vlastitog programa u koji se mogu uključiti ostali korisnici | Leon Špiranec
F03 | Izbor i pregled terena | Korisnik dobiva uvid u raspoloživost i popis terena | Leon Špiranec
F04 | Kreiranje i pregled događaja | Korisnik kreira događaj kojem prirodaje teren te je u mogućnosti događaje pregledati i filtrirati | Petar Šemiga
F05 | Evidencija događaja | Zaposlenik može dodavati nove i brisati i ažurirati postojeće događaje | Petar Šemiga
F06 | Evidencija sportskih terena | Zaposlenik može dodavati nove i brisati i ažurirati postojeće sportske prostore | Petar Šemiga
F07 | Najam sportske opreme | Korisnik je u mogućnosti unajmiti dodatne sportske rekvizite (lopte, reketi, sprave i pomagala...), a rezervacija je potvrđena ispisanom potvrdom | Tomislav Smetiško
F08 | Najam privatnog trenera | Korisnik može unajmiti privatnog trenera i ima mogućnost individualnih treninga | Tomislav Smetiško
F09 | Plaćanje | Korisnik ima mogućnost platiti unajmljeni sportski prostor, opremu i trenera putem aplikacije. | Tomislav Smetiško
F10 | Kreiranje i ažuriranje cjenika | Zaposlenik ima mogućnost dodavanja novih stavki u cjenik te ažuriranje postojećih, dok korisnik ima opciju samo pregledati cjenik. | David Milanović
F11 | Stvaranje obrazca za prigovore/poboljšanja | Korisnik ima mogućnost kreiranja obrazca za prigovore/poboljšanja. Zaposlenik prigovor/poboljšanje može prihvatiti ili odbiti uz obrazloženje u komentaru. | David Milanović
F12 | Evidencija termina korisnika | Aplikacija ima mogućnost evidentiranja termina gdje korisnik može evidentirati rezultate odigranih susreta. Također aplikacija nudi mogućnost generiranja osoba u timove za sljedeći termin odigravanja susreta. | David Milanović
F13 | Najam sportskih prostora | Korisnik može unajmiti željeni sportski prostor u određenom terminu | Tomislav Smetiško



## Tehnologije i oprema
Microsoft Visual Studio 2022, C# (.NET Framework), MySQL, Draw.io, GitHub, Microsoft Word
