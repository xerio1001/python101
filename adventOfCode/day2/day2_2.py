import readInput

list = readInput.readlines()

countForward = 0
countHeight = 0
aim = 0

for item in list:

    [command, value] = item.split()
        
    if(command == 'forward'):
        countForward = countForward + int(value)
        countHeight = int(value) * aim + countHeight
    if(command == 'down'):
        aim = int(value) + aim
    if(command == 'up'):
        aim = aim - int(value)

completeTotal = countForward * countHeight
print("\n", completeTotal)