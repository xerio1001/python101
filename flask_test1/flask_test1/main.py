from flask import Flask, render_template

# we maken een object met de naam app van de Flask module
app = Flask(__name__)

@app.route('/') # dit leidt onze webpagina naar de juiste functie
def home():
    return render_template('index.html', titel='Home Page')

@app.route('/data')
def data():
    return render_template('data.html', titel='Data')

@app.route('/hobbies')
def hobbies():
    return render_template('hobbies.html', titel='Hobbies')

@app.route('/hobbies/gitaar')
def gitaar():
    return render_template('gitaar.html', titel='Gitaar')

@app.route('/hobbies/gamen')
def gamen():
    return render_template('gamen.html', titel='Gamen')

if __name__ == "__main__":
    app.run(debug=True, port=8080)
