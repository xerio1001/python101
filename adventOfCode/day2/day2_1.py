import readInput

list = readInput.readlines()

countForward = 0
countHeight = 0

for item in list:

    [command, value] = item.split()

    if(command == 'forward'):
        countForward = countForward + int(value)
    if(command == 'down'):
        countHeight = countHeight + int(value)
    if(command == 'up'):
         countHeight = countHeight - int(value)


completeTotal = countForward * countHeight
print("\n", completeTotal)