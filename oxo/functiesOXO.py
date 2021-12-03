import pcinput

def toon_bord(bord):
    print(" A B C")
    for rij in range(3):
        print(rij + 1, end=' ')
        for kol in range(3):
            print(bord[rij][kol], end=' ')
        print()



def getRijKolom():
    getWaardeR = 0
    getWaardeKol = 0
    while True:
        getWaardeR = pcinput.getInteger("Geef de plek van uw rij: ")
        getWaardeKol = pcinput.getInteger("Geef de plek van uw kolom: ")
        if((getWaardeR <= 3) and (getWaardeKol <= 3)):
            break
        else:
            print("U heeft een te hoge waarde ingevoerd. probeer nog eens")
    
    return getWaardeR, getWaardeKol



def GetSpace(bord, waardeRij, waardeKolom):
    check = True
    if(bord[waardeRij][waardeKolom] != "-"):
        check = False
    else:
        check = True
        
    return check