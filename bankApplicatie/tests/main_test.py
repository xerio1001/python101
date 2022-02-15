import pytest
from bankapplicatie.main import *

# Create dummy "persoon1" model.
@pytest.fixture
def persoon1():
    """return a new person model"""
    return Persoon("Van Hasselt", "Dario", "01.10.02-149.08")

# Check if the application detects when the account number is invalid.
def test_verkeerdRekeningNummer(persoon1):
    with pytest.raises(RekeningNummerError):
        zicht1 = Zichtrekening(500, "191-0122401-16", persoon1)


# Check if the account you create is ceated succesfully and everything is valid. (Zichtrekening)
def test_creatieZichtRekening(persoon1):    
    zicht1 = Zichtrekening(500, "091-0122401-16", persoon1)

    assert (zicht1.saldo == 500 and zicht1.persoon == persoon1 and zicht1.bankrekeningNummer == "091-0122401-16")


# Create dummy "zicht1" model.
@pytest.fixture
def zicht1(persoon1):
    """return a new 'zicht' model"""
    return Zichtrekening(500, "091-0122401-16", persoon1)


# Check if the account you create is ceated succesfully and everything is valid. (Spaarrekening)
def test_creatieSpaarRekening(zicht1):    
    spaar1 = Spaarrekening(1000, "091-0122401-16", zicht1)

    assert spaar1.saldo == 1000 and spaar1.bankrekeningNummer == "091-0122401-16" and spaar1.zicht == zicht1


# Create dummy "spaar1" model.
@pytest.fixture
def spaar1(zicht1):
    """return a new 'spaar' model"""
    return Spaarrekening(1000, "091-0122401-16", zicht1)


# Check to see if the function "storten" works like it should. So, it should add the amount of money - "bedrag" - to the already possesed amount of money.
def test_storten(zicht1):
    zicht1.storten(500)

    assert zicht1.saldo == 1000


# Check to see if your "bedrag" does not go below the already possesed amount of money.
def test_afhalen(zicht1):
    zicht1.afhalen(100)

    assert zicht1.saldo == 400


# Check to see if you can transfer money to your other account through the function "storten (on main page)".
def test_sufficientAmountBywithdraw(zicht1, spaar1):
    zicht1.overschrijven(200, spaar1)

    assert zicht1.saldo == 300 and spaar1.saldo == 1200


# Check to see if you do not cross your current currency while making a withdrawl.
def test_insufficientAmountBywithdraw(zicht1):
    with pytest.raises(InsufficientAmount):
        zicht1.afhalen(100000000)
