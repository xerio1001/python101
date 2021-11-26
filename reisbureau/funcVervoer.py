import pcinput

def getControleVervoer (totaalPersonen):
    voertuigType = pcinput.getString("Wat vervoer wilt u gebruiken (vliegtuig/autocar/ander)?: ")
    voertuigKost = 0
    while voertuigType != "vliegtuig" or "autocar" or "ander":
        if(voertuigType == "vliegtuig"):
            voertuigKost = ((200 * totaalPersonen) * 2)
            print("U heeft gekozen voor vliegtuig")
            break

        elif(voertuigType == "autocar"):
            voertuigKost = ((50 * totaalPersonen) * 2)
            print("U heeft gekozen voor autocar")
            break

        elif(voertuigType == "ander"):
            voertuigKost = 0
            print("U heeft ander gekozen")
            break

        else:
            ("U heeft een verkeerd vervoersmiddel gekozen. Probeer nog eens")
            voertuigType = pcinput.getString("Wat vervoer wilt u gebruiken (vliegtuig/autocar/ander)?: ")

    return voertuigType, voertuigKost 