import pcinput

def getHotelTitel (nachtenPerVolwassenen, nachtenPerKinderen, aantalKinderen, aantalVolwassenen):
    hotelType = pcinput.getString("Welk hotel had u graag gehad (zeezicht/duinenzicht)?: ")
    hotelKost = 0
    while hotelType != "zeezicht" or "duinenzicht":
        if(hotelType == "zeezicht"):
            hotelKost = (30 * nachtenPerVolwassenen)
            if(aantalKinderen >= 1):
                hotelKost = ((nachtenPerVolwassenen * 30) + ((nachtenPerKinderen * 30) * 0.5))
            print("U heeft gekozen voor hotel zeezicht")
            break

        elif(hotelType == "duinenzicht"):
            hotelKost = (25 * aantalVolwassenen)
            if(aantalKinderen >= 1):
                hotelKost = ((nachtenPerVolwassenen * 25) + ((nachtenPerKinderen * 25) * 0.5))
            print("U heeft gekozen voor hotel duinenzicht")
            break

        else:
            print("U heeft een verkeerd hotel ingegeven. Probeer nog eens.")
            hotelType = pcinput.getString("Welk hotel had u graag gehad (zeezicht/duinenzicht)?: ")
    
    return hotelType, hotelKost



def getHotelKamer (aantalNachten, nachtenPerVolwassenen, nachtenPerKinderen, aantalKinderen, hotelKosten):
    kamerType = pcinput.getString("Welk supplement had u graag gehad (zeezicht/balkon/luxesuit)? ")
    kamerKost = 0
    while kamerType != "zeezicht" or "balkon" or "luxesuit":
        if(kamerType == "zeezicht"):
            kamerKost = hotelKosten * 1.1
            print("U heeft gekozen voor zeezicht")
            break

        elif(kamerType == "balkon"):
            kamerKost = (20 * aantalNachten * nachtenPerVolwassenen)
            if(aantalKinderen >= 1):
                kamerKost = ((20 * nachtenPerVolwassenen) + ((20 * nachtenPerKinderen) * 0.5))
            print("U heeft gekozen voor balkon")
            break

        elif(kamerType == "luxesuit"):
            kamerKost = 40
            if(aantalKinderen >= 1):
                kamerKost = ((40 * nachtenPerVolwassenen) + ((40 * nachtenPerKinderen) * 0.5))
            print("U heeft gekozen voor luxe suit")
            break

        else:
            print("U heeft een verkeerd supplement ingegeven. Probeer nog eens")
            kamerType = pcinput.getString("Welk supplement had u graag gehad (zeezicht/balkon/luxesuit)? ")

    return kamerType, kamerKost