import pytest
from shootergamedario.createPossibleErrors import *
from shootergamedario.main import *


# Create a dummy model size of an object.
@pytest.fixture
def objectSize1():
    """Creates a dummy model 'size" of an object."""
    return Stats(1, 5)


# Create a dummy model of the size of a map.
@pytest.fixture
def mapSize1():
    """Creates a dummy model 'size' of a map."""
    return Map(5, 5)


# Check if the program detect when an object has a size value below or equal to 0.
@pytest.mark.parametrize(("width", "height"),[
    (0, 5),
    (5, 0),
    (-2, 3),
    (3, -2)
])
def test_invalidSizeConstructorObject(width, height):
    with pytest.raises(InvalidObjectSize):
        Stats(width, height)


# Check to see if you can create the size of an object with the right values.
def test_validSizeConstructorObject(objectSize1):
    assert objectSize1.width == 1 and objectSize1.height == 5


# Check to see if the program detects if the size of the map is smaller than 20.
@pytest.mark.parametrize(("width", "height"),[
    (5, 3),
    (5, 0),
    (1, 1),
    (4, 3)
])
def test_InvalidSizeConstructorMap(width, height):
    with pytest.raises(InvalidMapSize):
        Map(width, height)


# Check to see if you can create a map size with the right values.
def test_validSizeConstructorMap(mapSize1):
    assert mapSize1.width == 5 and mapSize1.height == 5 and mapSize1.size == 25
 