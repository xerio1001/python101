def readlines():

    file1 = open('input.txt', 'r')
    Lines = file1.readlines()
    
    listLine = []
    count = 0
    # Strips the newline character
    for line in Lines:
        count += 1
        listLine.append(line.strip())
    return listLine