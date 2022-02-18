from shootergamedario.createPossibleErrors import *

class Movement:
    def __init__(self):
        pass

    def movement(self):
        pass

    def turn(self):
        pass


class Stats:
    def __init__(self, width, height):
        # Size construct of an object.
        if self.isValidSize(width, height):
            self.width = width
            self.height = height
        else:
            raise InvalidObjectSize(f"The sizes can't be 0 or smaller.")
        # End of size constructor

    def health(self):
        pass

    def damageable(self):
        pass

    def firePower(self):
        pass

    def position(self):
        pass

    def direction(self):
        pass

    def isValidSize(self, width, height):
        if width <= 0 or height <= 0:
            return False
        else:
            return True


class Actions:
    def __init__(self):
        pass

    def shoot(self):
        pass


class Map:
    def __init__(self, width, height):
        if self.isValidMapSize(width, height):
            self.width = width
            self.height = height
            self.size = self.width * self.height
        else:
            raise InvalidMapSize(f"The size of the map has to be bigger than {width * height}")

    def isValidMapSize(self, width, height):
        size = width * height
        if size < 20:
            return False
        else:
            return True


class Player(Movement, Stats, Actions):
    def __init__(self, shoot, damageTaken, movement, turn, position, direction, firepower, currentHealth, armour):
        pass

    def armour(self):
        pass


class Enemy(Movement, Stats, Actions):
    def __init__(self, shoot, damageTaken, movement, turn, position, direction, firepower, currentHealth):
        pass


class Bullet(Stats):
    def __init__(self, position, direction, currentFirepower):
        pass


class Rocks(Stats):
    def __init__(self, position, size):
        pass


class Crates(Stats):
    def __init__(self, damageTaken, position, size, beginningHealth):
        pass


class Buildings(Stats):
    def __init__(self, damageTaken, position, size, beginningHealth):
        pass