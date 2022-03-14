from flask import Flask, jsonify, request

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

lessons = {
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
        "lessonsID": [0, 1, 2]
    },
    1: {
        "Name": "Ful-Stack Webdeveloper",
        "lessonsID": [3, 4, 5]
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
            <a href='/lessons'>lessons</a>
            <br>
            <a href='/students'>Students</a>
        </center>
        """

################## Courses ##################

@app.route('/courses')
def showCourses():
    tempList = []
    limit = request.args.get('limit')
    if limit != None:
        limit = int(limit)
        for i in range(limit):
            tempList.append(courses[i])
        return jsonify(tempList)
    else:
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

@app.route('/courses/<int:id>/lessons', methods=['GET'])
def getCoursesWithlessons(id):
    resultList = []
    for item in courses[id]["lessonsID"]:
        resultList.append(lessons[item])
    return jsonify(resultList)

@app.route('/courses/<int:id>', methods=['DELETE'])
def deleteCourseById(id):
    course = courses.pop(id)
    return jsonify(course)

@app.route('/courses', methods=['POST'])
def createCourse():
    newID = max(courses) + 1
    course = request.get_json()
    courses[newID] = course
    return jsonify(newID)
    
@app.route('/courses/<int:id>', methods=['PUT'])
def updateCourse(id):
    course = request.get_json()
    courses[id] = course
    return jsonify(courses[id])

################## lessons ##################

@app.route('/lessons')
def showlessons():
    return jsonify(lessons)

@app.route('/lessons/<int:id>', methods=['GET'])
def getlessons(id):
    return jsonify(lessons[id])

@app.route('/lessons/<int:id>/students', methods=['GET'])
def getlessonsWithStudents(id):
    resultlist = []
    for courseID in courses:
        if id in courses[courseID]["lessonsID"]:
            for studentID in students:
                if(students[studentID]["CourseID"] == courseID):
                    resultlist.append(students[studentID])
    return jsonify(resultlist)

@app.route('/lessons/<int:id>/courses', methods=['GET'])
def getlessonsWithCourses(id):
    resultlist = []
    for courseID in courses:
        if id in courses[courseID]["lessonsID"]:
            resultlist.append(courses[courseID])
    return jsonify(resultlist)

@app.route('/lessons/<int:id>', methods=['DELETE'])
def deleteLessonById(id):
    lesson = lessons.pop(id)
    return jsonify(lesson)

@app.route('/lessons', methods=['POST'])
def createlessons():
    newID = max(lessons) + 1
    lesson = request.get_json()
    lessons[newID] = lesson
    return jsonify(newID)
    
@app.route('/lessons/<int:id>', methods=['PUT'])
def updatelessons(id):
    lesson = request.get_json()
    lessons[id] = lesson
    return jsonify(lessons[id])

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
        namelessons = lessons[resultID]["Name"]
        maxResult = lessons[resultID]["Max"]
        score = results[resultID]
        resultList.append(f'Score for: {namelessons} = {score}/{maxResult}')
    return jsonify(resultList)

@app.route('/students/<int:id>', methods=['DELETE'])
def deleteStudentById(id):
    student = students.pop(id)
    return jsonify(student)

@app.route('/students', methods=['POST'])
def createStudents():
    newID = max(students) + 1
    student = request.get_json()
    students[newID] = student
    return jsonify(newID)
    
@app.route('/students/<int:id>', methods=['PUT'])
def updateStudent(id):
    student = request.get_json()
    students[id] = student
    return jsonify(student[id])

################## Run The App ##################

if __name__ == "__main__":
    app.run(debug=True, port=8080)
