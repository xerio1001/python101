import kortingen
def showTicket(
    naam, aantal_mosFriet, kosten_mosFriet, aantal_kon, kosten_kon, aantal_ijs, 
    kosten_ijs, aantal_drank, kosten_drank, prijs, prijs_korting, korting, gegeven_bedrag, teruggave
    ):


    print('='*60)
    print(f'{naam:^60}')
    print('*'*60)
    print(f'{"Uw bestelling + aantal":<31}| {"Alle kosten":<30}')
    print('*'*60)

    print(f'Mosselen + frieten{aantal_mosFriet:>12} | kosten{kosten_mosFriet:>20.2f}€')
    print(f'koninginnehapje{aantal_kon:>15} | kosten{kosten_kon:>20.2f}€')
    print(f'ijsje{aantal_ijs:>25} | kosten{kosten_ijs:>20.2f}€')
    print(f'Drinken{aantal_drank:>23} | kosten{kosten_drank:>20.2f}€')

    print('*'*60)

    print(f'{"UW totaal":<30}{prijs:>29.2f}€')

    if(prijs_korting < prijs):
        print(f'{"Uw korting":<30}{korting:29.2f}€')
        print(f'{"UW totaal met korting":<30}{prijs_korting:>29.2f}€')
    
    print(f'{"Betaald":<30}{gegeven_bedrag:>29.2f}€')
    
    if(gegeven_bedrag == prijs_korting):
        print(f'{"Terug gehad":<30}{"0":>29}€')
    else:
        print(f'{"Terug gehad":<30}{teruggave:>29.2f}€')
        print('*'*60)

    # uitbreiding 2 (welke munstukken/biljetten) v
    kortingen.biljet(teruggave)
    
    print("*"*60)
    if((aantal_mosFriet == 0) and (aantal_ijs == 0) and (aantal_kon == 0)):
        print(f'{"Gezondheid":^60}')
    else:
        print(f'{"Smakelijk eten!!!":^60}')
    print('='*60)