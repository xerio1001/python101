from pcinput import getInteger
totaal = 0
num = getInteger("Geef een nummer (0 is om te stoppen): ")
aantal = 0

while num != 0:
    totaal += num
    aantal += 1
    num = getInteger("Geef een nummer (0 is om te stoppen): ")
    
print("Totaal is", totaal / aantal)