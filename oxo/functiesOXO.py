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




def winnaar(bord, playerTurn):
    if(bord[0][0] == bord[0][1] == bord[0][2] and bord[0][0] != "-"):
        print("speler", playerTurn, "heeft gewonnen!")
        exit()
    elif(bord[1][0] == bord[1][1] == bord[1][2] and bord[1][0] != "-"):
        print("speler", playerTurn, "heeft gewonnen!")
        exit()
    elif(bord[2][0] == bord[2][1] == bord[2][2] and bord[2][0] != "-"):
        print("speler", playerTurn, "heeft gewonnen!")
        exit()
    elif(bord[0][0] == bord[1][0] == bord[2][0] and bord[0][0] != "-"):
        print("speler", playerTurn, "heeft gewonnen!")
        exit()
    elif(bord[0][1] == bord[1][1] == bord[2][1] and bord[0][1] != "-"):
        print("speler", playerTurn, "heeft gewonnen!")
        exit()
    elif(bord[0][2] == bord[1][2] == bord[2][2] and bord[0][2] != "-"):
        print("speler", playerTurn, "heeft gewonnen!")
        exit()
    elif(bord[0][0] == bord[1][1] == bord[2][2] and bord[0][0] != "-"):
        print("speler", playerTurn, "heeft gewonnen!")
        exit()
    elif(bord[2][0] == bord[1][1] == bord[0][2] and bord[2][0] != "-"):
        print("speler", playerTurn, "heeft gewonnen!")
        exit()




def GetSpace(bord, waardeRij, waardeKolom):
    check = True
    if(bord[waardeRij][waardeKolom] != "-"):
        check = False
    else:
        check = True

    return check




def getDraw(bord, player):
    getPlayerTurn = "O"
    for row in range(3):
        for col in range(3):
            if(bord[row][col] == "-"):
                if(player == "X"):
                    getPlayerTurn = "O"
                else:
                    getPlayerTurn = "X"
                return getPlayerTurn.upper()
            else:
                print("Gelijkspel!")
                exit()