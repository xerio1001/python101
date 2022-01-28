class Persoon:
    def __init__(self, voornaam, naam, rijkregnum):
        self.voornaam = voornaam
        self.naam = naam
        self.rijkregnum = rijkregnum

class Rekeningen:
    def __init__(self, rekeningnummer):
        self.overzicht = 0
        self.rekeningnummer = rekeningnummer

    def controleReknum(self):
        self.rekeningnummer = self.rekeningnummer.replace(".","").replace("/","").replace("-","").replace(" ","")
        if(len(self.rekeningnummer) == 12):
            strippedNum = self.rekeningnummer[0:10]
            strippedNum = int(strippedNum)

            lastNum = self.rekeningnummer[10:12]
            lastNum = int(lastNum)

            controlenummer = strippedNum % 97

            if(controlenummer == lastNum):
                return "Geldig nummer"

            else:
                return "Ongeldig nummer"

        else:
            return "Ongeldige lengte van het nummer."

    def storten(self, bedrag):
        self.overzicht = self.overzicht + bedrag

    def overschrijven(self):
        return NotImplemented

class Zichtrekening (Rekeningen):
    def __init__(self, rekeningnummer, beginOverzicht, spaarnum):
        super().__init__(rekeningnummer)
        self.overzicht = beginOverzicht
        self.spaarnum = spaarnum

    def afhalen(self, bedrag):
        self.overzicht = self.overzicht - bedrag

    def overschrijven(self, bedrag):
        if(self.overzicht - bedrag > 0 and self.spaarnum == ""):
            self.storten(bedrag)
            self.overzicht = self.overzicht - bedrag
        if(self.overzicht - bedrag > 0 and self.spaarnum != ""):
            self.spaarnum.storten(bedrag)
            self.overzicht = self.overzicht - bedrag

class Spaarrekening (Rekeningen):
    def __init__(self, rekeningnummer, beginOverzicht, zichtnum):
        super().__init__(rekeningnummer)
        self.overzicht = beginOverzicht
        self.zichtnum = zichtnum

    def overschrijven(self, bedrag):
        if(self.overzicht - bedrag > 0):
            self.zichtnum.storten(bedrag)
            self.overzicht = self.overzicht - bedrag
        else:
            return print("Er is een fout opgetreden bij het overschrijven van de spaarrekening!")


persoon1 = Persoon("Dario", "Van Hasselt", "02.01.08-892.05")
gegevens1 = Zichtrekening("091-0122401-16")
gegevens2 = Spaarrekening("000-0000097-97", 1000, gegevens1)
gegevens2.overschrijven(250)
gegevens1.afhalen(100)
gegevens1 = Zichtrekening("091-0122401-16", 1000, gegevens2)

print("Zichtrekening ", gegevens1.overzicht)
print("Spaarrekening ", gegevens2.overzicht)


"""
Op de zichtrekening kunnen we geld storten, geld afhalen, en geld overschrijven naar andere rekeningen, ook naar onze eigen spaarrekening.
Op de spaarrekening kunnen we enkel geld terug overschrijven naar de gekoppelde zichtrekening. Opgelet: spaarrekening kan niet onder nul.
"""