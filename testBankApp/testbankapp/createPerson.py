from testbankapp.errorList import *

class Person:
    def __init__(self, firstName, lastName, socialSecurityNumber):
        if type(firstName) is not str:
            raise invalidPersonConstructor("Fisrstname is not a string.")
        if type(lastName) is not str:
            raise invalidPersonConstructor("Lastname is not a string.")
        if type(socialSecurityNumber) is not str:
            raise invalidPersonConstructor("social securityNumber is not a string.")
        
        self.firstName = firstName
        self.lastName = lastName
        self.socialSecurityNumber = socialSecurityNumber