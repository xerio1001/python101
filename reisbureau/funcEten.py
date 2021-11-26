import pcinput

def getVoedsel (aantalNachten):
    etenType = pcinput.getString("Wat soort ontbijt had u graag gehad (geen/normaal/half pension/vol pension)? ")
    etenKost = 0
    while etenType != "normaal" or "half pension" or "vol pension" or "geen":
        if(etenType == "geen"):
            print("U heeft gekozen voor geen ontbijt.")
            break

        elif(etenType == "normaal"):
            etenKost = (10 * aantalNachten)
            print("U heeft gekozen voor normaal ontbijt")
            break

        elif(etenType == "half pension"):
            etenKost = (30 * aantalNachten)
            print("U heeft gekozen voor half pension ontbijt")
            break

        elif(etenType == "vol pension"):
            etenKost = (40 * aantalNachten)
            print("U heeft gekozen voor vol pension ontbijt")
            break
        
        else:
            print("U heeft een verkeerd soort ontbijt doorgeven. Probeer nog eens.")
            etenType = pcinput.getString("Wat soort ontbijt had u graag gehad (normaal/half pension/vol pension)? ")
    
    return etenType, etenKost