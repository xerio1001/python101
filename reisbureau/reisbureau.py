import pcinput

"""
Een klant boekt bij een reisorganisatie een reis met keuze uit verschillende opties: bereken de
totale kostprijs voor deze klant met volgende gegevens:
• Vervoer : enkele reis vliegtuig=200€, enkele reis per autocar=50€, zelf met de auto = 0€.
• Hotel: standaardkamer prijs in hotel Zeezicht=30€/nacht/persoon, hotel
Duinenzicht=25€/nacht/persoon.
• Type kamer: zeezicht = supplement van 10%, balkon=+20€/nacht, luxe suite=+40€/nacht.
• Aantal nachten: hoeveelheidskorting: 7 +1 nacht gratis, 10+2 nachten gratis. (7=7, 8=7, 9=8,
10=9, 11=10, 12=10, 13=11, ….).
• Aantal personen: aantal volwassenen, kinderen (50% korting op kamerprijs en kamertype
supplement).
• Eten: geen ontbijt, met ontbijt (10€/nacht), half pension(30€/nacht), vol pension (40€/nacht).
Probeer zoveel mogelijk functies te gebruiken.
"""

#algemene informatie
nachten = pcinput.getInteger('Hoeveel nachten blijft u?: ')
personen = pcinput.getInteger('Hoeveel personen neemt u mee?: ')

#vaste kosten per vervoer
vliegtuig = 200
autocar = 50
auto = 0

#kosten verblijf
hotel_zeezicht = 30
hotel_duinenzicht = 25

