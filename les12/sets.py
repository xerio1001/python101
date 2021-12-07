set1 = set()
set2 = set()
set3 = set()

for x in range(1,1001):
    if(x % 3 == 0):
        set1.add(x)
    if(x % 7 == 0):
        set2.add(x)
    if(x % 11 == 0):
        set3.add(x)

print(set1)
print("\n", set2)
print("\n", set3)