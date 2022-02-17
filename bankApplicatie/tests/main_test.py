import pytest
from bankapplicatie.main import *
from bankapplicatie.possibleErrors import *


                    # V fixtures V #


# Create dummy "persoon1" model.
@pytest.fixture
def persoon1():
    """return a new 'person' model"""
    return Persoon("Van Hasselt", "Dario", "01.10.02-149.08")

# Create dummy "persoon2" model.
@pytest.fixture
def persoon2():
    """returns a new 'person' model."""
    return Persoon("Kersemans", "Wim", "01.02.03-123.04")

# Create dummy "zicht1" model.
@pytest.fixture
def zicht1(persoon1):
    """return a new 'zicht' model"""
    return Zichtrekening(500, "091-0122401-16", persoon1)


# Create dummy "spaar1" model.
@pytest.fixture
def spaar1(zicht1):
    """return a new 'spaar' model"""
    return Spaarrekening(1000, "091-0122401-16", zicht1)


# Create dummy "zicht2" model whitch is made to fail on the account number.
@pytest.fixture
def zicht2(persoon2):
    """return a new 'zicht2' model"""
    return Zichtrekening(500, "091-0122401-161", persoon2)


                    # V person Constructor V #


# Check if the program detects an error while creating a person model.
def test_invalidPersonConstructor():
    with pytest.raises(FalsePersonConstructor):
        persoon1 = Persoon(1, "Dario", "01.10.02-149.08")


# Check to see if all the values are being stored correctly into the object.
def test_ValidValuesForPersonConstructor(persoon1):
    assert persoon1.naam == "Van Hasselt" and persoon1.voornaam == "Dario" and persoon1.rijksregisternummer == "01.10.02-149.08"


                    # V zichtrekening tests V #


# Check if the application detects when the account number is invalid.
def test_verkeerdRekeningNummer(persoon1):
    with pytest.raises(RekeningNummerError):
        zicht1 = Zichtrekening(500, "191-0122401-16", persoon1)


# Check if the account you create is ceated succesfully and everything is valid.
def test_creatieZichtRekening(persoon1):    
    zicht1 = Zichtrekening(500, "091-0122401-16", persoon1)
    assert zicht1.saldo == 500 and zicht1.persoon == persoon1 and zicht1.bankrekeningNummer == "091-0122401-16"


# Check to see if the program detects an invalid account number.
def test_zichtValidAccountDetail(persoon1):
    with pytest.raises(RekeningNummerError):
        Zichtrekening(500, "091-0122401-161", persoon1)

    
# Check to see if the function "storten" works like it should. So, it should add the amount of money - "bedrag" - to the already possesed amount of money.
def test_storten(zicht1):
    zicht1.storten(500)
    assert zicht1.saldo == 1000


# Check to see if your "bedrag" does not go below the already possesed amount of money.
def test_afhalen(zicht1):
    zicht1.afhalen(100)
    assert zicht1.saldo == 400


# Check to see if you do not cross your current currency while making a withdrawl.
def test_zichtInsufficientAmountBywithdraw(zicht1):
    with pytest.raises(InsufficientAmount):
        zicht1.afhalen(501)


                    # V spaarrekening tests V #


# Check to see if the program detects an invalid account number.
def test_spaarValidAccountDetail(zicht1):
    with pytest.raises(RekeningNummerError):
        Spaarrekening(1000, "091-0122401-161", zicht1)


# Check if the account you create is ceated succesfully and everything is valid.
def test_creatieSpaarRekening(zicht1):    
    spaar1 = Spaarrekening(1000, "091-0122401-16", zicht1)
    assert spaar1.saldo == 1000 and spaar1.bankrekeningNummer == "091-0122401-16" and spaar1.zicht == zicht1


# Check to see if you can transfer money to your other account through the function "storten (on main page)".
def test_zichtSufficientAmountByTransfer(zicht1, spaar1):
    zicht1.overschrijven(200, spaar1)
    assert zicht1.saldo == 300 and spaar1.saldo == 1200


# Chech to see if you have enoug currency on your 'spaar' account for a money transfer.
def test_spaarInsufficientAmountByTransfer(spaar1):
    with pytest.raises(InsufficientAmount):
        spaar1.overschrijven(9000000, zicht1)


# Check to see if you're tranferring money to the correct person.
def test_isNotValidPersonforTransfer(spaar1, zicht2):
    with pytest.raises(WrongPerson):
        spaar1.overschrijven(100, zicht2)
