"""
Een klant boekt bij een reisorganisatie een reis met keuze uit verschillende opties: bereken de
totale kostprijs voor deze klant met volgende gegevens:
• (algemene informatie) Aantal nachten: hoeveelheidskorting: 7 +1 nacht gratis, 10+2 nachten gratis. (7=7, 8=7, 9=8,
10=9, 11=10, 12=10, 13=11, ….).
Probeer zoveel mogelijk functies te gebruiken.
"""
import pcinput
import funcVervoer
import funcHotel
import funcEten
import funcNachten


#algemene informatie
aantalNachten = pcinput.getInteger('Hoeveel nachten blijft u?: ')
aantalVolwassenen = pcinput.getInteger('Hoeveel volwassenen neemt u mee?: ')
aantalKinderen = pcinput.getInteger('Hoeveel kinderen neemt u mee?: ')

nachtenPerVolwassenen = aantalNachten * aantalVolwassenen
nachtenPerKinderen = aantalNachten * aantalKinderen
totaalPersonen = aantalKinderen + aantalVolwassenen

totaalKosten = 0

#nachten
AantalOvernachtingen = funcNachten.getNachten(aantalNachten)

#vervoer
vervoerType, vervoerKost = funcVervoer.getControleVervoer(totaalPersonen)

#hotel
hotelNaam, hotelKosten = funcHotel.getHotelTitel(nachtenPerVolwassenen, nachtenPerKinderen, aantalKinderen, aantalVolwassenen)
hotelKamertype, hotelKamerKosten = funcHotel.getHotelKamer(aantalNachten, nachtenPerVolwassenen, nachtenPerKinderen, aantalKinderen, hotelKosten)

#eten
voedselType, voedselKost = funcEten.getVoedsel(aantalNachten)

#totaal test
print("")
print(vervoerType, " ", round(vervoerKost, 2))
print(hotelNaam, " ", round(hotelKosten, 2))
print(hotelKamertype, " ", round(hotelKamerKosten, 2))
print(voedselType, " ", round(voedselKost, 2))
print("")
totaalKosten = vervoerKost + hotelKosten + hotelKamerKosten + voedselKost
print(totaalKosten)