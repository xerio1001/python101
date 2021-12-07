import readinput

list = readinput.readlines()

aantal = 0

for index in range(0,len(list)-3):
    get1 = list[index]
    get2 = list[index +1]
    get3 = list[index +2]
    get4 = list[index +3]
    if(int(get1) + int(get2) + int(get3) < int(get2) + int(get3) + int(get4)):
        aantal = aantal + 1
    
print(aantal)