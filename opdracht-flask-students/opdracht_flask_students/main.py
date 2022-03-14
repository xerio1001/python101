from flask import Flask, jsonify

app = Flask(__name__)

students = {
    0: {
        "Name": "Dario V.H.",
        "Age": 20,
        "Gender": "Male",
        "Phone": "0123456789",
        "CourseID": 1,
        "Result": {
            3: 90,
            4: 70,
            5: 80
        }
    },
    1: {
        "Name": "Jens C.",
        "Age": 32,
        "Gender": "Male",
        "Phone": "9876543210",
        "CourseID": 0,
        "Result": {
            0: 80,
            1: 80,
            2: 70
        }
    },
    2: {
        "Name": "Glenn S.",
        "Age": 20,
        "Gender": "Male",
        "Phone": "1472583690",
        "CourseID": 0,
        "Result": {
            0: 75,
            1: 60,
            2: 77
        }
    }
}

classes = {
    0: {
        "Name": "Python",
        "Max": 100
    },
    1: {
        "Name": "C# / .NET",
        "Max": 100
    },
    2: {
        "Name": "Frameworks",
        "Max": 100
    },
    3: {
        "Name": "HTML5",
        "Max": 100
    },
    4: {
        "Name": "PHP",
        "Max": 100
    },
    5: {
        "Name": "CSS",
        "Max": 100
    }
}

courses = {
     0: {
        "Name": "Junior Python Developer",
        "ClassesID": [0, 1, 2]
    },
    1: {
        "Name": "Full-Stack Webdeveloper",
        "ClassesID": [3, 4, 5]
    }
}

################## Main Route ##################

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
    for key in range(len(students)):
        if(students[key]["CourseID"] == id):
            resultList.append(students[key])
    return jsonify(resultList)

@app.route('/courses/<int:id>/classes', methods=['GET'])
def getCoursesWithClasses(id):
    resultList = []
    for item in courses[id]["ClassesID"]:
        resultList.append(classes[item])
    return jsonify(resultList)
    
################## Classes ##################

@app.route('/classes')
def showClasses():
    return jsonify(classes)

@app.route('/classes/<int:id>', methods=['GET'])
def getClasses(id):
    return jsonify(classes[id])

@app.route('/classes/<int:id>/students', methods=['GET'])
def getClassesWithStudents(id):
    resultlist = []
    for courseID in courses:
        if id in courses[courseID]["ClassesID"]:
            for studentID in students:
                if(students[studentID]["CourseID"] == courseID):
                    resultlist.append(students[studentID])
    return jsonify(resultlist)



@app.route('/classes/<int:id>/courses', methods=['GET'])
def getClassesWithCourses(id):
    resultlist = []
    for courseID in courses:
        if id in courses[courseID]["ClassesID"]:
            resultlist.append(courses[courseID])
    return jsonify(resultlist)

################## students ##################

@app.route('/students')
def showStudents():
    return jsonify(students)

@app.route('/students/<int:id>', methods=['GET'])
def getStudents(id):
    return jsonify(students[id])

@app.route('/students/<int:id>/results', methods=['GET'])
def getStudentsWithResults(id):
    resultList = []
    results = students[id]["Result"]
    for resultID in results:
        nameClasses = classes[resultID]["Name"]
        maxResult = classes[resultID]["Max"]
        score = results[resultID]
        resultList.append(f'Score for: {nameClasses} = {score}/{maxResult}')
    return jsonify(resultList)

################## Run The App ##################

if __name__ == "__main__":
    app.run(debug=True, port=8080)
