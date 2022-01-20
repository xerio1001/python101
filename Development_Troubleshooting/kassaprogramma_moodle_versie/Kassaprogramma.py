from pcinput import getInteger,getString, getLetter

class Bestelling:
    # De prijzen van de producten en de vraagstellingen ervan
    def __init__(self):
        self.PRIJSMOSSELEN = 20
        self.PRIJSVIDEE = 10
        self.PRIJSDRANK = 2
        self.PRIJSIJS = 3
        self.aantalMosselen = self.getAantal("Geef het aantal mosselen: ")
        self.aantalVidee = self.getAantal("Geef het aantal videe: ")
        self.aantalDrank = self.getAantal("Geef het aantal drank: ")
        self.aantalIjs = self.getAantal("Geef het aantal ijs: ")
        self.bedrag = self.berekenBedrag()

    # vraag hoeveel je wilt van ieder product
    def getAantal(self,strPrompt):
        aantal = getInteger(strPrompt)
        return aantal

    # bereken het totaalbedrag zonder kortingen
    def berekenBedrag(self):
        self.bedragMosselen = self.aantalMosselen * self.PRIJSMOSSELEN
        self.bedragVidee = self.aantalVidee * self.PRIJSVIDEE
        self.bedragDrank = self.aantalDrank * self.PRIJSDRANK
        self.bedragIjs = self.aantalIjs * self.PRIJSIJS
        return self.bedragMosselen + self.bedragVidee + self.bedragDrank + self.bedragIjs

    # bereken de korting
    def berekenKorting(self):
        if(self.aantalMosselen >= 2 and bestelling.bedrag >= 150):
            korting = 20
        elif(self.aantalMosselen >= 2 and bestelling.bedrag >= 100):
            korting = 10
        elif(self.aantalMosselen >= 2 and bestelling.bedrag >= 50):
            korting = 5
        else:
            korting = 0
        
        return korting

    # bereken het terug te geven bedrag
    def teruggave(self, betaald, totaalTeBetalen):
        self.betaald = betaald
        self.terugTeGeven = betaald - totaalTeBetalen
        return self.terugTeGeven

    # print het ticket af
    def printTicket(self, naamBediende):
        print()
        print("=-"*30)
        print(f'{"Ticket":^60}')
        print("-="*30)
        print(f'{"Kassabediende":>30} | {naamBediende:<30}')
        print("-="*30)
        print(f'| {"Product":<10} | {"Aantal":<11} | {"Eenheidsprijs":<15} | {"Totaal":11} |')
        print("-="*30)
        print(f'| {"Mosselen":<10} | {self.aantalMosselen:<11} | € {self.PRIJSMOSSELEN:<13} | € {self.bedragMosselen:<9} |')
        print(f'| {"Videé":<10} | {self.aantalVidee:<11} | € {self.PRIJSVIDEE:<13} | € {self.bedragVidee:<9} |')
        print(f'| {"Dranken":<10} | {self.aantalDrank:<11} | € {self.PRIJSDRANK:<13} | € {self.bedragDrank:<9} |')
        print(f'| {"Ijs":<10} | {self.aantalIjs:<11} | € {self.PRIJSIJS:<13} | € {self.bedragIjs:<9} |')
        print("=-"*30)
        print(f'| {"Totaal zonder korting":<50}  € {bestelling.bedrag:>1} |')
        print(f'| {"Korting":<52} € {korting:>1} |')
        print(f'| {"Totaal Met korting":<51} € {bestelling.bedrag - korting:>1} |')
        print(f'| {"Terug gekregen bedrag":<51} € {self.terugTeGeven:>1} |')
        print("=-"*30)
        print()



naamBediende = getString('Kassabediende, geef je naam! : ')
kassaBegin = getInteger(naamBediende + ', geef je kassabegin! : ')
while True:
    # print en bereken de totaalprijs zonder korting
    bestelling = Bestelling()
    print('Bedrag', "€",bestelling.bedrag)

    # print en bereken de korting(en)
    korting = bestelling.berekenKorting()
    print("Korting", "€",korting)

    # print en bereken de totaalprijs met korting
    totaalTeBetalen = bestelling.bedrag - korting
    print("TotaalPrijs", "€",totaalTeBetalen)

    # vraag hoeveel er betaald is en controleer op juistheid
    betaald = getInteger("Hoeveel heeft u betaald?: ")
    while True:
        if(betaald < totaalTeBetalen):
            print("U heeft te weinig gegeven!")
        else:
            terugTeGeven = bestelling.teruggave(betaald, totaalTeBetalen)
            print("U krijgt nog €", terugTeGeven, "terug")
            break

    # vraag voor een ticket en print indien nodig af
    vraagTicket = getString("Wilt u een ticket?: ").lower()
    if(vraagTicket == "ja" or vraagTicket == "j"):
        bestelling.printTicket(naamBediende)

    # vraag of je de bestelling wilt afronden
    if getLetter('Stoppen? J/N:') == 'J':
        print("kassatotaal is:", kassaBegin + (bestelling.bedrag - korting))
        break