from socket import getnameinfo
from flask import Flask

# we maken een object met de naam app van de Flask module
app = Flask(__name__)

@app.route('/') # dit leidt onze webpagina naar de juiste functie
def home():
    return \
        """
        Welkom! 
        </br>
        <a href='/data'>Naar data</a>
        """

@app.route('/data')
def data():
    return \
    """
    <table align='center'>
        <tr>
            <td>Voornaam</td>
            <td><input type='text' placeholder='Dario'></td>
        </tr>
        <tr>
            <td>Naam:</td>
            <td><input type='text' placeholder='Van Hasselt'></td>
        </tr>
        <tr>
            <td>ouderdom:</td>
            <td><input type='number' placeholder='20'></td>
        </tr>
        </tr>
        <tr>
            <td>Woonplaats:</td>
            <td><input type='text' placeholder='Mol'></td>
        </tr>
        <tr>
            <td></td>
            <td><a href='/'>Naar home</a></td>
        </tr>
    </table>
    """


@app.route('/hobbies')
def hobbies():
    return \
     """
     Actieve hobbies zijn: gitaar/gamen 
     </br> 
     <a href='http://127.0.0.1:8080'>Terug naar home</a>
     """

if __name__ == "__main__":
    app.run(debug=True, port=8080)
