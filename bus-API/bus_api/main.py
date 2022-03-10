from flask import Flask, jsonify, request

app = Flask(__name__)

buses = [
    {
        "Number_Plate": "1-ywc-849",
        "Manufacturer": "Ford",
        "Model": "Fiesta",
        "Year": "2009",
        "Capacity": 5
    },
    {
        "Number_Plate": "2-ywc-849",
        "Manufacturer": "Ford",
        "Model": "Fiesta",
        "Year": "2010",
        "Capacity": 5     
    },
    {
        "Number_Plate": "3-ywc-849",
        "Manufacturer": "Ford",
        "Model": "Fiesta",
        "Year": "2008",
        "Capacity": 5     
    }
]

@app.route('/')
def hello():
    return {'hello':'Universe'}

@app.route('/buses')
def get_buses():
    return jsonify(buses)

@app.route('/buses/<int:id>')
def get_bus(id):
    bus = buses[id]
    return jsonify(bus)

@app.route('/buses', methods=['POST'])
def add_bus():
    bus = request.get_json()
    buses.append(bus)
    return {'id': len(buses)}, 200

@app.route('/buses/<int:id>', methods=['PUT'])
def update_bus(id):
    bus_to_update = request.get_json()
    buses[id] = bus_to_update
    return jsonify(buses[id])

@app.route('/buses/<int:id>', methods=['DELETE'])
def delete_bus(id):
    deleted = buses.pop(id)
    return jsonify(deleted), 200

if __name__ == "__main__":
    app.run(debug=True, port=8080)
