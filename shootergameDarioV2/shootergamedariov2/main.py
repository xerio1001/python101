from shootergamedariov2.createPossibleErrors import *


# Holds every value of player and enemy.
class StatsOfEntity:
    def __init__(self, shoot:bool, damageTaken:int, movement:str, turn:str, x, y, direction:str, firepower:int, currentHealth:int):
        self.shoot = shoot
        self.damageTaken = damageTaken
        self.movement = movement
        self.x = x
        self.y = y
        self.turn = turn
        self.direction = direction
        self.firepower = firepower
        self.currentHealth = currentHealth
    
    def calcDamageTaken(self):
        self.currentHealth -= self.damageTaken

    def calcMovement(self):
        if self.movement == "front":
            self.x += 1
        if self.movement == "back":
            self.x -= 1
        if self.movement == "up":
            self.y += 1
        if self.movement == "down":
            self.y -= 1

    def checkDirection(self):
        if self.turn == "right":
            self.direction += 45
        elif self.turn == "left":
            self.direction -= 45

        if self.direction < -135:
            self.direction == 180
        elif self.direction > 180:
            self.direction == -135

    def shootBullet(self):
        if self.shoot == True:
            pass



# Holds every value of an object like rocks, etc.
class StatsOfStaticObject:
    def __init__(self, x, y, width:int, height:int, damageTaken:int, currentHealth:int):
        self.x = x
        self.y = y
        self.width = width
        self.height = height
        self.damageTaken = damageTaken
        self.currentHealth = currentHealth


# Creates a class for a bullet.
class bullet:
    def __init__(self, x, y, direction:str, firepowerOfEntity:int):
        self.x = x
        self.y = y
        self.direction = direction
        self.firepowerOfEntity = firepowerOfEntity


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
    def __init__(self, shoot:bool, damageTaken:int, movement:str, turn:str, x, y, direction:str, firepower:int, armour:int):
        self.shoot = shoot
        self.damageTaken = damageTaken
        self.movement = movement
        self.turn = turn
        self.x = x
        self.y = y
        self.direction = direction
        self.firepower = firepower
        self.armour = armour


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
