import pytest
from bankapplicatie.main import *

# Check if the application detects when the account number is invalid.
def test_verkeerdRekeningNummer():
    with pytest.raises(RekeningNummerError):
        persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
        zicht1 = Zichtrekening(500, "191-0122401-16", persoon1)


# Check if the account you create is ceated succesfully and everything is valid.
def test_creatieZichtRekening():
    persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
    zicht1 = Zichtrekening(500, "091-0122401-16", persoon1)

    assert (zicht1.saldo == 500 and zicht1.persoon == persoon1 and zicht1.bankrekeningNummer == "091-0122401-16")


# Check to see if the function "storten" works like it should. So, it should add the amount of money - "bedrag" - to the already possesed amount of money.
def test_storten():
    persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
    zicht1 = Zichtrekening(500, "091-0122401-16", persoon1)

    zicht1.storten(500)

    assert zicht1.saldo == 1000


# Check to see if your "bedrag" does not go below the already possesed amount of money.
def test_afhalen():
    persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
    zicht1 = Zichtrekening(500, "091-0122401-16", persoon1)
    zicht1.afhalen(100)


# Check to see if you can transfer money to your other account through the function "storten".
def test_overschrijven():
    persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
    zicht1 = Zichtrekening(400, "091-0122401-16", persoon1)
    spaar1 = Spaarrekening(500, "091-0122401-16", zicht1)
    zicht1.overschrijven(200, spaar1)
