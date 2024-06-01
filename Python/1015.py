p1 = input().split()
x1, y1 = p1
p2 = input().split()
x2, y2 = p2

d = ((float(x1) - float(x2))**2 + (float(y2) - float(y1))**2)**(0.5)
print('{:.4f}'.format(d))
