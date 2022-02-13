class InsufficientAmount(Exception):
    pass


class ValueError(Exception):
    pass


class Persoon:
    def __init__(self, naam, voornaam, rijksregisternummer):
        self.naam = naam
        self.voornaam = voornaam
        # rijksregisternummer bestaat uit "##.##.##-###.##"
        self.rijksregisternummer = rijksregisternummer


class Bankrekening:
    def __init__(self, saldo, bankrekeningNummer, persoon):
        self.saldo = saldo
        self.bankrekeningNummer = bankrekeningNummer
        self.persoon = persoon

    def controleBankrekNum(self):
        self.bankrekeningNummer = (
            self.bankrekeningNummer.replace(".", "")
            .replace("/", "")
            .replace("-", "")
            .replace(" ", "")
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
                return "Ongeldig nummer"

        else:
            return "Ongeldige lengte van het nummer."

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

    def overschrijven(self):
        pass


class Spaarrekening(Bankrekening):
    def __init__(self, saldo, bankrekeningNummer, persoon, zicht):
        super().__init__(self, saldo, bankrekeningNummer, persoon)
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


persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
zicht1 = Zichtrekening(1000, "BE53979123456753", persoon1)
spaar1 = Spaarrekening(2000, "BE11000123456748", persoon1, zicht1)


zicht1.storten(500)
# print(zicht1.overzicht())
zicht1.afhalen(200)
# print(zicht1.overzicht())


spaar1.overschrijven(1000, zicht1)
# print(spaar1.overzicht())
