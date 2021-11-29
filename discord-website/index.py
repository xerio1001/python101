from flask import Flask, render_template

app = Flask(__name__)

@app.route("/")
@app.route("/home")
def home():
    return render_template("index.html")

@app.route("/register")
def register():
    return render_template("register.html")

@app.route("/logged_in")
def logged_in():
    return render_template("logged_in.html")

if __name__ == "__main__":
    app.run(debug=True)