from shootergamedariov2.createPossibleErrors import *


# Holds every value of player and enemy.
class StatsOfEntity:
    def __init__(self, shoot:bool, damagTaken:int, movement:str, turn:str, position:tuple, direction:str, firepower:int, beginningHealth:int, currentHealth:int):
        pass


# Holds every value of an object like rocks, etc.
class StatsOfStaticObject:
    def __init__(self, position:tuple, width:int, height:int, damageTaken:int, startingHealth:int, currentHealth:int):
        pass


# Creates a class for a bullet.
class bullet:
    pass


# Holds every value of the map.
class Map:
    def __init__(self, width:int, height:int):
        if type(width) is not int:
            raise TypeError(f"The value of 'width' is not an integer. {width}")
        if type(height) is not int:
            raise TypeError(f"The value of 'height' is not an integer. {height}")
            
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


# Creates a class for a player.
class Player(StatsOfEntity):
    pass


# Creates a class for an enemy.
class Enemy(StatsOfEntity):
    pass


# Creates a class for crates.
class Crates(StatsOfStaticObject):
    pass


# Creates a class for rocks.
class Rocks(StatsOfStaticObject):
    pass


# Creates a class for building.
class Buildings(StatsOfStaticObject):
    pass