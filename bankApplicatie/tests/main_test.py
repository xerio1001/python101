from bankapplicatie import *


class InsufficientAmount(Exception):
    pass


def test_storten():
    pass


def test_overzicht():
    pass


def test_afhalen():
    pass


def test_overschrijven():
    pass


def test_saldo_boven_nul(saldo):
    if saldo < 0:
        raise InsufficientAmount(
            f"Het bedrag dat u probeert te gebruiken is hoger dan wat er beschikbaar is. {saldo}"
        )
