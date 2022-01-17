import datetime
current_date = datetime.datetime.now()

class Student:
    def __init__(self, voornaam, achternaam, adminNummer):
        self.voornaam = voornaam
        self.achternaam = achternaam
        self.adminNummer = adminNummer

    def geboortedatum(self, dag, maand, jaar):
        self.dag = dag
        self.maand = maand
        self.jaar = jaar

        leeftijd = current_date.year - jaar - ((current_date.month, current_date.day) < (maand, dag))
        
        return f'Leeftijd: {leeftijd}'

    def __repr__(self):
        return f'{self.voornaam} {self.achternaam} {self.adminNummer}'



class Cursus:
    def __init__(self, cursusNaam, cursusNummer):
        self.cursusNaam = cursusNaam
        self.cursusNummer = cursusNummer
        self.students = []

    def addStundent(self, *args):
        self.students.append(args)

    def __repr__(self):
        return f'Cursus: {self.cursusNaam} {self.cursusNummer}, Student:{self.students}'


student1 = Student("Dario", "Van Hasselt", 69)
student2 = Student("Bert", "Vriens", 68)
student3 = Student("Jens", "Coomans", 67)

cursus1 = Cursus("Python", 420)
cursus2 = Cursus("Dev & TroubleShooting", 21)
cursus3 = Cursus(".NET/C#", 1)
cursus4 = Cursus("UI & Publication", 2)

student1.geboortedatum(2, 10 ,2001)
student2.geboortedatum(15, 1 ,1977)
student2.geboortedatum(19, 1 ,1990)

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

exit()

print([student1.voornaam, student1.achternaam, student1.geboortedatum(2, 10 ,2001), "Cursist nummer", student1.adminNummer,
"Cursusnaam:", cursus1.cursusNaam, "Cursusnaam", cursus2.cursusNaam])

print()

print([student2.voornaam, student2.achternaam, student2.geboortedatum(15, 1 ,1977), "Cursist nummer", student2.adminNummer,
"Cursusnaam:", cursus1.cursusNaam, "Cursusnaam", cursus2.cursusNaam, "Cursusnaam", cursus4.cursusNaam])

print()

print([student3.voornaam, student3.achternaam, student3.geboortedatum(19, 1 ,1990), "Cursist nummer", student3.adminNummer,
"Cursusnaam:", cursus2.cursusNaam, "Cursusnaam", cursus4.cursusNaam])

print()