import pytest
from testbankapp.errorList import *
from testbankapp.createPerson import *

@pytest.fixture
def person1():
    """Makes a dummy 'person' model."""
    person1 = Person("Dario", "Van Hasselt", "01.10.02-149.08")
    return person1


def test_invalidPersonConstrocuter(person1):
    with pytest.raises(invalidPersonConstructor):
        person1 = Person(1, "Van Hasselt", "01.10.02-149.08")