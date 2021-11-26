def getNachten (aantalNachten):
    hoeveelheidNachten = 0
    if(aantalNachten <= 7):
        hoeveelheidNachten = aantalNachten

    elif(aantalNachten > 7 and aantalNachten < 12):
        hoeveelheidNachten = aantalNachten - 1

    elif(aantalNachten < 12):
        hoeveelheidNachten = aantalNachten - 2


    return hoeveelheidNachten