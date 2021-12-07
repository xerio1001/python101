def readlines():

    file1 = open('test.txt', 'r')
    Lines = file1.readlines()
    
    listLine = []
    i = 0
    # Strips the newline character
    for line in Lines:
        i += 1
        listLine.append(line.strip())
    return listLine