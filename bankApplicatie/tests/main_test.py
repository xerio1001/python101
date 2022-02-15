import pytest
from bankapplicatie.main import *


def test_verkeerdRekeningNummer():
    with pytest.raises(RekeningNummerError):
        persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
        zicht1 = Zichtrekening(500, "191-0122401-16", persoon1)


def test_creatieZichtRekening():
    persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
    zicht1 = Zichtrekening(500, "091-0122401-16", persoon1)

    assert (
        zicht1.saldo == 500
        and zicht1.persoon == persoon1
        and zicht1.bankrekeningNummer == "091-0122401-16"
    )


def test_storten():
    persoon1 = Persoon("Van Hasselt", "Dario", "01.10.02-149.08")
    zicht1 = Zichtrekening(500, "091-0122401-16", persoon1)

    zicht1.storten(500)

    assert zicht1.saldo == 1000


def test_overzicht():
    pass


def test_afhalen():
    pass


def test_overschrijven():
    pass
