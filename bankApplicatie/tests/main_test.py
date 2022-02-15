import pytest
from bankapplicatie.main import *

def test_wrongRekeningNummer():
    with pytest.raises(RekeningNummerError):
        persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
        zicht = Zichtrekening(500, "091-0122401-16", persoon1)


def test_creatieZichtrekening():
    persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
    zicht = Zichtrekening(500, "091-0122401-16", persoon1)

    assert zicht.saldo == 500 and zicht.persoon == persoon1 and zicht.bankrekeningNummer == "091-0122401-16"


def test_storten():
    persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
    zicht = Zichtrekening(500, "091-0122401-16", persoon1)

    zicht.storten(500)

    assert zicht.saldo == 1000


def test_overzicht():
    pass


def test_afhalen():
    pass


def test_overschrijven():
    pass
