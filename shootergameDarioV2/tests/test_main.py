import pytest
from shootergamedariov2.main import *
from shootergamedariov2.createPossibleErrors import *


@pytest.fixture
def playerModel1():
    """Creates a 'player' model dummy"""
    # Required stats:
    # shoot:bool, damagTaken:int, movement:str, turn:str, position:tuple, direction:str, firepower:int, beginningHealth:int, currentHealth:int, armour:int
    return Player(False, 0, 'front', "none", (1, 5), "voor", 5, 20, 20, 10)


@pytest.fixture
def enemyModel1():
    """Creates a 'enemy' model dummy"""
    # Required stats:
    # shoot:bool, damagTaken:int, movement:str, turn:str, position:tuple, direction:str, firepower:int, beginningHealth:int, currentHealth:int
    return Enemy(False, 2, 'front', "none", (10, 5), "voor", 5, 20, 18)


@pytest.fixture
def mapSize1Of100():
    """Creates a 'map size' model."""
    return Map(10, 10)


@pytest.fixture
def mapSize1():
    """Create a dummy model for map size."""
    # Required stats:
    # width, height
    return Map(10, 10)


@pytest.mark.parametrize(("width", "height"),[
    ("ten", 10),
    (10, "ten"),
    ("10", 10),
    (10, "10")
])
def test_validValueTypesOfMapSize(width, height):
    with pytest.raises(TypeError):
        Map(width, height)


@pytest.mark.parametrize(("width", "height"),[
    (9, 2),
    (1, 1)
])
def test_invalidValuesOfMapSize(width, height):
    with pytest.raises(InvalidMapSize):
        Map(width, height)


def test_validMapSize(mapSize1Of100):
    assert mapSize1Of100.width == 10 and mapSize1Of100.height == 10 and mapSize1Of100.size == 100
