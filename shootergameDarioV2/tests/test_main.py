import pytest
from shootergamedariov2.main import *
from shootergamedariov2.createPossibleErrors import *


# Create a player model.
@pytest.fixture
def playerModel1():
    """Creates a 'player' model dummy"""
    # Required stats:
    # shoot:bool, damagTaken:int, movement:str, turn:str, position:tuple, direction:str, firepower:int, beginningHealth:int, currentHealth:int, armour:int
    return Player(False, 0, 'front', "none", (1, 5), "voor", 5, 20, 20, 10)


# Create an enemy model.
@pytest.fixture
def enemyModel1():
    """Creates a 'enemy' model dummy"""
    # Required stats:
    # shoot:bool, damagTaken:int, movement:str, turn:str, position:tuple, direction:str, firepower:int, beginningHealth:int, currentHealth:int
    return Enemy(False, 2, 'front', "none", (10, 5), "voor", 5, 20, 18)