from socket import getnameinfo
from flask import Flask

# we maken een object met de naam app van de Flask module
app = Flask(__name__)

@app.route('/') # dit leidt onze webpagina naar de juiste functie
def home():
    return \
        """
        <body style='background-color: #ededed'>
        <center>
        <h2>Welkom!</h2> 
        <p>
        <a href='/data' style='font-size: 14pt; text-decoration: none;'>Naar data</a> 
        </p>
        <p>
        <a href='/hobbies' style='font-size: 14pt; text-decoration: none;'>Naar hobbies</a>
        </p>
        </center>
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
     <center>
     Actieve hobbies zijn: gitaar/gamen 
     <p> 
     <a href='/'>Terug naar home</a>
     </p>
     </center>
     """

if __name__ == "__main__":
    app.run(debug=True, port=8080)
