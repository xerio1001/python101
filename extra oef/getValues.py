students = [
        {'student_id': 1, 'name': 'Jean Castro', 'class': 'V'}, 
        {'student_id': 2, 'name': 'Lula Powell', 'class': 'V'},
        {'student_id': 3, 'name': 'Brian Howell', 'class': 'VI'}, 
        {'student_id': 4, 'name': 'Lynne Foster', 'class': 'VI'}, 
        {'student_id': 5, 'name': 'Zachary Simon', 'class': 'VII'}
        ]

list1 = []
list2 = []
list3 = []
    
def getValues(students):
    for item in students:
        stud_id = item["student_id"]
        stud_name = item["name"]
        stud_class = item["class"]

        list1.append([stud_id, stud_name,stud_class])
        list2.append([stud_id, stud_name])
        list3.append([stud_name,stud_class])

getValues(students)

print(list1)
# dit zou het volgende moeten printen: [[1, 'Jean Castro', 'V'], [2, 'Lula Powell', 'V'], [3, 'Brian Howell', 'VI'], [4, 'Lynne Foster', 'VI'], [5, 'Zachary Simon', 'VII']]

print(list2)
# dit zou het volgende moeten printen: [[1, 'Jean Castro'], [2, 'Lula Powell'], [3, 'Brian Howell'], [4, 'Lynne Foster'], [5, 'Zachary Simon']]

print(list3)
# dit zou het volgende moeten printen [['Jean Castro', 'V'], ['Lula Powell', 'V'], ['Brian Howell', 'VI'], ['Lynne Foster', 'VI'], ['Zachary Simon', 'VII']]

