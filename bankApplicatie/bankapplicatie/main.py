class Persoon:
    def __init__(self, naam, voornaam, rijksregisternummer):
        self.naam = naam
        self.voornaam = voornaam
        self.rijksregisternummer = rijksregisternummer


class Bankrekening:
    def __init__(self, saldo):
        self.saldo = saldo

    def afhalen(self):
        pass

    def overschrijven(self):
        pass

    def overzicht(self):
        return self.saldo


class Zichtrekening(Bankrekening):
    def storten(self, bedrag):
        self.bedrag = bedrag
        self.saldo += self.bedrag


class Spaarrekening(Bankrekening):
    pass


persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
zicht1 = Zichtrekening(1000)
zicht1.storten(500)

print(zicht1.overzicht())
