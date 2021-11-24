aantal_ratten = 2000000
jaar = 2021

while aantal_ratten < 10000000:
    aantal_ratten += (aantal_ratten / 100 * 15)
    jaar += 1
    print(aantal_ratten)
    print(jaar)

###############################################################################

jaar = 2021

for x in range(2000000,10000000):
    x += (2000000 / 100 * 15)
    jaar += 1
    print(x)
    print(jaar)
    