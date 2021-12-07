set1 = set()

for x in range(1,1001):
    if(x % 3 == 0 and x % 7 == 0 and x % 11 == 0):
        set1.add(x)
        
print(set1)