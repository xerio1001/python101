import pcinput

naam = pcinput.getString('Geef uw naam ')

aantal_mosFriet = pcinput.getInteger('Hoeveel mosselen + frieten (20€) ')
aantal_kon = pcinput.getInteger('Hoeveel koninginnehapjes (10€) ')
aantal_ijs = pcinput.getInteger('Hoeveel ijsjes (3€) ')
aantal_drank = pcinput.getInteger('Hoeveel dranken (2€) ')

kosten_mosFriet = aantal_mosFriet * 20
kosten_kon = aantal_kon * 10
kosten_ijs = aantal_ijs * 3
kosten_drank = aantal_drank * 2
korting = 5

print('U wilt:', aantal_mosFriet, 'Mosselen + frieten, ', aantal_kon, 'koninginnehapjes, ', aantal_ijs, 'ijsjes, ', aantal_drank, 'dranken')

prijs = (aantal_mosFriet * 20) + (aantal_kon * 10) + (aantal_ijs * 3) + (aantal_drank * 2)

print('Totaal te betalen:', prijs, 'euro')

                                                                # uitbreiding 1 (bereken de teruggaven) v

gegeven_bedrag = pcinput.getInteger('Gegeven bedrag: ')

# Nakijken voor korting
prijs_korting = prijs
if((prijs > 50) and (aantal_mosFriet >= 2)):
    prijs_korting = prijs - korting

if(gegeven_bedrag < prijs_korting):
    print('U heeft te weinig gegeven. Probeer opnieuw!')
else:
    teruggave = gegeven_bedrag - prijs_korting
    print('terug te geven:', teruggave, 'euro')

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

    try:
   
        berekening1 = teruggave // 500
        rest_ber1 = teruggave % 500

        berekening2 = rest_ber1 // 200
        rest_ber2 = rest_ber1 % 200

        berekening3 = rest_ber2 // 100
        rest_ber3 = rest_ber2 % 100

        berekening4 = rest_ber3 // 50
        rest_ber4 = rest_ber3 % 50

        berekening5 = rest_ber4 // 20
        rest_ber5 = rest_ber4 % 20

        berekening6 = rest_ber5 // 10
        rest_ber6 = rest_ber5 % 10

        berekening7 = rest_ber6 // 5
        rest_ber7 = rest_ber6 % 5

        berekening8 = rest_ber7 // 2
        rest_ber8 = rest_ber7 % 2

        berekening9 = rest_ber8 // 1
        rest_ber9 = rest_ber8 % 1

        if(berekening1 != 0):
            print(f'{berekening1:>22} {"briefjes van 500":<30}')

        if(berekening2 != 0):
            print(f'{berekening2:>22} {"briefjes van 200":<30}')

        if(berekening3 != 0):
            print(f'{berekening3:>22} {"briefjes van 100":<30}')

        if(berekening4 != 0):
            print(f'{berekening4:>22} {"briefjes van 50":<30}')

        if(berekening5 != 0):
            print(f'{berekening5:>22} {"briefjes van 20":<30}')

        if(berekening6 != 0):
            print(f'{berekening6:>22} {"briefjes van 10":<30}')
    
        if(berekening7 != 0):
            print(f'{berekening7:>22} {"briefjes van 5":<30}')
    
        if(berekening8 != 0):
            print(f'{berekening8:>22} {"munstukken van 2":<30}')

        if(berekening9 != 0):
            print(f'{berekening9:>22} {"munstukken van 1":<30}')

    except:
        print('Er is iets fout gelopen!')
    print('='*60)
