from bankapplicatie.possibleErrors import *


class Persoon:
    def __init__(self, naam: str, voornaam: str, rijksregisternummer: str):
        if type(naam) is not str:
            raise FalsePersonConstructor("De naam is geen string.")
        if type(voornaam) is not str:
            raise FalsePersonConstructor("De voornaam is geen string.")
        if type(rijksregisternummer) is not str:
            raise FalsePersonConstructor("De rijksregisternummer is geen string.")
        
        self.naam = naam
        self.voornaam = voornaam
        self.rijksregisternummer = rijksregisternummer


class Bankrekening:
<<<<<<< HEAD
    def __init__(self, bankrekeningNummer):
        self.bankrekeningNummer = bankrekeningNummer

    def controleBankrekNum(self):
        self.bankrekeningNummer = (
            self.bankrekeningNummer.replace(".", "")
            .replace("/", "")
            .replace("-", "")
            .replace(" ", "")
            .replace("BE","")
        )
        if len(self.bankrekeningNummer) == 12:
            strippedNum = self.bankrekeningNummer[0:10]
            strippedNum = int(strippedNum)

            lastNum = self.bankrekeningNummer[10:12]
            lastNum = int(lastNum)

            controlenummer = strippedNum % 97

            if controlenummer == lastNum:
                return "Geldig nummer"

            else:
                raise ValueError("Geen geldig nummer")

        else:
            raise ValueError("Ongeldig nummer")
=======
    def __init__(self, saldo, bankrekeningNummer, persoon):
        if self.isValidBankrekNum(bankrekeningNummer):
            self.saldo = saldo
            self.persoon = persoon
            self.bankrekeningNummer = bankrekeningNummer
        else:
            raise RekeningNummerError("Geen geldig rekeningnummer")

    def isValidBankrekNum(self, bankrekeningNummer):
        nummer = bankrekeningNummer[0:3] + bankrekeningNummer[4:-3]
        controleCijfers = bankrekeningNummer[-2:]
        try:
            checkFormat = bool(len(bankrekeningNummer) == 14 and bankrekeningNummer[3] == "-" and bankrekeningNummer[-3] == "-")
            checkControlnummer = bool(int(nummer) % 97 == int(controleCijfers))
        except:
            return False

        if (checkFormat and checkControlnummer and nummer.isdigit() and controleCijfers.isdigit()):
            return True
        else:
            return False
>>>>>>> 8c6b589f5d80c18288c85bd62b98770279d2d70b

    def overschrijven(self):
        return NotImplemented

    def overzicht(self):
        return self.saldo

<<<<<<< HEAD

class Zichtrekening(Bankrekening):
    def __init__(self, bankrekeningNummer, saldo):
        super().__init__(self, bankrekeningNummer)
        self.saldo = saldo

=======
>>>>>>> 8c6b589f5d80c18288c85bd62b98770279d2d70b
    def storten(self, bedrag):
        self.bedrag = bedrag
        self.saldo += self.bedrag


class Zichtrekening(Bankrekening):
    def afhalen(self, bedrag):
        if bedrag > self.saldo:
            raise InsufficientAmount(f"Niet genoeg saldo {self.saldo} < {bedrag}")
        else:
            self.saldo -= bedrag

    def overschrijven(self, bedrag, rekening):
        if bedrag > self.saldo:
            raise InsufficientAmount(f"Niet genoeg saldo {self.saldo} < {bedrag}")
        else:
            self.saldo -= bedrag
            rekening.storten(bedrag)


class Spaarrekening(Bankrekening):
<<<<<<< HEAD
    def __init__(self, bankrekeningNummer, saldo, zicht):
        super().__init__(self, bankrekeningNummer)
        self.saldo = saldo
=======
    def __init__(self, saldo, bankrekeningNummer, zicht):
        self.saldo = saldo
        self.bankrekeningNummer = bankrekeningNummer
>>>>>>> 8c6b589f5d80c18288c85bd62b98770279d2d70b
        if isinstance(zicht, Zichtrekening):
            self.zicht = zicht
        else:
            raise RekeningNummerError(f"De rekening die u probeert te gebruiken klopt niet {self.zicht}")

    def overschrijven(self, bedrag, zicht):
        if bedrag > self.saldo:
            raise InsufficientAmount(f"Niet genoeg saldo {self.saldo} < {bedrag}")
        else:
            self.saldo -= bedrag
            zicht.storten(bedrag)
<<<<<<< HEAD
        else:
            raise ValueError(
                f"De rekening die u probeert te gebruiken klopt niet {self.zicht}"
            )


persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
zicht1 = Zichtrekening("BE53979123456753", 1000)
spaar1 = Spaarrekening("BE11000123456748", 2000, zicht1)

zicht1.storten(500)
# print(zicht1.overzicht())
zicht1.afhalen(200)
# print(zicht1.overzicht())


spaar1.overschrijven(1000, zicht1)
# print(spaar1.overzicht())


#BE11679123456748
#BE36719123456781
#BE23640123456791
#BE34968123456790
=======
>>>>>>> 8c6b589f5d80c18288c85bd62b98770279d2d70b
