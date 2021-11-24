import pcinput
import kortingen
import funcMenu
import ticket_print

naam = pcinput.getString('Geef uw naam (Bediende): ')
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
        ticket_print.showTicket(
                                naam, aantal_mosFriet, kosten_mosFriet, aantal_kon, kosten_kon, aantal_ijs, 
                                kosten_ijs, aantal_drank, kosten_drank, prijs, prijs_korting, korting, gegeven_bedrag, teruggave
                                )
        #einde kassaticket opbouw
        
        stoppen = pcinput.getString('Wilt u stoppen met het programma?(Geef "ja" of "nee"): ')
        if(stoppen == 'nee'):
            kassaTotaal = (kassaTotaal + gegeven_bedrag - teruggave)
#einde while loop

kassaTotaal = (kassaTotaal + gegeven_bedrag - teruggave)
print('*'*60)
print(f'{"Kassatotaal:":>30} {kassaTotaal:<} {"euro":<}')
print(f'{"Bediende:":>30} {naam:<30}')
print('*'*60)