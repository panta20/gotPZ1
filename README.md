Predmetni zadatak 1 (PZ1) - 25 poena
Cilj predmetnog zadatka je kreirati WPF aplikaciju koja predstavlja jednostavan informacioni sistem.
Domen aplikacije ostaje za izbor autoru.
Informacioni sistem upravlja objektima samo jedne klase. Klasa mora sadržati bar jedno polje koje je
brojevnog tipa, jedno tekstualno, jedno koje predstavlja datum, jedno koje će služiti za prikaz slike I
jedno koje će referencirati tekstualni fajl.
Sama WPF aplikacija treba da na glavnom prozoru ima tabelu koja prikazuje sliku i vrednosti
najvažnijih polja za razlikovanje objekata. Svaki red u tabeli sa objektima treba da ima i tri dugmeta
od kojih je jedno za poziv prozora za pregled konkretnog objekta, drugo služi za poziv prozora za
izmenu parametara odabranog objekta, a treće za brisanje konkretnog objekta.
Pored tabele na glavnom prozoru treba da se nalaze dugmad za dodavanje novog objekta i dugme za
izlaz iz aplikacije. Klik na dugme za dodavanje novog objekta poziva prozor za dodavanje novog
objekta gde je moguće uneti vrednosti za sva polja klase objekta.
U suštini, prozori za dodavanje i izmenu su identični, sa tim da su prilikom prikaza prozora za izmenu
sva polja već popunjena predhodnim vrednostima. Kod oba prozora je potrebno implementirati
validaciju svih polja. OBAVEZNO implementirati databinding u okviru tabele.
Prilikom izmene i dodavanja novog objekta, potrebno je da jedno polje za unos bude realizovano
kao RichTextBox, gde se može iskoristiti implementacija započeta na terminu vežbi. Već su
implementirane opcije “Bold” i “promena fonta”, a potrebno je dodati opcije:
 Italic,
 Underline,
 promena boje teksta,
 promena veličine slova,
Takodje pored ovih opcija, na RichTextBox treba dodati status bar i u njemu prikazati broj reči u
RichTextBox-u. Aplikacija mora imati iscrtan oblik prozora i on ne sme biti isti kao onaj koji je
prikazan na terminu vežbi. Važno je uzeti u obzir da se sadržaj u RichTextBoxu može samo u
njemu i prikazivati, i da se on mora čuvati u .rtf formatu, pa treba obratiti pažnju kako će se
realizovati kreiranje novog objekta, odnosno izmena i brisanje, pošto je njegov sastavni deo i
referenca na .rtf datoteku.
Na sledećoj strani je dat prikaz izgleda interfejsa predmetnog zadatka.