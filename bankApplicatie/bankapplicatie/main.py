class InsufficientAmount(Exception):
    pass


class ValueError(Exception):
    pass


class RekeningNummerError(Exception):
    pass


class Persoon:
    def __init__(self, naam, voornaam, rijksregisternummer):
        self.naam = naam
        self.voornaam = voornaam
        # rijksregisternummer bestaat uit "##.##.##-###.##"
        self.rijksregisternummer = rijksregisternummer


class Bankrekening:
    def __init__(self, saldo, bankrekeningNummer, persoon):
        if(self.isValidBankrekNum(bankrekeningNummer)):
            self.saldo = saldo
            self.persoon = persoon
            self.bankrekeningNummer = bankrekeningNummer
        else:
            raise RekeningNummerError("Geen geldig rekening nummer")

    def isValidBankrekNum(self, bankrekeningNummer):
        nummer = bankrekeningNummer[0:3] + bankrekeningNummer[4:-3]
        controleCijfers = bankrekeningNummer[-2:]
        try:
            checkFormat = bool(len(bankrekeningNummer) == 14 and bankrekeningNummer[3] == "-" and bankrekeningNummer[-3] == "-")
            checkControlnummer = bool(int(nummer) % 97 == int(controleCijfers))
        except:
            return False

        if checkFormat and checkControlnummer and nummer.isdigit() and controleCijfers.isdigit():
            return True
        else:
            return False

    def overschrijven(self):
        return NotImplemented

    def overzicht(self):
        return self.saldo


class Zichtrekening(Bankrekening):
    def storten(self, bedrag):
        self.bedrag = bedrag
        self.saldo += self.bedrag

    def afhalen(self, bedrag):
        if self.saldo > 0:
            self.saldo -= bedrag
        else:
            raise InsufficientAmount(f"Niet genoeg saldo {self.saldo}")

    def overschrijven(self, bedrag, rekening):
        if self.saldo < bedrag:
            raise InsufficientAmount("U heeft niet voldoende saldo.")
        else:
            self.saldo -= bedrag
            rekening.storten(bedrag)


class Spaarrekening(Bankrekening):
    def __init__(self, saldo, bankrekeningNummer, zicht):
        self.saldo = saldo
        self.bankrekeningNummer = bankrekeningNummer
        if isinstance(zicht, Zichtrekening):
            self.zicht = zicht
        else:
            raise ValueError(
                f"De rekening die u probeert te gebruiken klopt niet {self.zicht}"
            )

    def overschrijven(self, bedrag, zicht):
        if bedrag > self.saldo:
            raise InsufficientAmount(
                f"Het bedrag dat u probeert over te schrijven is groter dan uw huidig saldo {self.saldo}"
            )
        elif self.zicht == zicht1:
            self.saldo -= bedrag
            zicht.storten(bedrag)
        else:
            raise ValueError(
                f"De rekening naar waar u probeert over te schrijven klopt niet {self.zicht}"
            )

if __name__ == '__main__':
    persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
    zicht1 = Zichtrekening(1000, "091-0122401-16", persoon1)
    spaar1 = Spaarrekening(2000, "091-0122401-16", zicht1)
"""
print("Start kapitaal van zicht1 ", zicht1.overzicht())
print("Start kapitaal van spaar1 ", spaar1.overzicht())
print()

zicht1.storten(500)
print("Storten van 500 op zichtrekening ", zicht1.overzicht())
print()
zicht1.afhalen(200)
print("Afhalen van 200 op zichtrekening ", zicht1.overzicht())
print()

spaar1.overschrijven(1000, zicht1)
print("Het overschrijven van 1000 van spaar naar zicht ",spaar1.overzicht())
print()
print("Het resultaat van zicht na overschrijven van spaar ", zicht1.overzicht())


persoon2 = Persoon("Nog iets", "Glenn", "01.02.03-123.04")
zicht2 = Zichtrekening(500, "BE36719123456781", persoon2)
spaar2 = Spaarrekening(1000, "BE23640123456791", zicht2)

zicht1.overschrijven(250, zicht2)
print()
print("Overzicht van zicht2 ",zicht2.overzicht())
"""