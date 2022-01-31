class Persoon:
    def __init__(self, voornaam, naam, rijkregnum):
        self.voornaam = voornaam
        self.naam = naam
        self.rijkregnum = rijkregnum

class Rekeningen:
    def __init__(self, rekeningnummer, saldo, persoon):
        self.saldo = saldo
        self.rekeningnummer = rekeningnummer
        self.persoon = persoon

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

    def overschrijven(self):
        return NotImplemented


    
class Zichtrekening (Rekeningen):
        def storten(self, bedrag):
            self.saldo = self.saldo + bedrag

        def afhalen(self, bedrag):
            if(bedrag > self.saldo):
                print("Het gegeven bedrag is te groot.")
            else:
                self.saldo = self.saldo - bedrag

        def overschrijven(self):
            pass



class Spaarrekening (Rekeningen):
    def __init__(self, rekeningnummer, saldo, persoon, zicht):
        super().__init__(self, rekeningnummer, saldo, persoon)
        if isinstance(zicht, Zichtrekening):
            self.zicht = zicht
        else:
            print("Dit is geen geldige zichtrekening")

    def overschrijven(self, bedrag, zicht):
        if(bedrag > self.saldo):
            print("Gaat niet.")

        elif(self.zicht == zicht):
            if isinstance(zicht, Zichtrekening):
                self.saldo = self.saldo - bedrag
                zicht.storten(bedrag)
            else:
                print("Dit is geen geldige zichtrekening")

        else:
            print("Ongeldige rekeningnummer")

persoon1 = Persoon("Dario", "Van Hasselt", "02.01.08-892.05")
zicht1 = Zichtrekening("091-0122401-16", 1000, persoon1)
spaar1 = Spaarrekening("000-0000097-97", 2000, persoon1, zicht1)

spaar1.overschrijven(100, zicht1)
zicht1.storten(500)
zicht1.afhalen(400)

print(zicht1.saldo)
print(spaar1.saldo)


#Op de zichtrekening kunnen we geld storten, geld afhalen, en geld overschrijven naar andere rekeningen, ook naar onze eigen spaarrekening.
#Op de spaarrekening kunnen we enkel geld terug overschrijven naar de gekoppelde zichtrekening. Opgelet: spaarrekening kan niet onder nul.
