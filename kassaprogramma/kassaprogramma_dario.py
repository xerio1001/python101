import pcinput
import funcMenu
import funcPrijzen

allProducts = {"A":{"Naam":"Mosselen frieten", "Prijs":20.0, "Stock":15}, 
                "B":{"Naam":"koninginnehapjes", "Prijs":10.0, "Stock":15}, 
                "C":{"Naam":"ijses", "Prijs":3.0, "Stock":50}, 
                "D":{"Naam":"dranken", "Prijs":2.0, "Stock":100}
            }
allOrders = []

naam_bediende = pcinput.getString('Geef uw naam (Bediende): ')
kassaTotaal = pcinput.getFloat('Geef de startwaarde van de kassa: ')

# Creêer nieuwe waardes om een nieuw product toe te voegen aan 'allProducts'
funcMenu.AddMenu(allProducts)

stoppen = 'nee'
while stoppen == 'nee':

    # vraag de bestellingen op en toon het menu (Functie om het menu te tonen wordt in de 'GetOrder' functie gebruikt.)
    funcMenu.GetOrder(allOrders, allProducts)
    
    # bereken de totaalprijs en daarna tonen
    prijs = funcPrijzen.CalcPrice(allOrders)
    print('Totaal te betalen:', prijs, 'euro')

    # uitbreiding: bereken de teruggaven

    gegeven_bedrag = pcinput.getFloat('Gegeven bedrag: ')

    if(gegeven_bedrag < prijs):
        print('U heeft te weinig gegeven. Probeer opnieuw!')
    else:
        teruggave = gegeven_bedrag - prijs
        print('terug te geven:', teruggave, 'euro')

    # vragen voor een ticket
    keuze = pcinput.getString('Wilt u een ticket? (Geef "ja" of "nee" in) ')
    if(keuze == "nee"):
        stoppen = pcinput.getString('Wilt u stoppen met het programma?(Geef "ja" of "nee"): ')

        if(stoppen == 'ja'):
            print('Gaat u verder')
            
    elif(keuze == 'ja'):

        # kassaticket opbouw
        funcMenu.showTicket(allOrders, naam_bediende, gegeven_bedrag, prijs, teruggave)
        
        # vragen of je wilt stoppen
        stoppen = pcinput.getString('Wilt u stoppen met het programma?(Geef "ja" of "nee"): ')


kassaTotaal = (kassaTotaal + gegeven_bedrag - teruggave)
print('*'*60)
print(f'{"Kassatotaal:":>30} {int(kassaTotaal):<} {"euro":<}')
print(f'{"Bediende:":>30} {naam_bediende:<30}')
print('*'*60)