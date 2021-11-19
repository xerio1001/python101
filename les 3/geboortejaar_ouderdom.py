import pcinput

geboorte = pcinput.getInteger("Geef je geboortejaar: ")
huidig_jaar = 2020
leeftijd = 0

while geboorte <= huidig_jaar:
    print("Jaar:", geboorte)
    geboorte += 1
    print("Leeftijd", leeftijd)
    leeftijd += 1
    print("")
    
