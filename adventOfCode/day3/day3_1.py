def readlines():

    file1 = open('test.txt', 'r')
    Lines = file1.readlines()
    
    listLine = []
    count = 0
    # Strips the newline character
    for line in Lines:
        count += 1
        listLine.append(line.strip())
    return listLine

list = readlines()

countlist = []

for item in list:
    for pos in range(0,len(list) -1):
        print(item[pos])