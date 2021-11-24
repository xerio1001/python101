import pcinput
import kortingen
import biljetten_berekenen
import funcMenu

naam = pcinput.getString('Geef uw naam: ')
kassaTotaal = pcinput.getInteger('Geef de startwaarde van de kassa: ')

stoppen = 'nee'
while stoppen == 'nee':

    aantal_mosFriet, aantal_kon, aantal_ijs, aantal_drank = funcMenu.showMenu()

    kosten_mosFriet = aantal_mosFriet * 20
    kosten_kon = aantal_kon * 10
    kosten_ijs = aantal_ijs * 3
    kosten_drank = aantal_drank * 2

    print('U wilt:', aantal_mosFriet, 'Mosselen + frieten, ', aantal_kon, 'koninginnehapjes, ', aantal_ijs, 'ijsjes, ', aantal_drank, 'dranken')

    prijs = (aantal_mosFriet * 20) + (aantal_kon * 10) + (aantal_ijs * 3) + (aantal_drank * 2)
    korting = kortingen.bereken(prijs, aantal_mosFriet)
    prijs_korting = prijs - korting
    print('Totaal te betalen:', prijs_korting, 'euro')

    # uitbreiding 1 (bereken de teruggaven) v

    gegeven_bedrag = pcinput.getInteger('Gegeven bedrag: ')

    if(gegeven_bedrag < prijs_korting):
        print('U heeft te weinig gegeven. Probeer opnieuw!')
    else:
        teruggave = gegeven_bedrag - prijs_korting
        print('terug te geven:', teruggave, 'euro')

    keuze = pcinput.getString('Wilt u een ticket? (Geef "ja" of "nee" in) ')
    if(keuze == "nee"):
        stoppen = pcinput.getString('Wilt u stoppen met het programma?(Geef "ja" of "nee"): ')
        if(stoppen == 'ja'):
            print('Gaat u verder')
    elif(keuze == 'ja'):
        # kassaticket opbouw v

        print('='*60)
        print(f'{naam:^60}')
        print('*'*60)
        print(f'{"Uw besteeling + aantal":<31}| {"Alle kosten":<30}')
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
        biljetten_berekenen.funBiljet(teruggave)
        
        print("*"*60)
        if((aantal_mosFriet == 0) and (aantal_ijs == 0) and (aantal_kon == 0)):
            print(f'{"Gezondheid":^60}')
        else:
            print(f'{"Smakelijk eten!!!":^60}')
        print('='*60)
        
        stoppen = pcinput.getString('Wilt u stoppen met het programma?(Geef "ja" of "nee"): ')
        if(stoppen == 'nee'):
            kassaTotaal = (kassaTotaal + gegeven_bedrag - teruggave)
    #einde elif
#einde while loop

kassaTotaal = (kassaTotaal + gegeven_bedrag - teruggave)
print('Het kassatotaal is nu:', kassaTotaal)