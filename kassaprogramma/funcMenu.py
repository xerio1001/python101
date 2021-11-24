import pcinput
def showMenu():
    aantal_mosFriet = pcinput.getInteger('Hoeveel mosselen + frieten (20€) ')
    aantal_kon = pcinput.getInteger('Hoeveel koninginnehapjes (10€) ')
    aantal_ijs = pcinput.getInteger('Hoeveel ijsjes (3€) ')
    aantal_drank = pcinput.getInteger('Hoeveel dranken (2€) ')
    return aantal_mosFriet, aantal_kon, aantal_ijs, aantal_drank