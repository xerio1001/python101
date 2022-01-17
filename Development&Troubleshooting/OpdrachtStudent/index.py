import datetime
current_date = datetime.datetime.now()

class Student:
    def __init__(self, voornaam, achternaam, adminNummer, gebDatum: tuple = (0,0,0)):
        self.voornaam = voornaam
        self.achternaam = achternaam
        self.adminNummer = adminNummer

        self.gebDatum = gebDatum
        self.leeftijd = self.geboortedatum()
        

    def geboortedatum(self):
        self.dag = self.gebDatum[0]
        self.maand = self.gebDatum[1]
        self.jaar = self.gebDatum[2]

        return current_date.year - self.jaar - ((current_date.month, current_date.day) < (self.maand, self.dag))

    def __repr__(self):
        return f'{self.voornaam} {self.achternaam} {self.adminNummer} {self.leeftijd}'



class Cursus:
    def __init__(self, cursusNaam, cursusNummer):
        self.cursusNaam = cursusNaam
        self.cursusNummer = cursusNummer
        self.students = []

    def addStundent(self, *args):
        self.students.append(args)

    def __repr__(self):
        return f'Cursus: {self.cursusNaam} {self.cursusNummer}, Student:{self.students}'


student1 = Student("Dario", "Van Hasselt", 69, (2, 10 ,2001))
student2 = Student("Bert", "Vriens", 68, (15, 1 ,1977))
student3 = Student("Jens", "Coomans", 67, (19, 1 ,1990))

cursus1 = Cursus("Python", 420)
cursus2 = Cursus("Dev & TroubleShooting", 21)
cursus3 = Cursus(".NET/C#", 1)
cursus4 = Cursus("UI & Publication", 2)

cursus1.addStundent(student1, student2)
cursus2.addStundent(student1, student3)
cursus3.addStundent(student2, student3)
cursus4.addStundent(student1, student2, student3)

print(cursus1)
print()
print(cursus2)
print()
print(cursus3)
print()
print(cursus4)
print()