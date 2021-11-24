def bereken(prijs, aantal_mosFriet):
    korting = 0
    if((prijs >= 150) and (aantal_mosFriet >= 2)):
        korting = 20
    elif((prijs >= 100) and (aantal_mosFriet >= 2)):
        korting = 10
    elif((prijs >= 50) and (aantal_mosFriet >= 2)):
        korting = 5
    return korting