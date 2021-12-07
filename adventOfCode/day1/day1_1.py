import readinput

list = readinput.readlines()


aantal = 0
for index in range(0,len(list)-1):

    if int(list[index]) < int(list[index +1]):
        aantal = aantal + 1
    
print(aantal)