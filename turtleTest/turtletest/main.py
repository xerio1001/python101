import turtle

s = turtle.getscreen()
t = turtle.Turtle()
t.width(3)
t.speed("fastest")

colors = ["red", "green", "blue"]

for i in range(100000):
    for j in range(3):
        t.color(colors[j])
        t.forward(1.1 * i)
        t.right(70)
