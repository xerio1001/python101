# test_capitalize.py

import pytest
from pytest_project.capitalize import *


def test_capital_case():
    assert capital_case("semaphore") == "Semaphore"


def test_raises_exception_on_non_string_arguments():
    with pytest.raises(TypeError):
        capital_case(9)
