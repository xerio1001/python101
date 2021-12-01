import pcinput

fullNum = pcinput.getString("Geef uw nummer: ")

fullNumInt = str(fullNum.replace(".","").replace("BE","").replace(" ",""))
strippedFullNumInt = fullNumInt[1:8]
strippedFullNumInt = int(strippedFullNumInt)

lastTwoNum = fullNumInt[8:10]
lastTwoNum = int(lastTwoNum)
print(lastTwoNum)

controlenummer = 97 - (strippedFullNumInt % 97)
if(controlenummer == lastTwoNum):
    print(fullNum)
else:
    print("Ongeldig nummer")