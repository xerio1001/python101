from flask import Flask, jsonify

app = Flask(__name__)

students = [
    {
        "id": 0,
        "Name": "Dario V.H.",
        "Age": 20,
        "Gender": "Male",
        "Phone": "0123456789",
        "CourseID": 1
    },
    {
        "id": 1,
        "Name": "Jens C.",
        "Age": 32,
        "Gender": "Male",
        "Phone": "9876543210",
        "CourseID": 0
    },
    {
        "id": 2,
        "Name": "Glenn S.",
        "Age": 20,
        "Gender": "Male",
        "Phone": "1472583690",
        "CourseID": 0
    }
]

classes = [
    {
        "id": 0,
        "Name": "Python"
    },
    {
        "id": 1,
        "Name": "C# / .NET"
    },
    {
        "id": 2,
        "Name": "Frameworks"
    },
    {
        "id": 3,
        "Name": "HTML5"
    },
    {
        "id": 4,
        "Name": "PHP"
    },
    {
        "id": 5,
        "Name": "CSS"
    }
]

courses = [
    {
        "id": 0,
        "Name": "Junior Python Developer",
        "ClassesID": [0, 1, 2]
    },
    {
        "id": 1,
        "Name": "Full-Stack Webdeveloper",
        "ClassesID": [3, 4, 5]
    }
]

@app.route('/')
def homeScreen():
    return \
        """
        <center>
            <h1>Welcome to 'CVO De Verdieping'</h1>
            <a href='/courses'>Courses</a>
            <br>
            <a href='/classes'>Classes</a>
            <br>
            <a href='/students'>Students</a>
        </center>
        """

################## Courses ##################

@app.route('/courses')
def showCourses():
    return jsonify(courses)

@app.route('/courses/<int:id>', methods=['GET'])
def getCourses(id):
    return jsonify(courses[id])

@app.route('/courses/<int:id>/students', methods=['GET'])
def getCoursesWithStudents(id):
    resultList = []
    for student in students:
        if student["CourseID"] == id:
            resultList.append(student)
    return jsonify(resultList)

@app.route('/courses/<int:id>/classes', methods=['GET'])
def getCoursesWithClasses(id):
    resultList = []
    for course in courses:
        if course["ClassesID"] == id:
            classID = course["ClassesID"]
            for i in classID:
                resultList.append(classes[i])

################## Classes ##################

@app.route('/classes')
def showClasses():
    return jsonify(classes)

@app.route('/classes/<int:id>', methods=['GET'])
def getClasses(id):
    return jsonify(classes[id])

################## students ##################

@app.route('/students')
def showStudents():
    return jsonify(students)

@app.route('/students/<int:id>', methods=['GET'])
def getStudents(id):
    return jsonify(students[id])

################## Run The App ##################

if __name__ == "__main__":
    app.run(debug=True, port=8080)
