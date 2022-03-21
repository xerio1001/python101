from dotenv import dotenv_values
from mysql.connector import Error, connect

config = dotenv_values(".env")

class ClassicModels:
    def __init__(self):
        self.openClassicModels()

    def openClassicModels(self):
        try:
            self.conn = connect(**config)
            if self.conn.is_connected():
                self.cursor = self.conn.cursor()
        except Error as e:
            print("Error while connecting to MySQL", e)

    def closeClassicModels(self):
        try:
            if self.conn.is_connected():
                self.cursor.close()
                self.conn.close()
        except Error as e:
            print("Error connection with MySQL", e)


class Klant(ClassicModels):
    def __init__(self, klant_nr = 0):
        super().__init__()
        self.nr = klant_nr
        self.naam = ''
        self.anaam = ''
        self.vnaam = ''
        self.tel = ''
        self.adres1 = ''
        self.adres2 = None
        self.gemeente = ''
        self.staat = None
        self.postcode = None
        self.land = ''
        self.verkopernr = None
        self.creditLimiet = None
        if self.nr > 0:
            self.getKlant(self.nr)
        super().closeClassicModels()

    def __repr__(self):
        return f'(<Klant> ' \
               f'\n\tklantnr: {self.nr}, ' \
               f'\n\tklantfirmanaam: {self.naam}, ' \
               f'\n\tklantachternaam: {self.anaam},' \
               f'\n\tklantvoornaam: {self.vnaam},' \
               f'\n\tklanttel: {self.tel}, ' \
               f'\n\tklantadres1: {self.adres1}, ' \
               f'\n\tklantadres2: {self.adres2}, ' \
               f'\n\tklantgemeente: {self.gemeente}, ' \
               f'\n\tklantstaat: {self.staat}, ' \
               f'\n\tklantpostcode: {self.postcode}, ' \
               f'\n\tklantland: {self.land}, ' \
               f'\n\tklantverkopernr: {self.verkopernr}, ' \
               f'\n\tklantcreditlimiet: {self.creditLimiet})'

    def getKlant(self,klantnr):
        super().openClassicModels()
        strSQL = "select * from customers where customerNumber = %(klantnr)s"
        self.cursor.execute(strSQL,{'klantnr':klantnr})
        self.record = self.cursor.fetchone()
        if self.cursor.rowcount > 0:
            self.matchKlantrecord(self.record)
        super().closeClassicModels()

    def matchKlantrecord(self,record):
        # print(record)
        self.nr = record[0]
        self.naam = record[1]
        self.anaam = record[2]
        self.vnaam = record[3]
        self.tel = record[4]
        self.adres1 = record[5]
        self.adres2 = record[6]
        self.gemeente = record[7]
        self.staat = record[8]
        self.postcode = record[9]
        self.land = record[10]
        self.verkopernr = record[11]
        self.creditLimiet = record[12]

    def saveKlant(self):
        super().openClassicModels()
        strSQL = "select * from customers where customerNumber = %(klantnr)s"
        self.cursor.execute(strSQL,{'klantnr':self.nr})
        self.record = self.cursor.fetchall()
        if self.cursor.rowcount <= 0:
            self.insertKlant()
        else:
            self.updateKlant()
        super().closeClassicModels()

    def updateKlant(self):
        strSQL = """
        UPDATE 
            customers 
        SET 
            customerName = %(naam)s,
            contactLastName = %(anaam)s,
            contactFirstName = %(vnaam)s,
            phone = %(tel)s,
            addressLine1 = %(adres1)s,
            addressLine2 = %(adres2)s,
            city = %(gemeente)s,
            state = %(staat)s,
            postalCode = %(postcode)s,
            country = %(land)s,
            salesRepEmployeeNumber = %(verkopernr)s,
            creditLimit = %(creditLimiet)s
        WHERE 
            customerNumber = %(nr)s
        """

        self.cursor.execute(strSQL, {
            "nr": self.nr,
            "naam": self.naam, 
            "anaam": self.anaam,
            "vnaam": self.vnaam,
            "tel": self.tel,
            "adres1": self.adres1,
            "adres2": self.adres2,
            "gemeente": self.gemeente,
            "staat": self.staat,
            "postcode": self.postcode,
            "land": self.land,
            "verkopernr": self.verkopernr,
            "creditLimiet": self.creditLimiet
            })
        self.conn.commit()
    
    def insertKlant(self):
        strSQL = "select max(customerNumber) from customers"
        self.cursor.execute(strSQL)
        record = self.cursor.fetchone()
        self.nr = record[0] + 1

        strSQL = """
        INSERT INTO
            customers (
                customerNumber,
                customerName,
                contactLastName,
                contactFirstName,
                phone,
                addressLine1,
                addressLine2,
                city,
                state,
                postalCode,
                country,
                salesRepEmployeeNumber,
                creditLimit
                )
        VALUES (
            %(nr)s,
            %(naam)s,
            %(anaam)s,
            %(vnaam)s,
            %(tel)s,
            %(adres1)s,
            %(adres2)s,
            %(gemeente)s,
            %(staat)s,
            %(postcode)s,
            %(land)s,
            %(verkopernr)s,
            %(creditLimiet)s
            )
        """
        self.cursor.execute(strSQL, {
            "nr": self.nr,
            "naam": self.naam, 
            "anaam": self.anaam,
            "vnaam": self.vnaam,
            "tel": self.tel,
            "adres1": self.adres1,
            "adres2": self.adres2,
            "gemeente": self.gemeente,
            "staat": self.staat,
            "postcode": self.postcode,
            "land": self.land,
            "verkopernr": self.verkopernr,
            "creditLimiet": self.creditLimiet
            })
        self.conn.commit()


if __name__ == "__main__":
    """klant1 = Klant()
    klant1.getKlant(121)
    print(klant1)
    print('\tklantfirmanaam:',klant1.naam)

    klant2 = Klant(276)
    print(klant2)

    klant3 = Klant(455000)
    print(klant3)
    """

    """
    klant1 = Klant(121)
    print(klant1.naam)
    klant1.naam = "Dario"
    klant1.vnaam = "jesse"
    print(klant1.naam, klant1.vnaam)
    klant1.naam = "test"
    klant1.saveKlant()
    """

    klant1 = Klant(497)
    
    klant1.naam = "Dario's solutions"
    klant1.anaam = "Van Hasselt"
    klant1.vnaam = "Dario"
    klant1.tel = "+32476752454"
    klant1.adres1 = "75, lieven heerstraat"
    klant1.adres2 = None
    klant1.gemeente = "Mol"
    klant1.staat = "Antwerpen"
    klant1.postcode = "2400"
    klant1.land = "België"
    klant1.verkopernr = "1370"
    klant1.creditLimiet = "1000000"

    klant1.saveKlant()
