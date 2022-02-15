class InsufficientAmount(Exception):
    pass


class RekeningNummerError(Exception):
    pass


class Persoon:
    def __init__(self, naam: str, voornaam: str, rijksregisternummer: str):
        self.naam = naam
        self.voornaam = voornaam
        self.rijksregisternummer = rijksregisternummer


class Bankrekening:
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

    def overschrijven(self):
        return NotImplemented

    def overzicht(self):
        return self.saldo

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
    def __init__(self, saldo, bankrekeningNummer, zicht):
        self.saldo = saldo
        self.bankrekeningNummer = bankrekeningNummer
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
